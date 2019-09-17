namespace NMRExperimentEditor.Views
{
    partial class ExperimentTableView
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
            this.experimentNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.freqency = new System.Windows.Forms.NumericUpDown();
            this.frequencyCode = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.relaysView1 = new NMRExperimentEditor.Views.RelaysView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.experimentNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freqency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyCode)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.28496F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.71504F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 199F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.experimentNumber, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.freqency, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.frequencyCode, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.relaysView1, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(768, 134);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер эксперимента";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // experimentNumber
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.experimentNumber, 2);
            this.experimentNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.experimentNumber.Location = new System.Drawing.Point(277, 3);
            this.experimentNumber.Name = "experimentNumber";
            this.experimentNumber.Size = new System.Drawing.Size(488, 20);
            this.experimentNumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Частота, Гц";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // freqency
            // 
            this.freqency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.freqency.Location = new System.Drawing.Point(277, 27);
            this.freqency.Name = "freqency";
            this.freqency.Size = new System.Drawing.Size(288, 20);
            this.freqency.TabIndex = 3;
            // 
            // frequencyCode
            // 
            this.frequencyCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frequencyCode.Location = new System.Drawing.Point(571, 27);
            this.frequencyCode.Name = "frequencyCode";
            this.frequencyCode.Size = new System.Drawing.Size(194, 20);
            this.frequencyCode.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 54);
            this.label3.TabIndex = 5;
            this.label3.Text = "Реле";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Код реле";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // relaysView1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.relaysView1, 2);
            this.relaysView1.Location = new System.Drawing.Point(277, 51);
            this.relaysView1.Name = "relaysView1";
            this.relaysView1.Size = new System.Drawing.Size(488, 46);
            this.relaysView1.TabIndex = 8;
            // 
            // ExperimentTableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ExperimentTableView";
            this.Size = new System.Drawing.Size(768, 207);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.experimentNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freqency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown experimentNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown freqency;
        private System.Windows.Forms.NumericUpDown frequencyCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private RelaysView relaysView1;
    }
}
