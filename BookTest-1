using System;
using Xunit; /* przestrzenie nazw z jakich korzystamy */


namespace GradeBook.Tests 
{
    public class BookTest /* komenda w cmd - dotnet add reference [i teraz ścieżka dostępu] */
    {
        [Fact] /* fact jest atrybutem czyli małym kawałkiem danych dołączonych do następującego po nim symbolu,
        a więc fact jest małym fragmentem danych dołączonym do metody Test1(), a xunit używa tego atrybutu w taki
        sposób że jak ładuje projekt aby znaleźć testy wewnątrz i wykonać je aby powiedzieć co jest nie tak  
        poszukuje metod które mają ten atrybut factu. Ponieważ mogę mieć np 3 metody wewnątrz klasy ale tylko 
        dwie z nich mogą reprezentować testy jednostkowe  */
        

        /* typowy podział testów jednostkowych jest na 3 części */
        public void Test1()
        {
            /* 1. część aranżacji - gdzie zestawiasz wszystkie dane testowe, układasz obiekty oraz wartości których
            planujesz użyć */
            var book = new Book("");
            book.AddGrade(50.1);
            book.AddGrade(23.3);
            book.AddGrade(77.3);
            /* 2. sekcja aktu - gdzie wywołujesz metodę wykonywania obliczeń, lub przeprowadzania obliczeń, 
            robisz coś co daje wynik */
            var result = book.GetStatistics();

            /* 3. assert section - miejsce gdzie potwierdzasz wartość z sekcji aktu  */
            Assert.Equal(50.2, result.Average, 1);
            Assert.Equal(23.3, result.Low, 1);
            Assert.Equal(77.3, result.High, 1);
            
        }
    }
}
