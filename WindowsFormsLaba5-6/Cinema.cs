using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsLaba5_6
{
	class Cinema : IU
	{

		public string film { get; set; }
		public int numSeats { get; set; }
		public int numViewers { get; set; }
		double costbil { get; set; }
		string begSession { get; set; }
		public Cinema() { }
		Cinema(string fn, int n, int v, double c, string b)
		{
			film = fn;
			numSeats = n;
			numViewers = v;
			costbil = c;
			begSession = b;
		}
		



		public static List<Cinema> cinemaList { get;  set; } = new List<Cinema>();

		public override void add(string fn, int n, int nz, int c, string fbeg)
		{ 
			Cinema wr = new Cinema(fn, n, nz, c, fbeg);

			cinemaList.Add(wr);

		}
		
		public double search(string n)
		{

			
			foreach (Cinema p in cinemaList)
			{
				if (p.film == n)
				{
					double a = p.numSeats;
					double b = p.numViewers;
					double c = b / (a / 100);
					return c;
				}


			}
			return 0;

		}

	}
}
