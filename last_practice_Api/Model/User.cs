using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace last_practice_Api.Model;

public class User
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonElement("username")]
    public string Username { get; set; } = null!;

    public string password { get; set; } = null!;

    public string email { get; set; } = null!;
}