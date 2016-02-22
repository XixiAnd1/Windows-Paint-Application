namespace SETPaint
{
    partial class SETPaint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SETPaint));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.file_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.open_file_option = new System.Windows.Forms.ToolStripMenuItem();
            this.save_file_option = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_file_option = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_drawing = new System.Windows.Forms.ToolStripMenuItem();
            this.erase_drawing = new System.Windows.Forms.ToolStripMenuItem();
            this.help_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.about_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.properties_box = new System.Windows.Forms.ListView();
            this.thickness_label = new System.Windows.Forms.Label();
            this.line_width = new System.Windows.Forms.ComboBox();
            this.fill_color_cb = new System.Windows.Forms.CheckBox();
            this.line_color_cb = new System.Windows.Forms.CheckBox();
            this.ellipse_r_button = new System.Windows.Forms.RadioButton();
            this.rectangle_r_button = new System.Windows.Forms.RadioButton();
            this.line_r_button = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mouse_position = new System.Windows.Forms.ToolStripStatusLabel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.paint_area = new System.Windows.Forms.PictureBox();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paint_area)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_menu,
            this.edit_drawing,
            this.help_menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(955, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // file_menu
            // 
            this.file_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open_file_option,
            this.save_file_option,
            this.exit_file_option});
            this.file_menu.Name = "file_menu";
            this.file_menu.Size = new System.Drawing.Size(37, 20);
            this.file_menu.Text = "&File";
            // 
            // open_file_option
            // 
            this.open_file_option.Name = "open_file_option";
            this.open_file_option.Size = new System.Drawing.Size(103, 22);
            this.open_file_option.Text = "&Open";
            this.open_file_option.Click += new System.EventHandler(this.open_file_option_Click);
            // 
            // save_file_option
            // 
            this.save_file_option.Name = "save_file_option";
            this.save_file_option.Size = new System.Drawing.Size(103, 22);
            this.save_file_option.Text = "&Save";
            this.save_file_option.Click += new System.EventHandler(this.save_file_option_Click);
            // 
            // exit_file_option
            // 
            this.exit_file_option.Name = "exit_file_option";
            this.exit_file_option.Size = new System.Drawing.Size(103, 22);
            this.exit_file_option.Text = "&Exit";
            this.exit_file_option.Click += new System.EventHandler(this.exit_file_option_Click);
            // 
            // edit_drawing
            // 
            this.edit_drawing.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.erase_drawing});
            this.edit_drawing.Name = "edit_drawing";
            this.edit_drawing.Size = new System.Drawing.Size(39, 20);
            this.edit_drawing.Text = "&Edit";
            // 
            // erase_drawing
            // 
            this.erase_drawing.Name = "erase_drawing";
            this.erase_drawing.Size = new System.Drawing.Size(101, 22);
            this.erase_drawing.Text = "&Erase";
            this.erase_drawing.Click += new System.EventHandler(this.erase_drawing_Click);
            // 
            // help_menu
            // 
            this.help_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.about_menu});
            this.help_menu.Name = "help_menu";
            this.help_menu.Size = new System.Drawing.Size(44, 20);
            this.help_menu.Text = "&Help";
            // 
            // about_menu
            // 
            this.about_menu.Name = "about_menu";
            this.about_menu.Size = new System.Drawing.Size(107, 22);
            this.about_menu.Text = "&About";
            this.about_menu.Click += new System.EventHandler(this.about_menu_Click);
            // 
            // properties_box
            // 
            this.properties_box.Location = new System.Drawing.Point(0, 27);
            this.properties_box.Name = "properties_box";
            this.properties_box.Size = new System.Drawing.Size(176, 494);
            this.properties_box.TabIndex = 3;
            this.properties_box.UseCompatibleStateImageBehavior = false;
            // 
            // thickness_label
            // 
            this.thickness_label.AutoSize = true;
            this.thickness_label.Location = new System.Drawing.Point(37, 224);
            this.thickness_label.Name = "thickness_label";
            this.thickness_label.Size = new System.Drawing.Size(56, 13);
            this.thickness_label.TabIndex = 19;
            this.thickness_label.Text = "Thickness";
            // 
            // line_width
            // 
            this.line_width.FormattingEnabled = true;
            this.line_width.Items.AddRange(new object[] {
            "1px",
            "3px",
            "5px",
            "8px"});
            this.line_width.Location = new System.Drawing.Point(99, 221);
            this.line_width.Name = "line_width";
            this.line_width.Size = new System.Drawing.Size(68, 21);
            this.line_width.TabIndex = 18;
            this.line_width.Text = "Size";
            // 
            // fill_color_cb
            // 
            this.fill_color_cb.AutoSize = true;
            this.fill_color_cb.Location = new System.Drawing.Point(37, 301);
            this.fill_color_cb.Name = "fill_color_cb";
            this.fill_color_cb.Size = new System.Drawing.Size(65, 17);
            this.fill_color_cb.TabIndex = 17;
            this.fill_color_cb.Text = "Fill Color";
            this.fill_color_cb.UseVisualStyleBackColor = true;
            this.fill_color_cb.CheckedChanged += new System.EventHandler(this.fill_color_cb_CheckedChanged);
            // 
            // line_color_cb
            // 
            this.line_color_cb.AutoSize = true;
            this.line_color_cb.Location = new System.Drawing.Point(36, 264);
            this.line_color_cb.Name = "line_color_cb";
            this.line_color_cb.Size = new System.Drawing.Size(108, 17);
            this.line_color_cb.TabIndex = 16;
            this.line_color_cb.Text = "Line/Border color";
            this.line_color_cb.UseVisualStyleBackColor = true;
            this.line_color_cb.CheckedChanged += new System.EventHandler(this.line_color_cb_CheckedChanged);
            // 
            // ellipse_r_button
            // 
            this.ellipse_r_button.AutoSize = true;
            this.ellipse_r_button.Location = new System.Drawing.Point(37, 112);
            this.ellipse_r_button.Name = "ellipse_r_button";
            this.ellipse_r_button.Size = new System.Drawing.Size(55, 17);
            this.ellipse_r_button.TabIndex = 14;
            this.ellipse_r_button.TabStop = true;
            this.ellipse_r_button.Text = "Ellipse";
            this.ellipse_r_button.UseVisualStyleBackColor = true;
            // 
            // rectangle_r_button
            // 
            this.rectangle_r_button.AutoSize = true;
            this.rectangle_r_button.Location = new System.Drawing.Point(37, 89);
            this.rectangle_r_button.Name = "rectangle_r_button";
            this.rectangle_r_button.Size = new System.Drawing.Size(74, 17);
            this.rectangle_r_button.TabIndex = 13;
            this.rectangle_r_button.TabStop = true;
            this.rectangle_r_button.Text = "Rectangle";
            this.rectangle_r_button.UseVisualStyleBackColor = true;
            // 
            // line_r_button
            // 
            this.line_r_button.AutoSize = true;
            this.line_r_button.Location = new System.Drawing.Point(37, 66);
            this.line_r_button.Name = "line_r_button";
            this.line_r_button.Size = new System.Drawing.Size(45, 17);
            this.line_r_button.TabIndex = 12;
            this.line_r_button.TabStop = true;
            this.line_r_button.Text = "Line";
            this.line_r_button.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mouse_position});
            this.statusStrip1.Location = new System.Drawing.Point(0, 499);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(955, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // mouse_position
            // 
            this.mouse_position.Name = "mouse_position";
            this.mouse_position.Size = new System.Drawing.Size(53, 17);
            this.mouse_position.Text = "Position:";
            // 
            // paint_area
            // 
            this.paint_area.BackColor = System.Drawing.Color.Gainsboro;
            this.paint_area.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paint_area.BackgroundImage")));
            this.paint_area.Location = new System.Drawing.Point(173, 27);
            this.paint_area.Name = "paint_area";
            this.paint_area.Size = new System.Drawing.Size(782, 494);
            this.paint_area.TabIndex = 21;
            this.paint_area.TabStop = false;
            this.paint_area.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paint_area_MouseDown);
            this.paint_area.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paint_area_MouseMove);
            this.paint_area.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paint_area_MouseUp);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SETPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 521);
            this.Controls.Add(this.paint_area);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.thickness_label);
            this.Controls.Add(this.line_width);
            this.Controls.Add(this.fill_color_cb);
            this.Controls.Add(this.line_color_cb);
            this.Controls.Add(this.ellipse_r_button);
            this.Controls.Add(this.rectangle_r_button);
            this.Controls.Add(this.line_r_button);
            this.Controls.Add(this.properties_box);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SETPaint";
            this.Text = "SETPaint Application";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paint_area)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem file_menu;
        private System.Windows.Forms.ToolStripMenuItem open_file_option;
        private System.Windows.Forms.ToolStripMenuItem save_file_option;
        private System.Windows.Forms.ToolStripMenuItem exit_file_option;
        private System.Windows.Forms.ToolStripMenuItem edit_drawing;
        private System.Windows.Forms.ToolStripMenuItem erase_drawing;
        private System.Windows.Forms.ToolStripMenuItem help_menu;
        private System.Windows.Forms.ListView properties_box;
        private System.Windows.Forms.Label thickness_label;
        private System.Windows.Forms.ComboBox line_width;
        private System.Windows.Forms.CheckBox fill_color_cb;
        private System.Windows.Forms.CheckBox line_color_cb;
        private System.Windows.Forms.RadioButton ellipse_r_button;
        private System.Windows.Forms.RadioButton rectangle_r_button;
        private System.Windows.Forms.RadioButton line_r_button;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel mouse_position;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox paint_area;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem about_menu;
    }
}

