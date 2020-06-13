using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;

//Testing creating and displaying arrays
namespace Arrays
{

    class Program
    {
        static void Main(string[] args)
        {

          //  Displays length of array. Output: 5
             
             int[] Numbers = { 1, 2, 3, 4, 5 };

            int lengthofNumbers = Numbers.Length;

            Console.WriteLine(lengthofNumbers);

            //Create string array. Assign values. Call 3rd index. Output: Night Wolf
            string[] Names = new string[4];

            Names[0] = "Sub-Zero";
            Names[1] = "Scorpion";
            Names[2] = "Shao Khan";
            Names[3] = "Night Wolf";

            Console.WriteLine(Names[3]);




            //Create string array. Assign Values. Display all values in array. Output: all names
            string[] Names_2 = new string[4];
            Names[0] = "Sub-Zero";
            Names[1] = "Scorpion";
            Names[2] = "Shao Khan";
            Names[3] = "Night Wolf";

            // Alternatively if you don't want to display the entire array: for(int i = 0; i < 2; i++)
            for (int i = 0; i < Names.Length; i++)
            {
                Console.WriteLine(Names_2[i] + ", ");
            }


            //Same as above but with easier syntax using foreach loop
            //Drawback cannot change data in the array when calling it
            string[] Names_3 = new string[4];
            Names[0] = "Sub-Zero";
            Names[1] = "Scorpion";
            Names[2] = "Shao Khan";
            Names[3] = "Night Wolf";

            foreach (string _Name in Names_3)
            {
                Console.WriteLine(_Name + ", ");
            }


            //Same as above. 
            string[] Names_4 = new string[8]
            { "Sub-Zero", "Scorpion","Shao Khan","Night Wolf","Kitana","Cyrax","Rain","Johnny Cage"};

            foreach (string _Name in Names_4)
            {
                Console.WriteLine(_Name);
            }



            //Creating a list

            List<int> numbers = new List<int>();
            numbers.Add(13);
            numbers.Add(4);
            numbers.Add(8);

            //Displaying data at index position in list

            Console.WriteLine(numbers[1]);

            //for loop displaying data in list

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i] + ", ");
            }


            //Removing data from the list at index position

            numbers.RemoveAt(0);

            //for loop again displaying data in list

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i] + ", ");
            }





            CreateGrid();

        }


        //Creating Multi-Dimensional Arrays  (don't forget to call your method ^)

        //Used a lot in creating games as you can see from the cool shapes this can be used to create
        //Side note - int[][] grid = new int[width][height] would be a jagged array. 

        public static void CreateGrid()
        {
            int width = 10;
            int height = 20;


            //1 comma = 2 dimensional, 2 coma = 3 dimensional etc..
            //alternatively you can write: int[,] grid = new int[5, 5]; instead of specifying variables width and height above

            int[,] grid = new int[width, height];
            //just says at position 2, 3 place number 3. Here to show you can place things
            grid[2, 3] = 3;

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    grid[x, y] = x + y;
                    //important this is "write" not "writeline" bc 
                    Console.Write(grid[x, y] + ", ");
                }

                Console.WriteLine();

            }


        }


    }
}
