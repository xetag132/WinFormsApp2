public interface ITicket
{
    int TicketID { get; set; }
    string EventName { get; set; }
    string DepartureCity { get; set; }
    string ArrivalCity { get; set; }
    DateTime FlightDate { get; set; }
    decimal Price { get; set; }
    void DisplayInfo();
}