using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sis301_Pescadería
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private Menu Main = new Menu();
        private Connection set = new Connection();
        private MySqlDataReader read;
        //importado
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Evento de barra
        private void PanelBarra_MouseDown(object sender, MouseEventArgs e)
        {
            
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Eventos click
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            if (verificar())
            {
                txtusuario.Clear();
                txtcontra.Clear();
                Main.Show();
                Main.Backform(this);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Datos Incorrectos","Error de inicio de sesion");
            }
        }

        private bool verificar()
        {
            string sql = "SELECT NOMBRE, PASS FROM USUARIO WHERE NOMBRE='" + txtusuario.Text + "' AND PASS='" + txtcontra.Text + "'";
            try
            {
                read = set.dataconsult(sql);
                string datos = "";
                if (read.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                set.ConnectionClose();
            }
        }
    }
}
