using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Wcf_Giris.UrunlerServiceReference;//ekledik

/*
 Service reference ekleyince aşağıdaki dll'leri ekledi.
 * System.Runtime.Serialization ve System.ServiceModel
 
 */

namespace Wcf_Giris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Wcf Servisteki UrunlerService.svc classını burda UrunlerServiceClient diye kullanıyoruz.
            UrunlerServiceClient client = new UrunlerServiceClient();
            string msg = client.DoWork();
            MessageBox.Show(msg);
        }

        private void btnUrunlerGetir_Click(object sender, EventArgs e)
        {
            UrunlerServiceClient client = new UrunlerServiceClient();
            dataGridView1.DataSource = client.UrunListesi();
            client.Close();//servisi kapattık
      }
    }
}
