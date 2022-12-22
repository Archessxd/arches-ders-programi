using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders_programi_uygulamasi
{
    public partial class Form1 : Form
    {
        string[] ders = new string[10];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //array temizleme
            for (int i = 0;i<ders.Length;i++)
            {
                ders[i] = null;
            }


            listBox1.Items.Clear();

            if (comboBox1.SelectedIndex == 0)
            {
                ders[0] = "robotik kodlama";
                ders[1] = "robotik kodlama";
                ders[2] = "robotik kodlama";
                ders[3] = "robotik kodlama";
                ders[4] = "Kimya";
                ders[5] = "Kimya";
                ders[6] = "Din Kültürü";
                ders[7] = "Din Kültürü";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                ders[0] = "Edebiyat";
                ders[1] = "Edebiyat";
                ders[2] = "İngilizce";
                ders[3] = "İngilizce";
                ders[4] = "Matematik";
                ders[5] = "Matematik";
                ders[6] = "Beden Eğitimi";
                ders[7] = "Beden Eğitimi";
            }
            if (comboBox1.SelectedIndex ==2)
            {
                ders[0] = "Biyoloji";
                ders[1] = "Biyoloji";
                ders[2] = "Rehberlik";
                ders[3] = "Edebiyat";
                ders[4] = "Edebiyat";
                ders[5] = "Tarih";
                ders[6] = "Tarih";
                ders[7] = "Fizik";
                ders[8] = "Fizik";
            }
            if (comboBox1.SelectionLength==3)
            {
                for (int i = 0;i<ders.Length;i++)
                {
                    ders[i] = "Nesne Tabanlı Programlama";
                }
            }
            if (comboBox1.SelectedIndex == 4)
            {
                ders[0] = "Coğrafya";
                ders[1] = "Coğrafya";
                ders[2] = "Felsefe";
                ders[2] = "Felsefe";
                ders[3] = "Edebiyat";
                ders[4] = "Matematik";
                ders[4] = "Matematik";
                ders[4] = "Matematik";
            }


            for (int i = 0;i<ders.Length;i++)
            {
                if (ders[i] == null) 
                {
                    continue;
                }

                listBox1.Items.Add(ders[i].ToString());
            }
        
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
