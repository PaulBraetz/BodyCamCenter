using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Commands
{
	internal sealed class AddBodyCam : CommandBase
	{
		public AddBodyCam(List<BodyCam> bodyCams, String navigationKey) : base(bodyCams, "BodyCam Hinzufügen", navigationKey)
		{
		}

		public override void Run()
		{
			var streamLink = $"https://www.youtube.com/embed/{Read("Id vom Stream:")}";
			Resolution resolution;
			if (Read<Boolean>("Möchten Sie eine vordefinierte Auflösung verwenden? (j/n):", s => s == "j"))
			{
				for (var i = 0; i < Resolution.Predefined.Count; i++)
				{
					var predefined = Resolution.Predefined[i];
					Console.WriteLine($"{i} - {predefined}");
				}

				resolution = Read<Resolution>(
					$"Auflösung Eingeben: ({(Resolution.Predefined.Count > 0 ? $"0-{Resolution.Predefined.Count}" : "0")})",
					s => Int32.TryParse(s, out var i) ? Resolution.Predefined[i] : Resolution.Predefined[0]);
			}
			else
			{
				var height = Read<UInt16>("Höhe", UInt16.Parse);
				var width = Read<UInt16>("Breite:", UInt16.Parse);
				resolution = new Resolution(height, width);
			}

			var bodyCam = new BodyCam(streamLink, resolution);
			BodyCams.Add(bodyCam);

			Console.WriteLine($"Hinzugefügt:\n{bodyCam.StreamLink} in {bodyCam.Resolution}");
		}
	}
}
