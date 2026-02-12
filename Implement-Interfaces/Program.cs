namespace Implement_Interfaces;

public class Program
{
    static void Main(string[] args)
    {
        IPerson student = new Student { Name = "Muhammad Irfan", Age = 22};
        IPerson teacher = new Teacher { Name = "Kayla Lewis", Age = 35};

        student.DisplayInfo();
        teacher.DisplayInfo();
    }
}