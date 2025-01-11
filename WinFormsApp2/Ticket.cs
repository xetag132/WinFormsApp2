using System;

public class Ticket : ITicket
{
    public int TicketID { get; set; }
    public string EventName { get; set; }
    public string DepartureCity { get; set; }
    public string ArrivalCity { get; set; }
    public DateTime FlightDate { get; set; }
    public decimal Price { get; set; }

    public Ticket(int ticketID, string departureCity, string arrivalCity, DateTime flightDate, decimal price)
    {
        TicketID = ticketID;
        EventName = "Авиабилет";
        DepartureCity = departureCity;
        ArrivalCity = arrivalCity;
        FlightDate = flightDate;
        Price = price;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"TicketID: {TicketID}, From: {DepartureCity}, To: {ArrivalCity}, Date: {FlightDate:d}, Price: {Price:C}");
    }

    public override string ToString()
    {
        return $"{DepartureCity} → {ArrivalCity} ({FlightDate:d}) - {Price:C}";
    }
}