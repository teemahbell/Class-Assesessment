 using System;

namespace AlphaApp
{
    class Program 
    {
        static void Main(string[] args)
        {
          //
           Console.WriteLine("Question 1");
           string word1 = Console.ReadLine();
          Console.WriteLine(word1);
           string word2 = Console.ReadLine();
           Console.WriteLine(word2);

           int lengthofword1 = word1.Length;
           Console.WriteLine(lengthofword1);
           int lengthofword2 = word2.Length;
           Console.WriteLine(lengthofword2);

           int sumofword1andword2 = lengthofword1 + lengthofword2;
           Console.WriteLine (sumofword1andword2);

          int endresult = sumofword1andword2 > 20? sumofword1andword2 * 3: sumofword1andword2 + 20;
          Console.WriteLine(endresult);

          Console.WriteLine("QUESTION 2");
  
        float cp = 0.00f;
         Console.WriteLine("Enter the costprice $");
          cp = float.Parse(Console.ReadLine());
         Console.WriteLine(cp);
         float sp = 0.00f;
         Console.WriteLine("Enter the sellingprice $");
         sp = float.Parse(Console.ReadLine());
          Console.WriteLine(sp);
         Console.WriteLine($"profit = {sp -cp}" );
          //float profit = sp - cp;
         Console.WriteLine(string.Format("profit = ${0:F2}", profit));
          
          Console.WriteLine("Question 3");
            
          string input;
          Console.WriteLine("Enter any word");
          input = Console.ReadLine();
          char[] word = input.ToCharArray();
          Console.WriteLine(word[2]);
          int lengthofword = input.Length;
          int value =  lengthofword + 2;
          Console.WriteLine(value);
          cha r finalresult = (char) value;
          Console.WriteLine(finalresult);

          Console.WriteLine("Question 4");

         double var1 = 0.00;
          double var2 = 0.00;
          var1 = double.Parse(Console.ReadLine());
          var2 = double.Parse(Console.ReadLine());
          double max = (Math.Sqrt(var1*var1 + var2*var2 - 2*var1*var2) + var1 + var2)/ 2;
          Console.WriteLine(max);

          Console.WriteLine("Question 5");

          Console.Write("x =");
          int x = int.Parse(Console.ReadLine());
          int a = 1;
          int     b = 1;
          Console.Write("")*/

          int a,b,c,d,e;
          bool ParseSuceed = false;

          Console.Write("Input the first number");
          parseSuceed = Int32.TryParse(Console.ReadLine());
          Conso le.WriteLine(parseSuceed);
          while (!parseSuceed);

          Console.Write("Input the second number");
          parseSuceed = Int32.TryParse(Console.ReadLine());
          Console.WriteLine(parseSuceed);
          while (!parseSuceed);

          Console.Write("Input the third number");
          parseSuceed = Int32.TryParse(Console.ReadLine());
          Console.WriteLine(parseSuceed);
          while (!parseSuceed);

          Console.Write("Input the fourth number");
          parseSuceed = Int32.TryParse(Console.ReadLine());
          Console.WriteLine(parseSuceed);
          while (!parseSuceed);

          Console.Write("Input the fifth  number");
          parseSuceed = Int32.TryParse(Console.ReadLine());
          Console.WriteLine(parseSuceed);
          while (!parseSuceed);
 



        }
    }
}
