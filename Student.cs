using System.Runtime.ExceptionServices;

internal class Student
{
    public string Name;
    public string SurName;
    public string Group;
    public int Point;
    public bool isGraduated;

    public Student(string name, string surname,string group)
    {
        this.Name = name;
        this.SurName= surname;
        this.Group = group;
    }

    public Student(string name, string surname, string group, int point, bool isGraduated) : this(name, surname,group)
    {
        Point = point;
        this.isGraduated = isGraduated;
    }

    public Student(bool isGraduated)
    {
        this.isGraduated = isGraduated;
    }


    public Student(int point)
    {
        this.Point = point;       
            if (point < 101 && point > 0)
            {
                if (point > 80)
                {
                    Console.WriteLine("Tebrikler!!! Siz imtahanda yeniden istirak ede bilersiniz.");
                }
                else
                {
                    Console.WriteLine("Siz imtahanda yeniden istirak ede bilmersiniz!");
                }
            }
            else
            {
                Console.WriteLine("Zehmet olmasa balinizi duzgun daxil edin!");
            }
    }
}
