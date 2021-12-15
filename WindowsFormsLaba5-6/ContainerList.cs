using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsLaba5_6
{
	class ContainerList : IContainer
	{

		public static List<Cinema> cinemaList { get; set; } = new List<Cinema>();

		public string searchFilm = "";// ���������� �����
		public int percent = 0;// ������� ������������� ����
		
		public  void add(string fn, int n, int nz, int c, string fbeg)
		{
			//������� ������

			Cinema wr = new Cinema(fn, n, nz, c, fbeg);
			//����������� ������ � ����
			cinemaList.Add(wr);

		}
		
		public override void search()
		{

			foreach (Cinema p in cinemaList)
			{
				//���� ����� �� ����������� ��������
				if (p.film == searchFilm)
				{
					//������� ������� ������������� ����
					double a = p.numSeats; // ����� ����
					double b = p.numViewers; // ������� ����� 
					double c = b / (a / 100); 
					percent=(int)c;
					
				}


			}
			

		}

	}
};