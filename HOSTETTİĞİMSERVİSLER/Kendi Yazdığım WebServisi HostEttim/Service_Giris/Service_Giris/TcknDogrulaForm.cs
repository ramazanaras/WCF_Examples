using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Service_Giris.TcknServiceReference;//ekledik
namespace Service_Giris
{
    public partial class TcknDogrulaForm : Form
    {
        public TcknDogrulaForm()
        {
            InitializeComponent();
        }

        private void TcknDogrulaForm_Load(object sender, EventArgs e)
        {



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDogrula_Click(object sender, EventArgs e)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();

            long tckn = Convert.ToInt64(mskdTCKN.Text);
            string isim = txtIsıim.Text.ToUpper();//büyük harfe dönüştür
            string soyisim = txtSoyIsim.Text.ToUpper();
            int dogumyili = Convert.ToInt32(mskdDogumYili.Text);


            bool sonuc = client.TCKimlikNoDogrula(tckn, isim, soyisim, dogumyili);

            if (sonuc==true)
            {
                MessageBox.Show("Tckn Doğru");
            }
            else
            {
                MessageBox.Show("Tckn Yanlış");
            }




        }
    }
}

/*Tckn webservis
 https://tckimlik.nvi.gov.tr/Service/KPSPublic.asmx?wsdl
 */
