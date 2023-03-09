namespace Kescha.Classes
{
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int AgeDifference { get; set; }

        public Animal() 
        {
            Age = 0;
            Name = "No name";
            AgeDifference = 0;
        }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Animal(
            string name, 
            int userAge, 
            int animalAge)
        {
            Name = name;
            Age = animalAge;
            CalculateAgeDifferenceNoReturn(userAge, animalAge);
        }

        public void Greets(string userName)
        {
            string greeting = $"Hello, {userName}. My name is 'Kescha'\n";
            Console.WriteLine(greeting);
        }

        public void AgesDifferenceAboutPrint ()
        {
            Console.WriteLine($"Our ages defference is {AgeDifference}.");
        }

        public void AgesAboutMessagePrint (int userAge, int animalAge) 
        {
            Console.WriteLine($"Wondurful! Your age is {userAge} and my age is {animalAge} years old.\n");
        }

        public void CompareAges () 
        {
            if ( AgeDifference > 0)
            {
                Console.WriteLine("You are than me older!\n");
            }
            else if ( AgeDifference < 0)
            {
                Console.WriteLine("You are than me younger!\n");
            }
            else
            {
                Console.WriteLine("We are the same age!\n");
            }
        }

        public void TellAboutFriends(string userName, int userAge ) 
        {
            Console.Write("I tell about my friends you!\n");
            string[] keschaFriends = { "Kasya", "Vasya", "Valya", userName };
            int[] friendsAges = new int[4];
            friendsAges[0] = 3;
            friendsAges[1] = 4;
            friendsAges[2] = 4;
            friendsAges[3] = userAge;
            for (int i = 0; i < friendsAges.Length; i++)
            {
            Console.WriteLine($"This is my friend {keschaFriends[i]}. He is {friendsAges[i]} years old.");
            }
            Console.WriteLine();
        }

        public void CalculateAgeDifferenceNoReturn(int userAge, int animalAge) 
        {
            AgeDifference = userAge - Age;
        }

        public void CalculateAgeDifferenceWithNoReturn (int userAge)
        {
            AgeDifference = userAge - Age;
        }

        public int CalculateAgeDifferenceReturn (int userAge, int animalAge)
        {
            return userAge - animalAge;
        }
    }
}