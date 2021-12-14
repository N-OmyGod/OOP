using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsLaba5_6
{
	class ContainerDictionary : IContainer 
	{
		//словарь из студентов обжещития 
		public static Dictionary<string, Hostel> person { get; set; } = new Dictionary<string, Hostel>();

		//использцем в методе search
		public List<string> foundValue = new List<string>();//лист для найденных по задынной группе и году студентов

		public string search_gr="";//задаваемая группа
		public int search_y = 0; //задаваемый год


		public void add(string sn, string g, int nr, int l)
		{
			//Создаем ключ из фио
			string ke = sn;
			Hostel Pr = new Hostel(sn, g, nr, l);
			//Добавляем объект в контейнер
			person.Add(ke, Pr);
		}
		public override void search()
		{

			
			foreach (KeyValuePair<string, Hostel> keyValue in person)
			{
				//ищем по заданной группе и заданному году 
				if (keyValue.Value.group == search_gr && keyValue.Value.last_year == search_y)
				{
					//если найдено, добавляем в лист студентов с такими же данными
					foundValue.Add(
						 keyValue.Value.fullName + " " + keyValue.Value.group + " " +
						 keyValue.Value.num_room + " " + keyValue.Value.last_year + "\n");

				}


			}
			
		}

	}
};