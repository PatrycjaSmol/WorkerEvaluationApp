public interface IEmployeeBase
{
    void AddGrade(double grade);
    string Name{get; set;}
    string Surname{get; set;}
    int Age {get; set;}
    Statistics GetStatistics();
}
