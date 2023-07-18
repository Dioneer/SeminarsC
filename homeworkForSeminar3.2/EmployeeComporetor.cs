namespace Homework2
{
	public class DataColComparer : Comparer<Employee>
	{
		private SortTypes sortTypes;

		public DataColComparer(SortTypes sortTypes)
		{
			this.sortTypes = sortTypes;
		}
		public override int Compare(Employee o1, Employee o2)
		{
			int nameRes = sortTypes == sortTypes.Ascending ? o1.getName().CompareTo(o2.getName()) : o2.getName().CompareTo(o1.getName());
			if (nameRes == 0)
			{
				return sortTypes == sortTypes.Ascending ? o1.getAge().CompareTo(o2.getAge()) : o2.getAge().CompareTo(o1.getAge());
			}
			return nameRes;
		}
	}
}