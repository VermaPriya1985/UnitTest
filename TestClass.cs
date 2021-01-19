using Xunit;
using UnitTest;
public class TestClass
{
    [Fact]
    public void PassingCase1()
    {
        Assert.Equal(700,Program.Case1(1234,100,300));
    } 
    [Fact]
    public void PassingCase2()
    {
        Assert.Equal(9800,Program.Case2(2001,35000,5000,12500,300));
    }
    [Fact]
    public void PassingCase3FirstAccount()
    {
        Assert.Equal(1497.60,Program.Case3FirstAccount(1010,7425,7300,13726));
    }
    [Fact]
    public void PassingCase3SecondAccount()
    {
        Assert.Equal(17300,Program.Case3SecondAccount(5500,15000,5000,7300));
    }
    [Fact]
    public void PassingCase4FirstAccount()
    {
        Assert.Equal(33.75,Program.Case4FirstAccount(0123,150,70,23.75));
    }
    [Fact]
    public void PassingCase4SecondAccount()
    {
        Assert.Equal(112554.25,Program.Case4SecondAccount(0456,65000,23.75,23789));
    }
    [Fact]
    public void PassingCase5()
    {
        Assert.Equal(7425,Program.Case5(1010,7425,100));
    } 
}