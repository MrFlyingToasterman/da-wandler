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
            
        }

        void arrayeintrag(int position) {

            if (positiona == 16) {
                positiona = 0;
                array_clean();
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
        }

        private void button2_Click(object sender, EventArgs e) {
            invol = eingabe_vol_box.Text;
            outbin = tobin(Convert.ToInt32(invol));
            inbin = outbin;
            einsetzen();
        }

        private void einsetzen() {
            ausgabe_bin_box.Text = outbin;
            ausgabe_vol_box.Text = outvol;
            arrayeintrag(Convert.ToInt32(invol)); //Array an stelle vol setzen
            wertausgabe(); //Array ausgeben
            Bin_verlauf.Text += "\r\n" + outbin;
        }


    }
}
