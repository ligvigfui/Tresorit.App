namespace Tresorit.Services.Managers;

public class ReviewManager(TableServiceClient serviceClient) : IReviewManager
{
    private readonly TableClient client = serviceClient.GetTableClient(nameof(Review));

    public Review GetReviewsForProduct(string productName, string userId) =>
        client.GetEntity<Review>(partitionKey: productName, rowKey: userId);
}
