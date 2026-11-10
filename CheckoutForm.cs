using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormCheckout.cs
{
    public partial class FormCheckout : Form
    {
        public FormCheckout()
        {
            decimal total = 1876m;

            TextBox txtPayment;
            Label lblTotal;
            Label lblChange;

            Button btnPay;
            Button btnCancel;

            this.Text = "Dominona's Pizza Kiosk Checkout";
            this.Size = new Size(500, 440);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.BurlyWood;

            Label title = new Label();
            title.Text = "DOMINONA'S PIZZA";
            title.Font = new Font("lucida Handwriting", 22, FontStyle.Bold);
            title.Location = new Point(100, 30);
            title.AutoSize = true;
            Controls.Add(title);

            lblTotal = new Label();
            lblTotal.Text = "Total Amount: ₱" + total.ToString("N2");
            lblTotal.Font = new Font("Arial", 14, FontStyle.Bold);
            lblTotal.Location = new Point(80, 110); lblTotal.AutoSize = true;
            Controls.Add(lblTotal);

            Label paymentLabel = new Label();
            paymentLabel.Text = "Enter Payment:";
            paymentLabel.Font = new Font("Arial", 12);
            paymentLabel.Location = new Point(80, 170);
            paymentLabel.AutoSize = true;
            Controls.Add(paymentLabel);

            txtPayment = new TextBox();
            txtPayment.Location = new Point(220, 168);
            txtPayment.Size = new Size(150, 30);
            Controls.Add(txtPayment);

            lblChange = new Label();
            lblChange.Text = "Change: ₱0.00";
            lblChange.Font = new Font("Arial", 14, FontStyle.Bold);
            lblChange.Location = new Point(80, 230);
            lblChange.AutoSize = true;
            Controls.Add(lblChange);

            btnPay = new Button();
            btnPay.Text = "PAY";
            btnPay.Location = new Point(100, 300); btnPay.Size = new Size(110, 40);
            btnPay.BackColor = Color.Maroon;
            btnPay.ForeColor = Color.White;
            Controls.Add(btnPay);

            btnCancel = new Button();
            btnCancel.Text = "CANCEL";
            btnCancel.Location = new Point(240, 300);
            btnCancel.Size = new Size(110, 40);
            Controls.Add(btnCancel);

            
            btnPay.Click += (s, e) =>
            {
            decimal payment;

            if (!decimal.TryParse(txtPayment.Text, out payment))
            {
                MessageBox.Show("Please enter a valid payment.");
                return;
            }

            if (payment < total)
            {
                MessageBox.Show("Insufficient Payment!");
                return;
            }
                decimal change = payment - total;

                lblChange.Text = "Change: ₱" + change.ToString("N2");

                string orderNumber =
                    "ORD" + DateTime.Now.ToString("yyyyMMddHHmmss");

                ReceiptForm receipt = new ReceiptForm(
                    orderNumber, total, payment, change
                );

                receipt.ShowDialog();
            };

            
            btnCancel.Click += (s, e) =>
            {
                txtPayment.Clear();
                lblChange.Text = "Change: ₱0.00";
            };
        }
    }
}