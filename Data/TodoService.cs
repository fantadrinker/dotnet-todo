namespace BlazorApp.Data;

public class TodoService
{
    public event Action? OnChange;

    public List<TodoItem> Todos { get; } = new();

    public void AddTodoItem(TodoItem todoItem)
    {
        Todos.Add(todoItem);
        NotifyStateChanged();
    }

    public void ClearTodos()
    {
        Todos.Clear();
        NotifyStateChanged();
    }

    public Task<List<TodoItem>> GetTodosAsync()
    {
        return Task.FromResult(Todos);
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}