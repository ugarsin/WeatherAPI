using Newtonsoft.Json;
using System.Data.SqlTypes;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using WeatherAPI.Models;
using WeatherAPI.Helpers;

string stringUrl = "https://api.openweathermap.org/data/2.5/weather?q=London&appid=2b1471b3ac3bc99815c97dbebdd1b5fe";
HttpClient client = new HttpClient();

var JsonObject = JsonConvert.DeserializeObject<RootJson>(await client.GetJson(stringUrl));

Console.WriteLine(JsonObject.ToString());

//Console.WriteLine(JsonObject!.ToString());

//Console.WriteLine(JsonConvert.DeserializeObject(await client.GetJson(stringUrl)));

stringUrl = "https://api.openweathermap.org/data/2.5/weather?q=London&mode=xml&appid=2b1471b3ac3bc99815c97dbebdd1b5fe";
XmlTextReader reader = new XmlTextReader(stringUrl);
//reader.MoveToContent();
//reader.Read();

//Console.WriteLine(reader.ReadOuterXml());

//XmlSerializer serializer = new XmlSerializer(typeof(current));
//var xmlObj = (current)serializer.Deserialize(reader)!;


////Console.WriteLine(reader.ReadOuterXml());
current currentXml = Helpers.DeserializeXmlData<current>(reader);

Console.WriteLine(currentXml.city.name);
Console.WriteLine(currentXml.wind.speed.value);

//Console.WriteLine(currentXml!.ToString());


//XmlSerializer serializer = new XmlSerializer(typeof(current), new XmlRootAttribute("current"));
////using (StreamReader readerx = new StreamReader(stringUrl))
////{
//current currentXml = (current)serializer.Deserialize(reader)!;
//}

//while (reader.Read())
//{
//    // Do some work here on the data.
//    Console.WriteLine(reader.Name);
//}
//Console.ReadLine();

//using (HttpClient client = new HttpClient())
//{
//    HttpResponseMessage response = await client.GetAsync(stringUrl);
//    response.EnsureSuccessStatusCode();
//    Console.WriteLine(JsonConvert.DeserializeObject(await response.Content.ReadAsStringAsync()));
//    //Console.WriteLine(responseBody);
//}


//HttpClient client = new HttpClient();
//client.DefaultRequestHeaders.Accept
//  .Add(new MediaTypeWithQualityHeaderValue("application/json"));
//var responseMsg = client.GetStringAsync(string.Format(stringUrl)).Result;
//Console.WriteLine(responseMsg);
