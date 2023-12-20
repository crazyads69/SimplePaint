namespace SimplePaint.UI
{
	partial class DrawPicture
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawPicture));
			this.button1 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.drawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.numericUpDown_Width = new System.Windows.Forms.NumericUpDown();
			this.groupBox_Width = new System.Windows.Forms.GroupBox();
			this.groupBox_Color = new System.Windows.Forms.GroupBox();
			this.pictureBox_ColorActual = new System.Windows.Forms.PictureBox();
			this.pictureBox_Color2 = new System.Windows.Forms.PictureBox();
			this.pictureBox_Color5 = new System.Windows.Forms.PictureBox();
			this.pictureBox_Color3 = new System.Windows.Forms.PictureBox();
			this.pictureBox_Color6 = new System.Windows.Forms.PictureBox();
			this.pictureBox_Color1 = new System.Windows.Forms.PictureBox();
			this.pictureBox_Color4 = new System.Windows.Forms.PictureBox();
			this.button3 = new System.Windows.Forms.Button();
			this.groupBox_Forms = new System.Windows.Forms.GroupBox();
			this.pictureBox13 = new System.Windows.Forms.PictureBox();
			this.pictureBox14 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox_File = new System.Windows.Forms.GroupBox();
			this.btn_print = new System.Windows.Forms.Button();
			this.btn_close = new System.Windows.Forms.Button();
			this.btn_save = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printDialog1 = new System.Windows.Forms.PrintDialog();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.btn_eraser = new System.Windows.Forms.Button();
			this.btn_pencil = new System.Windows.Forms.Button();
			this.btn_clear = new System.Windows.Forms.Button();
			this.groupBox_Tools = new System.Windows.Forms.GroupBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Width)).BeginInit();
			this.groupBox_Width.SuspendLayout();
			this.groupBox_Color.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_ColorActual)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color4)).BeginInit();
			this.groupBox_Forms.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox_File.SuspendLayout();
			this.groupBox_Tools.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button1.Location = new System.Drawing.Point(12, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(105, 100);
			this.button1.TabIndex = 0;
			this.button1.Text = "Pen";
			this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Location = new System.Drawing.Point(262, 83);
			this.panel1.Margin = new System.Windows.Forms.Padding(6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1382, 1119);
			this.panel1.TabIndex = 5;
			this.panel1.Click += new System.EventHandler(this.panel1_Click);
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.panel1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
			this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			// 
			// menuStrip1
			// 
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.drawToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(2004, 40);
			this.menuStrip1.TabIndex = 6;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.printToolStripMenuItem,
            this.quitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(71, 44);
			this.fileToolStripMenuItem.Text = "File";
			this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(279, 44);
			this.openToolStripMenuItem.Text = "Open Image";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(279, 44);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// printToolStripMenuItem
			// 
			this.printToolStripMenuItem.Name = "printToolStripMenuItem";
			this.printToolStripMenuItem.Size = new System.Drawing.Size(279, 44);
			this.printToolStripMenuItem.Text = "Print";
			this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
			// 
			// quitToolStripMenuItem
			// 
			this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
			this.quitToolStripMenuItem.Size = new System.Drawing.Size(279, 44);
			this.quitToolStripMenuItem.Text = "Quit";
			this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
			// 
			// drawToolStripMenuItem
			// 
			this.drawToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem});
			this.drawToolStripMenuItem.Name = "drawToolStripMenuItem";
			this.drawToolStripMenuItem.Size = new System.Drawing.Size(88, 44);
			this.drawToolStripMenuItem.Text = "Draw";
			this.drawToolStripMenuItem.Click += new System.EventHandler(this.drawToolStripMenuItem_Click);
			// 
			// resetToolStripMenuItem
			// 
			this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
			this.resetToolStripMenuItem.Size = new System.Drawing.Size(204, 44);
			this.resetToolStripMenuItem.Text = "Reset";
			this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
			// 
			// numericUpDown_Width
			// 
			this.numericUpDown_Width.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDown_Width.Location = new System.Drawing.Point(20, 50);
			this.numericUpDown_Width.Margin = new System.Windows.Forms.Padding(6);
			this.numericUpDown_Width.Name = "numericUpDown_Width";
			this.numericUpDown_Width.Size = new System.Drawing.Size(148, 56);
			this.numericUpDown_Width.TabIndex = 14;
			this.numericUpDown_Width.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDown_Width.ValueChanged += new System.EventHandler(this.numericUpDown_Width_ValueChanged);
			// 
			// groupBox_Width
			// 
			this.groupBox_Width.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.groupBox_Width.Controls.Add(this.numericUpDown_Width);
			this.groupBox_Width.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_Width.Location = new System.Drawing.Point(1692, 71);
			this.groupBox_Width.Margin = new System.Windows.Forms.Padding(6);
			this.groupBox_Width.Name = "groupBox_Width";
			this.groupBox_Width.Padding = new System.Windows.Forms.Padding(6);
			this.groupBox_Width.Size = new System.Drawing.Size(206, 135);
			this.groupBox_Width.TabIndex = 15;
			this.groupBox_Width.TabStop = false;
			this.groupBox_Width.Text = "Width";
			this.groupBox_Width.Enter += new System.EventHandler(this.groupBox_Width_Enter);
			// 
			// groupBox_Color
			// 
			this.groupBox_Color.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.groupBox_Color.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBox_Color.Controls.Add(this.pictureBox_ColorActual);
			this.groupBox_Color.Controls.Add(this.pictureBox_Color2);
			this.groupBox_Color.Controls.Add(this.pictureBox_Color5);
			this.groupBox_Color.Controls.Add(this.pictureBox_Color3);
			this.groupBox_Color.Controls.Add(this.pictureBox_Color6);
			this.groupBox_Color.Controls.Add(this.pictureBox_Color1);
			this.groupBox_Color.Controls.Add(this.pictureBox_Color4);
			this.groupBox_Color.Controls.Add(this.button3);
			this.groupBox_Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_Color.Location = new System.Drawing.Point(1692, 223);
			this.groupBox_Color.Margin = new System.Windows.Forms.Padding(6);
			this.groupBox_Color.Name = "groupBox_Color";
			this.groupBox_Color.Padding = new System.Windows.Forms.Padding(6);
			this.groupBox_Color.Size = new System.Drawing.Size(206, 327);
			this.groupBox_Color.TabIndex = 16;
			this.groupBox_Color.TabStop = false;
			this.groupBox_Color.Text = "Colors";
			// 
			// pictureBox_ColorActual
			// 
			this.pictureBox_ColorActual.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.pictureBox_ColorActual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox_ColorActual.Location = new System.Drawing.Point(82, 58);
			this.pictureBox_ColorActual.Margin = new System.Windows.Forms.Padding(6);
			this.pictureBox_ColorActual.Name = "pictureBox_ColorActual";
			this.pictureBox_ColorActual.Size = new System.Drawing.Size(40, 39);
			this.pictureBox_ColorActual.TabIndex = 10;
			this.pictureBox_ColorActual.TabStop = false;
			// 
			// pictureBox_Color2
			// 
			this.pictureBox_Color2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.pictureBox_Color2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox_Color2.Location = new System.Drawing.Point(82, 117);
			this.pictureBox_Color2.Margin = new System.Windows.Forms.Padding(6);
			this.pictureBox_Color2.Name = "pictureBox_Color2";
			this.pictureBox_Color2.Size = new System.Drawing.Size(42, 40);
			this.pictureBox_Color2.TabIndex = 9;
			this.pictureBox_Color2.TabStop = false;
			this.pictureBox_Color2.Click += new System.EventHandler(this.pictureBox_Color2_Click);
			// 
			// pictureBox_Color5
			// 
			this.pictureBox_Color5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.pictureBox_Color5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox_Color5.Location = new System.Drawing.Point(82, 171);
			this.pictureBox_Color5.Margin = new System.Windows.Forms.Padding(6);
			this.pictureBox_Color5.Name = "pictureBox_Color5";
			this.pictureBox_Color5.Size = new System.Drawing.Size(42, 40);
			this.pictureBox_Color5.TabIndex = 8;
			this.pictureBox_Color5.TabStop = false;
			this.pictureBox_Color5.Click += new System.EventHandler(this.pictureBox_Color5_Click);
			// 
			// pictureBox_Color3
			// 
			this.pictureBox_Color3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.pictureBox_Color3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox_Color3.Location = new System.Drawing.Point(144, 117);
			this.pictureBox_Color3.Margin = new System.Windows.Forms.Padding(6);
			this.pictureBox_Color3.Name = "pictureBox_Color3";
			this.pictureBox_Color3.Size = new System.Drawing.Size(42, 40);
			this.pictureBox_Color3.TabIndex = 7;
			this.pictureBox_Color3.TabStop = false;
			this.pictureBox_Color3.Click += new System.EventHandler(this.pictureBox_Color3_Click);
			// 
			// pictureBox_Color6
			// 
			this.pictureBox_Color6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.pictureBox_Color6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox_Color6.Location = new System.Drawing.Point(144, 171);
			this.pictureBox_Color6.Margin = new System.Windows.Forms.Padding(6);
			this.pictureBox_Color6.Name = "pictureBox_Color6";
			this.pictureBox_Color6.Size = new System.Drawing.Size(42, 40);
			this.pictureBox_Color6.TabIndex = 6;
			this.pictureBox_Color6.TabStop = false;
			this.pictureBox_Color6.Click += new System.EventHandler(this.pictureBox_Color6_Click);
			// 
			// pictureBox_Color1
			// 
			this.pictureBox_Color1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.pictureBox_Color1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox_Color1.Location = new System.Drawing.Point(20, 117);
			this.pictureBox_Color1.Margin = new System.Windows.Forms.Padding(6);
			this.pictureBox_Color1.Name = "pictureBox_Color1";
			this.pictureBox_Color1.Size = new System.Drawing.Size(42, 40);
			this.pictureBox_Color1.TabIndex = 5;
			this.pictureBox_Color1.TabStop = false;
			this.pictureBox_Color1.Click += new System.EventHandler(this.pictureBox_Color1_Click);
			// 
			// pictureBox_Color4
			// 
			this.pictureBox_Color4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.pictureBox_Color4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox_Color4.Location = new System.Drawing.Point(20, 171);
			this.pictureBox_Color4.Margin = new System.Windows.Forms.Padding(6);
			this.pictureBox_Color4.Name = "pictureBox_Color4";
			this.pictureBox_Color4.Size = new System.Drawing.Size(42, 40);
			this.pictureBox_Color4.TabIndex = 3;
			this.pictureBox_Color4.TabStop = false;
			this.pictureBox_Color4.Click += new System.EventHandler(this.pictureBox_Color4_Click);
			// 
			// button3
			// 
			this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.Location = new System.Drawing.Point(16, 227);
			this.button3.Margin = new System.Windows.Forms.Padding(6);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(176, 79);
			this.button3.TabIndex = 0;
			this.button3.Text = "More";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// groupBox_Forms
			// 
			this.groupBox_Forms.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.groupBox_Forms.Controls.Add(this.pictureBox13);
			this.groupBox_Forms.Controls.Add(this.pictureBox14);
			this.groupBox_Forms.Controls.Add(this.pictureBox6);
			this.groupBox_Forms.Controls.Add(this.pictureBox4);
			this.groupBox_Forms.Controls.Add(this.pictureBox3);
			this.groupBox_Forms.Controls.Add(this.pictureBox1);
			this.groupBox_Forms.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_Forms.Location = new System.Drawing.Point(56, 594);
			this.groupBox_Forms.Margin = new System.Windows.Forms.Padding(6);
			this.groupBox_Forms.Name = "groupBox_Forms";
			this.groupBox_Forms.Padding = new System.Windows.Forms.Padding(6);
			this.groupBox_Forms.Size = new System.Drawing.Size(194, 610);
			this.groupBox_Forms.TabIndex = 17;
			this.groupBox_Forms.TabStop = false;
			this.groupBox_Forms.Text = "Forms";
			// 
			// pictureBox13
			// 
			this.pictureBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox13.Image = global::SimplePaint.Properties.Resources.Rectangle_Stroked_32px;
			this.pictureBox13.Location = new System.Drawing.Point(20, 127);
			this.pictureBox13.Margin = new System.Windows.Forms.Padding(6);
			this.pictureBox13.Name = "pictureBox13";
			this.pictureBox13.Size = new System.Drawing.Size(68, 65);
			this.pictureBox13.TabIndex = 13;
			this.pictureBox13.TabStop = false;
			this.pictureBox13.Click += new System.EventHandler(this.pictureBox13_Click);
			// 
			// pictureBox14
			// 
			this.pictureBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox14.Image = global::SimplePaint.Properties.Resources.Circle_32px;
			this.pictureBox14.Location = new System.Drawing.Point(18, 208);
			this.pictureBox14.Margin = new System.Windows.Forms.Padding(6);
			this.pictureBox14.Name = "pictureBox14";
			this.pictureBox14.Size = new System.Drawing.Size(68, 65);
			this.pictureBox14.TabIndex = 12;
			this.pictureBox14.TabStop = false;
			this.pictureBox14.Click += new System.EventHandler(this.pictureBox14_Click);
			// 
			// pictureBox6
			// 
			this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox6.Image = global::SimplePaint.Properties.Resources.Sun_32px;
			this.pictureBox6.Location = new System.Drawing.Point(100, 48);
			this.pictureBox6.Margin = new System.Windows.Forms.Padding(6);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(68, 65);
			this.pictureBox6.TabIndex = 5;
			this.pictureBox6.TabStop = false;
			this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
			// 
			// pictureBox4
			// 
			this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox4.Image = global::SimplePaint.Properties.Resources.Hearts_32px;
			this.pictureBox4.Location = new System.Drawing.Point(100, 208);
			this.pictureBox4.Margin = new System.Windows.Forms.Padding(6);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(68, 65);
			this.pictureBox4.TabIndex = 3;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox3.Image = global::SimplePaint.Properties.Resources.Cloud_32px;
			this.pictureBox3.Location = new System.Drawing.Point(100, 127);
			this.pictureBox3.Margin = new System.Windows.Forms.Padding(6);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(68, 65);
			this.pictureBox3.TabIndex = 2;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Image = global::SimplePaint.Properties.Resources.Star_32px;
			this.pictureBox1.Location = new System.Drawing.Point(18, 50);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(68, 65);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// groupBox_File
			// 
			this.groupBox_File.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.groupBox_File.Controls.Add(this.btn_print);
			this.groupBox_File.Controls.Add(this.btn_close);
			this.groupBox_File.Controls.Add(this.btn_save);
			this.groupBox_File.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_File.Location = new System.Drawing.Point(1692, 567);
			this.groupBox_File.Margin = new System.Windows.Forms.Padding(6);
			this.groupBox_File.Name = "groupBox_File";
			this.groupBox_File.Padding = new System.Windows.Forms.Padding(6);
			this.groupBox_File.Size = new System.Drawing.Size(206, 333);
			this.groupBox_File.TabIndex = 18;
			this.groupBox_File.TabStop = false;
			this.groupBox_File.Text = "File";
			// 
			// btn_print
			// 
			this.btn_print.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_print.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btn_print.Location = new System.Drawing.Point(12, 63);
			this.btn_print.Margin = new System.Windows.Forms.Padding(6);
			this.btn_print.Name = "btn_print";
			this.btn_print.Size = new System.Drawing.Size(176, 79);
			this.btn_print.TabIndex = 6;
			this.btn_print.Text = "Print";
			this.btn_print.UseVisualStyleBackColor = true;
			this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
			// 
			// btn_close
			// 
			this.btn_close.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_close.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btn_close.Location = new System.Drawing.Point(12, 240);
			this.btn_close.Margin = new System.Windows.Forms.Padding(6);
			this.btn_close.Name = "btn_close";
			this.btn_close.Size = new System.Drawing.Size(176, 79);
			this.btn_close.TabIndex = 5;
			this.btn_close.Text = "Close";
			this.btn_close.UseVisualStyleBackColor = true;
			this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
			// 
			// btn_save
			// 
			this.btn_save.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_save.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btn_save.Location = new System.Drawing.Point(12, 150);
			this.btn_save.Margin = new System.Windows.Forms.Padding(6);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(176, 79);
			this.btn_save.TabIndex = 4;
			this.btn_save.Text = "Save";
			this.btn_save.UseVisualStyleBackColor = true;
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// button2
			// 
			this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button2.Location = new System.Drawing.Point(123, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(110, 100);
			this.button2.TabIndex = 1;
			this.button2.Text = "Close";
			this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// printDialog1
			// 
			this.printDialog1.UseEXDialog = true;
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.Visible = false;
			// 
			// btn_eraser
			// 
			this.btn_eraser.Image = global::SimplePaint.Properties.Resources.Erase_32px;
			this.btn_eraser.Location = new System.Drawing.Point(32, 167);
			this.btn_eraser.Margin = new System.Windows.Forms.Padding(6);
			this.btn_eraser.Name = "btn_eraser";
			this.btn_eraser.Size = new System.Drawing.Size(90, 71);
			this.btn_eraser.TabIndex = 1;
			this.btn_eraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_eraser.UseVisualStyleBackColor = true;
			this.btn_eraser.Click += new System.EventHandler(this.btn_eraser_Click);
			// 
			// btn_pencil
			// 
			this.btn_pencil.Image = global::SimplePaint.Properties.Resources.Edit_32px;
			this.btn_pencil.Location = new System.Drawing.Point(32, 87);
			this.btn_pencil.Margin = new System.Windows.Forms.Padding(6);
			this.btn_pencil.Name = "btn_pencil";
			this.btn_pencil.Size = new System.Drawing.Size(90, 71);
			this.btn_pencil.TabIndex = 0;
			this.btn_pencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_pencil.UseVisualStyleBackColor = true;
			this.btn_pencil.Click += new System.EventHandler(this.btn_pencil_Click);
			// 
			// btn_clear
			// 
			this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btn_clear.FlatAppearance.BorderColor = System.Drawing.Color.Red;
			this.btn_clear.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_clear.ForeColor = System.Drawing.Color.DarkOrange;
			this.btn_clear.Location = new System.Drawing.Point(20, 250);
			this.btn_clear.Margin = new System.Windows.Forms.Padding(6);
			this.btn_clear.Name = "btn_clear";
			this.btn_clear.Size = new System.Drawing.Size(118, 71);
			this.btn_clear.TabIndex = 19;
			this.btn_clear.Text = "Clear";
			this.btn_clear.UseVisualStyleBackColor = false;
			this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
			// 
			// groupBox_Tools
			// 
			this.groupBox_Tools.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.groupBox_Tools.Controls.Add(this.btn_clear);
			this.groupBox_Tools.Controls.Add(this.btn_pencil);
			this.groupBox_Tools.Controls.Add(this.btn_eraser);
			this.groupBox_Tools.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_Tools.Location = new System.Drawing.Point(56, 65);
			this.groupBox_Tools.Margin = new System.Windows.Forms.Padding(6);
			this.groupBox_Tools.Name = "groupBox_Tools";
			this.groupBox_Tools.Padding = new System.Windows.Forms.Padding(6);
			this.groupBox_Tools.Size = new System.Drawing.Size(162, 517);
			this.groupBox_Tools.TabIndex = 17;
			this.groupBox_Tools.TabStop = false;
			this.groupBox_Tools.Text = "Tools";
			// 
			// DrawPicture
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(2004, 1227);
			this.Controls.Add(this.groupBox_Forms);
			this.Controls.Add(this.groupBox_Color);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.groupBox_Width);
			this.Controls.Add(this.groupBox_Tools);
			this.Controls.Add(this.groupBox_File);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "DrawPicture";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Draw";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.DrawPicture_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Width)).EndInit();
			this.groupBox_Width.ResumeLayout(false);
			this.groupBox_Color.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_ColorActual)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color4)).EndInit();
			this.groupBox_Forms.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox_File.ResumeLayout(false);
			this.groupBox_Tools.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btn_save;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem drawToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
		private System.Windows.Forms.NumericUpDown numericUpDown_Width;
		private System.Windows.Forms.GroupBox groupBox_Width;
		private System.Windows.Forms.GroupBox groupBox_Color;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.GroupBox groupBox_Forms;
		private System.Windows.Forms.GroupBox groupBox_File;
		private System.Windows.Forms.Button btn_close;
		private System.Windows.Forms.PictureBox pictureBox_ColorActual;
		private System.Windows.Forms.PictureBox pictureBox_Color2;
		private System.Windows.Forms.PictureBox pictureBox_Color5;
		private System.Windows.Forms.PictureBox pictureBox_Color3;
		private System.Windows.Forms.PictureBox pictureBox_Color6;
		private System.Windows.Forms.PictureBox pictureBox_Color1;
		private System.Windows.Forms.PictureBox pictureBox_Color4;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox13;
		private System.Windows.Forms.PictureBox pictureBox14;
		private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintDialog printDialog1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.Button btn_print;
		private System.Windows.Forms.Button btn_eraser;
		private System.Windows.Forms.Button btn_pencil;
		private System.Windows.Forms.Button btn_clear;
		private System.Windows.Forms.GroupBox groupBox_Tools;
	}
}