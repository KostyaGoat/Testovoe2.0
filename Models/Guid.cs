using System.ComponentModel.DataAnnotations.Schema;
namespace Testovoe2._0.Models
{
    [Table("guid")]
    public class Guid
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("isPermaLink")]
        public bool IsPermaLink { get; set; }

        [Column("value")]
        public string Value { get; set; }

    }
}