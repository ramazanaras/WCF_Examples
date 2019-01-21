using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WCFServiceGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            //WcfSErvice1 projesindeki EntityService classının sonuna Client kelimesi eklenmiş.bunu kullanıyoruz
            EntityService.EntityServiceClient servis = new EntityService.EntityServiceClient();//servisten instance aldık

           textBox1.Text=servis.Listele().ToString();

        }
    }
}



//SErvisi ekleyince aşağıdaki dll'ler eklendi
// System.Runtime.Serialization;
// System.ServiceModel