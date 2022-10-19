using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Commands
{
	internal abstract class CommandBase:Scli.Command.CommandBase
	{
		protected readonly List<BodyCam> BodyCams;

		protected CommandBase(List<BodyCam> bodyCams,String name, String navigationKey) : base(name)
		{
			BodyCams = bodyCams;
			NavigationKey = navigationKey;
		}
	}
}
