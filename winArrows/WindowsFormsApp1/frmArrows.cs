using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmArrows : Form
    {
        public frmArrows()
        {
            InitializeComponent();
        }

        private void Clear_Screen()
        {
            picDown.Hide();
            picLeft.Hide();
            picRight.Hide();
            picUp.Hide();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Clear_Screen();
        }

        private void frmArrows_KeyDown(object sender, KeyEventArgs e)
        {
            Clear_Screen();

            switch (e.KeyCode)
            {
                case Keys.Left: picLeft.Show(); break;
                case Keys.Right: picRight.Show(); break;
                case Keys.Down: picDown.Show(); break;
                case Keys.Up: picUp.Show(); break;
                

            }
        }
    }
}
