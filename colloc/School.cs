using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colloc
{
	internal class School
	{
		string Name { get; set; }
		private List<Student> Students = new List<Student>();
		public School(string name)
		{
			Name = name;
		}

		public void Add(Student student)
		{
			Students.Add(student);
		}

		public List<Student> Analize()
		{
			return new List<Student>(Students);
		}

		public override string ToString()
		{
			string res = "";
			for (int i = 0; i < Students.Count; i++)
			{
				res += $"\n {i+1}. {Students[i].ToString()}";
			}
			return res;
		}
	}
}
