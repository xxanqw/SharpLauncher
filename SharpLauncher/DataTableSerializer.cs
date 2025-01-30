using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SharpLauncher
{
    internal class DataTableSerializer
    {
        public static string SerializeDataTable(DataTable dataTable, SerializerType type = SerializerType.XML)
        {
            if (dataTable == null) return null;

            if (type == SerializerType.XML)
            {
                using (StringWriter writer = new StringWriter())
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(DataTable));
                    serializer.Serialize(writer, dataTable);
                    return writer.ToString();
                }
            }
            else if (type == SerializerType.JSON)
            {
                return JsonConvert.SerializeObject(dataTable);
            }

            return null;
        }

        public static DataTable DeserializeDataTable(string serializedData, SerializerType type = SerializerType.XML)
        {
            if (string.IsNullOrEmpty(serializedData)) return null;

            if (type == SerializerType.XML)
            {
                using (StringReader reader = new StringReader(serializedData))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(DataTable));
                    return (DataTable)serializer.Deserialize(reader);
                }
            }
            else if (type == SerializerType.JSON)
            {
                try
                {
                    return JsonConvert.DeserializeObject<DataTable>(serializedData);
                }
                catch (JsonSerializationException ex)
                {
                    MessageBox.Show($"Error deserializing JSON: {ex.Message}", "Serialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null; // Or create a default new DataTable
                }

            }
            return null;
        }


        public enum SerializerType
        {
            XML,
            JSON
        }

    }
}
