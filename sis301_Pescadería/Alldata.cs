using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sis301_Pescadería
{
    public partial class Alldata : Form
    {
        public Alldata()
        {
            InitializeComponent();
        }

        private Dataread DR = new Dataread();

        private void Alldata_Load(object sender, EventArgs e)
        {
            
        }

        public void data()
        {
            DR.Loadtable(DGalldata, "SELECT * FROM USUARIO");
        }
    }
}
