using System;
namespace FirstCSharp
{
	public class ClassOnHeap
	{
		public int AddFive(int startingNum)
		{
			int result = startingNum += 5;
			return result;
		}
	}
}

