namespace Implement_Interfaces;

public class PersonUtilities
{
    public static void PrintPersonDetails(IPerson person)
    {
        person.DisplayInfo();
        person.Greet();
    }
}
