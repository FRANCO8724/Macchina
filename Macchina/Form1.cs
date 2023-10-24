using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
        public int num = 0;
        public bool cont2 = false;
        public bool cont3 = false;
        public bool o = false;

        public Form1()
        {
            InitializeComponent();
            
        }
        Automobile a;
        private void Form1_Load(object sender, EventArgs e)
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
                int acc = a.Accellerazione();
                listView1.Items.Clear();
                listView1.Items.Add("Velocità: " + acc + " Km/h");
                                  
        }

        public class Automobile
        {
            protected int velocità;
            protected int marcia;
            protected int acc;
            public int num = 0;
            public bool cont2 = false;
            public bool cont3 = false;


            public Automobile(int velocità, int marcia)
            {
                this.velocità = velocità;
                this.marcia = marcia;
            }

            public virtual int Accellerazione()
            {
                
                velocità++;

                if (marcia == 0)
                {
                    velocità--;
                }
                if (marcia == 1 && velocità > 2)
                {
                    velocità--;
                }
                if (marcia == 2 && velocità > 4)
                {
                    velocità--;
                }
                if (marcia == 3 && velocità > 6)
                {
                    velocità--;
                }
                if (marcia == 4 && velocità > 8)
                {
                    velocità--;
                }
                if (marcia == 5 && velocità > 10)
                {
                    velocità--;
                }
                if (marcia == 6 && velocità > 12)
                {
                    velocità--;
                }
                else
                {

                    if (velocità > 280)
                    {
                        velocità = 280;
                    }
                }

                return this.velocità;
                
            }

            public virtual int Decellerazione()
            {
                velocità--;

                if (marcia == 5 && velocità < 10)
                {
                    velocità++;
                }
                if (marcia == 4 && velocità < 8)
                {
                    velocità++;
                }
                if (marcia == 3 && velocità < 6)
                {
                    velocità++;
                }
                if (marcia == 2 && velocità < 4)
                {
                    velocità++;
                }
                if (marcia == 1 && velocità < 2)
                {
                    velocità++;
                }
                else
                {

                    if (velocità < 0)
                    {
                        velocità = 0;
                    }
                }

                return this.velocità;
            }

            public virtual bool Frizione()
            {
                cont2 = true;
                return cont2;
            }

            public virtual bool Frizione2()
            {
                cont3 = true;
                return cont3;
            }

            public virtual int Cambio()
            {
                marcia++;
                return marcia;
            }

            public virtual int Cambio2()
            {
                marcia--;
                return marcia;
            }

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cont2 = a.Frizione();
            cont3 = a.Frizione2();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int dec = 0;

            if (o == true)
            {
                dec = velocità--;
                if (velocità < -50)
                {
                    dec = velocità++;
                }
            }
            else
            {
               dec = a.Decellerazione();
            }

            listView1.Items.Clear();

            listView1.Items.Add("Velocità: " + dec + " Km/h");

        }

        //Retro
        private void button4_Click(object sender, EventArgs e)
        {
            if (velocità < 3)
            {
                o = true;
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (cont2 == true)
            {
                if (marcia == 0)
                {
                    marcia = a.Cambio();
                }
            }

            if (cont3 == true)
            {
                if (marcia == 2)
                {
                    marcia = a.Cambio2();
                }
            }

            cont2 = false;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (cont2 == true)
            {
                if (marcia == 1)
                {
                    marcia = a.Cambio();
                }
            }
            if (cont3 == true)
            {
                if (marcia == 3)
                {
                    marcia = a.Cambio2();
                }
            }

            cont2 = false;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (cont2 == true)
            {
                if (marcia == 2)
                {
                    marcia = a.Cambio();
                }
            }
            if (cont3 == true)
            {
                if (marcia == 4)
                {
                    marcia = a.Cambio2();
                }
            }

            cont2 = false;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (cont2 == true)
            {
                if (marcia == 3)
                {
                    marcia = a.Cambio();
                }
            }
            if (cont3 == true)
            {
                if (marcia == 5)
                {
                    marcia = a.Cambio2();
                }
            }

            cont2 = false;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (cont2 == true)
            {
                if (marcia == 4)
                {
                    marcia = a.Cambio();
                }
            }
            if (cont3 == true)
            {
                if (marcia == 6)
                {
                    marcia = a.Cambio2();
                }
            }

            cont2 = false;
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if (cont2 == true)
            {
                if (marcia == 5)
                {
                    marcia = a.Cambio();
                }
            }

            cont2 = false;
        }


    }



}
