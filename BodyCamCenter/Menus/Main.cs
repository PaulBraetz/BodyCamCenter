using Common;
using ConsoleApp.Commands;
using Scli.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyCamCenter.Menus
{
	internal sealed class Main : Scli.Menu.ExitableMenuBase
	{
		public Main() : base("BodyCamCenter", "Schließen")
		{
			var bodyCams = new List<BodyCam>();
			new CommandCollectionBuilder<ICommand>(1, new HashSet<UInt32>() { 0 })
				.Append(k => new AddBodyCam(bodyCams, k))
				.Append(k => new DeleteBodyCam(bodyCams, k))
				.Append(k => new DisplayBodyCams(bodyCams, k))
				.Append(k=>new Open(bodyCams, k))
				.Build(out var actions);

			Actions = actions;
		}
	}
}
