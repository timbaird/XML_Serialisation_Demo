using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DeploymentTest
{
    [XmlRoot("WidgetList")]
    public class WidgetList
    {
        [XmlElement("Widget")]
        public List<Widget> widgets { set; get; }
    }

    public class Widget
    {
        [XmlElement("Name")]
        public string name { set; get; }
        [XmlElement("Height")]
        public int height { get; set; }
        [XmlElement("Width")]
        public int width { get; set; }

        public override string ToString()
        {
            return name + " height: " + height + " width: " + width;
        }
    }
}
