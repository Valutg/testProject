using System.IO;
using System.Xml.Serialization;

namespace testProjWF
{
    static class SerializatorXML
    {
        public static void SerializeToXML<T>(T serializeClass, string filename)
        {
            XmlSerializer xml = new XmlSerializer(typeof(T));
            using (FileStream fs = new FileStream(filename + ".xml", FileMode.Create))
            {
                xml.Serialize(fs, serializeClass);
            }
        }
        public static T DeserialiazeFromXML<T>(string filename)
        {
                XmlSerializer xml = new XmlSerializer(typeof(T));
                using (FileStream fs = new FileStream(filename + ".xml", FileMode.Open))
                {

                    return (T)xml.Deserialize(fs);
 
               
                } 
        }
    }
}
