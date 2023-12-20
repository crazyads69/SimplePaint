using SimplePaint.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SimplePaint.UI
{
	public partial class DrawPicture : Form
	{
		List<Point> allPoints = new List<Point>();
		public Point current = new Point();
		public Point old = new Point();
		public Graphics g;
		public Pen pen;
		public Pen eraser;

		//Parameters that user can change
		Color pen_color;
		decimal pen_width;
		decimal eraser_width;
		SpecialForm Specialform;
		List<SpecialForm> allSpecialForms = new List<SpecialForm>();
		Image Specialform_IMG;

		//Useful to control pen state
		public Boolean pen_state;
		public Boolean eraser_state;
		public Boolean specialForm_enabled;
		public Boolean drawing;
		public DrawPicture()
		{
			InitializeComponent();
			g = panel1.CreateGraphics();

			//Init
			pen_state = false;
			eraser_state = false;
			specialForm_enabled = false;
			drawing = false;
			eraser_width = 5;
			pen_width = 5;
			pen_color = Color.Black;
			pen = new Pen(Color.Black, (int)pen_width);
			eraser = new Pen(Color.White, (int)eraser_width);
			pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
			eraser.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
			numericUpDown_Width.Value = pen_width;
			numericUpDown_Width.Increment = 3;
			pictureBox_ColorActual.BackColor = pen.Color;
			pictureBox_Color1.BackColor = Color.White;
			pictureBox_Color2.BackColor = Color.Black;
			pictureBox_Color3.BackColor = Color.Blue;
			pictureBox_Color4.BackColor = Color.Green;
			pictureBox_Color5.BackColor = Color.Yellow;
			pictureBox_Color6.BackColor = Color.Red;
		}

		private void RefreshSpecialForm_With(Image img)
		{
			specialForm_enabled = true;
			Specialform_IMG = img;

			//Make sure to not draw or erase when adding form to the panel
			pen_state = false;
			eraser_state = false;
		}

		private void PrintImage()
		{
			printPreviewDialog1 = new PrintPreviewDialog();

			printDialog1.Document = printDocument1;

			if (printDialog1.ShowDialog() == DialogResult.OK)
			{
				printDocument1.Print();
			}
		}
		private void SaveImage()
		{
			SaveFileDialog saveDialog = new SaveFileDialog();
			Bitmap bitm = new Bitmap(panel1.Width, panel1.Height);
			Graphics bitGraphics = Graphics.FromImage(bitm);

			saveDialog.Filter = "Image (*.PNG)|*.PNG";

			try
			{
				//Draw all point to Graphics
				bitGraphics.DrawLines(pen, allPoints.ToArray());

				//Drawing Images to Graphics
				foreach (var item in allSpecialForms)
				{
					bitGraphics.DrawImage(item._Image, item._Point);
				}

				//Here we let the user enter the name for the file
				if (saveDialog.ShowDialog() == DialogResult.OK)
				{
					bitm.Save(saveDialog.FileName);
				}
			}
			catch (Exception e)
			{
				MessageBox.Show("Cannot save file");
			}
		}
		private void DisconnectApp()
		{
			if (drawing)
			{
				DialogResult exitresult = MessageBox.Show("File unsaved ! Do you want to save file ?", "Quit ? ", MessageBoxButtons.YesNo);

				if (exitresult == DialogResult.Yes) //Saving the skecth is user is ok
				{
					SaveImage();
				}
			}
			Dispose();
		}

		private void DrawPicture_Load(object sender, EventArgs e)
		{
			// Changing the location of Left Control boxes
			groupBox_Tools.Location = new Point(groupBox_Tools.Location.X + 10, groupBox_Tools.Location.Y);
			groupBox_Forms.Location = new Point(groupBox_Forms.Location.X + 2, groupBox_Forms.Location.Y);

			// Changing the location of Right Control boxes
			int rightControlBoxes_X = groupBox_Tools.Width + panel1.Width + 70;

			this.Width = this.Width - 50;

			btn_ZoomIn.Enabled = false;
			btn_ZoomOut.Enabled = false;

		}
		private void btn_pencil_Click(object sender, EventArgs e)
		{
			pen_state = true;
			eraser_state = false;
			specialForm_enabled = false;
			numericUpDown_Width.Value = (decimal)pen.Width;
		}

		private void btn_eraser_Click(object sender, EventArgs e)
		{
			eraser_state = true;
			pen_state = false;
			specialForm_enabled = false;
			numericUpDown_Width.Value = (decimal)eraser.Width;
		}

		private void btn_clear_Click(object sender, EventArgs e)
		{
			allPoints = new List<Point>();
			allSpecialForms = new List<SpecialForm>();
			panel1.Invalidate();
		}
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			//pictureBox1.Focus
			RefreshSpecialForm_With(pictureBox1.Image);
		}

		private void pictureBox6_Click(object sender, EventArgs e)
		{
			RefreshSpecialForm_With(pictureBox6.Image);
		}



		private void pictureBox3_Click(object sender, EventArgs e)
		{
			RefreshSpecialForm_With(pictureBox3.Image);
		}


		private void pictureBox4_Click(object sender, EventArgs e)
		{
			RefreshSpecialForm_With(pictureBox4.Image);
		}

		private void pictureBox14_Click(object sender, EventArgs e)
		{
			RefreshSpecialForm_With(pictureBox14.Image);
		}

		private void pictureBox13_Click(object sender, EventArgs e)
		{
			RefreshSpecialForm_With(pictureBox13.Image);
		}

		private void numericUpDown_Width_ValueChanged(object sender, EventArgs e)
		{
			//Update pen width
			if (pen_state)
			{
				pen_width = numericUpDown_Width.Value;
				pen.Width = (int)pen_width;
			}
			else //Update eraser width
			{
				eraser_width = numericUpDown_Width.Value;
				eraser.Width = (int)eraser_width;
			}
		}
		private void button3_Click(object sender, EventArgs e)
		{
			DialogResult result = colorDialog1.ShowDialog();
			if (result == DialogResult.OK)
			{
				pen.Color = colorDialog1.Color;
				pictureBox_ColorActual.BackColor = pen.Color;
			}

		}

		private void pictureBox_Color1_Click(object sender, EventArgs e)
		{
			pen.Color = pictureBox_Color1.BackColor;
		}

		private void pictureBox_Color2_Click(object sender, EventArgs e)
		{
			pen.Color = pictureBox_Color2.BackColor;
		}

		private void pictureBox_Color3_Click(object sender, EventArgs e)
		{
			pen.Color = pictureBox_Color3.BackColor;
		}

		private void pictureBox_Color4_Click(object sender, EventArgs e)
		{
			pen.Color = pictureBox_Color4.BackColor;
		}

		private void pictureBox_Color5_Click(object sender, EventArgs e)
		{
			pen.Color = pictureBox_Color5.BackColor;
		}

		private void pictureBox_Color6_Click(object sender, EventArgs e)
		{
			pen.Color = pictureBox_Color6.BackColor;
		}
		private void btn_print_Click(object sender, EventArgs e)
		{
			PrintImage();
		}

		private void btn_save_Click(object sender, EventArgs e)
		{
			SaveImage();
		}

		private void btn_exit_Click(object sender, EventArgs e)
		{

		}

		private void btn_close_Click(object sender, EventArgs e)
		{
			//TODO: Put the code inside a method and call it here
			if (((allPoints.Count == 0) & (allSpecialForms.Count == 0)) || (drawing = false))
			{

				Dispose();
			}
			else
			{
				DialogResult exitresult = MessageBox.Show("Do you want to save this file ?", "Save ? ", MessageBoxButtons.YesNo);

				if (exitresult == DialogResult.Yes) //Saving the skecth is user is ok
				{
					SaveImage();
				}

				Dispose();
			}
		}
		private void panel1_MouseHover(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			if (pen_state) //crayon déjà cliqué
			{
				old = e.Location;
			}

			//About eraser
			if (eraser_state)
			{
				old = e.Location;
			}

			if (specialForm_enabled)
			{
				g.DrawImage(Specialform_IMG, e.Location);
				Specialform = new SpecialForm(Specialform_IMG, e.Location);
				//drawing = true;
			}

		}

		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (pen_state) //Pen enable
			{
				if (e.Button == MouseButtons.Left)
				{
					Cursor.Current = Cursors.Cross;
					current = e.Location;
					g.DrawLine(pen, old, current);
					old = current;

					//Add the draw point to the list of Points
					allPoints.Add(current);
					drawing = true;
				}
			}

			//Eraser enable
			if (eraser_state)
			{
				if (e.Button == MouseButtons.Left)
				{
					current = e.Location;
					g.DrawLine(eraser, old, current);
					old = current;

					//Remove the eraser point from the list of points
					allPoints.Remove(current);
					//drawing = true;
				}
			}

			if (specialForm_enabled)
			{
				if (e.Button == MouseButtons.Left)
				{
					g.DrawImage(Specialform_IMG, e.Location);

					//Add the draw point to the list of SpecialForm
					Specialform = new SpecialForm(Specialform_IMG, e.Location);
					allSpecialForms.Add(Specialform);


				}
			}

		}

		private void panel1_Click(object sender, EventArgs e)
		{
		}
		private void fileToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveImage();
		}

		private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void quitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (((allPoints.Count == 0) & (allSpecialForms.Count == 0)) || (drawing = false))
			{

				Dispose();
			}
			else
			{
				DialogResult exitresult = MessageBox.Show("File unsaved ! Do you want to save it", "Quit ? ", MessageBoxButtons.YesNo);

				if (exitresult == DialogResult.Yes) //Saving the skecth is user is ok
				{
					SaveImage();
				}


				Dispose();
			}
		}

		private void drawToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void resetToolStripMenuItem_Click(object sender, EventArgs e)
		{
			allPoints = new List<Point>();
			allSpecialForms = new List<SpecialForm>();
			panel1.Invalidate();
		}

		private void newDrawToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}
		private void OpenDrawWindows()
		{
			DrawPicture draw_Windows = new DrawPicture();
			draw_Windows.Show();
		}
		private void OpenPicture()
		{
			OpenFileDialog OpenFile_dialog = new OpenFileDialog();
			OpenFile_dialog.Title = "Choose a picture";
			OpenFile_dialog.Multiselect = false;

			// Set filter options and filter index.
			OpenFile_dialog.Filter = "Images (*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";

			//Open the file dialog
			if (OpenFile_dialog.ShowDialog() == DialogResult.OK)
			{
				FileInfo choice_info = new FileInfo(OpenFile_dialog.FileName);

				//Calling modifyPic and sending to it the picture info
				EditPicture modifPage = new EditPicture();
				modifPage.GetImage(choice_info);
				modifPage.Show();
			}
		}
		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenPicture();
		}

		private void printToolStripMenuItem_Click(object sender, EventArgs e)
		{
			PrintImage();
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			Bitmap bitm = new Bitmap(panel1.Width, panel1.Height);
			try
			{
				//Draw all point to Graphics
				e.Graphics.DrawLines(pen, allPoints.ToArray());

				//Drawing Images to Graphics
				foreach (var item in allSpecialForms)
				{
					e.Graphics.DrawImage(item._Image, item._Point);
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("Cannot print this image");
			}

			e.Graphics.DrawImage(bitm, 0, 0);
			bitm.Dispose();
		}

		private void groupBox_Width_Enter(object sender, EventArgs e)
		{

		}
	}
}
