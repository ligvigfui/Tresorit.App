namespace Tresorit.Models;

public static class ModelHelpers
{
    public static string GetPartitionKey(string rowKey) =>
        rowKey.GetHashCode().ToString()[..3];
}
