namespace SimplePaint.UI
{
	partial class EditPicture
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPicture));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeImageStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btn_flipHorizontal = new System.Windows.Forms.Button();
			this.btn_flipVertical = new System.Windows.Forms.Button();
			this.btn_rotateRight = new System.Windows.Forms.Button();
			this.btn_rotateLeft = new System.Windows.Forms.Button();
			this.printDialog1 = new System.Windows.Forms.PrintDialog();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1574, 40);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(20, 36);
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeImageStripMenuItem,
            this.printToolStripMenuItem,
            this.quitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(71, 36);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openImageToolStripMenuItem
			// 
			this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
			this.openImageToolStripMenuItem.Size = new System.Drawing.Size(279, 44);
			this.openImageToolStripMenuItem.Text = "Open Image";
			this.openImageToolStripMenuItem.Click += new System.EventHandler(this.openImageToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(279, 44);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// closeImageStripMenuItem
			// 
			this.closeImageStripMenuItem.Name = "closeImageStripMenuItem";
			this.closeImageStripMenuItem.Size = new System.Drawing.Size(279, 44);
			this.closeImageStripMenuItem.Text = "Close Image";
			this.closeImageStripMenuItem.Click += new System.EventHandler(this.closeImageStripMenuItem_Click);
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
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(150, 43);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1412, 774);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// btn_flipHorizontal
			// 
			this.btn_flipHorizontal.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.325F);
			this.btn_flipHorizontal.Image = global::SimplePaint.Properties.Resources.Flip_Horizontal_64px;
			this.btn_flipHorizontal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btn_flipHorizontal.Location = new System.Drawing.Point(2, 43);
			this.btn_flipHorizontal.Name = "btn_flipHorizontal";
			this.btn_flipHorizontal.Size = new System.Drawing.Size(142, 141);
			this.btn_flipHorizontal.TabIndex = 2;
			this.btn_flipHorizontal.Text = "Flip Horizontal";
			this.btn_flipHorizontal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_flipHorizontal.UseVisualStyleBackColor = true;
			this.btn_flipHorizontal.Click += new System.EventHandler(this.btn_flipHorizontal_Click);
			// 
			// btn_flipVertical
			// 
			this.btn_flipVertical.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.325F);
			this.btn_flipVertical.Image = global::SimplePaint.Properties.Resources.Flip_Vertical_64px;
			this.btn_flipVertical.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btn_flipVertical.Location = new System.Drawing.Point(2, 190);
			this.btn_flipVertical.Name = "btn_flipVertical";
			this.btn_flipVertical.Size = new System.Drawing.Size(142, 134);
			this.btn_flipVertical.TabIndex = 3;
			this.btn_flipVertical.Text = "Flip Vertical";
			this.btn_flipVertical.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_flipVertical.UseVisualStyleBackColor = true;
			this.btn_flipVertical.Click += new System.EventHandler(this.btn_flipVertical_Click);
			// 
			// btn_rotateRight
			// 
			this.btn_rotateRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.325F);
			this.btn_rotateRight.Image = global::SimplePaint.Properties.Resources.Rotate_Right_52px;
			this.btn_rotateRight.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btn_rotateRight.Location = new System.Drawing.Point(2, 330);
			this.btn_rotateRight.Name = "btn_rotateRight";
			this.btn_rotateRight.Size = new System.Drawing.Size(142, 131);
			this.btn_rotateRight.TabIndex = 4;
			this.btn_rotateRight.Text = "Rotate Right";
			this.btn_rotateRight.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_rotateRight.UseVisualStyleBackColor = true;
			this.btn_rotateRight.Click += new System.EventHandler(this.btn_rotateRight_Click);
			// 
			// btn_rotateLeft
			// 
			this.btn_rotateLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.325F);
			this.btn_rotateLeft.Image = global::SimplePaint.Properties.Resources.Rotate_Left_52px;
			this.btn_rotateLeft.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btn_rotateLeft.Location = new System.Drawing.Point(2, 467);
			this.btn_rotateLeft.Name = "btn_rotateLeft";
			this.btn_rotateLeft.Size = new System.Drawing.Size(142, 140);
			this.btn_rotateLeft.TabIndex = 5;
			this.btn_rotateLeft.Text = "Rotate Left";
			this.btn_rotateLeft.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_rotateLeft.UseVisualStyleBackColor = true;
			this.btn_rotateLeft.Click += new System.EventHandler(this.btn_rotateLeft_Click);
			// 
			// printDialog1
			// 
			this.printDialog1.UseEXDialog = true;
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
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
			// EditPicture
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1574, 829);
			this.Controls.Add(this.btn_rotateLeft);
			this.Controls.Add(this.btn_rotateRight);
			this.Controls.Add(this.btn_flipVertical);
			this.Controls.Add(this.btn_flipHorizontal);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "EditPicture";
			this.ShowIcon = false;
			this.Text = "EditPicture";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.EditPicture_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btn_flipHorizontal;
		private System.Windows.Forms.Button btn_flipVertical;
		private System.Windows.Forms.Button btn_rotateRight;
		private System.Windows.Forms.Button btn_rotateLeft;
		private System.Windows.Forms.PrintDialog printDialog1;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.ToolStripMenuItem closeImageStripMenuItem;
	}
}