using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colloc
{
	internal class Ministry
	{
		private List<School> Schools= new List<School>();

		public void Add(School school)
		{
			Schools.Add(school);
		}

		public List<Student> FilterHonors()
		{
			var res = new List<Student>();

			foreach (School school in Schools)
			{
				var schoolStudents = school.Analize();
				foreach (var stud in schoolStudents)
				{
					if(stud.Performance == 5)
					{
						res.Add(stud);
					}
				}
			}
			return res;	
		}
		public List<Student> FilterLoser()
		{
			var res = new List<Student>();

			foreach (School school in Schools)
			{
				var schoolStudents = school.Analize();
				foreach (var stud in schoolStudents)
				{
					if (stud.Performance <= 3)
					{
						res.Add(stud);
					}
				}
			}
			return res;
		}
	}
}
