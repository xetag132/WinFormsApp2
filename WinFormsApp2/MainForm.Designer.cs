partial class MainForm
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Button btnBookTicket;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnLoad;
    private System.Windows.Forms.ListBox listBoxTickets;
    private System.Windows.Forms.TextBox txtDepartureCity;
    private System.Windows.Forms.TextBox txtArrivalCity;
    private System.Windows.Forms.Label lblDepartureCity;
    private System.Windows.Forms.Label lblArrivalCity;

    private void InitializeComponent()
    {
        this.btnBookTicket = new System.Windows.Forms.Button();
        this.btnSave = new System.Windows.Forms.Button();
        this.btnLoad = new System.Windows.Forms.Button();
        this.listBoxTickets = new System.Windows.Forms.ListBox();
        this.txtDepartureCity = new System.Windows.Forms.TextBox();
        this.txtArrivalCity = new System.Windows.Forms.TextBox();
        this.lblDepartureCity = new System.Windows.Forms.Label();
        this.lblArrivalCity = new System.Windows.Forms.Label();
        this.SuspendLayout();


        this.btnBookTicket.Location = new System.Drawing.Point(50, 120);
        this.btnBookTicket.Name = "btnBookTicket";
        this.btnBookTicket.Size = new System.Drawing.Size(150, 30);
        this.btnBookTicket.Text = "Показать билеты";
        this.btnBookTicket.UseVisualStyleBackColor = true;
        this.btnBookTicket.Click += new System.EventHandler(this.btnBookTicket_Click);


        this.btnSave.Location = new System.Drawing.Point(50, 170);
        this.btnSave.Name = "btnSave";
        this.btnSave.Size = new System.Drawing.Size(150, 30);
        this.btnSave.Text = "Добавить в корзину";
        this.btnSave.UseVisualStyleBackColor = true;
        this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

 
        this.btnLoad.Location = new System.Drawing.Point(50, 220);
        this.btnLoad.Name = "btnLoad";
        this.btnLoad.Size = new System.Drawing.Size(150, 30);
        this.btnLoad.Text = "Корзина";
        this.btnLoad.UseVisualStyleBackColor = true;
        this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);


        this.listBoxTickets.Location = new System.Drawing.Point(250, 30);
        this.listBoxTickets.Name = "listBoxTickets";
        this.listBoxTickets.Size = new System.Drawing.Size(200, 160);
        this.listBoxTickets.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;


        this.txtDepartureCity.Location = new System.Drawing.Point(150, 30);
        this.txtDepartureCity.Name = "txtDepartureCity";
        this.txtDepartureCity.Size = new System.Drawing.Size(100, 20);


        this.txtArrivalCity.Location = new System.Drawing.Point(150, 70);
        this.txtArrivalCity.Name = "txtArrivalCity";
        this.txtArrivalCity.Size = new System.Drawing.Size(100, 20);


        this.lblDepartureCity.Location = new System.Drawing.Point(50, 30);
        this.lblDepartureCity.Name = "lblDepartureCity";
        this.lblDepartureCity.Size = new System.Drawing.Size(100, 20);
        this.lblDepartureCity.Text = "Город вылета:";

 
        this.lblArrivalCity.Location = new System.Drawing.Point(50, 70);
        this.lblArrivalCity.Name = "lblArrivalCity";
        this.lblArrivalCity.Size = new System.Drawing.Size(100, 20);
        this.lblArrivalCity.Text = "Город прилета:";


        this.ClientSize = new System.Drawing.Size(484, 261);
        this.Controls.Add(this.lblDepartureCity);
        this.Controls.Add(this.lblArrivalCity);
        this.Controls.Add(this.txtDepartureCity);
        this.Controls.Add(this.txtArrivalCity);
        this.Controls.Add(this.listBoxTickets);
        this.Controls.Add(this.btnBookTicket);
        this.Controls.Add(this.btnSave);
        this.Controls.Add(this.btnLoad);
        this.Name = "MainForm";
        this.Text = "Бронирование билетов";
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
