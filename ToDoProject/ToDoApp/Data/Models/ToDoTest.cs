using ToDoApp.Pages.Components;
using Xunit;

namespace ToDoApp.Data.Models
{
    public class ToDoTest
    {
        [Fact]
        public void AddTaskShouldAddTaskToList()
        {
            // Arrange
            var task = new TaskModels { TaskName = "Test Task" };
            var component = new ToDo();

            // Act
            component.AddTask();

            // Assert
            Assert.Single(component.taskList);
            Assert.Equal("Test Task", component.taskList[0].TaskName);
        }


        [Fact]
        public void PercentageCompletedShouldReturnCorrectPercentage()
        {
            // Arrange
            var taskList = new List<TaskModels>
    {
        new TaskModels { TaskName = "Task 1", IsComplete = true },
        new TaskModels { TaskName = "Task 2", IsComplete = false },
        new TaskModels { TaskName = "Task 3", IsComplete = true }
    };
            var component = new ToDo();
            component.taskList = taskList;
            // Act
            var percentage = component.PercentageCompleted;
            // Assert
            Assert.Equal(67, percentage);
        }



    }
}