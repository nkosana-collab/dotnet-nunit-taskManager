using TaskManager;

namespace TaskManagerTests;

public class Tests
{
    private TaskService Service;
    
    [SetUp]
    public void Setup()
    {
        Service = new TaskService();
    }


    /*
     * Given that I have a valid task, 
     * When I add that task to the TaskService object--
     * Then the task must be added to the TaskService list.
     */
    [Test]
    public void AddingTaskTest()
    {
        // Arrange
        int TaskId = 1;
        string Title = "task1";

        // Act
        Service.AddTask(TaskId, Title);
        var ResultTask = Service.GetTaskById(TaskId);

        // Assert
        Assert.That(ResultTask.GetId, Is.EqualTo(TaskId));
        Assert.That(ResultTask.GetTitle, Is.EqualTo(Title));
    }

}