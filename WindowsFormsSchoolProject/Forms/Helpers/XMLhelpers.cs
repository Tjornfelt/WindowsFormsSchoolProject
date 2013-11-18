using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace WindowsFormsSchoolProject.Helpers
{
    public static class XMLhelpers
    {
        public static void SaveUsersToXml(List<User> userList)
        {
            var serializer = new XmlSerializer(typeof(List<User>));
            using (var writer = XmlWriter.Create("users.xml"))
            {
                serializer.Serialize(writer, userList);
            }
        }

        public static List<User> FetchUsersFromXml()
        {
            var serializer = new XmlSerializer(typeof(List<User>));
            List<User> model;
            using (var reader = XmlReader.Create("users.xml"))
            {
                model = (List<User>)serializer.Deserialize(reader);
            }
            return model;
        }
    }
}
