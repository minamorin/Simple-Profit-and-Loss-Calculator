using System;
using System.Windows.Forms;

namespace Simple_Profit_and_Loss_Calculator
{
    public partial class Form1 : Form
    {
        private double result;
        private double income;
        private double advertising, assets, cartruck, commissionsfees, contractlabor, homeofficeexpenses, insurance, interestpaid, legalfeesprofessionalservices, meals, officeexpenses, otherbusinessexpenses, rentlease, repairsmaintenance, supplies, taxeslicenses, travelexpenses, utilities;
        private double otherincome;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string firstn = textBox1.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string address = textBox3.Text;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string lastname = textBox2.Text;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string city = textBox4.Text;

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string state = textBox5.Text;

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string zipcode = textBox6.Text;

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string taxnumberss = textBox7.Text;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox8.Text, out income))
            {

            }
            else
            {
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox9.Text, out advertising))
            {

            }
            else
            {
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }




        private void label4_Click(object sender, EventArgs e)
        {

        }




        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox12.Text, out assets))
            {

            }
            else
            {
            }

        }



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox13.Text, out commissionsfees))
            {

            }
            else
            {
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox14.Text, out cartruck))
            {

            }
            else
            {
            }

        }


        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox15.Text, out interestpaid))
            {

            }
            else
            {
            }
        }


        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox16.Text, out insurance))
            {

            }
            else
            {
            }
        }


        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox17.Text, out homeofficeexpenses))
            {

            }
            else
            {
            }
        }


        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox18.Text, out contractlabor))
            {

            }
            else
            {
            }
        }




        private void label14_Click(object sender, EventArgs e)
        {

        }


        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox22.Text, out utilities))
            {

            }
            else
            {
            }
        }




        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox23.Text, out supplies))
            {

            }
            else
            {
            }
        }



        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox24.Text, out rentlease))
            {

            }
            else
            {
            }
        }



        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox25.Text, out officeexpenses))
            {

            }
            else
            {
            }
        }



        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox26.Text, out meals))
            {

            }
            else
            {
            }
        }


        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox27.Text, out legalfeesprofessionalservices))
            {

            }
            else
            {
            }
        }


        private void label15_Click(object sender, EventArgs e)
        {

        }



        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            result = (income + otherincome) - (advertising + assets + cartruck + commissionsfees + contractlabor + homeofficeexpenses + insurance + interestpaid + legalfeesprofessionalservices + meals + officeexpenses + otherbusinessexpenses + rentlease + repairsmaintenance + supplies + taxeslicenses + travelexpenses + utilities);
            textBox19.Text = result.ToString();



        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox20.Text, out otherincome))
            {

            }
            else
            {
            }
        }


    }
}
