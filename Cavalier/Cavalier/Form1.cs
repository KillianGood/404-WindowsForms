//
// Author : Killian Good
// Lieu : ETML, lausanne
// Description : realization of the cavalier project in windows form
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cavalier
{
    public partial class Form1 : Form
    {


        int g_intCompteur = 0;
        Control currentButton;
        private bool _isClicked = true;

        private Point position = new Point(100, 100);

        private const int BUTTON_WIDTH = 8;
        private const int BUTTON_HEIGHT = 8;
        /// <summary>
        /// Constant :  The width of the labels
        /// </summary>
        private const int BUTTON_WIDTH_SIZE = 50;

        /// <summary>
        /// Constant : The height of the labels
        /// </summary>
        private const int BUTTON_HEIGHT_SIZE = 50;


            


        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < BUTTON_WIDTH; i++)
            {

                for (int j = 0; j < BUTTON_HEIGHT; j++)
                {
                    Button btn = new Button();

                    // Set width and height of the label
                    btn.Width = BUTTON_WIDTH_SIZE;
                    btn.Height = BUTTON_HEIGHT_SIZE;

                    btn.Location = new Point(i * BUTTON_WIDTH_SIZE, j * BUTTON_HEIGHT_SIZE);
                    btn.BackColor = Color.White;

                    btn.MouseClick += new MouseEventHandler(ClickOnButton);

                    //if (btn.Location.X == 0 || btn.Location.X == 50 )
                    //{
                    //    btn.BackColor = Color.Red;
                    //}

                    pnlMap.Controls.Add(btn);
                }
            }
        }

        private void pnlMap_Click(object sender, PaintEventArgs e)
        {

        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            foreach (Button btn in this.pnlMap.Controls)
            {
                btn.BackColor = Color.White;
                lblTry.Text = Convert.ToString(g_intCompteur = 0);
            }
        }

        private void ClickOnButton (object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;

            currentButton = pnlMap.GetChildAtPoint(position);
            if (_isClicked)
            {
                btn.BackColor = Color.Red;
                lblTry.Text = Convert.ToString(g_intCompteur++);
            }
                button1.Location.X = 50;
                currentButton = pnlMap.GetChildAtPoint(position);
                currentButton.BackColor = Color.Green;  
            
        }

        private void LblClick_Click(object sender, EventArgs e)
        {
        }

        private void LblTry_Click(object sender, EventArgs e)
        {

        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pour jouer il suffit de cliquer sur les carrés. " +
                "\n\n                               Bon jeux !");
        }

        private void CréateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Killian Good");
        }

        private void pnlMap_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, MouseEventArgs e)
        {
            
        }

        private void FormMouseCR_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
