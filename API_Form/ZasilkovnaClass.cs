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
        public Dictionary<int, PickupPoint> Data { get; set; } = new Dictionary<int, PickupPoint>(); // Fix: Initialize with a default value
        public Contact[] Contacts { get; set; } = Array.Empty<Contact>(); // Fix: Initialize with a default value
        public object[] Carriers { get; set; } = Array.Empty<object>(); // Fix: Initialize with a default value
        public Countries Countries { get; set; } = new Countries(); // Fix: Initialize with a default value
    }

    public class PickupPoint
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Fix: Initialize with a default value
        public string NameStreet { get; set; } = string.Empty; // Fix: Initialize with a default value
        public string? Special { get; set; }
        public string Place { get; set; } = string.Empty; // Fix: Initialize with a default value
        public string Street { get; set; } = string.Empty; // Fix: Initialize with a default value
        public string City { get; set; } = string.Empty; // Fix: Initialize with a default value
        public string Zip { get; set; } = string.Empty; // Fix: Initialize with a default value
        public string Country { get; set; } = string.Empty; // Fix: Initialize with a default value
        public string Currency { get; set; } = string.Empty; // Fix: Initialize with a default value
        public string? Directions { get; set; }
        public string? DirectionsCar { get; set; }
        public string? DirectionsPublic { get; set; }
        public string WheelchairAccessible { get; set; } = string.Empty; // Fix: Initialize with a default value
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Url { get; set; } = string.Empty; // Fix: Initialize with a default value
        public bool DressingRoom { get; set; }
        public bool ClaimAssistant { get; set; }
        public bool PacketConsignment { get; set; }
        public int MaxWeight { get; set; }
        public string LabelRouting { get; set; } = string.Empty; // Fix: Initialize with a default value
        public string LabelName { get; set; } = string.Empty; // Fix: Initialize with a default value
        public List<Photo> Photos { get; set; } = new List<Photo>(); // Fix: Initialize with a default value
        public OpeningHours OpeningHours { get; set; } = new OpeningHours(); // Fix: Initialize with a default value
    }

    public class Photo
    {
        public string Thumbnail { get; set; } = string.Empty; // Fix: Initialize with a default value
        public string Normal { get; set; } = string.Empty; // Fix: Initialize with a default value
    }

    public class OpeningHours
    {
        [System.Text.Json.Serialization.JsonConverter(typeof(StringOrEmptyObjectConverter))]
        public string? CompactShort { get; set; }
        [System.Text.Json.Serialization.JsonConverter(typeof(StringOrEmptyObjectConverter))]
        public string? CompactLong { get; set; }
        public string TableLong { get; set; } = string.Empty; // Fix: Initialize with a default value
        public RegularHours Regular { get; set; } = new RegularHours(); // Fix: Initialize with a default value
        public Exceptions Exceptions { get; set; } = new Exceptions(); // Fix: Initialize with a default value
    }

    public class RegularHours
    {
        public string Monday { get; set; } = string.Empty; // Fix: Initialize with a default value
        public string Tuesday { get; set; } = string.Empty; // Fix: Initialize with a default value
        public string Wednesday { get; set; } = string.Empty; // Fix: Initialize with a default value
        public string Thursday { get; set; } = string.Empty; // Fix: Initialize with a default value
        public string Friday { get; set; } = string.Empty; // Fix: Initialize with a default value
        public string Saturday { get; set; } = string.Empty; // Fix: Initialize with a default value
        public string Sunday { get; set; } = string.Empty; // Fix: Initialize with a default value
    }

    public class Exceptions
    {
        public List<ExceptionDay> Exception { get; set; }
    }

    public class ExceptionDay
    {
        [System.Text.Json.Serialization.JsonConverter(typeof(StringToDateOnlyConverter))]
        public DateOnly Date { get; set; }
        public string Hours { get; set; } = string.Empty; // Fix: Initialize with a default value
    }

    public class Carrier
    {
        // Add properties if needed
    }

    public partial class Contact
    {
        public string Country { get; set; } = string.Empty; // Fix: Initialize with a default value
        public string Phone { get; set; } = string.Empty; // Fix: Initialize with a default value
        public string Email { get; set; } = string.Empty; // Fix: Initialize with a default value
        public string BusinessHours { get; set; } = string.Empty; // Fix: Initialize with a default value
    }

    public partial class Countries
    {
        public string Cz { get; set; } = string.Empty; // Fix: Initialize with a default value
        public string Sk { get; set; } = string.Empty; // Fix: Initialize with a default value
        public string De { get; set; } = string.Empty; // Fix: Initialize with a default value
        public string Pl { get; set; } = string.Empty; // Fix: Initialize with a default value
        public string Hu { get; set; } = string.Empty; // Fix: Initialize with a default value
    }
}
