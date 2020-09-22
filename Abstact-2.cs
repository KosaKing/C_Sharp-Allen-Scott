using System;

namespace GradeBook
{
    public abstract class Book : NewObject, IBook
    {
        protected Book(string name) : base(name)
        {
        }

        public abstract event GradeAddedDelegat GradeAdded; /* abstract klas zmusza klasą pochodną 
        taką jak np diskbook do zapewniena implementacji dla gradeadded i to jest to czego chcę */

        public abstract void AddGrade(double grade);

        public abstract Statistics GetStatistics();
    }
}
