using Tyuiu.LavrinovichED.Sprint0.Task2.V0.Lib; 

namespace Tyuiu.LavrinovichED.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            //Область создания методов тестирования, методов из библиотеки
            var name = "Лиза"; 
            var res = DataService.GetMessage(name);

            //Вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Привет, Лиза", res); 
        }
    }
}