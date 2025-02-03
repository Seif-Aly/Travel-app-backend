using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("tours")]
public class Tour
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public required string Name { get; set; }

    [Column("description")]
    public required string Description { get; set; }

    [Column("price")]
    public required decimal Price { get; set; }

    [Column("start_date")]
    public required DateTime StartDate { get; set; }

    [Column("end_date")]
    public required DateTime EndDate { get; set; }
}