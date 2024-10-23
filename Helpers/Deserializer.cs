using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace WeatherAPI.Helpers
{
    public static class Helpers
    {
        public static T DeserializeXmlData<T>(XmlReader reader)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            //using StringReader reader = new StringReader(xmlData);

            return (T)serializer.Deserialize(reader)!;

            //using TextReader reader = new StringReader(value);
            //return (T)new XmlSerializer(typeof(T)).Deserialize(reader);
        }

        public static async Task<string> GetJson(this HttpClient client, string stringUrl)
        {
            HttpResponseMessage response = await client.GetAsync(stringUrl);
            response.EnsureSuccessStatusCode();
            //Console.WriteLine();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
