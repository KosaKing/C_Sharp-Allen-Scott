using System;

namespace GradeBook 
/* chcę jako interfejs zainicjowac czystą abstrakcje, chcę żeby wszysci wiedzieli co Ibook może zrobić
chcę abstrakcyjnie zdefiniować members, którzy będą dostępni co implementuje ten interfejs, a pokaże Ci 
jak zaimplementować ten interfejs.  */
{
public interface IBook /* jeżeli korzystamy z interface type nazwę zaczynamy od "I" */
{
    void AddGrade(double grade); /* nie używam public ponieważ zakładam że każdy obiekt który implementuje 
    ten interface musi mieć dostępny elemnt AddGrade. Aby obiekt musiał udostępnić tą metodę.  */
    Statistics GetStatistics();
    string Name {get; }
    event GradeAddedDelegat GradeAdded;     


}
}
