using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WcfServisimi_Tuket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ServiceReference1.ProductServiceClient client = new ServiceReference1.ProductServiceClient("BasicHttpBinding_IProductService");
        private void Form1_Load(object sender, EventArgs e)
        {
            ServiceReference1.SurrogateProduct[] datalar=client.GetProducts(1);
            dataGridView1.DataSource = datalar;
        }
    }
}
