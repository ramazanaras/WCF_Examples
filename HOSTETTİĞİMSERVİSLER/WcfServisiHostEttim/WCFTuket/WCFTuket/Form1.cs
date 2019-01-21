using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WCFTuket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Kendi host ettiğim servis
            //http://wcfservicekatmanli.somee.com/UrunService.svc



            ServiceReference1.UrunServiceClient client = new ServiceReference1.UrunServiceClient();
            ServiceReference1.UrunDTO[] datalar = client.Listele();
            dataGridView1.DataSource = datalar;



        }

        private void button1_Click(object sender, EventArgs e)
        {

            ServiceReference1.UrunServiceClient client = new ServiceReference1.UrunServiceClient();
            bool sonuc = client.Ekle(new ServiceReference1.UrunDTO
               {
                   UrunAdi = "TestUrun",
                   TedarikciID = 1,
                   KategoriID = 2,
                   BirimdekiMiktar = "10 boxes x 20 bags",
                   Fiyat = 20,
                   Stok = 15,
                   YeniSatis = 3,
                   EnAzYenidenSatisMikatari = 1,
                   Sonlandi = false,
                   UrunResimUrl = "dsdasdss"




               });
        }
    }
}
