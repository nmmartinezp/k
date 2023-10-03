using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace sis301_Pescadería
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private Form backform;

        //importado
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnoffsesion_Click(object sender, EventArgs e)
        {
            backform.Show();
            this.Hide();
        }

        public void Backform(Form a)
        {
            backform = a;
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnprconexion_Click(object sender, EventArgs e)
        {
            Connection a = new Connection();
            try
            {
                MySqlDataReader re = a.dataconsult("SHOW TABLES");
                string datos = "";
                while (re.Read())
                {
                    datos += re.GetString(0) + "\n";
                }
                MessageBox.Show(@"Base de datos " + "\n\n" + datos + "\n\n" + "Existe conexión");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                a.ConnectionClose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Alldata forma = new Alldata();
            AbrirFormEnPanel(forma);
            forma.data();
        }

        private Form AbrirFormEnPanel(object formsub)
        {
            Form formhija = formsub as Form;
            if (this.Pcontenedor.Controls.Count > 0)
                this.Pcontenedor.Controls.RemoveAt(0);
            formhija.TopLevel = false;
            formhija.Dock = DockStyle.Fill;
            this.Pcontenedor.Controls.Add(formhija);
            this.Pcontenedor.Tag = formhija;
            formhija.Show();
            return formhija;
        }
    }
}
