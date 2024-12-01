using System;
using WinFormsApp19.Model;
namespace WinFormsApp19.Controller;

public class TodoController
{
    private List<TodoItem> _tasks;

    public TodoController()
    {
        _tasks = new List<TodoItem>();
    }

    public void AddTask(string task)
    {
        if (!string.IsNullOrWhiteSpace(task))
        {
            _tasks.Add(new TodoItem { Task = task, IsComplete = false });
        }
    }

    public void DeleteTask(int index)
    {
        if (index >= 0 && index < _tasks.Count)
        {
            _tasks.RemoveAt(index);
        }
    }

    public void MarkTaskAsCompleted(int index)
    {
        if (index >= 0 && index < _tasks.Count)
        {
            _tasks[index].IsComplete = true;
        }
    }

    public List<TodoItem> GetTasks()
    {
        return _tasks;
    }
}