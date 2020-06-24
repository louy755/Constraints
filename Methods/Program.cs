using System;
using System.Threading;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Luke Warm
            // 1- user input for start and end!
            Console.WriteLine("1- Please insert from hint 1000!");
            int from = int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert to hint -1000!");
            int to = int.Parse(Console.ReadLine());
            // call the methos to print from to
            Printer(from, to);

            Console.WriteLine(" Get Ready for the next qustion Please ...");
            Thread.Sleep(2000);
            Console.WriteLine("Are you Ready!!");

            // 2- user input 
            Console.WriteLine("2- Please insert start number hint 3!");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert end number hint 999!");
            int end = int.Parse(Console.ReadLine());
            //  call the methos to print from to
            PrintThree(start, end);

            Console.WriteLine(" Get Ready for the next qustion Please ...");
            Thread.Sleep(2000);
            Console.WriteLine("Are you Ready!!");

            // 3- user input
            Console.WriteLine("3- Please insert array size: ");
            int arrSize = int.Parse(Console.ReadLine());
            // call the method to print from to
            IndexR(arrSize);

            Console.WriteLine(" Get Ready for the next qustion Please ...");
            Thread.Sleep(2000);
            Console.WriteLine("Are you Ready!!");
             
            // 4- user input
            Console.WriteLine("4- Please insert a Number to check if it Odd or Even: ");
            int numberIs = int.Parse(Console.ReadLine());
            // call the method
            string evenOrOdd = CheckNum(numberIs);
            Console.WriteLine(evenOrOdd);

            Console.WriteLine(" Get Ready for the next qustion Please ...");
            Thread.Sleep(2000);
            Console.WriteLine("Are you Ready!!");
            
            // 5- user input
            Console.WriteLine("5- Please insert a Number to check if it Pos Or Neg: ");
            int nmbrIs = int.Parse(Console.ReadLine());
            // call the method
            string posOr = PosOrNeg(nmbrIs);
            Console.WriteLine(posOr);

            Console.WriteLine(" Get Ready for the next qustion Please ...");
            Thread.Sleep(2000);
            Console.WriteLine("Are you Ready!!");
            
            // 6- user input
            Console.WriteLine("6- Please insert your Age or Year you Born to check if you can vote: ");
            int ageToVote = int.Parse(Console.ReadLine());
            // call the method
            string ageVote = VoteValidator(ageToVote);
            Console.WriteLine(ageVote);

            Console.WriteLine(" Get Ready for the next qustion Please ...");
            Thread.Sleep(2000);
            Console.WriteLine("Are you Ready!!");
            
            // Heatin Up
            // 1- user input range method
            Console.WriteLine("1- Please insert number to check if it in the Range 0f -10 to 10: ");
            int numRng = int.Parse(Console.ReadLine());
            // call the method to print from to
            Range(numRng);

            Console.WriteLine(" Get Ready for the next qustion Please ...");
            Thread.Sleep(2000);
            Console.WriteLine("Are you Ready!!");

            //user input
            Console.WriteLine("2- Please insert start number hint 1");
            int startIndex = int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert end number hint 12");
            int endIndex = int.Parse(Console.ReadLine());
            //  call the methos to print from to
            Multibly(startIndex, endIndex);

            Console.WriteLine(" Get Ready for the next qustion Please ...");
            Thread.Sleep(2000);
            Console.WriteLine("Are you Ready!!");
            
            // user input
            Console.WriteLine("3- Please insert number of to print the indexes:");
            int idx = int.Parse(Console.ReadLine());
            //  call the methos to print from to
            RandomIndex(idx);

            Console.WriteLine(" Get Ready for the next qustion Please ...");
            Thread.Sleep(2000);
            Console.WriteLine("Are you Ready!!");

            // user input
            Console.WriteLine("4- Please insert number to genrate your arry and culc the sum:");
            int newNum = int.Parse(Console.ReadLine());
            //  call the methos to print from to
            Compute(newNum);

            Console.WriteLine(" Get Ready for the next qustion Please ...");
            Thread.Sleep(2000);
            Console.WriteLine("Are you Ready!!");

            // user input
            Console.WriteLine("5- Please insert number to find the cube of the indexes:");
            int cubNum = int.Parse(Console.ReadLine());
            //  call the methos to print from to
            Cuber(cubNum);
        }
        //1- Write a method that will print to the console all numbers 1000 through - 1000.
        static void Printer(int start, int end) // method take 2 Params
        {
            for (int i = start; i >= end; i--) // create reverse loop
            {
                Console.WriteLine(i); // Print numbers
            }
        }
        // 2- Write a method that will print to the console numbers 3 through 999 by 3 each time.
        static void PrintThree(int min, int max) // method take 2 params
        {
            while(min <= max) // while loop 
            {
                Console.WriteLine(min); // print min number
                min += 3; // increment by 3
            }
        }
        //3- Write a method that takes a number from the user and returns an array with that many indexes. 
        //The indexes shall be random numbers.
        static void IndexR(int size) // method with one param
        {
            int[] returned = new int[size]; // create new array the size will assigned by user
            Random random = new Random(); // new random
            for (int i = 0; i < size; i++) // loop 
            {
                returned[i] = random.Next(100); // assign the random number to the empty array and increment by one
            }
            foreach(int numb in returned) // foreach to show the array content
            {
                Console.WriteLine(numb); // print random
            }
        }
        // 4- Write a method to check whether a given number is even or odd.
        static string  CheckNum(int n) // method with one param
        {
           return  n % 2 == 0 ? $"{n} is Even!" : $"{n} is Odd!"; // Ternary operator replaces if statement
        }
       // 5- Write a method to check whether a given number is positive or negative.
        static string PosOrNeg(int nmbr) // method with one param
        {
            return  nmbr > -1 ? $"{nmbr} is Positive" : $"{nmbr} is Negative"; // Ternary operator replaces if statement
        }
        //6- Write a method to read the age of a candidate and determine whether they can vote. 
        //Hint: use Parse()... or the safer TryParse() for an extra challenge!!
        static string VoteValidator(int age) // method with one param
        { 
            if(age <= 100 && age >= 18 ) // check if age valid by age number
            {
              return $"{age} can vote!!!"; // print message
            }
            else if(age <= 2002 && age >= 1920) // check if age valid by age birth date
            {
            int res = 2020 - age;  // assign age  to current Year - bith Year
              return $"{res} can Vote!!"; // print message
            }
            else if(age < 18 || age > 2002) // if age less then 18 by age number/Year birth
            {
              return $"{age} is Not Voteing age!!"; // print message
            }
            else
            {
              return $"{age} wish you long helthy life!!"; // brint message wish long helthy life!!
            }
        }
        // Heatin Up:
        // 1- Write a method to check if an integer (from the user) is in the range -10 to 10.
        static void  Range(int rng) // method with one param
        {   // Ternary operator replaces if statement
            string result = rng < -10 ? $"{rng} Not In Range!!" : rng <= 10 ? 
            $"{rng} in Range!" : "Not In Range!!";
            Console.WriteLine(result); // print message
        } 
        // 2- Write a method to display the multiplication table(from 1 to 12) of a given integer.
        static void Multibly(int startIdx, int endIdx) // method with 2 parmas
        {
            int sum = 1; // sum  initialized 
            for(int i = startIdx; i < endIdx; i++) // loop 
            {
              sum *= i; //  accumulating  / sum = sum * i to 
            }
            Console.WriteLine($" The result of multiplication is {sum}"); // print sum of multiplication
        }
        //3- Write a method that takes a number from the user and returns an array with that many indexes.
        // The indexes shall be random numbers.
        static void RandomIndex(int random) // method with number
        {
            int[] arrWanted = new int[random]; // create new array the size will assigned by user
            Random rand = new Random();  // new random 
            for (int i = 0; i < random; i++) // loop 
            {
                arrWanted[i] = rand.Next(100); // assign the random number to the empty array and increment by one
            }
            foreach(int numb in arrWanted) // foreach to show the array content
            {
                
                Console.WriteLine(numb); // print random number
            }
        }
        // 4- Write a method to compute the sum of all the elements in an array of integers.
        static void Compute(int arrSiz)
        {
            int[] arrSize = new int[arrSiz]; // create new array the size will assigned by user
            int sum = 0;
            for (int i = 0; i < arrSiz; i++) // loop 
            {
                arrSize[i] = i + 1 ; // assign the number to the empty array and increment by one
                sum += arrSize[i]; // we can short cut by this to save one loop throw the arrSize!**
            }
            Console.WriteLine(sum); // print the sum!
        }
        // 5-Write a method to display the cube of the number up to given an integer.    
        //(If a user inputs the number 3 the method should print to the console: 
        //Number is: 1 and the cube of 1 is: 1, 
        //Number is: 2 and the cube of 2 is: 8, 
        //Number is: 3 and the cube of 3 is:27)
        static void Cuber(int arg)
        {
            for(int i = 1; i <= arg; i++)
            {
                int cube = i * i * i; // find the cube of the current index
                Console.WriteLine($"Number is: {i} and the cube of {i} is: {cube} "); //print the message
            }
        }
    }
}