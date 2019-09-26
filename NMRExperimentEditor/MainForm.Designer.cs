namespace NMRExperimentEditor
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.experimentsListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportТаблицыЭкспериментовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.калькуляторЧастотToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.индексРелеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.removeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.upToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.downToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.experimentView = new NMRExperimentEditor.Views.ExperimentView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // experimentsListBox
            // 
            this.experimentsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.experimentsListBox.FormattingEnabled = true;
            this.experimentsListBox.Location = new System.Drawing.Point(0, 0);
            this.experimentsListBox.Name = "experimentsListBox";
            this.experimentsListBox.Size = new System.Drawing.Size(181, 605);
            this.experimentsListBox.TabIndex = 2;
            this.experimentsListBox.SelectedIndexChanged += new System.EventHandler(this.experimentsListBox_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.инструментыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(574, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exportТаблицыЭкспериментовToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Сохранить как...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.save_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Открыть...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.open_Click);
            // 
            // exportТаблицыЭкспериментовToolStripMenuItem
            // 
            this.exportТаблицыЭкспериментовToolStripMenuItem.Name = "exportТаблицыЭкспериментовToolStripMenuItem";
            this.exportТаблицыЭкспериментовToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportТаблицыЭкспериментовToolStripMenuItem.Text = "Экспорт...";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // инструментыToolStripMenuItem
            // 
            this.инструментыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.калькуляторЧастотToolStripMenuItem,
            this.индексРелеToolStripMenuItem});
            this.инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
            this.инструментыToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.инструментыToolStripMenuItem.Text = "Инструменты";
            // 
            // калькуляторЧастотToolStripMenuItem
            // 
            this.калькуляторЧастотToolStripMenuItem.Name = "калькуляторЧастотToolStripMenuItem";
            this.калькуляторЧастотToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.калькуляторЧастотToolStripMenuItem.Text = "Калькулятор частот...";
            // 
            // индексРелеToolStripMenuItem
            // 
            this.индексРелеToolStripMenuItem.Name = "индексРелеToolStripMenuItem";
            this.индексРелеToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.индексРелеToolStripMenuItem.Text = "Индекс реле...";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripButton,
            this.removeToolStripButton,
            this.upToolStripButton,
            this.downToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(574, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addToolStripButton
            // 
            this.addToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addToolStripButton.Image = global::NMRExperimentEditor.Properties.Resources.add2;
            this.addToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addToolStripButton.Name = "addToolStripButton";
            this.addToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.addToolStripButton.ToolTipText = "Добавить эксперимент";
            this.addToolStripButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeToolStripButton
            // 
            this.removeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.removeToolStripButton.Image = global::NMRExperimentEditor.Properties.Resources.delete2;
            this.removeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeToolStripButton.Name = "removeToolStripButton";
            this.removeToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.removeToolStripButton.ToolTipText = "Удалить выбранный эксперимент";
            this.removeToolStripButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // upToolStripButton
            // 
            this.upToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.upToolStripButton.Image = global::NMRExperimentEditor.Properties.Resources.arrow_up_blue;
            this.upToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.upToolStripButton.Name = "upToolStripButton";
            this.upToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.upToolStripButton.ToolTipText = "На одну позицию вверх";
            this.upToolStripButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // downToolStripButton
            // 
            this.downToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.downToolStripButton.Image = global::NMRExperimentEditor.Properties.Resources.arrow_down_blue;
            this.downToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.downToolStripButton.Name = "downToolStripButton";
            this.downToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.downToolStripButton.ToolTipText = "На одну позицию вниз";
            this.downToolStripButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // experimentView
            // 
            this.experimentView.AutoScroll = true;
            this.experimentView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.experimentView.Location = new System.Drawing.Point(0, 0);
            this.experimentView.Name = "experimentView";
            this.experimentView.Size = new System.Drawing.Size(383, 605);
            this.experimentView.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.experimentView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.experimentsListBox);
            this.splitContainer1.Size = new System.Drawing.Size(568, 605);
            this.splitContainer1.SplitterDistance = 383;
            this.splitContainer1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(574, 611);
            this.panel1.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 660);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Редактор экспериментов КарСар ЯК";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Views.ExperimentView experimentView;
        private System.Windows.Forms.ListBox experimentsListBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инструментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem калькуляторЧастотToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem индексРелеToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addToolStripButton;
        private System.Windows.Forms.ToolStripButton removeToolStripButton;
        private System.Windows.Forms.ToolStripButton upToolStripButton;
        private System.Windows.Forms.ToolStripButton downToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem exportТаблицыЭкспериментовToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
    }
}

