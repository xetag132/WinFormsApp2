using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class BookingManager
{
    public delegate void TicketBookedHandler(Ticket ticket);
    public event TicketBookedHandler TicketBooked;

    private List<Ticket> tickets = new List<Ticket>();

    public void BookTicket(Ticket ticket)
    {
        tickets.Add(ticket);
        TicketBooked?.Invoke(ticket);
    }

    public void SaveSelectedTickets(string filePath, IEnumerable<Ticket> selectedTickets)
    {
        string jsonString = JsonSerializer.Serialize(selectedTickets);
        File.WriteAllText(filePath, jsonString);
    }

    public void LoadTickets(string filePath)
    {
        if (File.Exists(filePath))
        {
            string jsonString = File.ReadAllText(filePath);
            tickets = JsonSerializer.Deserialize<List<Ticket>>(jsonString) ?? new List<Ticket>();
        }
    }

    public List<Ticket> GetTickets()
    {
        return tickets;
    }
}