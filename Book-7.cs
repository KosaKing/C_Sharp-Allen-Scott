using System;
using System.Collections.Generic;

namespace GradeBook /*przestrzeń nazw pozwala na wykorzystanie tych samych np klas w tej samej przestrzeni nazw */
{




  public delegate void GradeAddedDelegat(object something, EventArgs args);


    public class InMemoryBook : Book /* przypisujemy do klasy klase bazową książka jest tzw - name object - 
    książka przechoowuje dane w pamięci */
    {
        public InMemoryBook(string name) : base(name)
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
        public override event GradeAddedDelegat GradeAdded;



        public override void AddGrade(double grade) /* Metoda która nie zwraca żadnych wartości nazywa się Addgrade i 
        a w nawiasach jest liczba parametrów a nazwa mojego parametru będzie grade */
        {
          if(100 > grade && grade >= 0)
          {
            grades.Add(grade);/* w nawiasach {} znajduje się realizacja klasy */
            /* istnieje wiele sposobów dodawania stanu do definicji klasy, popularną metodą jest dodanie definicji
            zwanej definicją pola */ 
            /* jeżeli wstawimy zmienną do metody to jest to zmienna lokalna i ona jest tylko dostępna w metodzie */
          if(GradeAdded != null)
          {
            GradeAdded(this, new EventArgs());
          }
          }
          else
          {
              Console.WriteLine("Niepoprawna wartość podaj poprawną:");
              throw new ArgumentException($"Invalid{nameof(grade)}");
          }
        }
        
      public override Statistics GetStatistics()
      {
          var all = new Statistics();
           
           var index=0;
            while(index < grades.Count)
            {
            /* Tworzę zmienną która będzie przechowywać wartość każdego elementu znajdującego się w kolekcji którą iteruje 
i powiedzieć - foreach - że ta wartość będzie działała na wartościach numbers - czyli sumuje wszystkie wartości
z tablicy numbers i umieszczam je w zmiennej grade za pomocą powyższej funkcji*/     
                all.Add(grades[index]);
                index += 1;
            };

            
            
            

            return all;

        
      }


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

      readonly string category = "Science"; 


    }
}
