namespace Tresorit.Data.DataBaseModels;

[Table(nameof(Product))]
public class Product
{
    [Key]
    public required string Name { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public virtual List<Review> Reviews { get; set; }
}
