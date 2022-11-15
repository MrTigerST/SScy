using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SScy.Traslating; // Using Translation system
using System.IO;
using System.Net;
using System.Security.Cryptography;
namespace SScy
{
    public partial class MenuSScy : Form
    {

        public MenuSScy()
        {
            InitializeComponent();
        }

        public static int code = 0;
        public static string language = "en";
        private static bool blockloop1 = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            TraslateService.ToEn();
            button1.Text = TraslateService.button1Text;
            codesscytext.Text = TraslateService.codesscytext1;
            infotext1.Text = TraslateService.infotext1;
            selectLanguage.Items.Clear();
            selectLanguage.Items.Add(TraslateService.languageentxt);
            selectLanguage.Items.Add(TraslateService.languageittxt);
            selectLanguage.SelectedIndex = 0;
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Convert.ToString(id_txbx.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (blockloop1 == true)
            {
                blockloop1 = false;
                return;
            }

            if (selectLanguage.SelectedIndex == 0)
            {
                changeMainForm("en");
            }

            if (selectLanguage.SelectedIndex == 1)
            {
                changeMainForm("it");
            }
        }

        private void changeMainForm(string languageref)
        {
            if (languageref == "en")
            {
                language = "en";
                TraslateService.ToEn();
                button1.Text = TraslateService.button1Text;
                codesscytext.Text = TraslateService.codesscytext1;
                infotext1.Text = TraslateService.infotext1;
                selectLanguage.Items.Clear();
                selectLanguage.Items.Add(TraslateService.languageentxt);
                selectLanguage.Items.Add(TraslateService.languageittxt);
                blockloop1 = true;
                selectLanguage.SelectedIndex = 0;
            }

        else if (languageref == "it")
            {
                language = "it";
                TraslateService.ToIT();
                button1.Text = TraslateService.button1Text;
                codesscytext.Text = TraslateService.codesscytext1;
                infotext1.Text = TraslateService.infotext1;
                selectLanguage.Items.Clear();
                selectLanguage.Items.Add(TraslateService.languageentxt);
                selectLanguage.Items.Add(TraslateService.languageittxt);
                blockloop1 = true;
                selectLanguage.SelectedIndex = 1;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }
    }
}

       
