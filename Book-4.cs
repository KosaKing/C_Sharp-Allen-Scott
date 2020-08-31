using System;
using System.Collections.Generic;

namespace GradeBook /*przestrzeń nazw pozwala na wykorzystanie tych samych np klas w tej samej przestrzeni nazw */
{
    public class Book /* definicja klasy Book */
    {
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }

        public void Addletter(char letter)
        {
          switch(letter)
          {
          case 'A': 
          AddGrade(90);
          break;
          
          case 'B': 
          AddGrade(80);
          break;
          
          case 'C': 
          AddGrade(70);
          break;

          default:
          AddGrade(0);
          break;

          }

        }



        public void AddGrade(double grade) /* Metoda która nie zwraca żadnych wartości nazywa się Addgrade i 
        a w nawiasach jest liczba parametrów a nazwa mojego parametru będzie grade */
        {
          if(100 > grade && grade >= 0)
          {
            grades.Add(grade);/* w nawiasach {} znajduje się realizacja klasy */
            /* istnieje wiele sposobów dodawania stanu do definicji klasy, popularną metodą jest dodanie definicji
            zwanej definicją pola */ 
            /* jeżeli wstawimy zmienną do metody to jest to zmienna lokalna i ona jest tylko dostępna w metodzie */
          }
          else
          {
              Console.WriteLine("Niepoprawna wartość podaj poprawną:");
              throw new ArgumentException($"Invalid{nameof(grade)}");
          }
        }
        
      public Statistics GetStatistics()
      {
          var all = new Statistics();
          all.Average = 0.0;
          all.High = double.MinValue;
          all.Low = double.MaxValue;
           
           var index=0;
            while(index < grades.Count)
            {
            /* Tworzę zmienną która będzie przechowywać wartość każdego elementu znajdującego się w kolekcji którą iteruje 
i powiedzieć - foreach - że ta wartość będzie działała na wartościach numbers - czyli sumuje wszystkie wartości
z tablicy numbers i umieszczam je w zmiennej grade za pomocą powyższej funkcji*/     
                all.Average += grades[index];
                all.High = Math.Max(grades[index], all.High);
                all.Low = Math.Min(grades[index], all.Low);
                index += 1;
            };

            
            all.Average/=grades.Count;
            
            switch(all.Average)
            {
              case var d when d >= 90:
              all.Grade = 'A';
              break;
              
              case var d when d >= 80:
              all.Grade = 'B';
              break;
              
              case var d when d >= 70:
              all.Grade = 'C';
              break;
              
              case var d when d >= 60:
              all.Grade = 'D';
              break;

              default:
              all.Grade = 'F';
              break;
            }

            return all;

        
      }

public string Name; 
public List<double> grades; /* zmienna która jest dostępna dla typu Book do końca jego istnienia wtedy już nie jest
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
