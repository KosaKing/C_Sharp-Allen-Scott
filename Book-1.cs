using System;
using System.Collections.Generic;

namespace GradeBook /*przestrzeń nazw pozwala na wykorzystanie tych samych np klas w tej samej przestrzeni nazw */
{
    public class Book /* definicja klasy Book */
    {
        public Book(string v)
        {
            grades = new List<double>();
        }
        public void AddGrade(double grade) /* Metoda która nie zwraca żadnych wartości nazywa się Addgrade i 
        a w nawiasach jest liczba parametrów a nazwa mojego parametru będzie grade */
        {
            grades.Add(grade);/* w nawiasach {} znajduje się realizacja klasy */
            /* istnieje wiele sposobów dodawania stanu do definicji klasy, popularną metodą jest dodanie definicji
            zwanej definicją pola */ 
            /* jeżeli wstawimy zmienną do metody to jest to zmienna lokalna i ona jest tylko dostępna w metodzie */
        }
        
      public Statistics GetStatistics()
      {
          var all = new Statistics();
          all.Average = 0.0;
          all.High = double.MinValue;
          all.Low = double.MaxValue;
           
           
            foreach (var grade in grades)
            {
            /* Tworzę zmienną która będzie przechowywać wartość każdego elementu znajdującego się w kolekcji którą iteruje 
i powiedzieć - foreach - że ta wartość będzie działała na wartościach numbers - czyli sumuje wszystkie wartości
z tablicy numbers i umieszczam je w zmiennej grade za pomocą powyższej funkcji*/     
                all.Average += grade;
                all.High = Math.Max(grade, all.High);
                all.Low = Math.Min(grade, all.Low);
            }
            all.Average/=grades.Count;
            return all;

        
      }

private List<double> grades; /* zmienna która jest dostępna dla typu Book do końca jego istnienia wtedy już nie jest
        zmienną tylko jest polem, listy nie mamy dodanej w tej klasie więc aby jej użyć musimy dodać dostęp 
        do biblioteki z listą "powyżej dodana" */
        /* Wszystkie metody które są w klasie Book, będą miały dostęp do pola klasy "grades" i będą mogły wchodzić 
        w interakcje z nim */
      
      /* Pytanie jak zainicjalizować grades, są dwie opcje jedna to 
      => List<double> grades = new List<double>; 
      => metoda konstruktora 
      public Book()
        {
            grades = new List<double>();
        }
      */ 

    }
}
