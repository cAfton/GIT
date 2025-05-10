namespace Task1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            editingToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            cancelToolStripMenuItem = new ToolStripMenuItem();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            fontColorToolStripMenuItem = new ToolStripMenuItem();
            backgroundColorToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton_new = new ToolStripButton();
            toolStripButton_open = new ToolStripButton();
            toolStripButton_save = new ToolStripButton();
            toolStripButton_copy = new ToolStripButton();
            toolStripButton_cut = new ToolStripButton();
            toolStripButton_paste = new ToolStripButton();
            toolStripButton_cancel = new ToolStripButton();
            toolStripDropDownButton_settings = new ToolStripDropDownButton();
            fontColorToolStripMenuItem1 = new ToolStripMenuItem();
            backgroundColorToolStripMenuItem1 = new ToolStripMenuItem();
            fontToolStripMenuItem1 = new ToolStripMenuItem();
            richTextBox1 = new RichTextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            colorDialog1 = new ColorDialog();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editingToolStripMenuItem, settingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(141, 26);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += new_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(141, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += open_click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(141, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += save_click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(141, 26);
            saveAsToolStripMenuItem.Text = "Save as";
            saveAsToolStripMenuItem.Click += save_as_click;
            // 
            // editingToolStripMenuItem
            // 
            editingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copyToolStripMenuItem, pasteToolStripMenuItem, cutToolStripMenuItem, cancelToolStripMenuItem, selectAllToolStripMenuItem });
            editingToolStripMenuItem.Name = "editingToolStripMenuItem";
            editingToolStripMenuItem.Size = new Size(70, 24);
            editingToolStripMenuItem.Text = "Editing";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(152, 26);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copy_click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(152, 26);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += paste_Click;
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(152, 26);
            cutToolStripMenuItem.Text = "Cut";
            cutToolStripMenuItem.Click += cut_click;
            // 
            // cancelToolStripMenuItem
            // 
            cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            cancelToolStripMenuItem.Size = new Size(152, 26);
            cancelToolStripMenuItem.Text = "Cancel";
            cancelToolStripMenuItem.Click += cancel_click;
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.Size = new Size(152, 26);
            selectAllToolStripMenuItem.Text = "Select all";
            selectAllToolStripMenuItem.Click += Select_all_click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontColorToolStripMenuItem, backgroundColorToolStripMenuItem, fontToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(76, 24);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // fontColorToolStripMenuItem
            // 
            fontColorToolStripMenuItem.Name = "fontColorToolStripMenuItem";
            fontColorToolStripMenuItem.Size = new Size(209, 26);
            fontColorToolStripMenuItem.Text = "Font color";
            fontColorToolStripMenuItem.Click += font_color_click;
            // 
            // backgroundColorToolStripMenuItem
            // 
            backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            backgroundColorToolStripMenuItem.Size = new Size(209, 26);
            backgroundColorToolStripMenuItem.Text = "Background color";
            backgroundColorToolStripMenuItem.Click += background_color_click;
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(209, 26);
            fontToolStripMenuItem.Text = "Font";
            fontToolStripMenuItem.Click += font_click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton_new, toolStripButton_open, toolStripButton_save, toolStripButton_copy, toolStripButton_cut, toolStripButton_paste, toolStripButton_cancel, toolStripDropDownButton_settings });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_new
            // 
            toolStripButton_new.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton_new.Image = (Image)resources.GetObject("toolStripButton_new.Image");
            toolStripButton_new.ImageTransparentColor = Color.Magenta;
            toolStripButton_new.Name = "toolStripButton_new";
            toolStripButton_new.Size = new Size(29, 24);
            toolStripButton_new.Text = "New";
            toolStripButton_new.Click += new_Click;
            // 
            // toolStripButton_open
            // 
            toolStripButton_open.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton_open.Image = (Image)resources.GetObject("toolStripButton_open.Image");
            toolStripButton_open.ImageTransparentColor = Color.Magenta;
            toolStripButton_open.Name = "toolStripButton_open";
            toolStripButton_open.Size = new Size(29, 24);
            toolStripButton_open.Text = "Open";
            toolStripButton_open.Click += open_click;
            // 
            // toolStripButton_save
            // 
            toolStripButton_save.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton_save.Image = (Image)resources.GetObject("toolStripButton_save.Image");
            toolStripButton_save.ImageTransparentColor = Color.Magenta;
            toolStripButton_save.Name = "toolStripButton_save";
            toolStripButton_save.Size = new Size(29, 24);
            toolStripButton_save.Text = "Save";
            toolStripButton_save.Click += save_click;
            // 
            // toolStripButton_copy
            // 
            toolStripButton_copy.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton_copy.Image = (Image)resources.GetObject("toolStripButton_copy.Image");
            toolStripButton_copy.ImageTransparentColor = Color.Magenta;
            toolStripButton_copy.Name = "toolStripButton_copy";
            toolStripButton_copy.Size = new Size(29, 24);
            toolStripButton_copy.Text = "Copy";
            toolStripButton_copy.Click += copy_click;
            // 
            // toolStripButton_cut
            // 
            toolStripButton_cut.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton_cut.Image = (Image)resources.GetObject("toolStripButton_cut.Image");
            toolStripButton_cut.ImageTransparentColor = Color.Magenta;
            toolStripButton_cut.Name = "toolStripButton_cut";
            toolStripButton_cut.Size = new Size(29, 24);
            toolStripButton_cut.Text = "Cut";
            toolStripButton_cut.Click += cut_click;
            // 
            // toolStripButton_paste
            // 
            toolStripButton_paste.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton_paste.Image = (Image)resources.GetObject("toolStripButton_paste.Image");
            toolStripButton_paste.ImageTransparentColor = Color.Magenta;
            toolStripButton_paste.Name = "toolStripButton_paste";
            toolStripButton_paste.Size = new Size(29, 24);
            toolStripButton_paste.Text = "Paste";
            toolStripButton_paste.Click += paste_Click;
            // 
            // toolStripButton_cancel
            // 
            toolStripButton_cancel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton_cancel.Image = (Image)resources.GetObject("toolStripButton_cancel.Image");
            toolStripButton_cancel.ImageTransparentColor = Color.Magenta;
            toolStripButton_cancel.Name = "toolStripButton_cancel";
            toolStripButton_cancel.Size = new Size(29, 24);
            toolStripButton_cancel.Text = "Cancel";
            toolStripButton_cancel.Click += cancel_click;
            // 
            // toolStripDropDownButton_settings
            // 
            toolStripDropDownButton_settings.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton_settings.DropDownItems.AddRange(new ToolStripItem[] { fontColorToolStripMenuItem1, backgroundColorToolStripMenuItem1, fontToolStripMenuItem1 });
            toolStripDropDownButton_settings.Image = (Image)resources.GetObject("toolStripDropDownButton_settings.Image");
            toolStripDropDownButton_settings.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton_settings.Name = "toolStripDropDownButton_settings";
            toolStripDropDownButton_settings.Size = new Size(34, 24);
            toolStripDropDownButton_settings.Text = "Settings";
            // 
            // fontColorToolStripMenuItem1
            // 
            fontColorToolStripMenuItem1.Name = "fontColorToolStripMenuItem1";
            fontColorToolStripMenuItem1.Size = new Size(209, 26);
            fontColorToolStripMenuItem1.Text = "Font color";
            fontColorToolStripMenuItem1.Click += font_color_click;
            // 
            // backgroundColorToolStripMenuItem1
            // 
            backgroundColorToolStripMenuItem1.Name = "backgroundColorToolStripMenuItem1";
            backgroundColorToolStripMenuItem1.Size = new Size(209, 26);
            backgroundColorToolStripMenuItem1.Text = "Background color";
            backgroundColorToolStripMenuItem1.Click += background_color_click;
            // 
            // fontToolStripMenuItem1
            // 
            fontToolStripMenuItem1.Name = "fontToolStripMenuItem1";
            fontToolStripMenuItem1.Size = new Size(209, 26);
            fontToolStripMenuItem1.Text = "Font";
            fontToolStripMenuItem1.Click += font_click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 58);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 432);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "RTF Files (*.rtf)|*.rtf";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "RTF Files (*.rtf)|*.rtf";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 541);
            Controls.Add(richTextBox1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStrip toolStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem editingToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private RichTextBox richTextBox1;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem cancelToolStripMenuItem;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem fontColorToolStripMenuItem;
        private ToolStripMenuItem backgroundColorToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripButton toolStripButton_new;
        private ToolStripButton toolStripButton_open;
        private ToolStripButton toolStripButton_save;
        private ToolStripButton toolStripButton_copy;
        private ToolStripButton toolStripButton_cut;
        private ToolStripButton toolStripButton_paste;
        private ToolStripButton toolStripButton_cancel;
        private ToolStripDropDownButton toolStripDropDownButton_settings;
        private ToolStripMenuItem fontColorToolStripMenuItem1;
        private ToolStripMenuItem backgroundColorToolStripMenuItem1;
        private ToolStripMenuItem fontToolStripMenuItem1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
        private ColorDialog colorDialog1;
    }
}
