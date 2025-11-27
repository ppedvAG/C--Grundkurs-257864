using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
	internal class KennzeichenFehlerException: Exception
	{
		public KennzeichenFehlerException(string message) : base(message + " Kennzeichen Format nicht Okay.")
		{

		}
	}
}
