using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTag3
{
	public interface IBreathable
	{
		static int CountBreaths { get; set; } = 0;
		void BreatheIn();
		void BreatheOut();
	}
}
