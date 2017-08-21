namespace ECG_Compression_Evaluation
{
    partial class SignalsGraph
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.splitContainer_splitContainersHolder = new System.Windows.Forms.SplitContainer();
            this.splitContainer_chartsHolder = new System.Windows.Forms.SplitContainer();
            this.chart_originalSamples = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_reconstructedSamples = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_mixSamples = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_splitContainersHolder)).BeginInit();
            this.splitContainer_splitContainersHolder.Panel1.SuspendLayout();
            this.splitContainer_splitContainersHolder.Panel2.SuspendLayout();
            this.splitContainer_splitContainersHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_chartsHolder)).BeginInit();
            this.splitContainer_chartsHolder.Panel1.SuspendLayout();
            this.splitContainer_chartsHolder.Panel2.SuspendLayout();
            this.splitContainer_chartsHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_originalSamples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_reconstructedSamples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_mixSamples)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer_splitContainersHolder
            // 
            this.splitContainer_splitContainersHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_splitContainersHolder.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_splitContainersHolder.Name = "splitContainer_splitContainersHolder";
            this.splitContainer_splitContainersHolder.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_splitContainersHolder.Panel1
            // 
            this.splitContainer_splitContainersHolder.Panel1.Controls.Add(this.splitContainer_chartsHolder);
            // 
            // splitContainer_splitContainersHolder.Panel2
            // 
            this.splitContainer_splitContainersHolder.Panel2.Controls.Add(this.chart_mixSamples);
            this.splitContainer_splitContainersHolder.Size = new System.Drawing.Size(1034, 512);
            this.splitContainer_splitContainersHolder.SplitterDistance = 340;
            this.splitContainer_splitContainersHolder.TabIndex = 0;
            // 
            // splitContainer_chartsHolder
            // 
            this.splitContainer_chartsHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_chartsHolder.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_chartsHolder.Name = "splitContainer_chartsHolder";
            this.splitContainer_chartsHolder.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_chartsHolder.Panel1
            // 
            this.splitContainer_chartsHolder.Panel1.Controls.Add(this.chart_originalSamples);
            // 
            // splitContainer_chartsHolder.Panel2
            // 
            this.splitContainer_chartsHolder.Panel2.Controls.Add(this.chart_reconstructedSamples);
            this.splitContainer_chartsHolder.Size = new System.Drawing.Size(1034, 340);
            this.splitContainer_chartsHolder.SplitterDistance = 158;
            this.splitContainer_chartsHolder.TabIndex = 0;
            // 
            // chart_originalSamples
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_originalSamples.ChartAreas.Add(chartArea1);
            this.chart_originalSamples.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart_originalSamples.Legends.Add(legend1);
            this.chart_originalSamples.Location = new System.Drawing.Point(0, 0);
            this.chart_originalSamples.Name = "chart_originalSamples";
            this.chart_originalSamples.Size = new System.Drawing.Size(1034, 158);
            this.chart_originalSamples.TabIndex = 0;
            this.chart_originalSamples.Text = "chart1";
            // 
            // chart_reconstructedSamples
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_reconstructedSamples.ChartAreas.Add(chartArea2);
            this.chart_reconstructedSamples.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart_reconstructedSamples.Legends.Add(legend2);
            this.chart_reconstructedSamples.Location = new System.Drawing.Point(0, 0);
            this.chart_reconstructedSamples.Name = "chart_reconstructedSamples";
            this.chart_reconstructedSamples.Size = new System.Drawing.Size(1034, 178);
            this.chart_reconstructedSamples.TabIndex = 0;
            this.chart_reconstructedSamples.Text = "chart2";
            // 
            // chart_mixSamples
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_mixSamples.ChartAreas.Add(chartArea3);
            this.chart_mixSamples.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chart_mixSamples.Legends.Add(legend3);
            this.chart_mixSamples.Location = new System.Drawing.Point(0, 0);
            this.chart_mixSamples.Name = "chart_mixSamples";
            this.chart_mixSamples.Size = new System.Drawing.Size(1034, 168);
            this.chart_mixSamples.TabIndex = 0;
            this.chart_mixSamples.Text = "chart3";
            // 
            // SignalsGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(1000, 500);
            this.ClientSize = new System.Drawing.Size(1034, 512);
            this.Controls.Add(this.splitContainer_splitContainersHolder);
            this.KeyPreview = true;
            this.Name = "SignalsGraph";
            this.ShowIcon = false;
            this.Text = "SignalsGraph";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SignalsGraph_KeyPress);
            this.splitContainer_splitContainersHolder.Panel1.ResumeLayout(false);
            this.splitContainer_splitContainersHolder.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_splitContainersHolder)).EndInit();
            this.splitContainer_splitContainersHolder.ResumeLayout(false);
            this.splitContainer_chartsHolder.Panel1.ResumeLayout(false);
            this.splitContainer_chartsHolder.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_chartsHolder)).EndInit();
            this.splitContainer_chartsHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_originalSamples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_reconstructedSamples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_mixSamples)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer_splitContainersHolder;
        private System.Windows.Forms.SplitContainer splitContainer_chartsHolder;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_originalSamples;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_reconstructedSamples;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_mixSamples;
    }
}