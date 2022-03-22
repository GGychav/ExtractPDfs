namespace ExtractPDfs
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PDFlabel1 = new System.Windows.Forms.Label();
            this.PDFtextBox = new System.Windows.Forms.TextBox();
            this.CSVtextBox = new System.Windows.Forms.TextBox();
            this.PDFbutton = new System.Windows.Forms.Button();
            this.CSVbutton = new System.Windows.Forms.Button();
            this.Startutton = new System.Windows.Forms.Button();
            this.Closebutton = new System.Windows.Forms.Button();
            this.StatusrichTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DetailsgroupBox2 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Statuslabel1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TextradioButton2 = new System.Windows.Forms.RadioButton();
            this.IDNumradioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.OpenDestcheckBox4 = new System.Windows.Forms.CheckBox();
            this.SplitCheckBox3 = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenExtractedcheckBox2 = new System.Windows.Forms.CheckBox();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.DetailsgroupBox2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PDFlabel1
            // 
            this.PDFlabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PDFlabel1.AutoSize = true;
            this.PDFlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PDFlabel1.Location = new System.Drawing.Point(45, 38);
            this.PDFlabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PDFlabel1.Name = "PDFlabel1";
            this.PDFlabel1.Size = new System.Drawing.Size(61, 29);
            this.PDFlabel1.TabIndex = 0;
            this.PDFlabel1.Text = "PDF";
            // 
            // PDFtextBox
            // 
            this.PDFtextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PDFtextBox.Location = new System.Drawing.Point(135, 38);
            this.PDFtextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PDFtextBox.Name = "PDFtextBox";
            this.PDFtextBox.Size = new System.Drawing.Size(535, 26);
            this.PDFtextBox.TabIndex = 2;
            this.PDFtextBox.TextChanged += new System.EventHandler(this.PDFtextBox_TextChanged);
            // 
            // CSVtextBox
            // 
            this.CSVtextBox.Location = new System.Drawing.Point(292, 162);
            this.CSVtextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CSVtextBox.Name = "CSVtextBox";
            this.CSVtextBox.Size = new System.Drawing.Size(412, 26);
            this.CSVtextBox.TabIndex = 3;
            this.CSVtextBox.TextChanged += new System.EventHandler(this.CSVtextBox_TextChanged);
            // 
            // PDFbutton
            // 
            this.PDFbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PDFbutton.Location = new System.Drawing.Point(699, 35);
            this.PDFbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PDFbutton.Name = "PDFbutton";
            this.PDFbutton.Size = new System.Drawing.Size(112, 35);
            this.PDFbutton.TabIndex = 4;
            this.PDFbutton.Text = "Browse";
            this.PDFbutton.UseVisualStyleBackColor = true;
            this.PDFbutton.Click += new System.EventHandler(this.PDFbutton_Click);
            // 
            // CSVbutton
            // 
            this.CSVbutton.Enabled = false;
            this.CSVbutton.Location = new System.Drawing.Point(734, 155);
            this.CSVbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CSVbutton.Name = "CSVbutton";
            this.CSVbutton.Size = new System.Drawing.Size(112, 35);
            this.CSVbutton.TabIndex = 5;
            this.CSVbutton.Text = "Browse";
            this.CSVbutton.UseVisualStyleBackColor = true;
            this.CSVbutton.Click += new System.EventHandler(this.CSVbutton_Click);
            // 
            // Startutton
            // 
            this.Startutton.Enabled = false;
            this.Startutton.Location = new System.Drawing.Point(382, 731);
            this.Startutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Startutton.Name = "Startutton";
            this.Startutton.Size = new System.Drawing.Size(112, 35);
            this.Startutton.TabIndex = 6;
            this.Startutton.Text = "Start";
            this.Startutton.UseVisualStyleBackColor = true;
            this.Startutton.Click += new System.EventHandler(this.Startutton_Click);
            // 
            // Closebutton
            // 
            this.Closebutton.Location = new System.Drawing.Point(520, 731);
            this.Closebutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Closebutton.Name = "Closebutton";
            this.Closebutton.Size = new System.Drawing.Size(112, 35);
            this.Closebutton.TabIndex = 7;
            this.Closebutton.Text = "Exit";
            this.Closebutton.UseVisualStyleBackColor = true;
            this.Closebutton.Click += new System.EventHandler(this.Closebutton_Click);
            // 
            // StatusrichTextBox
            // 
            this.StatusrichTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.StatusrichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusrichTextBox.Location = new System.Drawing.Point(4, 24);
            this.StatusrichTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StatusrichTextBox.Name = "StatusrichTextBox";
            this.StatusrichTextBox.ReadOnly = true;
            this.StatusrichTextBox.Size = new System.Drawing.Size(850, 0);
            this.StatusrichTextBox.TabIndex = 8;
            this.StatusrichTextBox.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.PDFbutton);
            this.groupBox1.Controls.Add(this.PDFtextBox);
            this.groupBox1.Controls.Add(this.PDFlabel1);
            this.groupBox1.Location = new System.Drawing.Point(75, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(856, 115);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source PDF";
            // 
            // DetailsgroupBox2
            // 
            this.DetailsgroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailsgroupBox2.AutoSize = true;
            this.DetailsgroupBox2.Controls.Add(this.StatusrichTextBox);
            this.DetailsgroupBox2.Location = new System.Drawing.Point(70, 829);
            this.DetailsgroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DetailsgroupBox2.Name = "DetailsgroupBox2";
            this.DetailsgroupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DetailsgroupBox2.Size = new System.Drawing.Size(858, 29);
            this.DetailsgroupBox2.TabIndex = 11;
            this.DetailsgroupBox2.TabStop = false;
            this.DetailsgroupBox2.Text = "Status Details";
            this.DetailsgroupBox2.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(75, 794);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(128, 24);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Show Details";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(266, 645);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(382, 35);
            this.progressBar1.TabIndex = 13;
            // 
            // Statuslabel1
            // 
            this.Statuslabel1.AutoSize = true;
            this.Statuslabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statuslabel1.Location = new System.Drawing.Point(664, 645);
            this.Statuslabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Statuslabel1.Name = "Statuslabel1";
            this.Statuslabel1.Size = new System.Drawing.Size(79, 29);
            this.Statuslabel1.TabIndex = 14;
            this.Statuslabel1.Text = "Status";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.CSVbutton);
            this.groupBox2.Controls.Add(this.SearchtextBox);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.CSVtextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(75, 177);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(856, 258);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Options";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.TextradioButton2);
            this.groupBox5.Controls.Add(this.IDNumradioButton1);
            this.groupBox5.Location = new System.Drawing.Point(135, 38);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(152, 85);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            // 
            // TextradioButton2
            // 
            this.TextradioButton2.AutoSize = true;
            this.TextradioButton2.Location = new System.Drawing.Point(14, 45);
            this.TextradioButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextradioButton2.Name = "TextradioButton2";
            this.TextradioButton2.Size = new System.Drawing.Size(114, 24);
            this.TextradioButton2.TabIndex = 1;
            this.TextradioButton2.Text = "Single Item";
            this.TextradioButton2.UseVisualStyleBackColor = true;
            this.TextradioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // IDNumradioButton1
            // 
            this.IDNumradioButton1.AutoSize = true;
            this.IDNumradioButton1.Checked = true;
            this.IDNumradioButton1.Location = new System.Drawing.Point(14, 15);
            this.IDNumradioButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IDNumradioButton1.Name = "IDNumradioButton1";
            this.IDNumradioButton1.Size = new System.Drawing.Size(111, 24);
            this.IDNumradioButton1.TabIndex = 0;
            this.IDNumradioButton1.TabStop = true;
            this.IDNumradioButton1.Text = "ID Number";
            this.IDNumradioButton1.UseVisualStyleBackColor = true;
            this.IDNumradioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Digits";
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.Enabled = false;
            this.SearchtextBox.Location = new System.Drawing.Point(292, 83);
            this.SearchtextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(412, 26);
            this.SearchtextBox.TabIndex = 7;
            this.SearchtextBox.TextChanged += new System.EventHandler(this.SearchtextBox_TextChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(292, 49);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(69, 26);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "CSV";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.OpenExtractedcheckBox2);
            this.groupBox3.Controls.Add(this.OpenDestcheckBox4);
            this.groupBox3.Controls.Add(this.SplitCheckBox3);
            this.groupBox3.Location = new System.Drawing.Point(75, 458);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(855, 169);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Other Options";
            // 
            // OpenDestcheckBox4
            // 
            this.OpenDestcheckBox4.AutoSize = true;
            this.OpenDestcheckBox4.Checked = true;
            this.OpenDestcheckBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OpenDestcheckBox4.Location = new System.Drawing.Point(14, 94);
            this.OpenDestcheckBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OpenDestcheckBox4.Name = "OpenDestcheckBox4";
            this.OpenDestcheckBox4.Size = new System.Drawing.Size(266, 24);
            this.OpenDestcheckBox4.TabIndex = 1;
            this.OpenDestcheckBox4.Text = "Open files location when finished";
            this.OpenDestcheckBox4.UseVisualStyleBackColor = true;
            // 
            // SplitCheckBox3
            // 
            this.SplitCheckBox3.AutoSize = true;
            this.SplitCheckBox3.Location = new System.Drawing.Point(14, 57);
            this.SplitCheckBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SplitCheckBox3.Name = "SplitCheckBox3";
            this.SplitCheckBox3.Size = new System.Drawing.Size(313, 24);
            this.SplitCheckBox3.TabIndex = 0;
            this.SplitCheckBox3.Text = "Split PDF per item found (Multiple Files)";
            this.SplitCheckBox3.UseVisualStyleBackColor = true;
            this.SplitCheckBox3.CheckedChanged += new System.EventHandler(this.SplitCheckBox3_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1014, 33);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.instructionsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // OpenExtractedcheckBox2
            // 
            this.OpenExtractedcheckBox2.AutoSize = true;
            this.OpenExtractedcheckBox2.Location = new System.Drawing.Point(14, 127);
            this.OpenExtractedcheckBox2.Name = "OpenExtractedcheckBox2";
            this.OpenExtractedcheckBox2.Size = new System.Drawing.Size(175, 24);
            this.OpenExtractedcheckBox2.TabIndex = 2;
            this.OpenExtractedcheckBox2.Text = "Open Extracted File";
            this.OpenExtractedcheckBox2.UseVisualStyleBackColor = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 904);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Closebutton);
            this.Controls.Add(this.Statuslabel1);
            this.Controls.Add(this.Startutton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.DetailsgroupBox2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "PDF Extractor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.DetailsgroupBox2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PDFlabel1;
        private System.Windows.Forms.TextBox PDFtextBox;
        private System.Windows.Forms.TextBox CSVtextBox;
        private System.Windows.Forms.Button PDFbutton;
        private System.Windows.Forms.Button CSVbutton;
        private System.Windows.Forms.Button Startutton;
        private System.Windows.Forms.Button Closebutton;
        private System.Windows.Forms.RichTextBox StatusrichTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox DetailsgroupBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label Statuslabel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SearchtextBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RadioButton TextradioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton IDNumradioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox SplitCheckBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.CheckBox OpenDestcheckBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox OpenExtractedcheckBox2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    }
}

