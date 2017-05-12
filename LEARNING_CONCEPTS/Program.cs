namespace LEARNING_CONCEPTS
{
	class Program
	{
		static void Main(string[] args)
		{
			Person oPerson = new Person();

			//oPerson.Age = 20;
			//oPerson.FullName = "Ali Reza Alavi";

			//oPerson.ShowInfo();

			//Circle oCircle = new Circle();

			//oCircle.BorderWidth = 2;

			//Circle oCircle = new Circle(2, 3, 10);

			//Circle oCircle = new Circle(x: 2, y: 3, radius: 10); // OK

			//Circle oCircle = new Circle(2, y: 3, radius: 10); // OK

			//Circle oCircle = new Circle(2, y: 3, 10); // Error

			//Circle oCircle = new Circle(radius: 10, x: 2, y: 3); // OK

			//Circle oCircle = new Circle(x: 2, y: 3, radius: 10);

			//Person oPerson = new Person() { Age = 20, FullName = "Ali Reza Alavi" };

			//oPerson.ShowInfo();

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
