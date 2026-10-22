using TaskManager;

namespace TaskManagerTests;

public class BaseTaskServiceTest
{
    protected TaskService Service;
    
    [SetUp]
    public void Setup()
    {
        Service = new TaskService();
    }
}