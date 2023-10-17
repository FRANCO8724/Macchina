using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Macchina
{
    public partial class Form1 : Form
    {

        public int cont = 0;

        public int velocità = 0;
        public int marcia = 0;

        public Form1()
        {
            InitializeComponent();
            
        }
        Automobile a;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (cont == 0)
            {
                listView1.Items.Clear();
                listView1.Items.Add("Macchina accesa");
                cont = 1;
            }
            else
            {
                listView1.Items.Clear();
                listView1.Items.Add("Macchina spenta");
                cont = 0;
            }

            if(cont == 1)
            {
                a = new Automobile(velocità,marcia);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            while (true)
            {
                int acc = a.Accellerazione();
            }
        }

        public class Automobile
        {
            protected int velocità;
            protected int marcia;
            protected int acc;
            System.Windows.Forms.ListView listView1;


            public Automobile(int velocità, int marcia)
            {
                this.velocità = velocità;
                this.marcia = marcia;
            }

            public virtual int Accellerazione()
            {
                velocità++;

                if(velocità > 280)
                {
                    velocità = 280;
                }

                listView1.Items.Clear();
                listView1.Items.Add("Velocità: " + acc + " Km/h");

                return this.velocità;
            }
        }


    }



}
