using System.Drawing;

namespace SimplePaint.Model
{
	class SpecialForm
	{
		Image _image;
		Point _point;

		public Image _Image
		{
			get
			{
				return _image;
			}

			set
			{
				_image = value;
			}
		}

		public Point _Point
		{
			get
			{
				return _point;
			}
			set
			{
				_point = value;
			}
		}

		public SpecialForm(Image img, Point pnt)
		{
			_image = img;
			_point = pnt;
		}
	}
}
