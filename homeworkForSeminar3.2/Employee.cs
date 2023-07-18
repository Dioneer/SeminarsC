using System;
namespace Homework2
{
	public class Employee
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
		public int getAge()
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
		public override bool Equals(object obj)
		{
			if (this == obj)
				return true;
			if (obj is Employee)
			{
				Employee employee = (Employee)obj;
				if (employee.name.Equals(name) && employee.age == age)
				{
					return true;
				}
			}
			return false;
		}
		public String toString()
		{
			return String.format("%s-%d", name, age);
		}



	}
}