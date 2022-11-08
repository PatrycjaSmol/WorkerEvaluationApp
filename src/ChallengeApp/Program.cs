using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var employee = new Employee("Adam");
        employee.GradeAdded += OnWeakGradeAdded;

        EnterGrade(employee);

        PrintStatistics(employee);
    }

    private static void PrintStatistics(Employee employee)
    {
        var stat = employee.GetStatistics();

        Console.WriteLine($"High: {stat.High:N1}");
        Console.WriteLine($"Low: {stat.Low}");
        Console.WriteLine($"Average: {stat.Average}");
        Console.WriteLine($"Letter: {stat.Letter}");
    }

    private static void EnterGrade(Employee employee)
    {
        while (true)
        {
            Console.WriteLine($"Hello! Enter grade for employee {employee.Name}. If you want stop the program please enter q. ");
            var input = Console.ReadLine();

            if (input == "q")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            if (input == null)
            {
                Console.WriteLine("Input grade do not be null.");
                continue;
            }

            var grade = double.Parse(input); //TryParse? 
            employee.AddGrade(grade);

        }
    }

    static void OnWeakGradeAdded(object sender, EventArgs args)
    {
        Console.WriteLine("Grade under 3 - it is bad for year evaluation.");
    }
}