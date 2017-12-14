namespace LEARNING_CONCEPTS
{
	//public class Person
	//{
	//	public int Age;
	//	public string FullName;

	//	public void ShowInfo()
	//	{
	//		System.Console.WriteLine($"Full Name: { FullName }, Age: { Age }");
	//	}
	//}

	//public class Person
	//{
	//	/// <summary>
	//	/// Default Constructor
	//	/// Snippet => ctor
	//	/// </summary>
	//	public Person()
	//	{
	//	}

	//	public int Age;
	//	public string FullName;

	//	public void ShowInfo()
	//	{
	//		System.Console.WriteLine($"Full Name: { FullName }, Age: { Age }");
	//	}
	//}

	//public class Person
	//{
	//	public Person()
	//	{
	//	}

	//	/// <summary>
	//	/// این کار حرفه‌ای نیست
	//	/// </summary>
	//	//public int Age;
	//	public int Age = 20;

	//	/// <summary>
	//	/// این کار حرفه‌ای نیست
	//	/// </summary>
	//	public string FullName = "";

	//	public void ShowInfo()
	//	{
	//		System.Console.WriteLine($"Full Name: { FullName }, Age: { Age }");
	//	}
	//}

	public class Person
	{
		public Person()
		{
			Age = 20;

			//FullName = "";
			FullName = string.Empty;
		}

		public int Age;
		public string FullName;

		public void ShowInfo()
		{
			System.Console.WriteLine($"Full Name: { FullName }, Age: { Age }");
		}
	}

	//public class Person
	//{
	//	public Person(string fullName)
	//	{
	//		FullName = fullName;
	//	}

	//	public int Age;
	//	public string FullName;

	//	public void ShowInfo()
	//	{
	//		System.Console.WriteLine($"Full Name: { FullName }, Age: { Age }");
	//	}
	//}

	/// <summary>
	/// نگاه ذیل دیگر عرف نیست
	/// </summary>
	//public class Person
	//{
	//	public Person()
	//	{
	//	}

	//	public Person(int age)
	//	{
	//		Age = age;
	//	}

	//	public Person(string fullName)
	//	{
	//		FullName = fullName;
	//	}

	//	public Person(string fullName, int age)
	//	{
	//		Age = age;
	//		FullName = fullName;
	//	}

	//	public int Age;
	//	public string FullName;

	//	public void ShowInfo()
	//	{
	//		System.Console.WriteLine("I'm {0} and {1} years old.", FullName, Age);
	//	}
	//}
}
