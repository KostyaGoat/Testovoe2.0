using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using Testovoe2._0.Models;

namespace Testovoe2._0
{
    
    
        [SerializableAttribute()]
        public class ChannelItem
        {
            [XmlElementAttribute("title")]
            public string Title { get; set; }

            [XmlElementAttribute("guid")]
            public ChannelItemGuid Guid { get; set; }

            [XmlElementAttribute("description")]
            public string Description { get; set; }

            [XmlElementAttribute("pubDate")]
            public string PubDate { get; set; }

            [XmlElementAttribute("category")]
            public string[] Category { get; set; }
        }
    }

