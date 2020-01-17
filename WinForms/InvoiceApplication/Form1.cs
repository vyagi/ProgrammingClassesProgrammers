using System;
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

        private void readButton_Click(object sender, EventArgs e)
        {
            var content = File.ReadAllLines(_path);
        }
    }
}
