using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AdapterPattern.Interfaces
{
     public interface ILumiaXMLTarget
     {
       XmlDocument GetLumiaMobilesXMLSpecifications();
     }
}
