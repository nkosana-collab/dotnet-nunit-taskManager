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



    /*
     * Given that I add multiple tasks
     * Then the taskService must keep track of all added tasks
     */

    [Test]
    public void AddingMultipleTasksTest()
    {
        // Arrange
        for(int x = 1; x < 4; x++)
        {   
            Service.AddTask(x, $"Task{x}");
        }

        // Act
        List<TaskItem> Result = Service.GetAllTasks();

        //Assert
        Assert.True(Result.Count().Equals(3));
    }



    /*
     * Given that I have added a task successfully.
     * Whe I want to delete the task--
     * Then I should be able to do so.
     */
    [Test]
    public void DeleteTaskTest()
    {
        // Arrange
        int TaskId = 7;
        string Title = "They Cry";

        // Act
        Service.AddTask(TaskId, Title);
        TaskItem ResultTask = Service.GetTaskById(TaskId);
        Assert.That(ResultTask.GetId(), Is.EqualTo(TaskId));
        Assert.That(ResultTask.GetTitle(), Is.EqualTo(Title));

        Service.DeleteTask(TaskId);

        // Assert
        Assert.Throws<ArgumentException>(() => Service.GetTaskById(TaskId));
        
    }

    /*
     * Given that I have completed a certain task
     * When I notify the TaskService--
     * Then It should update the task completion status
     */
     [Test]
     public void CompletedTaskStatusUpdateTest()
    {
        // Arrange
        int TaskId = 11;
        string Title = "When They See Us";
        
        Service.AddTask(TaskId, Title);
        Assert.False(Service.GetTaskById(TaskId).Completed());

        // Act
        Service.GetTaskById(TaskId).Complete();

        // Asssert
        Assert.True(Service.GetTaskById(TaskId).Completed());
    }
}