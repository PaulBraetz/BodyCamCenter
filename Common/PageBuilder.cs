using System.Text;

namespace Common
{
	public sealed class PageBuilder
	{
		private const String INIT = "<!DOCTYPE html><html><body>";
		private const String BUILD = "</body></html>";
		private readonly StringBuilder _builder = new StringBuilder(INIT);
		public PageBuilder Add(BodyCam bodyCam)
		{
			_builder.Append(bodyCam);
			return this;
		}
		public PageBuilder Clear()
		{
			_builder.Clear();
			_builder.Append(INIT);
			return this;
		}
		public String Build()
		{
			var page = _builder.Append(BUILD).ToString();

			return page;
		}
		public override String ToString()
		{
			return Build();
		}
	}
}