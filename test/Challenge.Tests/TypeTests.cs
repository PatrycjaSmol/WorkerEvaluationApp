using System;
using Xunit;

namespace Challenge.Tests;
public class TypeTests
{
    public delegate string WriteMessage(string message);
    int counter = 0;

    [Fact]
    public void WriteMessegeDelegate()
    {
        WriteMessage del; // deklaracja delegatu

        del = ReturnMessage; //podpiecie delegatu
        del += ReturnMessage;
        del += ReturnSecondMessage;

        var result = del("Hello"); //wywolanie metody za pomoca delegatu//act

        Assert.Equal(3, counter);
    }

    string ReturnMessage(string message)
    {
        counter ++;
        return message;
    }

     string ReturnSecondMessage(string message)
    {
        counter++;
        return message;
    }

    [Fact]
    
    public void GetEmployeeDifferentObjects()
    {
        var emp1 = new Employee("Patka");
        var emp2 = new Employee("Nala");

        Assert.NotEqual(emp1,emp2);
    }
}