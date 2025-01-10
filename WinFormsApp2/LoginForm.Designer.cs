partial class LoginForm
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.TextBox txtLogin;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Button btnLogin;
    private System.Windows.Forms.Button btnRegister;

    private void InitializeComponent()
    {
        this.txtLogin = new System.Windows.Forms.TextBox();
        this.txtPassword = new System.Windows.Forms.TextBox();
        this.btnLogin = new System.Windows.Forms.Button();
        this.btnRegister = new System.Windows.Forms.Button();
        this.SuspendLayout();

        this.txtLogin.Location = new System.Drawing.Point(50, 30);
        this.txtLogin.Name = "txtLogin";
        this.txtLogin.Size = new System.Drawing.Size(200, 20);
        this.txtLogin.PlaceholderText = "Логин";

        this.txtPassword.Location = new System.Drawing.Point(50, 70);
        this.txtPassword.Name = "txtPassword";
        this.txtPassword.Size = new System.Drawing.Size(200, 20);
        this.txtPassword.UseSystemPasswordChar = true;
        this.txtPassword.PlaceholderText = "Пароль";

        this.btnLogin.Location = new System.Drawing.Point(50, 110);
        this.btnLogin.Name = "btnLogin";
        this.btnLogin.Size = new System.Drawing.Size(90, 30);
        this.btnLogin.Text = "Вход";
        this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

        this.btnRegister.Location = new System.Drawing.Point(160, 110);
        this.btnRegister.Name = "btnRegister";
        this.btnRegister.Size = new System.Drawing.Size(90, 30);
        this.btnRegister.Text = "Регистрация";
        this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

        this.ClientSize = new System.Drawing.Size(300, 200);
        this.Controls.Add(this.txtLogin);
        this.Controls.Add(this.txtPassword);
        this.Controls.Add(this.btnLogin);
        this.Controls.Add(this.btnRegister);
        this.Text = "Вход";
        this.ResumeLayout(false);
    }
}
