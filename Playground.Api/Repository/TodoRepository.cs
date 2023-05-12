using Playground.Api.Models;

namespace Playground.Api.Repository;

public class TodoRepository : ITodoRepository
{
    public Task<Todo> CreateTodo(Todo todo)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteTodoById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Todo>> GetAllTodos()
    {
        throw new NotImplementedException();
    }

    public Task<Todo> GetTodoById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Todo> UpdateTodo(Todo todo)
    {
        throw new NotImplementedException();
    }
}
