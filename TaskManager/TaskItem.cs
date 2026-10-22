namespace TaskManager;

public class TaskItem
{
    private int Id {get;}
    private string Title {get; set;}
    private bool IsCompleted {get; set;}

    public TaskItem(int Id, string Title)
    {
        this.Title = Title;
        this.Id = Id;
        IsCompleted = false;
    }

    public int GetId()
    {
        return Id;
    }

    public string GetTitle()
    {
        return Title;
    }

    public void SetTitle(string Title)
    {
        this.Title = Title;
    }

    public bool Completed()
    {
        return IsCompleted;
    }

    public void Complete()
    {
        IsCompleted = true;
    }
}
