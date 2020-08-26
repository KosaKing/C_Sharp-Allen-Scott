using System;
using Xunit; /* przestrzenie nazw z jakich korzystamy */


namespace GradeBook.Tests 
{
    public class TypeTest /* komenda w cmd - dotnet add reference [i teraz ścieżka dostępu] */
    {
        [Fact]
        public void Test1()
        {
            var x = GetIntiger() ; 
            PowerOfx(ref x);
            Assert.Equal(9, x);
        }

        private int GetIntiger()
        {
            return 3;
        }

        private int PowerOfx(ref int z)
        {
            return z = z*z;
        }











        [Fact] 
        
        public void It_can_pass_by_ref()
        {
            var book1 = GetBook("Book 1"); 
            GetNewBookAndSetNameGLOBAL(ref book1 ,"New name"); 
            Assert.Equal("New name", book1.Name);

        }
        /*Tu się dzieje wszystko lokalnie*/   
        private void GetNewBookAndSetNameGLOBAL(ref Book book, string name) 
        /*ref daje dostęp do pracy na prawdziwiej zmiennej a nie na wskaźniku*/ 
        {
            book = new Book(name);
        }



















        [Fact] 
        
        public void Pass_by_value()
        {
            var book1 = GetBook("Book 1"); 
            GetNewBookAndSetName(book1 ,"New name"); /* do metody jest przekazywany wskaźnik do book1 */
            /* Więc nie wpływa to na prawdziwą zmienną tylko na parametr wewnątrz metody */

            Assert.Equal("Book 1", book1.Name);

        }
        /*Tu się dzieje wszystko lokalnie*/   
        private void GetNewBookAndSetName(Book book, string name) 
        {
            book = new Book(name);
            /* w tym wypadku wskaźnik book jest zmieniony na nową lokację do nowego obiektu */
        }











        [Fact] 
        
        public void Set_the_new_name_by_reference() /* Daje mi możliwość zmiany nazwy istniejącego obkietu
        za pomocą metody ktora się odwołuje do nazwy obiektu, dzieje się to poprzez referencje, 
        odniesienie do pierwotnego obiektu */
        {
            var book1 = GetBook("Book 1"); 
            SetName(book1 ,"New name"); /* do metody jest przekazywany wskaźnik do book1 */

            Assert.Equal("New name", book1.Name);
        }

        private void SetName(Book book, string name) /* parametr book jest wskaźnikiem */
        {
            book.Name = name;
        }

        [Fact] /* fact jest atrybutem czyli małym kawałkiem danych dołączonych do następującego po nim symbolu,
        a więc fact jest małym fragmentem danych dołączonym do metody Test1(), a xunit używa tego atrybutu w taki
        sposób że jak ładuje projekt aby znaleźć testy wewnątrz i wykonać je aby powiedzieć co jest nie tak  
        poszukuje metod które mają ten atrybut factu. Ponieważ mogę mieć np 3 metody wewnątrz klasy ale tylko 
        dwie z nich mogą reprezentować testy jednostkowe  */
        

        /* typowy podział testów jednostkowych jest na 3 części */
        public void Get_eturne_new_book_object()
        {
            /* 1. część aranżacji - gdzie zestawiasz wszystkie dane testowe, układasz obiekty oraz wartości których
            planujesz użyć */
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");
            /* 2. sekcja aktu - gdzie wywołujesz metodę wykonywania obliczeń, lub przeprowadzania obliczeń, 
            robisz coś co daje wynik */
            

            /* 3. assert section - miejsce gdzie potwierdzasz wartość z sekcji aktu  */
            Assert.Equal("Book 2", book2.Name);
            Assert.Equal("Book 1", book1.Name);
        }




        [Fact] 
        
        public void Get_eturne_same_book_object()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;

            Assert.Equal("Book 1", book2.Name);
            Assert.Equal("Book 1", book1.Name);
        }





        /*private*/ Book /* Typ powroty */ GetBook(string name)
        {
            return new Book(name);
        }
    }
}
