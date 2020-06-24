using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1- user input for start and end!
            Console.WriteLine("1- Please insert from hint 1000!");
            int from = int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert to hint -1000!");
            int to = int.Parse(Console.ReadLine());
            // call the methos to print from to
            Printer(from, to);

            // 2- user input 
            Console.WriteLine("2- Please insert start number hint 3!");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert end number hint 999!");
            int end = int.Parse(Console.ReadLine());
            //  call the methos to print from to
            PrintThree(start, end);

            // 3- user input
            Console.WriteLine("3- Please insert array size: ");
            int arrSize = int.Parse(Console.ReadLine());
            // call the method to print from to
            IndexR(arrSize);
             
            // 4- user input
            Console.WriteLine("4- Please insert a Number to check if it Odd or Even: ");
            int numberIs = int.Parse(Console.ReadLine());
            // call the method
            string evenOrOdd = CheckNum(numberIs);
            Console.WriteLine(evenOrOdd);
            
            // 5- user input
            Console.WriteLine("5- Please insert a Number to check if it Pos Or Neg: ");
            int nmbrIs = int.Parse(Console.ReadLine());
            // call the method
            string posOr = PosOrNeg(nmbrIs);
            Console.WriteLine(posOr);
            
            // 6- user input
            Console.WriteLine("6- Please insert your Age or Year you Born to check if you can vote: ");
            int ageToVote = int.Parse(Console.ReadLine());
            // call the method
            string ageVote = VoteValidator(ageToVote);
            Console.WriteLine(ageVote);

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
        //3- Write a method that takes a number from the user and returns an array with that many indexes. The indexes shall be random numbers.

        static void IndexR(int size) // method with one param
        {
            int[] returned = new int[size]; // create new array the size will assigned by user
            for (int i = 0; i < size; i++) // loop 
            {
                returned[i] = i + 1; // assign the number to the empty array and increment by one
            }
            foreach(int numb in returned) // foreach to show the array content
                {
                Console.WriteLine(numb); // print the numbers in the array
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
        

    }
}
