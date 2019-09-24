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
            this.experimentNumber = new System.Windows.Forms.NumericUpDown();
            this.frequencyView1 = new NMRExperimentEditor.Views.FrequencyView();
            this.relaysView1 = new NMRExperimentEditor.Views.RelaysView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.silence1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.noiseLength = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.calibrationsNumber = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.silence2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.experimentNumber)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.silence1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiseLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calibrationsNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silence2)).BeginInit();
            this.SuspendLayout();
            // 
            // experimentNumber
            // 
            this.experimentNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.experimentNumber.Location = new System.Drawing.Point(3, 16);
            this.experimentNumber.Name = "experimentNumber";
            this.experimentNumber.Size = new System.Drawing.Size(145, 20);
            this.experimentNumber.TabIndex = 1;
            // 
            // frequencyView1
            // 
            this.frequencyView1.Frequency = 0D;
            this.frequencyView1.FrequencyIndex = ((uint)(0u));
            this.frequencyView1.Location = new System.Drawing.Point(3, 59);
            this.frequencyView1.Name = "frequencyView1";
            this.frequencyView1.Phase = ((byte)(0));
            this.frequencyView1.Size = new System.Drawing.Size(293, 74);
            this.frequencyView1.SynthesizerFrequency = 0D;
            this.frequencyView1.TabIndex = 2;
            // 
            // relaysView1
            // 
            this.relaysView1.Location = new System.Drawing.Point(6, 139);
            this.relaysView1.Name = "relaysView1";
            this.relaysView1.Size = new System.Drawing.Size(388, 46);
            this.relaysView1.TabIndex = 8;
            this.relaysView1.Load += new System.EventHandler(this.relaysView1_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.experimentNumber);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 50);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Номер эксперимента";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Тишина 1";
            // 
            // silence1
            // 
            this.silence1.Location = new System.Drawing.Point(274, 192);
            this.silence1.Name = "silence1";
            this.silence1.Size = new System.Drawing.Size(120, 20);
            this.silence1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Длина шума:";
            // 
            // noiseLength
            // 
            this.noiseLength.Location = new System.Drawing.Point(274, 221);
            this.noiseLength.Name = "noiseLength";
            this.noiseLength.Size = new System.Drawing.Size(120, 20);
            this.noiseLength.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Калибровочных выборок:";
            // 
            // calibrationsNumber
            // 
            this.calibrationsNumber.Location = new System.Drawing.Point(274, 256);
            this.calibrationsNumber.Name = "calibrationsNumber";
            this.calibrationsNumber.Size = new System.Drawing.Size(120, 20);
            this.calibrationsNumber.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Тишина 2:";
            // 
            // silence2
            // 
            this.silence2.Location = new System.Drawing.Point(274, 286);
            this.silence2.Name = "silence2";
            this.silence2.Size = new System.Drawing.Size(120, 20);
            this.silence2.TabIndex = 17;
            // 
            // ExperimentTableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.silence2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.calibrationsNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.noiseLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.silence1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.frequencyView1);
            this.Controls.Add(this.relaysView1);
            this.Name = "ExperimentTableView";
            this.Size = new System.Drawing.Size(668, 492);
            ((System.ComponentModel.ISupportInitialize)(this.experimentNumber)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.silence1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiseLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calibrationsNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silence2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown experimentNumber;
        private RelaysView relaysView1;
        private FrequencyView frequencyView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown silence1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown noiseLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown calibrationsNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown silence2;
    }
}
