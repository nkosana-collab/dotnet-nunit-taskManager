using System.Diagnostics.Contracts;

namespace TaskManager;

public class TaskService
{
    private List<TaskItem> tasks;

    public TaskService()
    {
        tasks = new List<TaskItem>();
    }

    public void AddTask(string title)
    {
        
    }

    public TaskItem GetTaskById(int id)
    {
        return null;
    }

    public List<TaskItem> GetAllTasks()
    {
        return null;
    }

    public void CompleteTask( int id)
    {
        
    }

    public void DeleteTask(int id)
    {
        
    }

    public void UpdateTaskTitle(int id, string title)
    {
        
    }

}