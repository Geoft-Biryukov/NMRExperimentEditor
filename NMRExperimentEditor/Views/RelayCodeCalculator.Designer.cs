namespace NMRExperimentEditor.Views
{
    partial class RelayCodeCalculator
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
            this.relaysView1 = new NMRExperimentEditor.Views.RelaysView();
            this.SuspendLayout();
            // 
            // relaysView1
            // 
            this.relaysView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.relaysView1.Location = new System.Drawing.Point(0, 0);
            this.relaysView1.Name = "relaysView1";
            this.relaysView1.Size = new System.Drawing.Size(599, 69);
            this.relaysView1.TabIndex = 0;
            // 
            // RelayCodeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 69);
            this.Controls.Add(this.relaysView1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(615, 108);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(615, 108);
            this.Name = "RelayCodeCalculator";
            this.ShowIcon = false;
            this.Text = "Расчет кода реле";
            this.ResumeLayout(false);

        }

        #endregion

        private RelaysView relaysView1;
    }
}