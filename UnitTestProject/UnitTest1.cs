using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwissTransport;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        // Unit-Test GetStations
        [TestMethod]
        public void Stations()
        {
            // arrange
            var testee = new Transport();
            // act
            var stations = testee.GetStations("Sursee");
            // assert
            Assert.AreEqual(10, stations.StationList.Count);
        }

        // Unit-Test StationBoard
        [TestMethod]
        public void StationBoard()
        {
            // arrange
            var testee = new Transport();
            // act
            var stationBoard = testee.GetStationBoard("Sursee", "8502007");
            // assert
            Assert.IsNotNull(stationBoard);
        }

        // Unit-Test Connection
        [TestMethod]
        public void Connections()
        {
            // arrange
            var testee = new Transport();
            // act
            var connections = testee.GetConnections("Sursee", "Luzern", "2020-01-01", "12:00");
            // assert
            Assert.IsNotNull(connections);
        }
    }
    }
