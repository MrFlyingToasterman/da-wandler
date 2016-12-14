using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace da_wandler {

    public partial class Form1 : Form {

        char[,] gArray = new char[16, 16];
        int positiona = 0;
        String inbin;
        String outbin; 
        String invol;
        String outvol;

        void wertausgabe() {

            Volt_verlauf.Text = "";

            for (int y = 0; y < 16; y++) {

                for (int x = 0; x < 16; x++) {
                    if (gArray[y, x] == '\0') {
                        Volt_verlauf.Text = Volt_verlauf.Text + "  ";
                    }else {
                        Volt_verlauf.Text = Volt_verlauf.Text + gArray[y, x] + " ";
                    }
                }
                Volt_verlauf.Text = Volt_verlauf.Text + "\r\n";
            }
        }

        void array_clean() {
            for (int y = 0; y < 16; y++) {
                for (int x = 0; x < 16; x++) {
                    gArray[y, x] = '\0';
                }
            }
        }

        void binverlauf_clear() {
            Bin_verlauf.Text = "";
        }

        void arrayeintrag(int position) {

            if (positiona > 15) {
                positiona = 0;
                array_clean();
                binverlauf_clear();
            }

            gArray[position, positiona] = '*';
            positiona++;
        }


        public Form1() {
            InitializeComponent();
        }

        public static String tobin(int dec_input) {
            //Convert to Binary
            String bin = Convert.ToString(dec_input, 2);

            //Add Zeros
            String filling0s = "";
            if (bin.Length < 4) {
                for (int i = 0; i < 4 - bin.Length; i++) {
                    filling0s = filling0s + "0";
                }
            }

            //Convert to Binary
            return filling0s + bin;
        }

        private void button1_Click(object sender, EventArgs e) {
            inbin = eingabe_bin_box.Text;
            outvol = DezToBin(inbin);
            invol = outvol;
            outbin = inbin;
            invol = outvol;
            einsetzen();
        }

        private void button2_Click(object sender, EventArgs e) {
            invol = eingabe_vol_box.Text;
            if (Convert.ToInt32(invol) < 16) {
                outbin = tobin(Convert.ToInt32(invol));
                inbin = outbin;
                outvol = invol;
                einsetzen();
            } else {
                MessageBox.Show("Bitte maximal 15 Volt Spannung anlegen.");
            }
        }

        private void einsetzen() {
            eingabe_bin_box.Text = inbin;
            eingabe_vol_box.Text = invol;
            ausgabe_bin_box.Text = outbin;
            ausgabe_vol_box.Text = outvol;
            arrayeintrag(Convert.ToInt32(invol)); //Array an stelle vol setzen
            wertausgabe(); //Array ausgeben
            Bin_verlauf.Text += "\r\n" + outbin;
            Bin_verlauf.SelectionStart = Bin_verlauf.Text.Length;
            Bin_verlauf.ScrollToCaret();
        }

        private string DezToBin(string dez) {
            return Convert.ToInt32(dez, 2).ToString();
        }


    }
}
