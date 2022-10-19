using Common;

namespace ConsoleApp.Commands
{
	internal sealed class Open : CommandBase
	{
		public Open(List<BodyCam> bodyCams, String navigationKey) : base(bodyCams, "Öffnen", navigationKey)
		{
		}

		public override void Run()
		{
			var builder = new PageBuilder();
			foreach (var bodyCam in BodyCams)
			{
				builder.Add(bodyCam);
			}

			Page.Open(builder);
		}
	}
}
