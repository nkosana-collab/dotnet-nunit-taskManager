namespace TaskManager;

public class TaskItem
{
    private int Id {get; set;}
    private string Title {get; set;}
    private bool IsCompleted {get; set;}

    public TaskItem(int Id, string Title)
    {
        this.Title = Title;
        this.Id = Id;
        IsCompleted = false;
    }
}
