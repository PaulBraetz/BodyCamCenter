using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Commands
{
	internal sealed class DeleteBodyCam : CommandBase
	{
		public DeleteBodyCam(List<BodyCam> bodyCams, String navigationKey) : base(bodyCams, "BodyCam Entfernen", navigationKey)
		{
		}

		public override void Run()
		{
			if (BodyCams.Count > 0)
			{
				foreach (var bodyCam in BodyCams)
				{
					Console.WriteLine($"{BodyCams.IndexOf(bodyCam)} - {bodyCam.StreamLink} in {bodyCam.Resolution}");
				}

				var index = Read<Int32>("Welche BodyCam soll gelöscht werden?", Int32.Parse);
				BodyCams.RemoveAt(index);
			}
			else
			{
				Console.WriteLine("Es wurden noch keine BodyCams hinzugefügt.");
			}
		}
	}
}
