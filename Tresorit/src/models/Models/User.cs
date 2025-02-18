namespace Tresorit.Models.Models;

public record User : ITableEntity
{
    public required string PartitionKey { get; set; }
    public required string RowKey { get; set; }
    public ETag ETag { get; set; } = ETag.All;
    public DateTimeOffset? Timestamp { get; set; }

    public string UserId
    {
        get => RowKey;
        set
        {
            RowKey = value;
            PartitionKey = ModelHelpers.GetPartitionKey(value);
        }
    }
    public string UserName { get; set; } = "Anonymous";
}
