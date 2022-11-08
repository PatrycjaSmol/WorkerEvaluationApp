
using System;
using Xunit;

namespace Challenge.Tests;

public class EmployeeTests
{
    [Fact]
    public void Test1()
    {
        //arrange
        var emp = new Employee("Rysiek");
        emp.AddGrade(11);
        emp.AddGrade(22);
        emp.AddGrade(49);

        //act
        var result = emp.GetStatistics();

        //assert

        Assert.NotEqual(41, result.Average);
        Assert.Equal(11, result.Low);
        Assert.Equal(49, result.High);

    }
}