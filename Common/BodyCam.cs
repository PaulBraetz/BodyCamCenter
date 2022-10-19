namespace Common
{
	public sealed record BodyCam(String StreamLink, Resolution Resolution)
	{
		private const String TEMPLATE =
@"<iframe src=""{0}"" 
width=""{1}"" 
height=""{2}"" 
title=""YouTube video player"" 
frameborder=""0"" 
allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"" 
allowfullscreen></iframe>";
		public override String ToString()
		{
			return String.Format(TEMPLATE, StreamLink, Resolution.Width, Resolution.Height);
		}
	}
}