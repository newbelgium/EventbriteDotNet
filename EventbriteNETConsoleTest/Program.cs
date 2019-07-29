using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using EventbriteNET;

namespace EventbriteNETConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new EventbriteContext("URI7ZVJW2FXE7DTIFK46");

            var fetchedEvents = context.GetOrganizerEvents(6420441677, status: new[] { EventbriteNET.StatusOptions.live }, dateStart: DateTime.Now, expansions: "ticket_availability");

            Console.WriteLine(context.Page);
            Console.WriteLine(context.Pagination);

            var withTicketDetails = fetchedEvents.Where(e => e.TicketAvailability?.HasAvailableTickets == true);

            foreach (var ticketsleft in withTicketDetails)
            {
                Console.WriteLine(ticketsleft.Name.Text);
                var ticketClasses = context.GetEventTicketClasses(ticketsleft.Id);
                var allR = 0;
                foreach (var ticketClass in ticketClasses)
                {
                    var t = ticketClass.QuantityTotal;
                    var s = ticketClass.QuantitySold;
                    var r = t - s;
                    allR = allR + r.GetValueOrDefault();
                }
                Console.WriteLine(allR);
            }

            Console.ReadLine();
            // eventbriteNET.Get<List<Event>>("")
            // Console
        }
    }
}
