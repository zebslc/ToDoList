using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Hosting;
using FluentAssertions;
using Newtonsoft.Json;
using NSubstitute;
using NUnit.Framework;
using WillowKatieMartin.LightingTasks.Web.Controllers;
using WillowMartin.TodoList.Data.Repositories;
using WillowMartin.TodoList.Domain;

namespace KatieWillowMartin.TodoList.Specifications
{

    public class TasksControllerSpecifications
    {
        [TestFixture]
        public class GetSpecifications:TasksControllerSpecifications
        {
            [Test]
            public void Do_make_call_to_repository()
            {
                // Arrange 
                var repository = Substitute.For<ITasksRepository>();
                var controller = BuildController(repository);

                // Act 
                controller.Get();
                // Verify
                repository.Received().Get();
            }

            [Test]
            public void Do_return_a_OK_status_code()
            {
                // Arrange 
                var repository = Substitute.For<ITasksRepository>();
                var controller = BuildController(repository);
                // Act
                var result = controller.Get();
                result.EnsureSuccessStatusCode();

                // Verify
                result.StatusCode.Should().Be(HttpStatusCode.OK);

            }

            [Test]
            public void Do_return_list_of_tasks()
            {
                // Arrange 
                var tasks = new List<CustomTask> { new CustomTask(), new CustomTask(), new CustomTask() };
                var expectedContent = JsonConvert.SerializeObject(tasks);

                var repository = Substitute.For<ITasksRepository>();
                repository.Get().Returns(tasks);

                // Act
                var controller = this.BuildController(repository);
                var responseMessage = controller.Get();
                var resultTask = responseMessage.Content.ReadAsStringAsync();
                resultTask.Wait();

                // Verify
                resultTask.Result.Should().Be(expectedContent);
            }

            [Test]
            public void Do_return_a_task_with_name()
            {
                // Arrange 
                const string taskName = "test Task";
                var customTask = new CustomTask()
                {
                    Name = taskName
                };
                var tasks = new List<CustomTask> { new CustomTask(), customTask, new CustomTask() };
                
                var repository = Substitute.For<ITasksRepository>();
                repository.Get().Returns(tasks);

                // Act
                var controller = this.BuildController(repository);
                var responseMessage = controller.Get();
                var resultTask = responseMessage.Content.ReadAsStringAsync();
                resultTask.Wait();

                // Verify
                resultTask.Result.Should().Contain(taskName);
            }
        }
        [TestFixture]
        public class PostSpecification : TasksControllerSpecifications
        {
            [Test]
            public void Do_make_a_call_to_repository()
            {
                //Arrange 
                const string expectedName = "test task";
                var repository=Substitute.For<ITasksRepository>();
                repository.Create(Arg.Any<CustomTask>()).Returns(1);
                var controller = BuildController(repository);

                //Act 
                controller.Post(new CustomTask(){Name=expectedName});

                //Verify
                repository.Received().Create(Arg.Is<CustomTask>(x=>x.Name==expectedName));
            }

            [Test]
            public void Do_receive_a_OK_status()
            {
                // Arrange 
                var repository = Substitute.For<ITasksRepository>();
                repository.Create(Arg.Any<CustomTask>()).Returns(1);
                var controller = BuildController(repository);

                // Act
                var result = controller.Post(new CustomTask());
                result.EnsureSuccessStatusCode();

                // Verify
                result.StatusCode.Should().Be(HttpStatusCode.OK);
            }

            [Test]
            public void Do_receive_a_task_id()
            {
                //Arrange
                const int expectedId = 1;
                var tasksRepository = Substitute.For<ITasksRepository>();
                tasksRepository.Create(Arg.Any<CustomTask>()).Returns(expectedId);
                var controller=BuildController(tasksRepository);
                //Act
                var result=controller.Post(new CustomTask());
                var contentTask = result.Content.ReadAsAsync<int>();
                contentTask.Wait();
                var content=contentTask.Result;

                //Verify
                content.Should().Be(expectedId);
            }
        }
        private TasksController BuildController(ITasksRepository repository)
            {
                var config = new HttpConfiguration();
                var request = new HttpRequestMessage(HttpMethod.Post, "http://localhost/api/CustomTask");
                var controller = new TasksController(repository)
                {
                    Request = request,
                };
                controller.Request.Properties[HttpPropertyKeys.HttpConfigurationKey] = config;
                return controller;
            }
        }
    }
