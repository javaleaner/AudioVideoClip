using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AudioVideoClip
{
    public partial class Form1 : Form
    {
        public string m1Name,m2Name;
        public Form1()
        {
            InitializeComponent();
            m1Name = "";
            m2Name = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName=="")
            {
                return;
            }
            byte[] buf=new byte[1024*1024*10];
            textBox1.Text = openFileDialog1.FileName;
            m1Name = openFileDialog1.FileName;
            FileStream f1 = File.OpenRead(m1Name);
            int length=f1.Read(buf, 0, 1024 * 1024 * 10);
            f1.Close();

            FileStream fs = File.Create(Application.StartupPath + "\\music\\new.mp3");
            fs.Write(buf, 0, length/2);
            fs.Close();


        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
