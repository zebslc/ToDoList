using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Hosting;
using FluentAssertions;
using KatieWillowMartin.TodoList.UI.Web.Repositories;
using Newtonsoft.Json;
using NSubstitute;
using NUnit.Framework;
using WillowKatieMartin.LightingTasks.Web.Controllers;
using WillowKatieMartin.LightingTasks.Web.Models;

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
