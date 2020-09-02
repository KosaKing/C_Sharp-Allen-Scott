using System;
using System.Collections.Generic;

namespace GradeBook /* Przestrzeń nazw GradeBook */
{
    class Program /* Co to jest ???????? */
    {
        static void Main(string[] args)  /* Co to jest ???????? */
        {
            Console.WriteLine("Podaj ocenę, jeśli chcesz zakończyć działanie programu wciśnij Q:");

            var book = new Book("Hi"); /* nowa zmienna przypisana do klasy Book, jednocześnie puste nawiasy 
            powodują wywołanie metody tzw konstruktora, idea konstruktora polega na tym że konstruuje obiekty typu 
            Book lub typu list. Nie musimy pisać metody konstrkutora, ale jeśli się zdecyduje mogę przejąć całkowitą 
            kontrolę nad inicjalizacją obiektu produkowanego przez moją klasę */
         
book.GradeAdded += OneGradeAdd;

           for(var w = 0;w > -1; w++)
           {
            var input = Console.ReadLine();            
            if(input == "q")
            {
                break;
            }
            try
            {
            var transcript = double.Parse(input);           
            book.AddGrade(transcript);
            }
            catch(ArgumentException exep)
            {
                Console.WriteLine(exep.Message);
            }
            
            catch(FormatException exep)
            {
                Console.WriteLine(exep.Message);
            }

            finally
            {
                Console.WriteLine("* *");
            }

           }
    


           



                var stats = book.GetStatistics(); /* Jest to równe wartości zwracanej przez Getstatiscitcs  */
                
                
            Console.WriteLine($"The highest grade {stats.High}");
            Console.WriteLine($"The lowest grade {stats.Low}");
            Console.WriteLine($"Average of all grades {stats.Average}");
            Console.WriteLine($"U get  {stats.Grade} grade");
            


        }
        static void OneGradeAdd(object sender, EventArgs e)
        {
            Console.WriteLine("A grade was added");
        }
    }
}
/* 
1. wpisuje oceny z konsoli 
 */
