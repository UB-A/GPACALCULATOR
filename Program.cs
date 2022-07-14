using System;

namespace GpaCalculator
{
    public class Program
    {       
        static void Main(string[] args)
        {
           Console.Write("GPA Calculator\n");
           int creditUnite = 0;
           int totalCreditUnit = 0;

           char grade = 'A';
           int total = 0;

           int counter = 0;
           double GPA = 0;
           int gradePoint = 0;
           bool moreCoursesToRecord = true;

           do
           {
               Console.Write("Enter grade for module #{0}(press 0 to exit): ", counter +=1);
               // write some code to prevent user from entering more than 10:
               char userInput = char.Parse(Console.ReadLine());

               if (userInput == '0')
               {
                   break;
               }
               else
               {
                   grade = userInput;
                    // assing value for userInput into gradePoint:
                    Console.Write("Enter credit unit(s) for course: ");
                    creditUnite = int.Parse(Console.ReadLine());

                    switch (char.ToUpper(grade))
                    {
                        case 'A': gradePoint = 5;
                            break;
                        case 'B': gradePoint = 4;
                            break;
                        case 'C': gradePoint = 3;
                            break;
                        case 'D': gradePoint = 2;
                            break;
                         case 'E': gradePoint = 1;
                            break;
                    }

                    total += creditUnite * gradePoint;
                    totalCreditUnit += creditUnite;
                    gradePoint = 0;
               }
           }
           while(moreCoursesToRecord); 
            GPA = total / totalCreditUnit;
            Console.Write("Your GPA this semester is {0:F2}", GPA);
            Console.ReadKey();
           
        }
    }
}
            

