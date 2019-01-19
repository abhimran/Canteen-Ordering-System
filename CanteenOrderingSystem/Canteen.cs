using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanteenOrderingSystem
{
    public partial class Canteen : Form
    {
        public Canteen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSamosa.Text = "0";
            textNoodls.Text = "0";
            textVegetable.Text = "0";
            textChicken.Text = "0";
            textSandwich.Text = "0";
            textWater.Text = "0";
            textLemon.Text = "0";
            textSoft.Text = "0";
            textParatha.Text = "0";
            textKachchi.Text = "0";
            textBhuna.Text = "0";
            textPolao.Text = "0";
            textPatla.Text = "0";
            textRegular.Text = "0";
            textChocolate.Text = "0";
            textTea.Text = "0";

            CBsamosa.Checked = false;
            CBnoodls.Checked = false;
            CBvegetable.Checked = false;
            CBchicken.Checked = false;
            CBsandwich.Checked = false;
            CBwater.Checked = false;
            CBlemon.Checked = false;
            CBsoft.Checked = false;
            CBparatha.Checked = false;
            CBkachchi.Checked = false;
            CBbhuna.Checked = false;
            CBmorog.Checked = false;
            CBpatla.Checked = false;
            CBregular.Checked = false;
            CBchocolate.Checked = false;
            CBtea.Checked = false;



        }

        private void Canteen_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();

            txtSamosa.Text = "0";
            textNoodls.Text = "0";
            textVegetable.Text = "0";
            textChicken.Text = "0";
            textSandwich.Text = "0";
            textWater.Text = "0";
            textLemon.Text = "0";
            textSoft.Text = "0";
            textParatha.Text = "0";
            textKachchi.Text = "0";
            textBhuna.Text = "0";
            textPolao.Text = "0";
            textPatla.Text = "0";
            textRegular.Text = "0";
            textChocolate.Text = "0";
            textTea.Text = "0";

            txtSamosa.Enabled = false;
            textNoodls.Enabled = false;
            textVegetable.Enabled = false;
            textChicken.Enabled = false;
            textSandwich.Enabled = false;
            textWater.Enabled = false;
            textLemon.Enabled = false;
            textSoft.Enabled = false;
            textParatha.Enabled = false;
            textKachchi.Enabled = false;
            textBhuna.Enabled = false;
            textPolao.Enabled = false;
            textPatla.Enabled = false;
            textRegular.Enabled = false;
            textChocolate.Enabled = false;
            textTea.Enabled = false;




        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CBsamosa_CheckedChanged(object sender, EventArgs e)
        {
            if (CBsamosa.Checked == true) {
                txtSamosa.Enabled = true;

            }
            if (CBsamosa.Checked == false) {
                txtSamosa.Enabled = false;
                txtSamosa.Text = "0";


            }
        }

        private void txtSamosa_click(object sender, EventArgs e)
        {
            txtSamosa.Text = "";
            txtSamosa.Focus();

        }
        private void textNoodls_click(object sender, EventArgs e)
        {
            textNoodls.Text = "";
            textNoodls.Focus();

        }
        private void textVegetable_click(object sender, EventArgs e)
        {
            textVegetable.Text = "";
            textVegetable.Focus();

        }
        private void textChicken_click(object sender, EventArgs e)
        {
            textChicken.Text = "";
            textChicken.Focus();

        }
        private void textSandwich_click(object sender, EventArgs e)
        {
            textSandwich.Text = "";
            textSandwich.Focus();

        }
        private void textWater_click(object sender, EventArgs e)
        {
            textWater.Text = "";
            textWater.Focus();

        }
        private void textLemon_click(object sender, EventArgs e)
        {
            textLemon.Text = "";
            textLemon.Focus();

        }
        private void textSoft_click(object sender, EventArgs e)
        {
            textSoft.Text = "";
            textSoft.Focus();

        }
        private void textParatha_click(object sender, EventArgs e)
        {
            textParatha.Text = "";
            textParatha.Focus();

        }
        private void textKachchi_click(object sender, EventArgs e)
        {
            textKachchi.Text = "";
            textKachchi.Focus();

        }
        private void textBhuna_click(object sender, EventArgs e)
        {
            textBhuna.Text = "";
            textBhuna.Focus();

        }
        private void textPolao_click(object sender, EventArgs e)
        {
            textPolao.Text = "";
            textPolao.Focus();

        }
        private void textPatla_click(object sender, EventArgs e)
        {
            textPatla.Text = "";
            textPatla.Focus();

        }
        private void textRegular_click(object sender, EventArgs e)
        {
            textRegular.Text = "";
            textRegular.Focus();

        }
        private void textChocolate_click(object sender, EventArgs e)
        {
            textChocolate.Text = "";
            textChocolate.Focus();

        }
        private void textTea_click(object sender, EventArgs e)
        {
            textTea.Text = "";
            textTea.Focus();

        }

        private void txtSamosa_TextChanged(object sender, EventArgs e)
        {

        }

        private void CBnoodls_CheckedChanged(object sender, EventArgs e)
        {
            if (CBnoodls.Checked == true)
            {
                textNoodls.Enabled = true;

            }
            if (CBnoodls.Checked == false)
            {
                textNoodls.Enabled = false;
                textNoodls.Text = "0";


            }

        }

        private void CBvegetable_CheckedChanged(object sender, EventArgs e)
        {
            if (CBvegetable.Checked == true)
            {
                textVegetable.Enabled = true;

            }
            if (CBvegetable.Checked == false)
            {
                textVegetable.Enabled = false;
                textVegetable.Text = "0";


            }

        }

        private void CBchicken_CheckedChanged(object sender, EventArgs e)
        {
            if (CBchicken.Checked == true)
            {
                textChicken.Enabled = true;

            }
            if (CBchicken.Checked == false)
            {
                textChicken.Enabled = false;
                textChicken.Text = "0";


            }
        }

        private void CBsandwich_CheckedChanged(object sender, EventArgs e)
        {
            if (CBsandwich.Checked == true)
            {
                textSandwich.Enabled = true;

            }
            if (CBsandwich.Checked == false)
            {
                textSandwich.Enabled = false;
                textSandwich.Text = "0";


            }
        }

        private void CBwater_CheckedChanged(object sender, EventArgs e)
        {
            if (CBwater.Checked == true)
            {
                textWater.Enabled = true;

            }
            if (CBwater.Checked == false)
            {
                textWater.Enabled = false;
                textWater.Text = "0";


            }
        }

        private void CBlemon_CheckedChanged(object sender, EventArgs e)
        {
            if (CBlemon.Checked == true)
            {
                textLemon.Enabled = true;

            }
            if (CBlemon.Checked == false)
            {
                textLemon.Enabled = false;
                textLemon.Text = "0";


            }
        }

        private void CBsoft_CheckedChanged(object sender, EventArgs e)
        {
            if (CBsoft.Checked == true)
            {
                textSoft.Enabled = true;

            }
            if (CBsoft.Checked == false)
            {
                textSoft.Enabled = false;
                textSoft.Text = "0";


            }
        }

        private void CBparatha_CheckedChanged(object sender, EventArgs e)
        {
            if (CBparatha.Checked == true)
            {
                textParatha.Enabled = true;

            }
            if (CBparatha.Checked == false)
            {
                textParatha.Enabled = false;
                textParatha.Text = "0";


            }
        }

        private void CBkachchi_CheckedChanged(object sender, EventArgs e)
        {
            if (CBkachchi.Checked == true)
            {
                textKachchi.Enabled = true;

            }
            if (CBkachchi.Checked == false)
            {
                textKachchi.Enabled = false;
                textKachchi.Text = "0";


            }
        }

        private void CBbhuna_CheckedChanged(object sender, EventArgs e)
        {
            if (CBbhuna.Checked == true)
            {
                textBhuna.Enabled = true;

            }
            if (CBbhuna.Checked == false)
            {
                textBhuna.Enabled = false;
                textBhuna.Text = "0";


            }
        }

        private void CBmorog_CheckedChanged(object sender, EventArgs e)
        {
            if (CBmorog.Checked == true)
            {
                textPolao.Enabled = true;

            }
            if (CBmorog.Checked == false)
            {
                textPolao.Enabled = false;
                textPolao.Text = "0";


            }
        }

        private void CBpatla_CheckedChanged(object sender, EventArgs e)
        {
            if (CBpatla.Checked == true)
            {
                textPatla.Enabled = true;

            }
            if (CBpatla.Checked == false)
            {
                textPatla.Enabled = false;
                textPatla.Text = "0";


            }
        }

        private void CBregular_CheckedChanged(object sender, EventArgs e)
        {
            if (CBregular.Checked == true)
            {
                textRegular.Enabled = true;

            }
            if (CBregular.Checked == false)
            {
                textRegular.Enabled = false;
                textRegular.Text = "0";


            }
        }

        private void CBchocolate_CheckedChanged(object sender, EventArgs e)
        {
            if (CBchocolate.Checked == true)
            {
                textChocolate.Enabled = true;

            }
            if (CBchocolate.Checked == false)
            {
                textChocolate.Enabled = false;
                textChocolate.Text = "0";


            }
        }

        private void CBtea_CheckedChanged(object sender, EventArgs e)
        {
            if (CBtea.Checked == true)
            {
                textTea.Enabled = true;

            }
            if (CBtea.Checked == false)
            {
                textTea.Enabled = false;
                textTea.Text = "0";


            }
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtfReceipt.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            
        }


        private void btnReceipt_Click(object sender, EventArgs e)
        {
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double samosa, noodls, vegetable, chicken, sandwich, water, lemon, soft, 
                paratha, kachchi, bhuna, polao, patla, regular, chocolate, tea;


            samosa = 10; noodls = 35; vegetable = 15; chicken = 25; sandwich = 35; water = 15; lemon = 15; soft = 20;
            paratha = 130; kachchi = 130; bhuna = 135; polao = 140; patla = 100; regular = 50; chocolate = 65; tea = 10;

            double Samosa = Convert.ToDouble(txtSamosa.Text);
            double Noodls = Convert.ToDouble(textNoodls.Text);
            double Vegitable = Convert.ToDouble(textVegetable.Text);
            double Chicken = Convert.ToDouble(textChicken.Text);
            double Sandwich = Convert.ToDouble(textSandwich.Text);
            double Water = Convert.ToDouble(textWater.Text);
            double Lemon = Convert.ToDouble(textLemon.Text);
            double Soft = Convert.ToDouble(textSoft.Text);

            double Paratha = Convert.ToDouble(textParatha.Text);
            double Kachchi = Convert.ToDouble(textKachchi.Text);
            double Bhuna = Convert.ToDouble(textBhuna.Text);
            double Polao = Convert.ToDouble(textPolao.Text);
            double Patla = Convert.ToDouble(textPatla.Text);
            double Regular = Convert.ToDouble(textRegular.Text);
            double Chocolate = Convert.ToDouble(textChocolate.Text);
            double Tea = Convert.ToDouble(textTea.Text);

            Canteenn canteenn = new Canteenn(Samosa,Noodls,Vegitable,Chicken,Sandwich, Water,Lemon,
                Soft,Paratha,Kachchi,Bhuna,Polao,Patla, Regular,Chocolate,Tea);

            double cost_total = (Samosa * samosa) + (Noodls * noodls) + (Vegitable * vegetable) + (Chicken * chicken) +
                (Sandwich * sandwich) + (Water * water) + (Lemon * lemon) + (Soft * soft) + (Paratha * paratha) + (Kachchi * kachchi) +
                (Bhuna * bhuna) + (Polao * polao) + (Regular * regular) + (Chocolate * chocolate) + (Tea * tea);

            lblTotal.Text = Convert.ToString(cost_total);

        
           
          
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
