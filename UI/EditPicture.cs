using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SimplePaint.UI
{
	public partial class EditPicture : Form
	{
		Image pictureObj;
		FileStream picture_stream;
		FileInfo img;
		public EditPicture()
		{
			InitializeComponent();
		}
		private void RefreshPictureBoxImage()
		{
			pictureBox1.Image = pictureObj;
		}
		private void EditPicture_Load(object sender, System.EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, System.EventArgs e)
		{

		}
		public void GetImage(FileInfo imgInfo)
		{
			//Getting the picture stream
			img = imgInfo;
			picture_stream = img.OpenRead();
			pictureObj = Image.FromStream(picture_stream);

			this.Text = img.FullName + " - Image Modified";

			RefreshPictureBoxImage();


			btn_flipHorizontal.Enabled = true;
			btn_flipVertical.Enabled = true;
			btn_rotateLeft.Enabled = true;
			btn_rotateRight.Enabled = true;

			openImageToolStripMenuItem.Enabled = true;
			saveToolStripMenuItem.Enabled = true;
			printToolStripMenuItem.Enabled = true;
			quitToolStripMenuItem.Enabled = true;
		}

		private void openImageToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			OpenImage();
		}

		private void saveToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			SaveImage();
		}

		private void printToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			PrintImage();
		}

		private void quitToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		public void OpenImage()
		{

			OpenFileDialog OpenFile_dialog = new OpenFileDialog();

			OpenFile_dialog.Title = "Choose a picture";
			OpenFile_dialog.Multiselect = false;
			OpenFile_dialog.Filter = "Images (*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";

			//Open the file dialog
			if (OpenFile_dialog.ShowDialog() == DialogResult.OK)
			{
				FileInfo choice_info = new FileInfo(OpenFile_dialog.FileName);
				GetImage(choice_info);
			}
		}
		public void SaveImage()
		{
			SaveFileDialog saveDialog = new SaveFileDialog();

			saveDialog.Filter = "Image (*.PNG)|*.PNG";
			saveDialog.RestoreDirectory = true;

			//Showing and saving the picture
			if (saveDialog.ShowDialog() == DialogResult.OK)
			{
				pictureBox1.Image.Save(saveDialog.FileName);
				this.Text = saveDialog.FileName + " - Modified Image"; ;
			}
		}
		public void PrintImage()
		{
			printPreviewDialog1 = new PrintPreviewDialog();

			printDialog1.Document = printDocument1;

			if (printDialog1.ShowDialog() == DialogResult.OK)
			{
				printDocument1.Print();
			}
		}
		public void CloseImage()
		{
			pictureObj = null;
			RefreshPictureBoxImage();
			btn_flipHorizontal.Enabled = false;
			btn_flipVertical.Enabled = false;
			btn_rotateLeft.Enabled = false;
			btn_rotateRight.Enabled = false;

			openImageToolStripMenuItem.Enabled = false;
			saveToolStripMenuItem.Enabled = false;
			printToolStripMenuItem.Enabled = false;
			quitToolStripMenuItem.Enabled = false;
		}
		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			Bitmap bitm = new Bitmap(pictureBox1.Width, pictureBox1.Height);

			pictureBox1.DrawToBitmap(bitm, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
			e.Graphics.DrawImage(bitm, 0, 0);
			bitm.Dispose();
		}

		private void btn_flipHorizontal_Click(object sender, System.EventArgs e)
		{
			pictureObj.RotateFlip(RotateFlipType.RotateNoneFlipY);
			RefreshPictureBoxImage();
		}

		private void btn_flipVertical_Click(object sender, System.EventArgs e)
		{
			pictureObj.RotateFlip(RotateFlipType.RotateNoneFlipX);
			RefreshPictureBoxImage();
		}

		private void btn_rotateRight_Click(object sender, System.EventArgs e)
		{
			pictureObj.RotateFlip(RotateFlipType.Rotate90FlipNone);
			RefreshPictureBoxImage();
		}

		private void btn_rotateLeft_Click(object sender, System.EventArgs e)
		{

			RefreshPictureBoxImage();
			pictureObj.RotateFlip(RotateFlipType.Rotate270FlipNone);
		}
		private void closeImageStripMenuItem_Click(object sender, System.EventArgs e)
		{
			CloseImage();
		}
	}
}
