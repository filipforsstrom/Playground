using Playground.Api.Models;

namespace Playground.Api.Repository;

public interface ITodoRepository
{
    Task<List<Todo>> GetAllTodos();
    Task<Todo> GetTodoById(int id);
    Task<Todo> CreateTodo(Todo todo);
    Task<Todo> UpdateTodo(Todo todo);
    Task<bool> DeleteTodoById(int id);
}