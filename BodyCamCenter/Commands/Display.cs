using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Commands
{
	internal sealed class DisplayBodyCams : CommandBase
	{
		public DisplayBodyCams(List<BodyCam> bodyCams, String navigationKey) : base(bodyCams, "BodyCams Anzeigen", navigationKey)
		{
		}

		public override void Run()
		{
			foreach (var bodyCam in BodyCams)
			{
				Console.WriteLine($"{BodyCams.IndexOf(bodyCam)} - {bodyCam.StreamLink} in {bodyCam.Resolution}");
			}
		}
	}
}
