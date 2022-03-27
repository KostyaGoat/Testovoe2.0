using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Testovoe2._0.Models
{
    
    
        [SerializableAttribute()]
        [XmlRootAttribute("guid")]
        public class ChannelItemGuid
        {
            [XmlAttributeAttribute("isPermaLink")]
            public bool IsPermaLink { get; set; }

            [XmlTextAttribute()]
            public string Value { get; set; }
        }
    
}
