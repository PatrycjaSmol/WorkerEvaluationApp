


using static Person;

public class Employee : EmployeeBase
{
public delegate void GradeAddedDelegate(object sender, EventArgs args); 
public event GradeAddedDelegate GradeAdded; 

private List<double> grades = new List<double>();

    public Employee(string name) : base(name)
    {
         this.Name = name;
    }

    public void AddGrade(int inputValue)
    {
        if (inputValue <= 0 && inputValue > 6)
        {
            throw new ArgumentOutOfRangeException($"Invalid data {inputValue}. Grade must be a number > 0 and < 6.");
        }
        else
        {
            this.grades.Add(inputValue);

        }
    }

    public override void AddGrade(double grade)
    {
        if(grade > 0 && grade <= 6)
        {
            this.grades.Add(grade);

            if(grade <=3)
            {
                 GradeAdded(this, new EventArgs()); //this bo senderem jest klasa którą uruchamiamy 
            }           
        }
        else
        {
            throw new ArgumentOutOfRangeException($"Invalid data {grade}. Grade must be a number > 0 and < 6.");

        }
    }

    public void AddGrade(string strGrade)
    {

        switch (strGrade)
        {
            case var d when d == "5+":
                grades.Add(5.5);
                break;

            case var d when d == "4+":
                grades.Add(4.5);
                break;

            case var d when d == "3+":
                grades.Add(3.5);
                break;

            case var d when d == "2+":
                grades.Add(2.5);
                break;

            case var d when d == "1+":
                grades.Add(1.5);
                break;

            case var d when d == "5-":
                grades.Add(4.75);
                break;

            case var d when d == "4-":
                grades.Add(3.75);
                break;

            case var d when d == "3-":
                grades.Add(2.75);
                break;

            case var d when d == "2-":
                grades.Add(1.75);
                break;

            case var d when d == "1-":
                grades.Add(0.75);
                break;
        }
    }

    public void ChangeWorkerName(string name, string newName)
    {
        bool result;

        foreach (var l in newName)
        {
            result = char.IsDigit(l);

            if (!result)
            {
                Console.WriteLine("There should be only characters in name.");
            }
        }
    }

    public Statistics GetStatistics()
    {
        var result = new Statistics();
        result.Average = 0.0;
        result.Low = double.MaxValue;
        result.High = double.MinValue;


        for (var index = 0; index < grades.Count; index++)
        {
            result.Low = Math.Min(grades[index], result.Low);
            result.High = Math.Max(grades[index], result.High);
            result.Average += grades[index];
        }

        result.Average /= grades.Count;

        switch (result.Average)
        {
            case var d when d >= 5:
                result.Letter = 'A';
                break;

            case var d when d >= 4:
                result.Letter = 'B';
                break;

            case var d when d >= 3:
                result.Letter = 'C';
                break;

            case var d when d >= 2:
                result.Letter = 'D';
                break;

            default:
                result.Letter = 'F';
                break;
        }

        return result;
    }

    public override void AddGrade(double grade)
    {
        throw new NotImplementedException();
    }
}

