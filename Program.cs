//Kescha OOP
//02.03.2023

using Kescha.Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        Animal kescha = new Animal(name: "Kescha", age: 3);
        
        //name
        Console.Write("\nEnter your name: ");
        string userName = Console.ReadLine();

        //age
        Console.Write("Enter your age: ");
        int userAge = Convert.ToInt32(Console.ReadLine());

        kescha.Greets(userName);
        kescha.CalculateAgeDifferenceWithNoReturn(userAge);
        kescha.AgesAboutMessagePrint(userAge, animalAge: kescha.Age);
        kescha.AgesDifferenceAboutPrint();
        kescha.CompareAges();
        kescha.TellAboutFriends(userName, userAge);
    }
}