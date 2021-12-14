using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsLaba5_6
{
	class Cinema 
	{

		public string film { get; set; }
		public int numSeats { get; set; }
		public int numViewers { get; set; }
		public double costbil { get; set; }
		public string begSession { get; set; }
		public Cinema() { }
		public Cinema(string fn, int n, int v, double c, string b)
		{
			film = fn;
			numSeats = n;
			numViewers = v;
			costbil = c;
			begSession = b;
		}
		
	}
}
