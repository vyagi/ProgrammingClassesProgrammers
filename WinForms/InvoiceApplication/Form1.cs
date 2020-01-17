using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace InvoiceApplication
{
    public partial class Form1 : Form
    {
        private string _path = @"C:\Users\MJAGIELA\Desktop\Invoice1.txt";
        public Form1()
        {
            InitializeComponent();
            statusLabel.Text = "Press Read file to read a file";
        }
        private void byNameButton_Click(object sender, EventArgs e)
        {
            resultListBox.Items.Clear();
            
            var content = File.ReadAllLines(_path);
            var values = new Dictionary<string, decimal>();

            foreach (var invoiceLine in content)
            {
                var split = invoiceLine.Split('\t');
                var name = split[0];
                var amount = Convert.ToDecimal(split[2]);

                if (values.ContainsKey(name))
                {
                    values[name] += amount;
                }
                else
                {
                    values[name] = amount;
                }
            }

            foreach (var item in values)
            {
                resultListBox.Items.Add($"{item.Key}\t{item.Value}");
            }
            statusLabel.Text = "File processed";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            resultListBox.Items.Clear();
            statusLabel.Text = "Clearing done";
        }

        private void byMonthsButton_Click(object sender, EventArgs e)
        {
            resultListBox.Items.Clear();

            var content = File.ReadAllLines(_path);
            var values = new Dictionary<string, decimal>();

            foreach (var invoiceLine in content)
            {
                var split = invoiceLine.Split('\t');
                DateTime date = DateTime.Parse(split[1]);
                var month = date.Month;
                var year = date.Year;
                var yearAndMonth = $"{year}-{month}";

                decimal amount = Convert.ToDecimal(split[2]);

                if (values.ContainsKey(yearAndMonth))
                {
                    values[yearAndMonth] += amount;
                }
                else
                {
                    values[yearAndMonth] = amount;
                }
            }
            foreach (var item in values)
            {
                resultListBox.Items.Add($"{item.Key}\t{item.Value}");
            }
            statusLabel.Text = "File processed";
        }
    }
}
