using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Playground.Api.Models;

public class Todo
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsComplete { get; set; }
}