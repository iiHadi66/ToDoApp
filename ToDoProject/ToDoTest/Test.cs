using ToDoApp.Data.Models;
using ToDoApp.Pages.Components;

namespace ToDoTest
{
    public class Test
    {

        [Fact]
        public void PercentageCompleted_calculates_correctly()
        {
            // Arrange
            var component = new ToDo();
            component.taskList.Add(new TaskModels { TaskName = "Task 1", IsComplete = false });
            component.taskList.Add(new TaskModels { TaskName = "Task 2", IsComplete = true });

            // Act
            var result = component.PercentageCompleted;

            // Assert
            Assert.Equal(50, result);
        }


    }
}