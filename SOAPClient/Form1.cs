using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOAPClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnCalcSoap_Click(object sender, EventArgs e)
        {
            var client = new ServiceReference1.CalculatorSoapClient();
            // I/O
            var result  = await client.MultiplyAsync(10, 5);
            MessageBox.Show(result.ToString());
        }
    }
}
