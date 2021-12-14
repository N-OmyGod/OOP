using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsLaba5_6
{
	class Hostel 
	{
		public string fullName { get; set; }
		public string group { get; set; }
		public int num_room { get; set; }
		public int last_year { get; set; }
		public Hostel() { }
		public Hostel(string sn, string gr, int nr, int l)
		{
			fullName = sn;
			group = gr;
			num_room = nr;
			last_year = l;
		}	

	}
}
