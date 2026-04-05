using Lab1;
using NUnit.Framework;

[TestFixture]
public class AllTests
{
    // 🔹 1. Расстояние
    [Test]
    public void Task1_Distance_Test()
    {
        double result = Task1Program.Distance(0, 0, 3, 4);
        Assert.AreEqual(5, result);
    }

    // 🔹 2. Четность
    [Test]
    public void Task2_IsOdd_Test()
    {
        Assert.IsTrue(Task2Program.IsOdd(3));
    }

    // 🔹 3. Точка
    [Test]
    public void Task3_Point_Test()
    {
        string result = Lab1.Program3.CheckPoint(6, 2);
        Assert.AreEqual("Так", result);
    }

    // 🔹 4. Масть
    [Test]
    public void Task4_Suit_Test()
    {
        string result = Lab1.Program4.GetSuit(1);
        Assert.AreEqual("піки", result);
    }

    // 🔹 5. Умножение
    [Test]
    public void Task5_Multiply_Test()
    {
        int result = Lab1.Program5.Multiply(2, 3);
        Assert.AreEqual(6, result);
    }

    // 🔹 6. Формула
    [Test]
    public void Task6_Formula_Test()
    {
        double result = Program6.Calculate(1, 1);
        Assert.AreEqual(0.41666666666666663, result, 1e-10); // дельта для double
    }
}