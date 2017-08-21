/**
 * @author: Kamyar Nemati <kamyarnemati at gmail.com>
 */

using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Forms; //OpenFileDialog

namespace ECG_Compression_Evaluation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /* Fixed number of samples that each
         * type of ECG signal dataset contains.
         */
        private const int SHORT_SIGNAL = 3600; //Freq.: 360Hz, Length: 10sec
        private const int LONG_SIGNAL = 21600; //Freq.: 360Hz, Length: 60sec
        /* - */

        private OpenFileDialog ofd;
        private List<int> original_samples;
        private List<int> reconstructed_samples;
        private libecgclrinterface.EncodeWrapper EncoderObject;
        private libecgclrinterface.DecodeWrapper DecoderObject;

        public MainWindow()
        {
            InitializeComponent();

            this.ofd = new OpenFileDialog();
            this.original_samples = new List<int>();
            this.reconstructed_samples = new List<int>();
            this.EncoderObject = null;
            this.DecoderObject = null;
        }

        private void ButtonSelectECG_Click(object sender, RoutedEventArgs e)
        {
            int len = 0;

            //Determine what sort of signal is being chosen.
            System.Windows.MessageBoxResult answer = System.Windows.MessageBox.Show("Are you selecting a long signal?", "Signal type", 
                MessageBoxButton.YesNoCancel, MessageBoxImage.Question);

            if (answer != MessageBoxResult.Yes && answer != MessageBoxResult.No && answer != MessageBoxResult.Cancel)
                return;
            if (answer == MessageBoxResult.Cancel)
                return;
            if (answer == MessageBoxResult.No)
                len = SHORT_SIGNAL;
            if (answer == MessageBoxResult.Yes)
                len = LONG_SIGNAL;

            //Show up open file dialog.
            this.ofd.ShowDialog();
            this.textbox_ecg_file_path.Text = this.ofd.FileName;

            //Prepare ingredients.
            int dataset_length = len;
            string dataset_path = this.textbox_ecg_file_path.Text;
            int threshold = int.Parse(this.textbox_threshold.Text);
            int aperture = int.Parse(this.textbox_aperture.Text);
            bool eStat = false, dStat = false;
            float cr, prd, qs;

            //Instantiate Encode class.
            this.EncoderObject = new libecgclrinterface.EncodeWrapper(dataset_length, dataset_path, threshold, aperture, ref eStat);
            
            if (eStat) //Encode Instantiation successful.
            {
                //Get original samples.
                this.original_samples.Clear();
                this.EncoderObject._getOriginal(ref original_samples);
                this.listbox_original_samples.Items.Clear();
                for (int i = 0; i < original_samples.Count; ++i)
                    this.listbox_original_samples.Items.Add(original_samples.ElementAt(i));
                this.label3_original_samples_count.Content = string.Format("{0} samples", original_samples.Count);
                
                //Perform encode operation.
                if (this.EncoderObject._encode())
                {
                    //Get compressed data.
                    string compressed_sequence = this.EncoderObject._getBinarySequeneCompressed();
                    this.textbox_compressed_data.Text = compressed_sequence;
                    this.label8_compressed_data_count.Content = string.Format("{0} digits", compressed_sequence.Length);

                    //Get Compression Ratio.
                    cr = this.EncoderObject._getBinarySequeneCompressionRatio();
                    this.textbox_cr.Text = cr.ToString();

                    //Instantiate Decode class.
                    this.DecoderObject = new libecgclrinterface.DecodeWrapper(compressed_sequence, ref dStat);

                    if (dStat) //Decode Instantiation successful.
                    {
                        //Perform decode operation.
                        if (this.DecoderObject._decode())
                        {
                            //Get reconstructed samples.
                            this.reconstructed_samples.Clear();
                            this.DecoderObject._getReconstructed(ref reconstructed_samples);
                            this.listbox_reconstructed_samples.Items.Clear();
                            for (int i = 0; i < reconstructed_samples.Count; ++i)
                                this.listbox_reconstructed_samples.Items.Add(reconstructed_samples.ElementAt(i));
                            this.label10_reconstructed_samples_count.Content = string.Format("{0} samples", reconstructed_samples.Count);

                            //Get Persent Root-Mean-Squared Difference.
                            prd = this.DecoderObject._getPercentRootMeanSquareDifference(original_samples);
                            this.textbox_prd.Text = prd.ToString();

                            //Get Quality Score.
                            qs = cr / prd;
                            this.textbox_qs.Text = qs.ToString();

                            //Enable graph function.
                            this.button_plot_ecg.IsEnabled = true;
                        }
                    }
                }
            }
        }

        private void ButtonPlotECG_Click(object sender, RoutedEventArgs e)
        {
            //Load graph.
            SignalsGraph sg = new SignalsGraph(ref this.original_samples, ref this.reconstructed_samples);
            sg.Show();
        }
    }
}
