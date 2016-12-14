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
            for (int y = 0; y < gArray.GetLength(0); y++) {
                for (int x = 0; x < gArray.GetLength(1); x++) {
                    Volt_verlauf.Text = Convert.ToString(gArray[x, y]);
                }
            }
        }

        void arrayeintrag(int position) {
            gArray[position,position] = '*';
            position++;
        }

        public Form1() {
            InitializeComponent();
        }

        public static String tobin(int dec_input) {
            //Convert to Binary
            String bin_ip = Convert.ToString(dec_input, 2);

            //Add Zeros
            String filling0s = "";
            if (bin_ip.Length < 4) {
                for (int i = 0; i < 8 - bin_ip.Length; i++) {
                    filling0s = filling0s + "0";
                }
            }

            //Convert to Binary
            return filling0s + bin_ip;
        }


    }
}
