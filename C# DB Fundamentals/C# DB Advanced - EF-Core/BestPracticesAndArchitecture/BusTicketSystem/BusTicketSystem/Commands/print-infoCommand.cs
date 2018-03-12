namespace BusTicketSystem.Commands
{
    using BusTicketSystem.Commands.Contracts;
    using Services.Contracts;
    using System.Text;

    public class print_infoCommand : ICommand
    {
        private readonly IBusStationService service;
        
        public print_infoCommand(IBusStationService serviceProvider)
        {
            this.service = serviceProvider;
        }

        public string Execute(string[] args)
        {
            int busStationId = int.Parse(args[0]);
            var busStation = service.ById(busStationId);
            var sb = new StringBuilder();
            sb.AppendLine($"{busStation.Name}, {busStation.Town.Name}");
            sb.AppendLine($"Arrivals:");
            foreach (var originStation in busStation.OriginTrips)
            {
                sb.AppendLine($"From {originStation.OriginBusStation.Name} | Arrive at {originStation.ArrivalTime} | {originStation.Status}");
            }
            sb.AppendLine($"Departures:");
            foreach (var destinationStation in busStation.DestinationTrips)
            {
                sb.AppendLine($"To {destinationStation.DestinationBusStation.Name} | Depart at {destinationStation.DepartureTime} | {destinationStation.Status}");
            }


            return sb.ToString().Trim();
        }
    }
}
