
/**
 * @author: Kamyar Nemati <kamyarnemati at gmail.com>
 */

using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ECG_Compression_Evaluation
{
    public partial class SignalsGraph : Form
    {
        List<int> originalSamples;
        List<int> reconstructedSamples;

        public SignalsGraph()
        {
            InitializeComponent();

            this.originalSamples = null;
            this.reconstructedSamples = null;
        }

        //Overloaded constructor, passing in required parameters to draw signals graph.
        public SignalsGraph(ref List<int> originalSamples, ref List<int> reconstructedSamples)
        {
            InitializeComponent();

            this.originalSamples = originalSamples;
            this.reconstructedSamples = reconstructedSamples;
            DrawOriginalSamples();
            DrawReconstructedSamples();
        }

        //Plot original signal graph.
        private void DrawOriginalSamples()
        {
            if (this.originalSamples.Count == 0)
                return;
            System.Windows.Forms.DataVisualization.Charting.Series seriesOriginal = chart_originalSamples.Series.Add("Representation of\nOriginal\nSignal");
            System.Windows.Forms.DataVisualization.Charting.Series seriesMix = chart_mixSamples.Series.Add("Representation of\nOriginal\nSignal");
            seriesOriginal.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            seriesMix.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            seriesOriginal.Color = Color.Blue;
            seriesMix.Color = Color.Blue;
            foreach (int sample in this.originalSamples)
            {
                seriesOriginal.Points.Add(sample);
                seriesMix.Points.Add(sample);
            }
        }

        //Plot reconstructed signal graph.
        private void DrawReconstructedSamples()
        {
            if (this.reconstructedSamples.Count == 0)
                return;
            System.Windows.Forms.DataVisualization.Charting.Series seriesReconstructed = chart_reconstructedSamples.Series.Add("Representation of\nReconstructed\nSignal");
            System.Windows.Forms.DataVisualization.Charting.Series seriesMix = chart_mixSamples.Series.Add("Representation of\nReconstructed\nSignal");
            seriesReconstructed.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            seriesMix.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            seriesReconstructed.Color = Color.Red;
            seriesMix.Color = Color.Red;
            foreach (int sample in this.reconstructedSamples)
            {
                seriesReconstructed.Points.Add(sample);
                seriesMix.Points.Add(sample);
            }
        }

        //Enable zoom.
        private void SignalsGraph_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '+')
                this.AutoScrollMinSize = new System.Drawing.Size(this.AutoScrollMinSize.Width + 1000, this.AutoScrollMinSize.Height + 500);
            else
                if (e.KeyChar == '-')
                this.AutoScrollMinSize = new System.Drawing.Size(this.AutoScrollMinSize.Width - 1000, this.AutoScrollMinSize.Height - 500);
            this.Refresh();
        }
    }
}
