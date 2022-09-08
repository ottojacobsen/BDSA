namespace test;

public class LeapYearTest
{
    [Fact]
    public void isDivisibleBy4()
    {

        var leap = new LeapYear();

        var result = leap.isLeapYear(1600);

        result.Should().Be(true);
    }

    [Fact]
    public void isDivisibleBy100()
    {

        var leap = new LeapYear();

        var result = leap.isLeapYear(1700);

        result.Should().Be(false);
    }

    [Fact]
    public void isDivisibleBy400()
    {

        var leap = new LeapYear();

        var result = leap.isLeapYear(1640);

        result.Should().Be(true);
    }

    [Fact]
    public void Main_when_run_prints_nay()
    {
        var leap = new LeapYear();

        var result = leap.printLeapYear(1700);

        result.Should().Be("nay");
    }

    [Fact]
    public void Main_when_run_prints_yay()
    {
        var leap = new LeapYear();

        var result = leap.printLeapYear(1600);

        result.Should().Be("yay");
    }

    [Fact]
    public void main_when_run_fails_because_int_less_than_1582()
    {
        // Given
        var leap = new LeapYear();
        // When
        var result = leap.printLeapYear(1500);
        // Then
        result.Should().Be("nay");
    }
}