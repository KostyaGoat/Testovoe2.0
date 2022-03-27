using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace Testovoe2._0.Models
{
    [Table("items")]
    public class Items
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("guid_id")]
        public int GuidId { get; set; }

        public Guid Guid { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("pubDate")]
        public string PubDate { get; set; }

        [Column("channel_id")]
        public int ChannelId { get; set; }

        public Channel Channel { get; set; }

        public List<LinksCategoryItems> LinksCategoryItems { get; set; }


        public string Categories => GetCategories();

        private string GetCategories()
        {
            var result = "";
            foreach (var c in LinksCategoryItems)
                result += $"{c.Category.Value}, ";
            return result.Substring(0, result.Length - 2);
        }

    }
}
