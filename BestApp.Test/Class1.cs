using NUnit.Framework;
using Newtonsoft.Json;

[TestFixture]
public class ProgramTests
{
    [Test]
    public void TestSerialization()
    {
        // Arrange
        var obj = new { Name = "John", Age = 30 };
        string expectedJson = "{\"Name\":\"John\",\"Age\":30}";

        // Act
        string json = JsonConvert.SerializeObject(obj);

        // Assert
        Assert.AreEqual(expectedJson, json);
    }
}