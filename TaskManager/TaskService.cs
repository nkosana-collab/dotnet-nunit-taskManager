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
            if (task.GetId().Equals(id))
            {
                return task;
            }
        }
        throw new Exception();
    }

    public List<TaskItem> GetAllTasks()
    {
        return [.. tasks];
    }

    public void CompleteTask( int id)
    {
        foreach(TaskItem task in tasks)
        {
            if (task.GetId().Equals(id))
            {
                task.Complete();
                return;
            }
        }
        throw new Exception();
    }

    public void DeleteTask(int id)
    {
        foreach(TaskItem task in tasks)
        {
            if (task.GetId().Equals(id))
            {
                tasks.Remove(task);
                return;
            }
        }
        throw new Exception();
    }

    public void UpdateTaskTitle(int id, string title)
    {
        foreach(TaskItem task in tasks)
        {
            if (task.GetId().Equals(id))
            {
                task.SetTitle(title);
                return;
            }
        }
        throw new Exception();
    }

}