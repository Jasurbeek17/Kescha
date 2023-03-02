//Kescha
//28.02.2023

//name
System.Console.Write("\nEnter your name: ");
string name = Console.ReadLine();
string greeting = $"Hello, {name}. My name is 'Kescha'\n";
System.Console.WriteLine(greeting);

//age
System.Console.Write("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());
int keschaAge = 3;
System.Console.WriteLine($"Wondurful! Your age is {age} and my age is {keschaAge} years old.\n");

//ageDifference
int ageDifference = Math.Abs(age - keschaAge);
System.Console.WriteLine($"Our ages defference is {ageDifference}.");

//who is big
if (ageDifference > 0)
{
    System.Console.WriteLine("You are than me older!\n");
}
else if (ageDifference < 0 ) 
{
    System.Console.WriteLine("You are than me younger!\n");
}
else 
{
    System.Console.WriteLine("We are the same age!\n");
}

// friends y/n
char doFriendsTell = ' ';
System.Console.Write("Do you tell about my friends? (y/n): ");
doFriendsTell = Console.ReadLine()[0];
if (doFriendsTell.Equals('y')) {

    //Kescha's Friends
    string[] keschaFriends = {"Kasya", "Vasya", "Valya", name};
    int[] friendsAges = new int [4];
    friendsAges[0] = 3;
    friendsAges[1] = 4;
    friendsAges[2] = 4;
    friendsAges[3] = age;

    for (int i = 0; i < friendsAges.Length; i ++ ) 
    {
        System.Console.WriteLine($"This is my friend {keschaFriends[i]}. He is {friendsAges[i]} years old.");
    }
    System.Console.WriteLine();

}
else if (doFriendsTell.Equals('n')) 
{
    System.Console.WriteLine("Okey.\n");
}
else 
{
    System.Console.WriteLine("You enter other sign! \n");
}