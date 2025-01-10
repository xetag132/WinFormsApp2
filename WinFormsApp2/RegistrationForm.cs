using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

public partial class RegistrationForm : Form
{
    private const string UsersFilePath = "users.json";

    public RegistrationForm()
    {
        InitializeComponent();
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        string login = txtLogin.Text.Trim();
        string password = txtPassword.Text.Trim();

        if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
        {
            MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var users = LoadUsers();

        if (users.ContainsKey(login))
        {
            MessageBox.Show("Этот логин уже используется.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        users[login] = password;
        SaveUsers(users);

        MessageBox.Show("Регистрация прошла успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.Close();
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

    private void SaveUsers(Dictionary<string, string> users)
    {
        string json = JsonSerializer.Serialize(users);
        File.WriteAllText(UsersFilePath, json);
    }
}
