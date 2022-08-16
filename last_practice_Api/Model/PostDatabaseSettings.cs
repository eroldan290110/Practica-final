namespace last_practice_Api.Model;

public class PostDatabaseSettings
{
    public string ConnectionString { get; set; } = null!;

    public string DatabaseName { get; set; } = null!;

    public string PostCollectionName { get; set; } = null!;
}