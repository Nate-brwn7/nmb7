 using System;
 using System.Diagnostics;
using System.Globalization;

class Program
{
    static void Main()
    {
        int n = 7000000; // number of random numbers to generate
        double[,] numbers;
        int[,] numberI;
        Stopwatch timer = new Stopwatch();

        numbers = GenRandomNumbers(n);
        numberI = GenRandomNumbersI(n);

        timer.Start();
        AddNumbersI(numberI, n);
        timer.Stop();
        Console.WriteLine("Additions");
        Console.WriteLine("Elapsed time = " +
        timer.ElapsedMilliseconds + " ms " +
        timer.ElapsedTicks + " ticks\n");
        float addTicks = (float)timer.ElapsedTicks;

        timer.Restart();
        MultNumbers(numberI, n);
        timer.Stop();
        Console.WriteLine("Multiplications");
        Console.WriteLine("Elapsed time = " +
        timer.ElapsedMilliseconds + " ms " +
        timer.ElapsedTicks + " ticks\n");
        float multTicks = (float)timer.ElapsedTicks;
        timer.Restart();
        AddNumbers(numbers, n);
        timer.Stop();
        Console.WriteLine("Double Addition");
        Console.WriteLine("Elapsed time = " +
        timer.ElapsedMilliseconds + " ms " +
        timer.ElapsedTicks + " ticks\n");
        float addTicks2 = (float)timer.ElapsedTicks;

        timer.Restart();
        MultiplyNumbers(numbers, n);
        timer.Stop();

        Console.WriteLine("Double Multiplication");
        Console.WriteLine("Elapsed time = " +
        timer.ElapsedMilliseconds + " ms " +
        timer.ElapsedTicks + " ticks\n");
        float addTicks3 = (float)timer.ElapsedTicks;

        timer.Restart();
        SquareMNumbers(numbers, n);
        timer.Stop();

        Console.WriteLine("Square by Multiplication");
        Console.WriteLine("Elapsed time = " +
        timer.ElapsedMilliseconds + " ms " +
        timer.ElapsedTicks + " ticks\n");
        float addTicks4 = (float)timer.ElapsedTicks;

        timer.Restart();
        SquarePOWNumbers(numbers, n);
        timer.Stop();

        Console.WriteLine("Square by Math.Pow");
        Console.WriteLine("Elapsed time = " +
        timer.ElapsedMilliseconds + " ms " +
        timer.ElapsedTicks + " ticks\n");
        float addTicks5 = (float)timer.ElapsedTicks;

        timer.Restart();
        SquareRTNumbers(numbers, n);
        timer.Stop();

        Console.WriteLine("Square Root by Math.Sqrt");
        Console.WriteLine("Elapsed time = " +
        timer.ElapsedMilliseconds + " ms " +
        timer.ElapsedTicks + " ticks\n");
        float addTicks6 = (float)timer.ElapsedTicks;


    }


// Function to generate an integer array-------
    static int[,] GenRandomNumbersI(int count)
    {
        Random rand = new Random(); // instantiate random number generator
        int[,] num = new int[count,3]; // make array
        for(int i=0; i<count; ++i){
            num[i,0] = (int)(10000.0 *rand.NextInt64()); // fill in elements of array
            num[i,1] = (int)(10000.0 *rand.NextInt64());
        }

        return num; // returns reference to array
    }


   static void AddNumbersI(int[,] nums, int count)
 {
        int i;
        for(i=0; i<count; ++i){
            nums[i,2] = nums[i,0] + nums[i,1];
        }
    }

   static void MultNumbers(int[,] nums, int count)
 {
        int i;
        for(i=0; i<count; ++i){
            nums[i,2] = nums[i,0] * nums[i,1];
        }
    }

  // Function to generate an array of random numbers
     static double[,] GenRandomNumbers(int count)
    {
         Random rand = new Random(); // instantiate random number generator
         double[,] num = new double[count,3]; // make array
         for(int i=0; i<count; ++i){
             num[i,0] = 10000.0*rand.NextDouble(); // fill in elements of array
             num[i,1] = 10000.0*rand.NextDouble();
        }

         return num; // returns reference to array
     }


 // Function that adds numbers in the supplied 2d array
     static void AddNumbers(double[,] nums, int count)
  {
         int i;
         for(i=0; i<count; ++i){
             nums[i,2] = nums[i,0] + nums[i,1];
         }
     }

  // Function that adds numbers in the supplied 2d array
     static void MultiplyNumbers(double[,] nums, int count)
     {
         int i;
         for(i=0; i<count; ++i){
             nums[i,2] = nums[i,0] * nums[i,1];
         }
     }


     static void SquareMNumbers(double[,] nums, int count)
     {
         int i;
         for(i=0; i<count; ++i){
             nums[i,2] = nums[i,0] * nums[i,0];
         }
     }

    static void SquarePOWNumbers(double[,] nums, int count)
     {
         int i;
         for(i=0; i<count; ++i){
             nums[i,2] = Math.Pow(nums[i,0], 2);
         }
     }

     static void SquareRTNumbers(double[,] nums, int count)
     {
         int i;
         for(i=0; i<count; ++i){
             nums[i,2] = Math.Sqrt(nums[i,0]);
         }
     }

}