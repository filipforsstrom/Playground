using MongoDB.Driver;
using Playground.Api.Models;

namespace Playground.Api.Repository;

public class TodoRepositoryMongoDb : ITodoRepository
{
    private readonly IMongoCollection<Todo> _todoCollection;

    public TodoRepositoryMongoDb(IMongoDatabase database)
    {
        _todoCollection = database.GetCollection<Todo>("todos");
    }

    public async Task<List<Todo>> GetAllTodos()
    {
        return await _todoCollection.Find(_ => true).ToListAsync();
    }

    public async Task<Todo> GetTodoById(int id)
    {
        var filter = Builders<Todo>.Filter.Eq(todo => todo.Id, id);
        return await _todoCollection.Find(filter).FirstOrDefaultAsync();
    }

    public async Task<Todo> CreateTodo(Todo todo)
    {
        await _todoCollection.InsertOneAsync(todo);
        return todo;
    }

    public async Task<Todo> UpdateTodo(Todo todo)
    {
        var filter = Builders<Todo>.Filter.Eq(existingTodo => existingTodo.Id, todo.Id);
        await _todoCollection.ReplaceOneAsync(filter, todo);
        return todo;
    }

    public async Task<bool> DeleteTodoById(int id)
    {
        var filter = Builders<Todo>.Filter.Eq(todo => todo.Id, id);
        var result = await _todoCollection.DeleteOneAsync(filter);
        return result.DeletedCount > 0;
    }
}
