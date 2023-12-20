using System;
using System.IO;
using System.Windows.Forms;

namespace SimplePaint.UI
{
	public partial class Home : Form
	{
		public Home()
		{
			InitializeComponent();
		}

		private void fileToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void openImageFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenImage();
		}

		private void OpenImage()
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

				//Calling modifiedPage and sending to it the picture info
				EditPicture modifiedPage = new EditPicture();
				modifiedPage.GetImage(choice_info);
				modifiedPage.Show();
			}
		}
	}
}
