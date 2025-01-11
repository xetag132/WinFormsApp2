using System;
using System.Collections.Generic;
using System.Windows.Forms;

public partial class MainForm : Form
{
    private BookingManager bookingManager = new BookingManager();
    private string currentUser;

    public MainForm(string user)
    {
        InitializeComponent();
        currentUser = user;
        LoadTicketsToListBox();
    }

    private void btnBookTicket_Click(object sender, EventArgs e)
    {
        string departureCity = txtDepartureCity.Text;
        string arrivalCity = txtArrivalCity.Text;

        if (string.IsNullOrWhiteSpace(departureCity) || string.IsNullOrWhiteSpace(arrivalCity))
        {
            MessageBox.Show("Пожалуйста, введите оба города!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        Random random = new Random();
        List<Ticket> newTickets = new List<Ticket>();

        for (int i = 0; i < 10; i++)
        {
            int ticketID = random.Next(1000, 9999);
            DateTime flightDate = DateTime.Now.AddDays(random.Next(1, 30));
            decimal price = random.Next(3000, 10000);

            Ticket ticket = new Ticket(ticketID, departureCity, arrivalCity, flightDate, price);
            newTickets.Add(ticket);
        }

        foreach (var ticket in newTickets)
        {
            bookingManager.BookTicket(ticket);
        }

        MessageBox.Show($"Успешно найдено {newTickets.Count} билетов на рейсы {departureCity} → {arrivalCity}.", "Поиск завершен", MessageBoxButtons.OK, MessageBoxIcon.Information);

        LoadTicketsToListBox();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        var selectedTickets = new List<Ticket>();
        foreach (var item in listBoxTickets.SelectedItems)
        {
            if (item is Ticket ticket)
            {
                selectedTickets.Add(ticket);
            }
        }

        if (selectedTickets.Count > 0)
        {
            bookingManager.SaveSelectedTickets(currentUser, selectedTickets);
            MessageBox.Show("Билеты добавлены в вашу корзину!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show("Пожалуйста, выберите хотя бы один билет.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnLoad_Click(object sender, EventArgs e)
    {
        var userTickets = bookingManager.GetUserTickets(currentUser);
        if (userTickets.Count == 0)
        {
            MessageBox.Show("Ваша корзина пуста.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            listBoxTickets.Items.Clear();
            foreach (var ticket in userTickets)
            {
                listBoxTickets.Items.Add(ticket);
            }
        }
    }

    private void LoadTicketsToListBox()
    {
        listBoxTickets.Items.Clear();
        foreach (var ticket in bookingManager.GetTickets())
        {
            listBoxTickets.Items.Add(ticket);
        }
    }
}
