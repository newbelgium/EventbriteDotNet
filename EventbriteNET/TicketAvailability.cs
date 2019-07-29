using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventbriteNET
{
    public class TicketAvailability
    {
        [JsonProperty("has_available_tickets")]
        public bool HasAvailableTickets { get; set; }
        [JsonProperty("minimum_ticket_price")]
        public TicketPrice MinimumTicketPrice { get; set; }
        [JsonProperty("maximum_ticket_price")]
        public TicketPrice MaximumTicketPrice { get; set; }
        [JsonProperty("is_sold_out")]
        public bool IsSoldOut { get; set; }
        [JsonProperty("start_sales_date")]
        public DateTimeTimezoneField StartSalesDate { get; set; }
        [JsonProperty("waitlist_available")]
        public bool WaitlistAvailable { get; set; }
    }

    public class TicketPrice
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }
        [JsonProperty("value")]
        public int Value { get; set; }
        [JsonProperty("major_value")]
        public string MajorValue { get; set; }
        [JsonProperty("display")]
        public string Display { get; set; }
    }

}
