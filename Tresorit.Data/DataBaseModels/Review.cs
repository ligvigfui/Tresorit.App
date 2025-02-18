namespace Tresorit.Data.DataBaseModels;

[Table(nameof(Review))]
public class Review
{
    [Key]
    public int Id { get; set; }
    [Length(0, 500)]
    public required string ReviewText { get; set; }
    public required DateTime ReviewDate { get; set; }
    [ForeignKey(nameof(Product))]
    public int ProductId { get; set; }
    public virtual Product Product { get; set; }
}
