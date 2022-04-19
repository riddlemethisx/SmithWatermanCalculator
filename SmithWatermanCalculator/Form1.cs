using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeedlemanWunschCalculator
{
    public partial class Form1 : Form
    {
        int kelimeUzunluk1;     //sütunlar
        int kelimeUzunluk2;     //satırlar
        string karakterDizisi1;
        string karakterDizisi2;
        int match;
        int missmatch;
        int gap;

        DataGridView table = new DataGridView();

        Color renk = new Color();
        Color secimRengi = new Color();
        public Form1()
        {
            InitializeComponent();
            KelimeleriAl();
            TabloyuOlusturma();
            table = dataGridView1;
            match = int.Parse(txtMatch.Text);
            missmatch = int.Parse(txtMissmatch.Text);
            gap = int.Parse(txtGap.Text);

            renk = Color.BlueViolet;
            secimRengi = Color.LightGray;
            dataGridView1.RowsDefaultCellStyle.SelectionBackColor = secimRengi;
            dataGridView2.RowsDefaultCellStyle.SelectionBackColor = renk;
            dataGridView2.ClearSelection();

        }

        private void btnKelimeKlasor_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", System.IO.Path.GetDirectoryName(Application.StartupPath));     //2. parametre dosyanın nerde aranacağını belirler
        }


        void KelimeleriAl()
        {
            string dosya_yolu = Application.StartupPath + @"\seq1.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);

            string yazi = sw.ReadLine();
            kelimeUzunluk1 = int.Parse(yazi);

            yazi = sw.ReadLine();
            karakterDizisi1 = yazi;
            //label4.Text = kelimeUzunluk1 + " " + karakterDizisi1;
            txtKelime1.Text = karakterDizisi1;

            sw.Close();
            fs.Close();




            dosya_yolu = Application.StartupPath + @"\seq2.txt";
            fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            sw = new StreamReader(fs);

            yazi = sw.ReadLine();
            kelimeUzunluk2 = int.Parse(yazi);

            yazi = sw.ReadLine();
            karakterDizisi2 = yazi;
            //label4.Text = kelimeUzunluk2 + " " + karakterDizisi2;
            txtKelime2.Text = karakterDizisi2;

            sw.Close();
            fs.Close();




        }


        void TabloyuOlusturma()
        {


            #region COLUMN EKLEME VE COLUMN HEADER'I OLUŞTURMA
            dataGridView1.Columns.Add("m", "m");
            for (int k = 0; k < kelimeUzunluk1; k++)
            {
                dataGridView1.Columns.Add(karakterDizisi1[k].ToString(), karakterDizisi1[k].ToString());
            }
            #endregion





            dataGridView2.Columns.Add(null, " ");
            dataGridView2.Rows.Add("n");
            for (int k = 0; k < kelimeUzunluk2; k++)
            {
                dataGridView2.Rows.Add(karakterDizisi2[k].ToString());
            }




        }


        private void btnHesapla_Click(object sender, EventArgs e)
        {
            var sw = new Stopwatch();


            NeedlemanAlgoritma();

            sw.Stop();
            //Console.WriteLine(sw.Elapsed); // TimeSpan
            //Console.WriteLine(sw.ElapsedMilliseconds);
            //Console.WriteLine(sw.ElapsedTicks);

            lblCalismaZamani.Text = sw.Elapsed + " msn";
        }


        int i = 0;      //sütunlar
        int j = 0;      //satırlar

        int nullVal = 999;
        void NeedlemanAlgoritma()
        {

            int deger1 = 0;
            int deger2 = 0;
            int deger3 = 0;
            int S1S2 = 0;
            int hucre = 0;








            for (int g = 0; g < kelimeUzunluk2 + 1; g++)
            {
                table.Rows.Add();
                for (int k = 0; k < kelimeUzunluk1 + 1; k++)
                {  //bu kısım 1 satırı yapıyor


                    #region S1S2 HESAPLAMA
                    if (k > 0 && g > 0 && k < karakterDizisi1.Length - 1 && g < karakterDizisi2.Length - 1)
                    {
                        if (karakterDizisi1[k - 1] == karakterDizisi2[g - 1])
                            S1S2 = match;
                        else
                            S1S2 = missmatch;
                    }
                    #endregion



                    #region DEĞERLERİ HESAPLAMA
                    if (i > 0 && j > 0)
                        deger1 = int.Parse(table[i - 1, j - 1].Value.ToString()) + S1S2;
                    else
                        deger1 = nullVal;




                    if (i > 0)
                    {

                        deger2 = int.Parse(table[i - 1, j].Value.ToString()) + gap;
                    }
                    else
                        deger2 = nullVal;




                    if (j > 0)
                        deger3 = int.Parse(table[i, j - 1].Value.ToString()) + gap;
                    else
                        deger3 = nullVal;
                    #endregion



                    #region NULL OLANLAR MAX İŞLEMİNE DAHİL EDİLMEYECEK
                    int[] degerler = new int[3];
                    degerler[0] = deger1;
                    degerler[1] = deger2;
                    degerler[2] = deger3;


                    List<int> nullDegiller = new List<int>();
                    for (int s = 0; s < 3; s++)
                    {
                        if (degerler[s] != nullVal)
                            nullDegiller.Add(degerler[s]);

                    }
                    #endregion



                    #region MAX İŞLEMİ---YANİ EN BÜYÜK DEĞER ALINIYOR
                    if (nullDegiller.Count == 3)
                        hucre = EnBuyuk(deger1, deger2, deger3);
                    else if (nullDegiller.Count == 2)
                        hucre = Math.Max(nullDegiller[0], nullDegiller[1]);
                    else if (nullDegiller.Count == 1)
                        hucre = nullDegiller[0];
                    else
                        hucre = 0;
                    #endregion


                    if (j == 0 || i==0)
                    {
                        if (hucre > 0 )
                            table.Rows[j].Cells[i].Value = hucre;
                        else 
                            table.Rows[j].Cells[i].Value = 0;
                    }
                    else
                    {
                        if (hucre > 0)
                            table.Rows[j].Cells[i].Value = hucre;
                        else
                            table.Rows[j].Cells[i].Value = 0;
                    }



                    //table.Rows[j].Cells[i].Value = hucre;

                    //table[j,i].Value = hucre; //BU YÖNTEM HATALIDIR---ÇALIŞMIYOR!!!
                    i++;
                }
                i = 0;
                j++;
            }








            HizalamaBul();

        }   //ALGORİTMA BAŞARILI BİR ŞEKİLDE ÇALIŞIYOR

        private int EnBuyuk(int deger1, int deger2, int deger3)
        {
            int sonuc = 0;
            if (Math.Max(deger1, deger2) == deger1)
            {
                if (Math.Max(deger1, deger3) == deger1)
                    sonuc = deger1;
                else
                    sonuc = deger3;
            }
            else
            {
                if (Math.Max(deger2, deger3) == deger2)
                    sonuc = deger2;
                else
                    sonuc = deger3;
            }



            return sonuc;

        }



        void HizalamaBul()
        {
            //buradan rakamlar çekilecek ve hizalama bulunmuş olacak. rakamlar diziye atılacak
            //daha sonra rakamlar toplanarak puan-score bulunmuş olacak
            List<int> hDegerleri = new List<int>();     //hizalama değerleri


            int deger1 = 0;
            int deger2 = 0;
            int deger3 = 0;

            int koseI = table.Columns.Count - 1;
            int koseJ = table.Rows.Count - 1;

            int koseDeger = int.Parse(table[koseJ, koseI].Value.ToString());
            hDegerleri.Add(koseDeger);
            table[koseJ, koseI].Style.BackColor = renk;
            table[0, 0].Style.BackColor = renk;    //üst köşe ve alt köşe kırmızı yapılıyor


            while (koseJ != 0 && koseI != 0)    //üst köşeye ulaşana kadar döngü çalışıyor
            {
                if (karakterDizisi1[koseI - 1] == karakterDizisi2[koseJ - 1])
                {
                    koseDeger = int.Parse(table[koseJ - 1, koseI - 1].Value.ToString());
                    hDegerleri.Add(koseDeger);
                    table[koseJ - 1, koseI - 1].Style.BackColor = renk;
                }
                else
                {
                    deger1 = int.Parse(table[koseJ - 1, koseI - 1].Value.ToString());
                    deger2 = int.Parse(table[koseJ - 1, koseI].Value.ToString());
                    deger3 = int.Parse(table[koseJ, koseI - 1].Value.ToString());

                    int sonuc = EnBuyuk(deger1, deger2, deger3);
                    hDegerleri.Add(sonuc);

                    if (sonuc == deger1)        //3 değer birbirine eşitse yine buraya girecek. yani çapraz gidecek
                    {
                        table[koseJ - 1, koseI - 1].Style.BackColor = renk;
                        koseJ = koseJ - 1;
                        koseI = koseI - 1;
                    }
                    else if (sonuc == deger2)
                    {
                        table[koseJ - 1, koseI].Style.BackColor = renk;
                        koseJ = koseJ - 1;
                    }
                    else if(sonuc == deger3)
                    {
                        table[koseJ, koseI - 1].Style.BackColor = renk;
                        koseI = koseI - 1;
                    }
                    else
                    {
                        table[koseJ - 1, koseI - 1].Style.BackColor = renk;
                        koseJ = koseJ - 1;
                        koseI = koseI - 1;
                    }

                }
            }















            #region PUAN HESAPLAMA
            int toplam = 0;
            foreach (int item in hDegerleri)
            {
                toplam += item;
            }
            txtPuan.Text = toplam.ToString();
            #endregion
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
