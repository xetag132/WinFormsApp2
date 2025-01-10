using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
public partial class LoginForm : Form
{
    private const string UsersFilePath = "users.json";

    public LoginForm()
    {
        InitializeComponent();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        string login = txtLogin.Text.Trim();
        string password = txtPassword.Text.Trim();

        if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
        {
            MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var users = LoadUsers();
        if (users.TryGetValue(login, out var storedPassword) && storedPassword == password)
        {
            MessageBox.Show("Вход выполнен успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            this.Close();
        }
        else
        {
            MessageBox.Show("Неверный логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        this.Hide();
        RegistrationForm registrationForm = new RegistrationForm();
        registrationForm.ShowDialog();
        this.Show();
    }

    private Dictionary<string, string> LoadUsers()
    {
        if (!File.Exists(UsersFilePath))
        {
            return new Dictionary<string, string>();
        }

        string json = File.ReadAllText(UsersFilePath);
        return JsonSerializer.Deserialize<Dictionary<string, string>>(json) ?? new Dictionary<string, string>();
    }
}
