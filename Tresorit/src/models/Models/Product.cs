namespace Tresorit.Models.Models;

public record Product : ITableEntity
{
    public required string PartitionKey { get; set; }
    public required string RowKey { get; set; }
    public ETag ETag { get; set; } = ETag.All;
    public DateTimeOffset? Timestamp { get; set; }

    public string Name
    {
        get => RowKey;
        set
        {
            RowKey = value;
            PartitionKey = ModelHelpers.GetPartitionKey(value);
        }
    }
};
