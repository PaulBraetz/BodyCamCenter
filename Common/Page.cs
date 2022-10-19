using System.Diagnostics;

namespace Common
{
	public static class Page
	{
		public static void Open(PageBuilder builder)
		{
			var path = Path.Combine(Path.GetTempPath(), $"BodyCamCenter_{Guid.NewGuid()}.html");
			using var stream = File.CreateText(path);
			stream.Write(builder);
			using var _ = Process.Start("explorer", path);
		}
	}
}