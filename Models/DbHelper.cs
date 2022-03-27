
using System.Linq;

namespace Testovoe2._0.Models
{
    public static class DbHelper
    {
        internal static void AddToDb(Channel data)
        {


            using (var db = new Testovoe20DbContext())
            {
                if (!db.Channels.Any())
                {
                    db.Channels.Add(new Channel() { Id = 1 });
                }

                for (int i = 0; i < data.Item.Length; i++)
                {
                    var channelItem = data.Item[i];
                    var guid = new Guid()
                    {
                        Id = db.Guids.Count() + 1,
                        IsPermaLink = channelItem.Guid.IsPermaLink,
                        Value = channelItem.Guid.Value
                    };
                    db.Guids.Add(guid);
                    db.SaveChanges();

                    var item = new Items()
                    {
                        Id = db.Items.Count() + 1,
                        Title = channelItem.Title,
                        Guid = guid,
                        Description = channelItem.Description,
                        PubDate = channelItem.PubDate,
                        Channel = db.Channels.FirstOrDefault()
                    };
                    db.Items.Add(item);
                    db.SaveChanges();

                    for (int j = 0; j < channelItem.Category.Length; j++)
                    {
                        var category = new Category()
                        {
                            Id = db.Categories.Count() + 1,
                            Value = channelItem.Category[j],
                        };
                        db.Categories.Add(category);

                        var linkCI = new LinksCategoryItems()
                        {
                            Id = db.LinksCategoryItems.Count() + 1,
                            Item = item,
                            Category = category
                        };
                        db.LinksCategoryItems.Add(linkCI);
                        db.SaveChanges();
                    }
                }
            }
        }
        public static void DeletеDb()
        {
            using (Testovoe20DbContext db = new Testovoe20DbContext())
            {
                var records = db.Channels.ToList();
                foreach (var record in records)
                {
                    db.Channels.Remove(record);

                }
                db.SaveChanges();

                var items = db.Items.ToList();
                foreach (var record in items)
                {
                    db.Items.Remove(record);

                }
                db.SaveChanges();

                var guids = db.Guids.ToList();
                foreach (var record in guids)
                {
                    db.Guids.Remove(record);

                }
                db.SaveChanges();
            }
        }
    }
}
