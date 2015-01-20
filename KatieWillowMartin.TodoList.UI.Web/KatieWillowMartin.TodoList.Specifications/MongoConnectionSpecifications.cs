using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cavity;
using FluentAssertions;
using MongoDB.Driver;
using NUnit.Framework;

namespace KatieWillowMartin.TodoList.Specifications
{
    [TestFixture,
    Explicit]
    public class MongoConnectionSpecifications
    {
        [TestFixture,
         Explicit,
         Category("External Resource"),
         Category("Spike"),
         Category("MongoDB"),
        ]
        public class DiscoveryMongoCSharpDriver
        {
            [Test]
            [ExpectedException("MongoDB.Driver.MongoConnectionException")]
            public void Can_not_connect_without_connection_string()
            {
                //Arrange
                var mongoClient = new MongoClient();
                
                //Act
                mongoClient.GetServer().Connect();
            }

            [Test]
            public void Can_connect()
            {
                //Arrange
                var connectionString = ConfigurationManager.AppSettings["mongoConnectionString"];
                var mongoClient = new MongoClient(connectionString);

                //Act
                mongoClient.GetServer().Connect();


                //Assert
                mongoClient.GetServer().State.Should().Be(MongoServerState.Connected);
            }
        }

    }
}
