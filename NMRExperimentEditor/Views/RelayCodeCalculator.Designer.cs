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
            this.hexCheckBox = new System.Windows.Forms.CheckBox();
            this.relaysView1 = new NMRExperimentEditor.Views.RelaysView();
            this.SuspendLayout();
            // 
            // hexCheckBox
            // 
            this.hexCheckBox.AutoSize = true;
            this.hexCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hexCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.hexCheckBox.Location = new System.Drawing.Point(0, 69);
            this.hexCheckBox.Name = "hexCheckBox";
            this.hexCheckBox.Padding = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.hexCheckBox.Size = new System.Drawing.Size(599, 17);
            this.hexCheckBox.TabIndex = 1;
            this.hexCheckBox.Text = "hex";
            this.hexCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hexCheckBox.UseVisualStyleBackColor = true;
            this.hexCheckBox.CheckedChanged += new System.EventHandler(this.hexCheckBox_CheckedChanged);
            // 
            // relaysView1
            // 
            this.relaysView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.relaysView1.Hexadecimal = true;
            this.relaysView1.Location = new System.Drawing.Point(0, 0);
            this.relaysView1.Name = "relaysView1";
            this.relaysView1.Size = new System.Drawing.Size(599, 69);
            this.relaysView1.TabIndex = 0;
            // 
            // RelayCodeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 95);
            this.Controls.Add(this.hexCheckBox);
            this.Controls.Add(this.relaysView1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(615, 134);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(615, 134);
            this.Name = "RelayCodeCalculator";
            this.ShowIcon = false;
            this.Text = "Расчет кода реле";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RelaysView relaysView1;
        private System.Windows.Forms.CheckBox hexCheckBox;
    }
}