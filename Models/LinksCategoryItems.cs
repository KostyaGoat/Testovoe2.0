using DocumentFormat.OpenXml.Spreadsheet;
using System.ComponentModel.DataAnnotations.Schema;

namespace Testovoe2._0.Models
{
    [Table("linksCategoryItem")]
    public class LinksCategoryItems
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("item_id")]
        public int ItemId { get; set; }
        public Items Item { get; set; }

        [Column("category_id")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}


