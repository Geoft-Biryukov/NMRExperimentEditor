namespace NMRExperimentEditor.Views
{
    partial class FrequencyCalculatorForm
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
            this.frequencyCalculator1 = new NMRExperimentEditor.Views.FrequencyCalculator();
            this.SuspendLayout();
            // 
            // frequencyCalculator1
            // 
            this.frequencyCalculator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frequencyCalculator1.Location = new System.Drawing.Point(0, 0);
            this.frequencyCalculator1.Name = "frequencyCalculator1";
            this.frequencyCalculator1.Size = new System.Drawing.Size(376, 155);
            this.frequencyCalculator1.TabIndex = 0;
            // 
            // FrequencyCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 155);
            this.Controls.Add(this.frequencyCalculator1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 194);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(365, 194);
            this.Name = "FrequencyCalculatorForm";
            this.ShowIcon = false;
            this.Text = "Калькулятор частот";
            this.ResumeLayout(false);

        }

        #endregion

        private FrequencyCalculator frequencyCalculator1;
    }
}