using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace last_practice_Api.Model;

public class Post
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonElement("username")]
    public string UserName { get; set; } = null!;

    public DateTime date { get; set; } = new DateTime()!;

    public string title { get; set; } = null!;

    public string image { get; set; } = null!;

    public string resume { get; set; } = null!;
    
    public string description { get; set; } = null!;
}