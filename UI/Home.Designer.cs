namespace SimplePaint.UI
{
	partial class Home
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openImageFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(975, 40);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageFileToolStripMenuItem,
            this.newFileToolStripMenuItem,
            this.quitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(71, 36);
			this.fileToolStripMenuItem.Text = "File";
			this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
			// 
			// openImageFileToolStripMenuItem
			// 
			this.openImageFileToolStripMenuItem.Name = "openImageFileToolStripMenuItem";
			this.openImageFileToolStripMenuItem.Size = new System.Drawing.Size(323, 44);
			this.openImageFileToolStripMenuItem.Text = "Open Image File";
			this.openImageFileToolStripMenuItem.Click += new System.EventHandler(this.openImageFileToolStripMenuItem_Click);
			// 
			// newFileToolStripMenuItem
			// 
			this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
			this.newFileToolStripMenuItem.Size = new System.Drawing.Size(323, 44);
			this.newFileToolStripMenuItem.Text = "New File";
			this.newFileToolStripMenuItem.Click += new System.EventHandler(this.newFileToolStripMenuItem_Click);
			// 
			// quitToolStripMenuItem
			// 
			this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
			this.quitToolStripMenuItem.Size = new System.Drawing.Size(323, 44);
			this.quitToolStripMenuItem.Text = "Quit";
			this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(279, 102);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(350, 42);
			this.label1.TabIndex = 1;
			this.label1.Text = "Open existed image";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(359, 167);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(182, 59);
			this.button1.TabIndex = 2;
			this.button1.Text = "Open Image";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(420, 249);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 42);
			this.label2.TabIndex = 3;
			this.label2.Text = "Or";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(380, 308);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(140, 61);
			this.button2.TabIndex = 4;
			this.button2.Text = "New File";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Home
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(975, 569);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.DoubleBuffered = true;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Home";
			this.ShowIcon = false;
			this.Text = "SimplePaint";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openImageFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button2;
	}
}