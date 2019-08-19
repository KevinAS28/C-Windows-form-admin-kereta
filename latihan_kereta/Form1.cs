using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace latihan_kereta
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        //nama kereta: harga
        Dictionary<string, double> kereta = null;
        Dictionary<string, string> nama_keretaa = new Dictionary<string, string>() {
            {"AG001", "Argo bromo"},
            {"BS001", "Bima sakti"},
            {"JE001", "Jakarta Express"}
        };
        struct penumpang
        {
            public double persentase;
            public CheckBox box;
            public penumpang(double p, CheckBox b)
            {
                this.persentase = p;
                this.box = b;
            }
        };
        
        Dictionary<string, penumpang> jenis_penumpang = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.jenis_penumpang = new Dictionary<string, penumpang>
            {
                {"Anak", new penumpang(15/100, jp_anak)},
                {"Dewasa", new penumpang(1/10, jp_dewasa)},
                {"Lansia", new penumpang(1/20, jp_lansia) }
            };

        
            this.kereta = new Dictionary<string, double>
            {
                {"AG001", 1000000},
                {"BS001", 1200000 },
                {"JE001", 1300000 }
            };

            //isi jenis kereta
            foreach (KeyValuePair<string, double> keyValue in this.kereta)
            {
                this.jenis_kereta.Items.Add(keyValue.Key);
            }

            //isis tanggal
            this.tanggal.Text = String.Format(@"{0}:{1}:{2}", DateTime.Now.Day.ToString(), DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString());


        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void errMissing(string pesan)
        {
            MessageBox.Show(String.Format("Mohon cek kembali masukan anda pada {0}", pesan), "Kesalahan Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Proses_Click(object sender, EventArgs e)
        {
            int jumlah_tiket;
            string jenis_penumpangg = "";
            string jenis_kereta = "";
            double jumlah_uang;
            
            try{
                jumlah_tiket = int.Parse(this.jumlah_tiket.Text);
            }catch (Exception s){errMissing("jumlah tiket");return;}

            try
            {
                jenis_kereta =  this.jenis_kereta.SelectedItem.ToString();
            }catch{errMissing("jenis kereta");return;}

            try
            {
                jenis_kereta = this.jenis_kereta.SelectedItem.ToString();
            }catch{errMissing("jenis kereta");return;}

            foreach (KeyValuePair<string, penumpang> x in this.jenis_penumpang){
                if (x.Value.box.Checked)
                {
                    jenis_penumpangg = x.Key;
                    break;
                }
            }
            if (jenis_penumpangg == ""){
                errMissing("jenis penumpang");
                return;
            }

            try
            {
                jumlah_uang = Convert.ToDouble(this.jumlah_uang.Text);
            }catch{errMissing("jumlah uang");return;}
            

            double harga_tiket = this.kereta[jenis_kereta];
            this.nama_kereta.Text = this.nama_keretaa[jenis_kereta];
            this.harga_tiket.Text = Convert.ToString(harga_tiket);
            double biaya = harga_tiket * jumlah_tiket;
            this.biaya.Text =Convert.ToString(biaya);

            double potongan_persen = this.jenis_penumpang[jenis_penumpangg].persentase;

            this.potongan.Text = Convert.ToString( (biaya * potongan_persen));
            this.ppn.Text = Convert.ToString(biaya * 0.1);
            double harga_total = biaya - (biaya * 0.1) - (biaya * potongan_persen);
            this.total_bayar.Text = Convert.ToString(harga_total);
            this.potongan.Text = Convert.ToString(biaya - (biaya * potongan_persen));
            double uang = Convert.ToDouble(this.jumlah_uang.Text);

            this.biaya_asuransi.Text = Convert.ToString((biaya * potongan_persen));
            Console.WriteLine(String.Format("{0} {1} {2}", biaya, potongan_persen, jenis_penumpangg));

            if ((uang - harga_total) < 0)
            {
                MessageBox.Show(String.Format("Uang anda tidak cukup. kurang", Math.Abs(uang-harga_total)), "Uang anda kurang", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.kembali.Text = Convert.ToString(uang - harga_total);




            
        }
    }
}
