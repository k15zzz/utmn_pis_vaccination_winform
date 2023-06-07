using NUnit.Framework;
using System.Collections.Generic;
using PIS_WinForm.GlobalClasses.NonStaticClasses;
using PIS_WinForm.GlobalClasses.StaticClasses;

namespace TestProject1
{
    [TestFixture]
    public class ReportMakerTests
    {
        [Test]
        public void CreateReport_ReturnsReportWithCorrectData()
        {
            // Arrange
            var report = new Dictionary<int, Dictionary<string, string>>
            {
                { 1, new Dictionary<string, string> { { "town_name", "Москва" }, { "price", "100" } } },
                { 2, new Dictionary<string, string> { { "town_name", "Москва" }, { "price", "200" } } },
                { 3, new Dictionary<string, string> { { "town_name", "Нью-Йорк" }, { "price", "300" } } },
                { 4, new Dictionary<string, string> { { "town_name", "Нью-Йорк" }, { "price", "400" } } }
            };

            // Assert
            var result = ReportMaker.CreateReport(report);

            // Assert
            Assert.AreEqual(2, result.GetTown().Length);
            Assert.AreEqual("Москва", result.GetTown()[0].Name);
            Assert.AreEqual(2, result.GetTown()[0].Count);
            Assert.AreEqual(300.0, result.GetTown()[0].Cost);
            Assert.AreEqual("Нью-Йорк", result.GetTown()[1].Name);
            Assert.AreEqual(2, result.GetTown()[1].Count);
            Assert.AreEqual(700.0, result.GetTown()[1].Cost);
        }

        [Test]
        public void AddTown_CorrectData_AddsTownToReport()
        {
            // Arrange
            var report = new Report();
            var town = new Report.Town { Name = "New York", Count = 10, Cost = 100 };

            // Act
            report.AddTown(town.Name, town.Count, town.Cost);

            // Assert
            Assert.AreEqual(1, report.GetTown().Length);
            Assert.AreEqual(town.Name, report.GetTown()[0].Name);
            Assert.AreEqual(town.Count, report.GetTown()[0].Count);
            Assert.AreEqual(town.Cost, report.GetTown()[0].Cost);
        }


        [Test]
        public void AddTown_CorrectData_AddsTownToReport2()
        {
            // Arrange
            var report = new Report();
            var town = new Report.Town { Name = "New York", Count = 10, Cost = 100 };

            // Act
            report.AddTown(town.Name, town.Count, town.Cost);

            // Assert
            Assert.AreEqual(1, report.GetTown().Length);
            Assert.AreEqual(town.Name, report.GetTown()[0].Name);
            Assert.AreEqual(town.Count, report.GetTown()[0].Count);
            Assert.AreEqual(town.Cost, report.GetTown()[0].Cost);
        }

        [Test]
        public void CreateReport_ReturnsReportWithCorrectData2()
        {
            // Arrange
            var report = new Dictionary<int, Dictionary<string, string>>
            {
                { 1, new Dictionary<string, string> { { "town_name", "Москва" }, { "price", "1000" } } },
                { 2, new Dictionary<string, string> { { "town_name", "Москва" }, { "price", "2000" } } },
                { 3, new Dictionary<string, string> { { "town_name", "Новосибирск" }, { "price", "3000" } } },
                { 4, new Dictionary<string, string> { { "town_name", "Новосибирск" }, { "price", "4000" } } },
                { 5, new Dictionary<string, string> { { "town_name", "Казань" }, { "price", "5000" } } },
                { 6, new Dictionary<string, string> { { "town_name", "Казань" }, { "price", "6000" } } }
            };

            // Act
            var result = ReportMaker.CreateReport(report);

            // Assert
            Assert.AreEqual(3, result.GetTown().Length);
            Assert.AreEqual("Москва", result.GetTown()[0].Name);
            Assert.AreEqual(2, result.GetTown()[0].Count);
            Assert.AreEqual(3000.0, result.GetTown()[0].Cost);
            Assert.AreEqual("Новосибирск", result.GetTown()[1].Name);
            Assert.AreEqual(2, result.GetTown()[1].Count);
            Assert.AreEqual(7000.0, result.GetTown()[1].Cost);
            Assert.AreEqual("Казань", result.GetTown()[2].Name);
            Assert.AreEqual(2, result.GetTown()[2].Count);
            Assert.AreEqual(11000.0, result.GetTown()[2].Cost);
        }

        [Test]
        public void CreateReport_ReturnsReportWithEmptyData()
        {
            // Arrange
            var report = new Dictionary<int, Dictionary<string, string>>();

            // Act
            var result = ReportMaker.CreateReport(report);

            // Assert
            Assert.AreEqual(0, result.GetTown().Length);
        }
    }
}