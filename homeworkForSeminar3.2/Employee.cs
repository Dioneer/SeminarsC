using System;
namespace Homework2
{
	class Employee
	{
		private string name;
		private int age;

		public string getName()
		{
			return name;
		}
		public void setName(string name)
		{
			this.name = name;
		}
		public int detAge()
		{
			return age;
		}
		public void setAge(int age)
		{
			this.age = age;
		}
		public Employee(string name, int age)
		{
			this.name = name;
			this.age = age;
		}
	}
}