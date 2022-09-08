namespace test;

public class LeapYearTest
{
    [Fact]
    public void isDivisibleBy4()
    {

        var leap = new LeapYear();

        var result = leap.isLeapYear(40);

        result.Should().Be(true);
    }

    [Fact]
    public void isDivisibleBy100()
    {

        var leap = new LeapYear();

        var result = leap.isLeapYear(100);

        result.Should().Be(false);
    }

    [Fact]
    public void isDivisibleBy400()
    {

        var leap = new LeapYear();

        var result = leap.isLeapYear(400);

        result.Should().Be(true);
    }

    [Fact]
    public void Main_when_run_prints_nay()
    {
        var leap = new LeapYear();

        var result = leap.printLeapYear(300);

        result.Should().Be("nay");
    }

    [Fact]
    public void Main_when_run_prints_yay()
    {
        var leap = new LeapYear();

        var result = leap.printLeapYear(400);

        result.Should().Be("yay");
    }
}