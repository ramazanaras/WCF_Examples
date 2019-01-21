using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuzeyYeli.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Wcf servisindeki UrunService.svc classı burda sonuna Client eklenmiş
            UrunService.UrunServiceClient client = new UrunService.UrunServiceClient();

            dataGridView1.DataSource = client.Listele();


        }
    }
}
