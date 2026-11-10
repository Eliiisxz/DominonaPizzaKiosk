using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormCheckout.cs
{
    public partial class FormReceipt : Form
    {
        public FormReceipt(string orderNumber, decimal total, decimal payment, decimal change)
        {
            this.Size = new Size(400, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;

            Label title = new Label();
            title.Text = "DOMINONA'S PIZZA";
            title.Font = new Font("Arial", 18, FontStyle.Bold);
            title.Location = new Point(70, 25);
            title.AutoSize = true;
            Controls.Add(title);

            Label receipt = new Label();
            receipt.Text = "           OFFICIAL RECEIPT\n\n" +
                "Order No.: " + orderNumber + "\n\n" +
                "--------------------------------\n" +
                "Total Amount:  P" + total.ToString("N2") + "\n" +
                "Payment:       P" + payment.ToString("N2") + "\n" +
                "Change:        P" + change.ToString("N2") + "\n" +
                "--------------------------------\n\n" +
                "       THANK YOU FOR ORDERING!\n" +
                "          Please come again!";
            receipt.Font = new Font("Arial", 11);
            receipt.Location = new Point(35, 100);
            receipt.AutoSize = true;
            Controls.Add(receipt); Button close = new Button();
            close.Text = "CLOSE";
            close.Location = new Point(135, 380);
            close.Size = new Size(110, 35); 
            close.Click += (s, e) => this.Close();
            Controls.Add(close);
        }
    }
}