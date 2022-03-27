using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Xml.Serialization;

namespace Testovoe2._0
{
  [SerializableAttribute()]
  [XmlRootAttribute("channel", Namespace = "", IsNullable = false)]
  public partial class Channel
  {
    [XmlElementAttribute("item")]
    public ChannelItem[] Item { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
    
}
