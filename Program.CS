using System;
using System.Collections.Generic;

namespace GradeBook /* Przestrzeń nazw GradeBook */
{
    class Program /* Co to jest ???????? */
    {
        static void Main(string[] args)  /* Co to jest ???????? */
        {



            var book = new Book("Hi"); /* nowa zmienna przypisana do klasy Book, jednocześnie puste nawiasy 
            powodują wywołanie metody tzw konstruktora, idea konstruktora polega na tym że konstruuje obiekty typu 
            Book lub typu list. Nie musimy pisać metody konstrkutora, ale jeśli się zdecyduje mogę przejąć całkowitą 
            kontrolę nad inicjalizacją obiektu produkowanego przez moją klasę */
            book.AddGrade(55.3); /* korzystamy z metody która jest dodana do klasy Book */
            book.AddGrade(22.3);



            var grades = new List<double>() {3.14, 32.3, 123, 23.1}; 
            /*tworzymy zmienną lokalną grade która zainicjowaliśmy żeby wskazywała na nowo powstałą listę 
            liczb zmienno przecinkowych */
            grades.Add(89.1); /* to jest metoda klasy/typu list */
            var all=0.0;
            var highGrade = double.MinValue;
            var MinValuee = double.MaxValue;
           
           
            foreach (var number in grades)
            {
            /* Tworzę zmienną która będzie przechowywać wartość każdego elementu znajdującego się w kolekcji którą iteruje 
i powiedzieć - foreach - że ta wartość będzie działała na wartościach numbers - czyli sumuje wszystkie wartości
z tablicy numbers i umieszczam je w zmiennej number za pomocą powyższej funkcji*/     
                if(highGrade < number)
                {
                    highGrade = number;
                }

                
                if(MinValuee > number)
                {
                    MinValuee = number;
                }
                all += number;
            }
            

                var stats = book.GetStatistics(); /* Jest to równe wartości zwracanej przez Getstatiscitcs  */
                
            Console.WriteLine($"The highest value {stats.High}");
            Console.WriteLine($"The lowest value {stats.Low}");
            Console.WriteLine($"All grades {stats.Average}");
            stats.Average/=grades.Count;


            
            Console.WriteLine($"Average value {stats.Average}");


        }
    }
}
