using System.Diagnostics.Contracts;

namespace TaskManager;

public class TaskService
{
    private List<TaskItem> tasks;
    private int _nextId = 1;

    public TaskService()
    {
        tasks = new List<TaskItem>();
    }

    public void AddTask(string title)
    {
        // Create a task to be added to tasks
        int taskId = _nextId++;
        TaskItem task = new TaskItem(taskId, title);

        // Add the new task to the list of tasks
        tasks.Add(task);
    }

    public TaskItem GetTaskById(int id)
    {
        foreach( TaskItem task in tasks)
        {
            
        }
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