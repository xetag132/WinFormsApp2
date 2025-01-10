partial class RegistrationForm
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.TextBox txtLogin;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Button btnRegister;

    private void InitializeComponent()
    {
        this.txtLogin = new System.Windows.Forms.TextBox();
        this.txtPassword = new System.Windows.Forms.TextBox();
        this.btnRegister = new System.Windows.Forms.Button();
        this.SuspendLayout();

        this.txtLogin.Location = new System.Drawing.Point(50, 30);
        this.txtLogin.Name = "txtLogin";
        this.txtLogin.Size = new System.Drawing.Size(200, 20);
        this.txtLogin.PlaceholderText = "Введите логин";

        this.txtPassword.Location = new System.Drawing.Point(50, 70);
        this.txtPassword.Name = "txtPassword";
        this.txtPassword.Size = new System.Drawing.Size(200, 20);
        this.txtPassword.UseSystemPasswordChar = true;
        this.txtPassword.PlaceholderText = "Введите пароль";

        this.btnRegister.Location = new System.Drawing.Point(100, 110);
        this.btnRegister.Name = "btnRegister";
        this.btnRegister.Size = new System.Drawing.Size(100, 30);
        this.btnRegister.Text = "Зарегистрироваться";
        this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

        this.ClientSize = new System.Drawing.Size(300, 200);
        this.Controls.Add(this.txtLogin);
        this.Controls.Add(this.txtPassword);
        this.Controls.Add(this.btnRegister);
        this.Text = "Регистрация";
        this.ResumeLayout(false);
    }
}
