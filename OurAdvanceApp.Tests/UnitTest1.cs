namespace OurAdvanceApp.Tests;

public class UnitTest1
{
    [Fact]
    public void TestCube()
    {

        int input=5;
        int expectedValue=125;
        int result=Program.Cube(input);
        Assert.Equal(expectedValue,result);
    }
}