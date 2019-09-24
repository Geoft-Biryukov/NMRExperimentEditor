namespace NMRExperimentEditor.Views
{
    partial class RelaysView
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
            this.relay1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.relay2 = new System.Windows.Forms.CheckBox();
            this.relay3 = new System.Windows.Forms.CheckBox();
            this.relay4 = new System.Windows.Forms.CheckBox();
            this.relay5 = new System.Windows.Forms.CheckBox();
            this.relay6 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.relayCode = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.relayCode)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.relay1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.relay2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.relay3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.relay4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.relay5, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.relay6, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.relayCode, 6, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(582, 46);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // relay1
            // 
            this.relay1.AutoSize = true;
            this.relay1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.relay1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.relay1.Location = new System.Drawing.Point(3, 26);
            this.relay1.Name = "relay1";
            this.relay1.Size = new System.Drawing.Size(66, 17);
            this.relay1.TabIndex = 0;
            this.relay1.UseVisualStyleBackColor = true;
            this.relay1.CheckedChanged += new System.EventHandler(this.RelayCheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Реле 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(75, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Реле 2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(147, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Реле 3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(219, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Реле 4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(291, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Реле 5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(363, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Реле 6";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // relay2
            // 
            this.relay2.AutoSize = true;
            this.relay2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.relay2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.relay2.Location = new System.Drawing.Point(75, 26);
            this.relay2.Name = "relay2";
            this.relay2.Size = new System.Drawing.Size(66, 17);
            this.relay2.TabIndex = 7;
            this.relay2.UseVisualStyleBackColor = true;
            this.relay2.CheckedChanged += new System.EventHandler(this.RelayCheckedChanged);
            // 
            // relay3
            // 
            this.relay3.AutoSize = true;
            this.relay3.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.relay3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.relay3.Location = new System.Drawing.Point(147, 26);
            this.relay3.Name = "relay3";
            this.relay3.Size = new System.Drawing.Size(66, 17);
            this.relay3.TabIndex = 8;
            this.relay3.UseVisualStyleBackColor = true;
            this.relay3.CheckedChanged += new System.EventHandler(this.RelayCheckedChanged);
            // 
            // relay4
            // 
            this.relay4.AutoSize = true;
            this.relay4.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.relay4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.relay4.Location = new System.Drawing.Point(219, 26);
            this.relay4.Name = "relay4";
            this.relay4.Size = new System.Drawing.Size(66, 17);
            this.relay4.TabIndex = 9;
            this.relay4.UseVisualStyleBackColor = true;
            this.relay4.CheckedChanged += new System.EventHandler(this.RelayCheckedChanged);
            // 
            // relay5
            // 
            this.relay5.AutoSize = true;
            this.relay5.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.relay5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.relay5.Location = new System.Drawing.Point(291, 26);
            this.relay5.Name = "relay5";
            this.relay5.Size = new System.Drawing.Size(66, 17);
            this.relay5.TabIndex = 10;
            this.relay5.UseVisualStyleBackColor = true;
            this.relay5.CheckedChanged += new System.EventHandler(this.RelayCheckedChanged);
            // 
            // relay6
            // 
            this.relay6.AutoSize = true;
            this.relay6.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.relay6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.relay6.Location = new System.Drawing.Point(363, 26);
            this.relay6.Name = "relay6";
            this.relay6.Size = new System.Drawing.Size(66, 17);
            this.relay6.TabIndex = 11;
            this.relay6.UseVisualStyleBackColor = true;
            this.relay6.CheckedChanged += new System.EventHandler(this.RelayCheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(435, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Код реле";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // relayCode
            // 
            this.relayCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.relayCode.Hexadecimal = true;
            this.relayCode.Location = new System.Drawing.Point(435, 26);
            this.relayCode.Maximum = new decimal(new int[] {
            63,
            0,
            0,
            0});
            this.relayCode.Name = "relayCode";
            this.relayCode.Size = new System.Drawing.Size(144, 20);
            this.relayCode.TabIndex = 13;
            this.relayCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.relayCode.ValueChanged += new System.EventHandler(this.relayCode_ValueChanged);
            // 
            // RelaysView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RelaysView";
            this.Size = new System.Drawing.Size(582, 46);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.relayCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox relay1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox relay2;
        private System.Windows.Forms.CheckBox relay3;
        private System.Windows.Forms.CheckBox relay4;
        private System.Windows.Forms.CheckBox relay5;
        private System.Windows.Forms.CheckBox relay6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown relayCode;
    }
}
