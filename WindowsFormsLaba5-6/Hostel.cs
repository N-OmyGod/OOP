using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsLaba5_6
{
	class Hostel : IU
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
		public static Dictionary<string, Hostel> person { get; set; } = new Dictionary<string, Hostel>();
		
		public  void add(string sn, string g, int  nr,int l)
		{

			//Создаем ключ из фио
			string ke = sn;
			//Создаем объект
			Hostel Pr = new Hostel(sn, g, nr, l);
			//Добавляем объект в контейнер
			person.Add(ke, Pr);

		}

		
		public List<string> search(string search_gr, int search_y)
		{

			List<string> foundValue = new List<string>();
			foreach (KeyValuePair<string, Hostel> keyValue in person)
			{
				if (keyValue.Value.group == search_gr && keyValue.Value.last_year == search_y)
				{
					foundValue.Add(
						 keyValue.Value.fullName + " " + keyValue.Value.group + " " +
						 keyValue.Value.num_room + " " + keyValue.Value.last_year + "\n");
					
				}
				

			}
			return foundValue;
		}


	}
}
