using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HospitalManagementSystem
{
    [Serializable]
    public class Informations
    {
        public String ManagerName { get; set; }

        public String HospitalName { get; set; }

        public Informations()
        {

        }

        public static Informations read()
        {
            XmlSerializer serializer;
            serializer = new XmlSerializer(typeof(Informations));
            StreamReader reader = new StreamReader("Info.xml");
            Informations a = (Informations)serializer.Deserialize(reader);
            reader.Close();
            return a;
        }

        public static void write(String HName, String MName)
        {
            XmlSerializer serializer;
            serializer = new XmlSerializer(typeof(Informations));
            StreamWriter writer = new StreamWriter("Info.xml");
            Informations a = new Informations();
            a.HospitalName = HName;
            a.ManagerName = MName;
            serializer.Serialize(writer, a);
            writer.Close();
        }
    }



}
