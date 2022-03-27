using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Testovoe2._0.Models
{
    [Table("category")]
    public class Category
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("value")]
        public string Value { get; set; }

        public List<LinksCategoryItems> LinksCategoryItems { get; set; }
    }
}
