using Playground.Api.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/todoitems", () => "All todos");

app.MapGet("/todoitems/{id}", (int id) => "A todo with id " + id);

app.MapPost("/todoitems", (Todo todo) =>
{
    return Results.Created($"/todoitems/{todo.Id}", todo);
});

app.Run();