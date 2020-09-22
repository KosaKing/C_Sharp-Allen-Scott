using System;
namespace GradeBook
{
  /* chcę(newobject) tego użyc jako bazowej klasy, dla wszystkich innych klas w tym Book class */
public class NewObject
{
        public NewObject(string name) /* utowrzyć konstruktor inny niż domyślny który wymaga parametru nazwy */
        {
          Name = name; 

        }

        public string Name
  {
    get;
    set;
  }
}
}

/*znaczącą różnicą miedzy book i NewObject jest to że book wymaga podania nazwy.  */
