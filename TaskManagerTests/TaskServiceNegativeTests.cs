namespace TaskManagerTests;

public class TaskServiceNegativeTests : BaseTaskServiceTest
{

    /*
     * Given that a task does not exist.
     * When you attempt to get such a task--
     * Then TaskService should throw an ArgumentException.
     */
    [Test]
    public void NoneExistentTaskItemDeletingTest()
    {
        // Arrange & Act
        int fakeId = 25;

        // Assert 
        Assert.Throws<ArgumentException>(() => Service.GetTaskById(fakeId));
    }



    /*
     * Given that an A task already exists,
     * When you add the same task with the same TaskId--
     * Then the TaskService must throw an ArgumentException.
     */
    [Test]
    public void SameTaskIdTest()
    {
        // Arrange 
        int TaskId = 7;
        string Title = "Lucky 7";

        // Act 
        Service.AddTask(TaskId, Title);

        // Assert
        Assert.Throws<ArgumentException>(() => Service.AddTask(TaskId, "Lucky Not So Lucky"));

    }




    /*
     * Given that you have an invalid update title,
     * When you try to udate the current title--
     * Then TaskServe must throw an ArgumentException. 
     */
     [Test]
     public void TaskServiceDoesNotAllowInvalidTItleUpdate(){}
}