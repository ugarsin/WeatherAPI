using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WeatherAPI.Models
{
    [XmlRoot("current")]
    public class current
    {
        [XmlElement]
        public CityAttribute city { get; set; }
        [XmlElement]
        public TemperatureAttribute temperature { get; set; }
        [XmlElement]
        public FeelslikeAttribute feels_like { get; set; }
        [XmlElement]
        public HumidityAttribute humidity { get; set; }
        [XmlElement]
        public PressureAttribute pressure { get; set; }
        [XmlElement]
        public WindAttribute wind { get; set; }
        [XmlElement]
        public CloudsAttribute clouds { get; set; }
        [XmlElement]
        public VisibilityAttribute visibility { get; set; }
        [XmlElement]
        public PrecipitationAttribute precipitation { get; set; }
        [XmlElement]
        public WeatherAttribute weather { get; set; }
        [XmlElement]
        public LastupdateAttribute lastupdate { get; set; }
    }

    public class CityAttribute
    {
        [XmlAttribute]
        public string id { get; set; }
        [XmlAttribute]
        public string name { get; set; }
        [XmlElement]
        public CoordAttribute coord { get; set; }
        [XmlElement]
        public string country { get; set; }
        [XmlElement]
        public string timezone { get; set; }
        [XmlElement]
        public SunAttribute sun { get; set; }
    }

    public class CoordAttribute
    {
        [XmlAttribute]
        public string lon { get; set; }
        [XmlAttribute]
        public string lat { get; set; }
    }

    public class SunAttribute
    {
        [XmlAttribute]
        public string rise { get; set; }
        [XmlAttribute]
        public string set { get; set; }
    }

    public class TemperatureAttribute
    {
        [XmlAttribute]
        public string value { get; set; }
        [XmlAttribute]
        public string min { get; set; }
        [XmlAttribute]
        public string max { get; set; }
        [XmlAttribute]
        public string unit { get; set; }
    }

    public class FeelslikeAttribute
    {
        [XmlAttribute]
        public string value { get; set; }
        [XmlAttribute]
        public string unit { get; set; }
    }

    public class HumidityAttribute
    {
        [XmlAttribute]
        public string value { get; set; }
        [XmlAttribute]
        public string unit { get; set; }
    }

    public class PressureAttribute
    {
        [XmlAttribute]
        public string value { get; set; }
        [XmlAttribute]
        public string unit { get; set; }
    }

    public class WindAttribute
    {
        [XmlElement]
        public SpeedAttribute speed { get; set; }
        [XmlElement]
        public GustsAttribute gust { get; set; }
        [XmlElement]
        public DirectionAttribute direction { get; set; }
    }

    public class SpeedAttribute
    {
        [XmlAttribute]
        public string value { get; set; }
        [XmlAttribute]
        public string unit { get; set; }
        [XmlAttribute]
        public string name { get; set; }
    }

    public class GustsAttribute
    {
        [XmlAttribute]
        public string value { get; set; }
    }

    public class DirectionAttribute
    {
        [XmlAttribute]
        public string value { get; set; }
        [XmlAttribute]
        public string code { get; set; }
        [XmlAttribute]
        public string name { get; set; }
    }

    public class CloudsAttribute
    {
        [XmlElement]
        public string value { get; set; }
        [XmlElement]
        public string name { get; set; }
    }

    public class VisibilityAttribute
    {
        [XmlElement]
        public string value { get; set; }
    }

    public class PrecipitationAttribute
    {
        [XmlElement]
        public string mode { get; set; }
    }

    public class WeatherAttribute
    {
        [XmlElement]
        public string number { get; set; }
        [XmlElement]
        public string value { get; set; }
        [XmlElement]
        public string icon { get; set; }
    }

    public class LastupdateAttribute
    {
        [XmlElement]
        public string value { get; set; }
    }

    public class RootJson
    {
        public Coordinate coord { get; set; }
        public List<Weather> weather { get; set; }
        public string Base { get; set; }
        public MAIN main { get; set; }
        public long visibility { get; set; }
        public Wind wind { get; set; }
        public Clouds clouds { get; set; }
        public long dt { get; set; }
        public  Sys sys { get; set; }
        public long timezone { get; set; }
        public long  id { get; set; }
        public string name { get; set; }
        public long cod { get; set; }
    }

    public class Coordinate
    {
        public long lon { get; set; }
        public long lat { get; set; }
    }

    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

    public class MAIN
    {
        public long temp { get; set; }
        public long feels_like { get; set; }
        public long temp_min { get; set; }
        public long temp_max { get; set; }
        public long pressure { get; set; }
        public long humidity { get; set; }
        public long sea_level { get; set; }
        public long grnd_level { get; set; }
    }
 
    public class Wind
    {
        public long speed { get; set; }
        public long deg { get; set; }
    }

    public class Clouds
    {
        public long all { get; set; }
    }

    public class Sys
    {
        public long  type { get; set; }
        public long  id { get; set; }
        public string country { get; set; }
        public long  sunrise { get; set; }
        public long sunset { get; set; }
    }
}
