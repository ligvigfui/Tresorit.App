namespace Tresorit.Models.Models;

public record Review : ITableEntity
{
    public required string PartitionKey { get; set; }
    public required string RowKey { get; set; }
    public ETag ETag { get; set; } = ETag.All;
    public DateTimeOffset? Timestamp { get; set; }

    public string ProductName
    {
        get => PartitionKey;
        set => PartitionKey = value;
    }
    public string UserId
    {
        get => RowKey;
        set => RowKey = value;
    }
    public required string Text { get; set; }
    public DateTime PostDateTime { get; set; } = DateTime.UtcNow;
}