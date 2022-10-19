using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
	public readonly struct Resolution : IEquatable<Resolution>
	{
		public readonly UInt16 Height;
		public readonly UInt16 Width;

		public Resolution(UInt16 height, UInt16 width)
		{
			Height = height;
			Width = width;
		}

		public static readonly Resolution W700H394 = new Resolution(394, 700);
		public static readonly Resolution W750H422 = new Resolution(422, 750);
		public static readonly Resolution W800H450 = new Resolution(450, 800);
		public static readonly Resolution W850H478 = new Resolution(478, 850);

		public static readonly IList<Resolution> Predefined = new[]
		{
			W700H394,
			W750H422,
			W800H450,
			W850H478
		}.ToList().AsReadOnly();

		public override String ToString()
		{
			return $"{Width}*{Height}";
		}

		public override Boolean Equals(Object? obj)
		{
			return obj is Resolution resolution && Equals(resolution);
		}

		public Boolean Equals(Resolution other)
		{
			return Height == other.Height &&
				   Width == other.Width;
		}

		public override Int32 GetHashCode()
		{
			return HashCode.Combine(Height, Width);
		}

		public static Boolean operator ==(Resolution left, Resolution right)
		{
			return left.Equals(right);
		}

		public static Boolean operator !=(Resolution left, Resolution right)
		{
			return !(left == right);
		}
	}
}
