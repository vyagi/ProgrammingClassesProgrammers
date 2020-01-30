using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var path = textBox1.Text;
            if (!File.Exists(path))
            {
                MessageBox.Show("The file does not exist");
                return;
            }
            var lines = File.ReadAllLines(path).Skip(1);

            var invoices = lines
                .Select(x => x.Split('\t'))
                .Select(x => new
                {
                    InvoiceDate = DateTime.Parse(x[0]),
                    Amount = int.Parse(x[1])
                });
            var totalSum = invoices.Select(x => x.Amount).Sum();
            var uniqueDates = invoices.Select(x => x.InvoiceDate).Distinct().Count();

            var days = invoices.Select(x => x.InvoiceDate.DayOfWeek).Distinct();
            var daysString = string.Join(", ", days);

            var grouped = invoices.GroupBy(x => x.InvoiceDate.Month)
                .Select(x => $"{x.Key} - {x.Count()}");


            var message = $"Total dates: {uniqueDates}, total amount {totalSum}.\r\n"
                        + $"Invoice days: {daysString}";


            textBox2.Text = message;

        }
    }
    //public class Invoice
    //{
    //    public DateTime InvoiceDate { get; set; }
    //    public int Amount { get; set; }
    //    public Invoice(DateTime date, int amount)
    //    {
    //        InvoiceDate = date;
    //        Amount = amount;
    //    }
    //}
}
