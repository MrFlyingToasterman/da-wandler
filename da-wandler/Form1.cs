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
        int x, y;

        void wertausgabe() {
            for (y = 0; y < gArray.GetLength(0); y++) {
                for (x = 0; x < gArray.GetLength(1); x++) {
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

    }
}
