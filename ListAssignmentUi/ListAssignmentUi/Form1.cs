using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListAssignmentUi
{
    public partial class Form1 : Form
    {
        int index = 0;
        int uniPrice=1;
        List<string> customerName = new List<string> { };
        List<string> contuctNo = new List<string> { };
        List<string> address = new List<string> { };
        List<string> order = new List<string> { };
        List<string> quantity = new List<string> { };

        List<string> bill = new List<string> { };
        

        public Form1()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            customerName.Add(customerNameTextBox.Text);
            contuctNo.Add(contuctTextBox.Text);
            address.Add(addressTextBox.Text);
            order.Add(orderComboBox.Text);

            if (String.IsNullOrEmpty(quantityTextBox.Text))
            {
                MessageBox.Show("Please fill the current quantity");
                return;
            }
            else
            {
                quantity.Add(quantityTextBox.Text);
            }


            if (order[index] == "Black")
            {
                uniPrice = 120;
            }
            else if (order[index] == "Cold")
            {
                uniPrice = 100;
            }
            else if (order[index] == "Hot")
            {
                uniPrice = 90;
            }
            else if (order[index] == "Regular")
            {
                uniPrice = 80;
            }
            bill.Add (Convert.ToString(Convert.ToInt32(quantity[index] )* uniPrice));
            index++;

            showRichTextBox.AppendText("\n\t Customer No. [" + index + "] Information \n\t_______________________\n\n");
            index--;

            showRichTextBox.AppendText("Customer Name : " + customerName[index] + "\n");
            showRichTextBox.AppendText("Contuct Nimber : " + contuctNo[index] + "\n");
            showRichTextBox.AppendText("Address : " + address[index] + "\n");
            showRichTextBox.AppendText("Order : " + order[index] + "\n");
            showRichTextBox.AppendText("Quantity : " + quantity[index] + "\n");
            showRichTextBox.AppendText("Total Bill is : " + bill[index] + ".tk \n");
            index++;

            customerNameTextBox.Clear();
            contuctTextBox.Clear();
            addressTextBox.Clear();
            orderComboBox.Text = " ";
            quantityTextBox.Clear();
        }
    }
}
