using Tyuiu.LavrinovichED.Sprint0.Task2.V0.Lib; 

namespace Tyuiu.LavrinovichED.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            //������� �������� ������� ������������, ������� �� ����������
            var name = "����"; 
            var res = DataService.GetMessage(name);

            //�������� ����� Assert � ����� AreEqual
            Assert.AreEqual("������, ����", res); 
        }
    }
}