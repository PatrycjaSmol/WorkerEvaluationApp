public class Person
{
    public string Name {get; set;}
    public string ? Surname{get; set;}

    //public string FullName{get;set;}
    public char WorkerGrade {get; set;}
    public string ? Sex {get; set;}
    public int ? Age {get; set;}
    public string ? Adress{get; set;}
    
    public Person(string name)
    {
        this.Name = name;
             
    }
    public Person(string name, string surname, char workerGrade, string sex, int age, string adress)
    {
        this.Name = name;
        this.Surname = surname;
        this.WorkerGrade = workerGrade;
        this.Sex = sex;
        this.Age = age;
        this.Adress = adress;        
    }

    public class PersonObject
    {
        public PersonObject(string name)
        {
            this.Name = name;

        }
        public string Name {get; set;}
        public int Age {get; set;}
        //public string Sex {get; set;}
    }

    public abstract class EmployeeBase : PersonObject, IEmployeeBase
    {
        public EmployeeBase(string name) : base(name) //jesli jest konstruktor bez parametrowy to trzeba dodac 2 ctor
        {
        }

        public string Surname {get; set;}

        public event Employee.GradeAddedDelegate GradeAdded;

        public abstract void AddGrade(double grade);

        public virtual Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}