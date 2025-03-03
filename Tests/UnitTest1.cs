using Scraper;

namespace Tests;

public class Tests
{
    [Test]
    public void Test1()
    {
        var class1 = new Class1();
        Assert.That(class1.SayHello(), Is.EqualTo("Hello!"));
    }
}