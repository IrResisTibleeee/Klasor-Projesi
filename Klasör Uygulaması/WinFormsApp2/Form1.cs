using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.AccessControl;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace WinFormsApp2

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //KLASÖR ÝÞLEMLERÝ 
            //KLASÖR AÇMA 
            //ÝÇ ÝÇE KLASÖR AÇMA


            //Directory.CreateDirectory("C:/DENEME");  // D:\DENEME ÝÇÝN --> D:\\DENEME || D:/DENEME
            Directory.CreateDirectory("C:/DENEME/A/B");

            Directory.CreateDirectory("C:/DENEME");

            //var sonuc = Directory

            /*

            string path = @"C:\Users\you\Desktop\perms"; // path to directory whose settings you have already correctly configured
            DirectorySecurity sec = Directory.GetAccessControl(path);
            foreach (FileSystemAccessRule acr in sec.GetAccessRules(true, true, typeof(System.Security.Principal.NTAccount)))
            {
                Console.WriteLine("{0} | {1} | {2} | {3} | {4}", acr.IdentityReference.Value, acr.FileSystemRights, acr.InheritanceFlags, acr.PropagationFlags, acr.AccessControlType);
            }*/

        }




        private void Form1_Load(object sender, EventArgs e)
        {
           


        }


        //DOÐRULAMA KODU
        private void button3_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("C:/DENEME"))
            MessageBox.Show("C:/DENEME yolu var");
            else
             MessageBox.Show("C:/DENEME yolu yok!");
        }


        //SÝLME KODU
        private void button2_Click(object sender, EventArgs e)
        {

            //Directory.Delete("C:/DENEME");
            Directory.Delete("C:/DENEME", true); //Klasör içindekileri de siler
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Directory.GetCurrentDirectory());

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var gelen = Directory.GetDirectories("C:/");
            foreach (var item in gelen) 

            {
                listBox1.Items.Add(item);
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            //LÝSTELEME
            var gelen = Directory.GetFiles("C:/");
            foreach (var item in gelen)

            {
                listBox1.Items.Add(item);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}