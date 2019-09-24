namespace NMRExperimentEditor.Views
{
    partial class FrequencyView
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.frequencyIndex = new System.Windows.Forms.NumericUpDown();
            this.frequency = new System.Windows.Forms.NumericUpDown();
            this.phase = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phase)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.frequencyIndex, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.frequency, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.phase, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(360, 74);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Индекс частоты:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Частота, кГц:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Фаза:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frequencyIndex
            // 
            this.frequencyIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frequencyIndex.Hexadecimal = true;
            this.frequencyIndex.Location = new System.Drawing.Point(183, 3);
            this.frequencyIndex.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.frequencyIndex.Name = "frequencyIndex";
            this.frequencyIndex.Size = new System.Drawing.Size(174, 20);
            this.frequencyIndex.TabIndex = 3;
            // 
            // frequency
            // 
            this.frequency.DecimalPlaces = 3;
            this.frequency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frequency.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.frequency.Location = new System.Drawing.Point(183, 27);
            this.frequency.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.frequency.Name = "frequency";
            this.frequency.Size = new System.Drawing.Size(174, 20);
            this.frequency.TabIndex = 4;
            this.frequency.Value = new decimal(new int[] {
            740,
            0,
            0,
            0});
            // 
            // phase
            // 
            this.phase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phase.Location = new System.Drawing.Point(183, 51);
            this.phase.Name = "phase";
            this.phase.Size = new System.Drawing.Size(174, 20);
            this.phase.TabIndex = 5;
            // 
            // FrequencyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrequencyView";
            this.Size = new System.Drawing.Size(360, 74);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown frequencyIndex;
        private System.Windows.Forms.NumericUpDown frequency;
        private System.Windows.Forms.NumericUpDown phase;
    }
}
