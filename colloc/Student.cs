using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace colloc
{
	class Student
	{
		public string FIO { get; set; }
		public int Grade { get; set; }
		public double Performance { get; set; }
		public string Stage { get; set; }
		private char NameChar = 'A';

		public Student()
		{
			FIO = NameChar.ToString();
			NameChar++;
			Grade = 1;
			Performance = 5;
			Stage = "elementary";

		}
		public Student(string fio, int grade, double performance)
		{
			FIO = fio;
			Grade = grade;
			Performance = performance;
			Stage = GetStage(grade);
		}
		private string GetStage(int grade)
		{
			if(grade <= 4)
			{
				return "elementary";
			}
			if (grade <= 8 && grade >= 5)
			{
				return "secondary";
			}
			if (grade >= 9)
			{
				return "higher";
			}
			return "Не ерный класс";
		}
		public void Pass(double newPerfomnce = 0)
		{
			Grade++;
			Performance += newPerfomnce;
		}
		public override string ToString()
		{
			if(Stage == "elementary")
				return $"{FIO}, младшая школа, {Grade} класс, {Performance} балла";
			if (Stage == "secondary")
				return $"{FIO}, средняя школа, {Grade} класс, {Performance} балла";
			if (Stage == "higher")
				return $"{FIO}, старшая школа, {Grade} класс, {Performance} балла";
			return " ";
		}
	}
}

