using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace People.Specifications
{
    [TestFixture]
    public class Crowd_specifications
    {
        [Test]
        public void Can_add_a_person_to_crowd()
        {
            //Arrange
            const int expectedCount = 1;
            var crowd = new Crowd();


            //Act
            crowd.Add(new Person());

            //Assert
            crowd.Count.Should().Be(expectedCount);
        }


        [Test]
        public void Can_remove_a_person_from_a_crowd()
        {
            //Arrange
            const int expectedCount = 0;
            var crowd = new Crowd()
            {
                {new Person()}
            };

            //Act
            crowd.Remove(crowd.First());
            
            //Assert
            crowd.Count.Should().Be(expectedCount);
        }

        [Test]
        public void Can_list_all_names_of_people_in_crowd()
        {
            //Arrange
            var expectedNamesOfpeopleInCrowd=new string[]{"tom","dick","harry"};
            var crowd = new Crowd()
            {
                new Person() {Name = "tom"},
                new Person() {Name = "dick"},
                new Person() {Name = "harry"}
            };

            //Act
            var result = crowd.ToListOfNames();
            
            //Assert
            var count = 0;
            foreach (var s in result)
            {
                s.Should().Be(expectedNamesOfpeopleInCrowd[count]);
                count++;
            }
        }

        [Test]
        public void Can_find_name_of_the_oldest_person_in_the_crowd()
        {
            // Arrange 
            const string expectedName = "fred";
            var crowd = new Crowd()
            {
                new Person
                {
                    Name = "jessey",
                    Age = 6
                },
                new Person{
                Name="jones",
                            Age = 7
                        },
                new Person
                {
                    Name = "fred",
                    Age = 60
                }
            };


            // Act
            var result=crowd.Oldest().Name;


            // Assert
            result.Should().Be(expectedName);
        }
    }

    public class Crowd : List<Person>
        {
        public string[] ToListOfNames()
        {
            var returnValue = new string[base.Count];
            for (var i = 0; i < returnValue.Length; i++)
            {
                returnValue[i] = base[i].Name;
            }
            return returnValue;
        }

        public Person Oldest()
        {
            return this.OrderByDescending(x => x.Age).First();
        }
        }

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
    
}
