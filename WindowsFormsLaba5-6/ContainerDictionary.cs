using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsLaba5_6
{
	class ContainerDictionary : IContainer 
	{
		//������� �� ��������� ��������� 
		public static Dictionary<string, Hostel> person { get; set; } = new Dictionary<string, Hostel>();

		//���������� � ������ search
		public List<string> foundValue = new List<string>();//���� ��� ��������� �� �������� ������ � ���� ���������

		public string search_gr="";//���������� ������
		public int search_y = 0; //���������� ���


		public void add(string sn, string g, int nr, int l)
		{
			//������� ���� �� ���
			string ke = sn;
			Hostel Pr = new Hostel(sn, g, nr, l);
			//��������� ������ � ���������
			person.Add(ke, Pr);
		}
		public override void search()
		{

			
			foreach (KeyValuePair<string, Hostel> keyValue in person)
			{
				//���� �� �������� ������ � ��������� ���� 
				if (keyValue.Value.group == search_gr && keyValue.Value.last_year == search_y)
				{
					//���� �������, ��������� � ���� ��������� � ������ �� �������
					foundValue.Add(
						 keyValue.Value.fullName + " " + keyValue.Value.group + " " +
						 keyValue.Value.num_room + " " + keyValue.Value.last_year + "\n");

				}


			}
			
		}

	}
};