namespace Tresorit.Services.Managers;

public class ProductManager(TableServiceClient serviceClient) : IProductManager
{
    private readonly TableClient client = serviceClient.GetTableClient(nameof(Product));

    public Product GetProduct(string name) =>
        client.GetEntity<Product>(partitionKey: ModelHelpers.GetPartitionKey(name), rowKey: name);
}
