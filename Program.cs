namespace TB_tasks
{
    class Program
    {
        static void Main(string[] args)
        {

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }

        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose a functionality:");
            Console.WriteLine("0) Exit");
            Console.WriteLine("1) World greeting");
            Console.WriteLine("2) Name & age");
            Console.WriteLine("3) Change color of console text");
            Console.WriteLine("4) Todays date");
            Console.WriteLine("5) Which is larger?");
            Console.WriteLine("6) Guess the number");
            Console.WriteLine("7) Save as file");
            Console.WriteLine("8) Read file");
            Console.WriteLine("9) Do some math");
            Console.WriteLine("10) Show times tables 1-10");
            Console.WriteLine("11) Get random numbers");
            Console.WriteLine("12) Check if palindrome");
            Console.WriteLine("13) Check in-between numbers");
            Console.WriteLine("14) Check if odd or even");
            Console.WriteLine("15) Do some addition");
            Console.WriteLine("16) Create a character");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "0":
                    return false;
                case "1":
                    WorldGreeting();
                    return true;
                case "2":
                    NameAge();
                    return true;
                case "3":
                    ChangeColor();
                    return true;
                case "4":
                    TodaysDate();
                    return true;
                case "5":
                    WhichIsLarger();
                    return true;
                case "6":
                    GuessTheNumber();
                    return true;
                case "7":
                    _ = SaveAsFile();
                    return true;
                case "8":
                    ReadFile();
                    return true;
                case "9":
                    Calculate();
                    return true;
                case "10":
                    TimesTables();
                    return true;
                case "11":
                    CreateTwoArrays();
                    return true;
                case "12":
                    CheckIfPalindrome();
                    return true;
                case "13":
                    CheckInBetweenNums();
                    return true;
                case "14":
                    CheckIfOddOrEven();
                    return true;
                case "15":
                    DoAddition();
                    return true;
                case "16":
                    Character.CreateCharacter();
                    return true;
                default:
                    return true;
            }
        }
        private static void WorldGreeting()
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        private static void NameAge()
        {
            Console.WriteLine("What's your first name?");
            string? firstname = Console.ReadLine();
            Console.WriteLine("Well, hello " + firstname);
            Console.WriteLine("And what's your last name?");
            string? lastname = Console.ReadLine();
            Console.WriteLine(firstname + " " + lastname + ", I see...");
            Console.WriteLine("And how old might you be?");
            string? age = Console.ReadLine();
            Console.WriteLine("Ok, so " + firstname + " " + lastname + ", " + age + " years old. That's cool!");
            Console.ReadLine();
        }

        private static void ChangeColor()
        {
            if (Console.ForegroundColor == ConsoleColor.Cyan)
                Console.ForegroundColor = ConsoleColor.White;
            else
                Console.ForegroundColor = ConsoleColor.Cyan;
        }

        private static void TodaysDate()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine("Today is " + date.ToString("F"));
            Console.ReadLine();
        }

        private static void WhichIsLarger()
        {
            Console.WriteLine("Please, input a random number");
            string? input1 = Console.ReadLine();
            Console.WriteLine("Thanks, now input another random number, please");
            string? input2 = Console.ReadLine();

            int int1 = int.Parse(input1!);
            int int2 = int.Parse(input2!);

            if (int1 > int2)
                Console.WriteLine("The larger number is " + input1);
            else
                Console.WriteLine("The larger number is " + input2);
                Console.ReadLine();
        }

        private static void GuessTheNumber()
        {
            Random random = new();
            int rndNum = random.Next(100);
            Console.WriteLine("Guess the number (1-100). Input your guess.");

            int count = 0;

            for ( ; ; )
            {
                count++;

                string? userInput = Console.ReadLine();
                int userInt = int.Parse(userInput!);

                if (userInt == rndNum)
                {
                    Console.WriteLine(rndNum + " is correct! It took you " + count + " guesses.");
                    Console.ReadLine();
                    break;
                }
                else
                    Console.WriteLine("Sorry, try again...");
            }

        }

        private static async Task SaveAsFile()
        {
            Console.WriteLine("Input a string and press enter to save to hard drive");
            string? text = Console.ReadLine();

            await File.WriteAllTextAsync("TB_stringToFile.txt", text);
        }

        private static void ReadFile()
        {
            string text = File.ReadAllText("TB_stringToFile.txt");

            Console.WriteLine("Contents of TB_stringToFile.txt = {0}", text);
            Console.ReadLine();
        }

        private static void Calculate()
        {
            Console.WriteLine("Input a decimal number to do some math");
            string? userInput = Console.ReadLine();

            double userDecimal = Convert.ToDouble(userInput);


            double squareRoot = Math.Sqrt(userDecimal);
            double powerOf2 = Math.Pow(userDecimal, 2);
            double powerOf10 = Math.Pow(userDecimal, 10);

            Console.WriteLine("The square root of " + userDecimal + " is " + squareRoot);
            Console.WriteLine(userDecimal + " to the power of 2 is " + powerOf2);
            Console.WriteLine(userDecimal + " to the power of 10 is " + powerOf10);
            Console.ReadLine();
        }

        private static void TimesTables()
        {
            List<int> TimeTable1 = new();
            List<int> TimeTable2 = new();
            List<int> TimeTable3 = new();
            List<int> TimeTable4 = new();
            List<int> TimeTable5 = new();
            List<int> TimeTable6 = new();
            List<int> TimeTable7 = new();
            List<int> TimeTable8 = new();
            List<int> TimeTable9 = new();
            List<int> TimeTable10 = new();

            for (int i = 1; i <= 10; i++)
            {
                TimeTable1.Add(1 * i);
                TimeTable2.Add(2 * i);
                TimeTable3.Add(3 * i);
                TimeTable4.Add(4 * i);
                TimeTable5.Add(5 * i);
                TimeTable6.Add(6 * i);
                TimeTable7.Add(7 * i);
                TimeTable8.Add(8 * i);
                TimeTable9.Add(9 * i);
                TimeTable10.Add(10 * i);
            }

            Console.WriteLine(string.Format("1 times table: {0}", string.Join("   ", TimeTable1)));
            Console.WriteLine(string.Format("2 times table: {0}", string.Join("   ", TimeTable2)));
            Console.WriteLine(string.Format("3 times table: {0}", string.Join("   ", TimeTable3)));
            Console.WriteLine(string.Format("4 times table: {0}", string.Join("   ", TimeTable4)));
            Console.WriteLine(string.Format("5 times table: {0}", string.Join("   ", TimeTable5)));
            Console.WriteLine(string.Format("6 times table: {0}", string.Join("   ", TimeTable6)));
            Console.WriteLine(string.Format("7 times table: {0}", string.Join("   ", TimeTable7)));
            Console.WriteLine(string.Format("8 times table: {0}", string.Join("   ", TimeTable8)));
            Console.WriteLine(string.Format("9 times table: {0}", string.Join("   ", TimeTable9)));
            Console.WriteLine(string.Format("10 times table: {0}", string.Join("   ", TimeTable10)));
            Console.ReadLine();
        }

        private static void CreateTwoArrays()
        {
            int[] rndArr = new int[10];
            int[] orderedArr = new int[10];

            Random rndNums = new();

            for (int i = 0; i < rndArr.Length; i++)
            {
                rndArr[i] = rndNums.Next(100);
            }

            Array.Copy(rndArr, orderedArr, 10);

            for (int i = 0; i < orderedArr.Length; i++)
            {
                for (int j = i+1; j < orderedArr.Length; j++)
                {
                    if (orderedArr[i] > orderedArr[j])
                    {
                        (orderedArr[j], orderedArr[i]) = (orderedArr[i], orderedArr[j]);
                    }
                }
            }

            Console.WriteLine(string.Format("Random numbers in random order: {0}", string.Join(", ", rndArr)));
            Console.WriteLine(string.Format("Random numbers in ascending order: {0}", string.Join(", ", orderedArr)));
            Console.ReadLine();
        }

        private static void CheckIfPalindrome()
        {
            Console.WriteLine("Input a word to check if it's a palindrome");
            string? userInput = Console.ReadLine();

            string? userWord = userInput!.ToLower();

            char[] charArr = userWord.ToCharArray(); ;

            Array.Reverse(charArr);

            string reversedStr = string.Join("", charArr);

            if (userWord == reversedStr)
            {
                Console.WriteLine(userInput + " is a palindrome!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(userInput + " is NOT a palindrome!");
                Console.ReadLine();
            }

        }

        private static void CheckInBetweenNums()
        {
            Console.WriteLine("Input a number");
            string? input1 = Console.ReadLine();
            Console.WriteLine("Input another number");
            string? input2 = Console.ReadLine();

            int int1 = int.Parse(input1!);
            int int2 = int.Parse(input2!);

            List<int> betweenNums = new();

            int larger = 0;
            int smaller = 0;

            if (int1 > int2)
            {
                for (int count = int2+1; count < int1; count++)
                {
                    betweenNums.Add(count);
                }
                larger = int1;
                smaller = int2;
            }
            if (int1 < int2)
            {
                for (int count = int1+1; count < int2; count++)
                {
                    betweenNums.Add(count);
                }
                larger = int2;
                smaller = int1;
            }

            Console.WriteLine(string.Format("The numbers between " + smaller + " and " + larger + " is {0}", string.Join(", ", betweenNums)));
            Console.ReadLine();
        }

        private static void CheckIfOddOrEven()
        {
            Console.WriteLine("Input any amount of numbers seperated by commas to sort them by odd and even");
            string? numSequence = Console.ReadLine();

            string[] sep = {" ", ", ", ","};

            string[] strArr = numSequence!.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int[] intArr = Array.ConvertAll(strArr, str => int.Parse(str));

            List<int> Odd = new();
            List<int> Even = new();

            foreach (int i in intArr)
            {
                if (i % 2 == 0)
                {
                    Even.Add(i);
                }
                else
                {
                    Odd.Add(i);
                }
            }
            
            Console.WriteLine("Even numbers: {0}", string.Join(", ", Even));
            Console.WriteLine("Odd numbers: {0}", string.Join(", ", Odd));
            Console.ReadLine();
        }

        private static void DoAddition()
        {
            Console.WriteLine("Input any amount of numbers seperated by commas to add them together");
            string? numSequence = Console.ReadLine();

            string[] sep = { " ", ", ", "," };

            string[] strArr = numSequence!.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int[] intArr = Array.ConvertAll(strArr, str => int.Parse(str));

            int count = 0;
            
            foreach (int i in intArr)
            {
                count += i;
            }

            Console.WriteLine(string.Join(" + ", intArr) + " = " + count);
            Console.ReadLine();
        }

        public class Character
        {

            public string? name;
            public int health;
            public int strength;
            public int luck;

            public static void CreateCharacter()
            {
                Random rndVal = new();
                Character char1 = new();
                Character char2 = new();

                Console.WriteLine("Enter a character name");
                char1.name = Console.ReadLine();

                Console.WriteLine("Enter an enemy character name");
                char2.name = Console.ReadLine();

                char1.health = rndVal.Next(100);
                char1.strength = rndVal.Next(100);
                char1.luck = rndVal.Next(100);

                char2.health = rndVal.Next(100);
                char2.strength = rndVal.Next(100);
                char2.luck = rndVal.Next(100);

                Console.WriteLine(" ");
                Console.WriteLine("Character: " + char1.name);
                Console.WriteLine("Health: " + char1.health);
                Console.WriteLine("Strength: " + char1.strength);
                Console.WriteLine("Luck: " + char1.luck);
                Console.WriteLine(" ");
                Console.WriteLine("Enemy character: " + char2.name);
                Console.WriteLine("Health: " + char2.health);
                Console.WriteLine("Strength: " + char2.strength);
                Console.WriteLine("Luck: " + char2.luck);
                Console.ReadLine();
            }
        }


    }
}