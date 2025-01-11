using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class BookingManager
{
    private List<Ticket> tickets = new List<Ticket>();
    private const string CartDirectory = "UserCarts";

    public BookingManager()
    {
        if (!Directory.Exists(CartDirectory))
        {
            Directory.CreateDirectory(CartDirectory);
        }
    }

    public void BookTicket(Ticket ticket)
    {
        tickets.Add(ticket);
    }

    public void SaveSelectedTickets(string user, IEnumerable<Ticket> selectedTickets)
    {
        string cartFilePath = GetCartFilePath(user);
        List<Ticket> userCart = LoadUserCart(user);

        userCart.AddRange(selectedTickets);

        string json = JsonSerializer.Serialize(userCart, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(cartFilePath, json);
    }

    public List<Ticket> GetUserTickets(string user)
    {
        return LoadUserCart(user);
    }

    public List<Ticket> GetTickets()
    {
        return tickets;
    }

    private List<Ticket> LoadUserCart(string user)
    {
        string cartFilePath = GetCartFilePath(user);

        if (!File.Exists(cartFilePath))
        {
            return new List<Ticket>();
        }

        string json = File.ReadAllText(cartFilePath);
        return JsonSerializer.Deserialize<List<Ticket>>(json) ?? new List<Ticket>();
    }

    private string GetCartFilePath(string user)
    {
        return Path.Combine(CartDirectory, $"{user}_cart.json");
    }
}
