
using Microsoft.VisualBasic;

namespace TaskManagerTests;

public class TaskValidationTests : BaseTaskServiceTest
{
    /*
     * Given that a task title is null or empty.
     * When you attempt to add the task--
     * Then the service must throw an exception.
     */
    [TestCase(7, "")]
    [TestCase(25,(string?)null )]
    public void NullOrEmptyTitle(int TaskId, string? Title)
    {
        // Arrange
        int Id = TaskId;
        string? title = Title;

        // Act and Assert
        Assert.Throws<ArgumentException>(() => Service.AddTask(Id, title));
    }
}