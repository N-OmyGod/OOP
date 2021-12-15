using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsLaba5_6
{
	class ContainerList : IContainer
	{

		public static List<Cinema> cinemaList { get; set; } = new List<Cinema>();

		public string searchFilm = "";// задаваемый фильм
		public int percent = 0;// процент заполненности зала
		
		public  void add(string fn, int n, int nz, int c, string fbeg)
		{
			//создаем обьект

			Cinema wr = new Cinema(fn, n, nz, c, fbeg);
			//Заталкиваем объект в лист
			cinemaList.Add(wr);

		}
		
		public override void search()
		{

			foreach (Cinema p in cinemaList)
			{
				//ищем фильм по задаваемому названию
				if (p.film == searchFilm)
				{
					//находим процент заполненности зала
					double a = p.numSeats; // всего мест
					double b = p.numViewers; // занятые места 
					double c = b / (a / 100); 
					percent=(int)c;
					
				}


			}
			

		}

	}
};