using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KuchukIA.Sprint7.Project.V14.Lib;

namespace Tyuiu.KuchukIA.Sprint7.Project.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        string[,] testArray;
        string routeNumber = "12";

        [TestInitialize]
        public void TestSetup()
        {
            testArray = new string[,]
            {
                { "1", "Автобус", "12", "15.01.2023", "Вокзал", "Аэропорт", "45", "Интервал 10 минут" },
                { "2", "Трамвай", "5", "20.03.2022", "Центр", "Завод", "25", "" },
                { "3", "Троллейбус", "8", "10.05.2021", "Университет", "Парк", "18", "" },
                { "4", "Автобус", "12", "05.11.2023", "Аэропорт", "Вокзал", "42", "Ночной" },
                { "5", "Маршрутка", "24", "30.08.2022", "Молл", "Стадион", "12", "Экспресс" }
            };
        }

        [TestMethod]
        public void TestVehicleAmount()
        {
            int res = ds.VehicleAmount(testArray);
            Assert.AreEqual(5, res);
        }

        [TestMethod]
        public void TestRouteAmount()
        {
            int res = ds.RouteAmount(testArray);
            Assert.AreEqual(4, res);
        }

        [TestMethod]
        public void TestMinTime()
        {
            int res = ds.MinTime(testArray);
            Assert.AreEqual(12, res);
        }

        [TestMethod]
        public void TestMaxTime()
        {
            int res = ds.MaxTime(testArray);
            Assert.AreEqual(45, res);
        }

        [TestMethod]
        public void TestAvgTime()
        {
            int res = ds.AvgTime(testArray);
            Assert.AreEqual(28, res);
        }

        [TestMethod]
        public void TestRouteAmountOnRoute()
        {
            int res = ds.RouteAmount_Route(testArray, routeNumber);
            Assert.AreEqual(2, res);
        }

        [TestMethod]
        public void TestMinTimeOnRoute()
        {
            int res = ds.MinTime_Route(testArray, routeNumber);
            Assert.AreEqual(42, res);
        }

        [TestMethod]
        public void TestMaxTimeOnRoute()
        {
            int res = ds.MaxTime_Route(testArray, routeNumber);
            Assert.AreEqual(45, res);
        }

        [TestMethod]
        public void TestAvgTimeOnRoute()
        {
            int res = ds.AvgTime_Route(testArray, routeNumber);
            Assert.AreEqual(43, res);
        }
    }
}