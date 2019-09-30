namespace NMRExperimentEditor.Views
{
    partial class FrequencyCalculator
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.synthesizerFrequency = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.frequency = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.frequencyIndex = new System.Windows.Forms.NumericUpDown();
            this.hexFrequencyIndex = new System.Windows.Forms.CheckBox();
            this.frequencyByIndex = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.synthesizerFrequency)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Частота синтезатора (Sys_clk), МГц:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // synthesizerFrequency
            // 
            this.synthesizerFrequency.DecimalPlaces = 3;
            this.synthesizerFrequency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.synthesizerFrequency.Location = new System.Drawing.Point(206, 3);
            this.synthesizerFrequency.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.synthesizerFrequency.Name = "synthesizerFrequency";
            this.synthesizerFrequency.Size = new System.Drawing.Size(151, 20);
            this.synthesizerFrequency.TabIndex = 1;
            this.synthesizerFrequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.synthesizerFrequency.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.51042F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.48958F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.synthesizerFrequency, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.frequency, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.frequencyIndex, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.hexFrequencyIndex, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.frequencyByIndex, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(360, 152);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Частота (Fout), МГц:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frequency
            // 
            this.frequency.DecimalPlaces = 3;
            this.frequency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frequency.Location = new System.Drawing.Point(206, 33);
            this.frequency.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.frequency.Name = "frequency";
            this.frequency.Size = new System.Drawing.Size(151, 20);
            this.frequency.TabIndex = 3;
            this.frequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.frequency.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Индекс частоты (Fword):";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frequencyIndex
            // 
            this.frequencyIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frequencyIndex.Location = new System.Drawing.Point(206, 63);
            this.frequencyIndex.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.frequencyIndex.Name = "frequencyIndex";
            this.frequencyIndex.Size = new System.Drawing.Size(151, 20);
            this.frequencyIndex.TabIndex = 5;
            this.frequencyIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.frequencyIndex.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // hexFrequencyIndex
            // 
            this.hexFrequencyIndex.AutoSize = true;
            this.hexFrequencyIndex.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hexFrequencyIndex.Dock = System.Windows.Forms.DockStyle.Right;
            this.hexFrequencyIndex.Location = new System.Drawing.Point(235, 93);
            this.hexFrequencyIndex.Name = "hexFrequencyIndex";
            this.hexFrequencyIndex.Size = new System.Drawing.Size(122, 24);
            this.hexFrequencyIndex.TabIndex = 6;
            this.hexFrequencyIndex.Text = "Индек частоты hex";
            this.hexFrequencyIndex.UseVisualStyleBackColor = true;
            this.hexFrequencyIndex.CheckedChanged += new System.EventHandler(this.hexFrequencyIndex_CheckedChanged);
            // 
            // frequencyByIndex
            // 
            this.frequencyByIndex.AutoSize = true;
            this.frequencyByIndex.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.frequencyByIndex.Dock = System.Windows.Forms.DockStyle.Right;
            this.frequencyByIndex.Location = new System.Drawing.Point(231, 123);
            this.frequencyByIndex.Name = "frequencyByIndex";
            this.frequencyByIndex.Size = new System.Drawing.Size(126, 26);
            this.frequencyByIndex.TabIndex = 7;
            this.frequencyByIndex.Text = "Обратный пересчет";
            this.frequencyByIndex.UseVisualStyleBackColor = true;
            this.frequencyByIndex.CheckedChanged += new System.EventHandler(this.frequencyByIndex_CheckedChanged);
            // 
            // FrequencyCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrequencyCalculator";
            this.Size = new System.Drawing.Size(360, 152);
            ((System.ComponentModel.ISupportInitialize)(this.synthesizerFrequency)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyIndex)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown synthesizerFrequency;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown frequency;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown frequencyIndex;
        private System.Windows.Forms.CheckBox hexFrequencyIndex;
        private System.Windows.Forms.CheckBox frequencyByIndex;
    }
}
