using API_Form;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ApiStoreTest
{
    public class ZasilkovnaJsonModel
    {
        public Dictionary<int, PickupPoint> Data { get; set; }
        public Contact[] Contacts { get; set; }
        public object[] Carriers { get; set; }
        public Countries Countries { get; set; }
    }

    public class PickupPoint
    {
        [System.Text.Json.Serialization.JsonConverter(typeof(StringToIntConverter))]
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameStreet { get; set; }
        public string? Special { get; set; }
        public string Place { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Currency { get; set; }
        public string? Directions { get; set; }
        public string? DirectionsCar { get; set; }
        public string? DirectionsPublic { get; set; }
        public string WheelchairAccessible { get; set; }
        [System.Text.Json.Serialization.JsonConverter(typeof(StringToDoubleConverter))]
        public double Latitude { get; set; }
        [System.Text.Json.Serialization.JsonConverter(typeof(StringToDoubleConverter))]
        public double Longitude { get; set; }
        public string Url { get; set; }
        [System.Text.Json.Serialization.JsonConverter(typeof(StringToBoolConverter))]
        public bool DressingRoom { get; set; }
        [System.Text.Json.Serialization.JsonConverter(typeof(StringToBoolConverter))]
        public bool ClaimAssistant { get; set; }
        [System.Text.Json.Serialization.JsonConverter(typeof(StringToBoolConverter))]
        public bool PacketConsignment { get; set; }
        [System.Text.Json.Serialization.JsonConverter(typeof(StringToIntConverter))]
        public int MaxWeight { get; set; }
        public string LabelRouting { get; set; }
        public string LabelName { get; set; }
        public List<Photo> Photos { get; set; }
        public OpeningHours OpeningHours { get; set; }
    }

    public class Photo
    {
        public string Thumbnail { get; set; }
        public string Normal { get; set; }
    }

    public class OpeningHours
    {
        [System.Text.Json.Serialization.JsonConverter(typeof(StringOrEmptyObjectConverter))]
        public string? CompactShort { get; set; }
        [System.Text.Json.Serialization.JsonConverter(typeof(StringOrEmptyObjectConverter))]
        public string? CompactLong { get; set; }
        public string TableLong { get; set; }
        public RegularHours Regular { get; set; }
        public Exceptions Exceptions { get; set; }
    }

    public class RegularHours
    {
        public string Monday { get; set; }
        public string Tuesday { get; set; }
        public string Wednesday { get; set; }
        public string Thursday { get; set; }
        public string Friday { get; set; }
        public string Saturday { get; set; }
        public string Sunday { get; set; }
    }

    public class Exceptions
    {
        public List<ExceptionDay> Exception { get; set; }
    }

    public class ExceptionDay
    {
        [System.Text.Json.Serialization.JsonConverter(typeof(StringToDateOnlyConverter))]
        public DateOnly Date { get; set; }
        public string Hours { get; set; }
    }

    public class Carrier
    {
        // Add properties if needed
    }

    public partial class Contact
    {
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string BusinessHours { get; set; }
    }

    public partial class Countries
    {
        public string Cz { get; set; }
        public string Sk { get; set; }
        public string De { get; set; }
        public string Pl { get; set; }
        public string Hu { get; set; }
    }
}
