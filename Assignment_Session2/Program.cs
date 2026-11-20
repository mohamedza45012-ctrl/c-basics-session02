using System;
using System.Diagnostics.CodeAnalysis;

namespace Assignment_Session2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          #region Q01
           Object Ob = new Book();
           Console.WriteLine(Ob);
          #endregion
         
          #region Q02
            Console.WriteLine(Ob.ToString());
            Console.WriteLine(Ob.Equals(Ob));
            Console.WriteLine(Ob.GetHashCode());
            Console.WriteLine(Ob.GetType());
          #endregion

          #region Q03 
             // 
            /* int Puges = "464"; 
               Compile_Time Error: Cannot implicitly convert type string to int */
             int Puges = 464; // Error Fix
             Console.WriteLine(Puges);
          #endregion

          #region Q04
                try
                {
                    int number = 10;
                    int zero = 0;
                    Console.WriteLine(number / zero);
                }
                catch(Exception)
                {
                    Console.WriteLine("Cannot divide by zero");
                }
                finally
                {
                    Console.WriteLine("Done");
                }
           #endregion
          
          #region Q05  
           int pages1 = 300;
           double impResult = pages1;
           Console.WriteLine(impResult);
          #endregion
         
          #region Q06
           double price = 49.99; 
           int expResult = (int) price;
           Console.WriteLine(expResult); // 49
          #endregion

          #region Q07
            string pagesText = "464";
            int conResult = Convert.ToInt32(pagesText);
            Console.WriteLine(conResult);
          #endregion

          #region Q08
           string yearText = "2023";
           int yearNumber = int.Parse(yearText);
           Console.WriteLine(yearNumber);

           string badText = "abc";
           int parsedNumber = 0;
           if(int.TryParse(badText, out parsedNumber))
            Console.WriteLine(parsedNumber);
           else
            Console.WriteLine("Invalid Number");
           
          #endregion

          #region Q09
           int pages = 464;
           string pagesString = pages.ToString();
           Console.WriteLine(pagesString);
           Console.WriteLine(pagesString.GetType());
          #endregion

          #region Q10
           int copies = 100;
           object obj = copies;// Boxing
           int unboxedInt = (int)obj; // Unboxing
           Console.WriteLine($" Copies {copies}");
           Console.WriteLine($" Unboxed {unboxedInt}");
          #endregion

          #region Q11
           int? year = null;
           if(year == null) 
             {
                Console.WriteLine("Empty Value");
             }
                year = 2023;
                Console.WriteLine($"Year : {year}");
          #endregion

          #region Q12
            string? reviewer = null;
            if(reviewer == null)
             Console.WriteLine("Empty Value");
            else 
             Console.WriteLine("The value is not empty");
          #endregion

          #region Q13 % Q14
            Book? book = null;
            string? title = book?.Title;

            Console.WriteLine(book?.Title);
            Console.WriteLine(title?? "Untitled"); 
            title??= "Untitled";
            Console.WriteLine(title);
          #endregion

          #region Q15
           string name = "Ahmed";
           string confirmedName = name!;
           Console.WriteLine(confirmedName);
          #endregion
        }
    }
}