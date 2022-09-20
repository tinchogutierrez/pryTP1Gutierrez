using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTP1Gutierrez
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            txtContraseña.Enabled = true;
            if (txtUsuario.Text == "")
            {
                txtContraseña.Enabled = false;
            }

        }
        // VARIABLE PUBLICA, ENTERO DE 32 BITS, LA USO PARA CONTADOR DE VECES INCORRECTAS.
        Int32 ContadorIncorrecto = 0;
        string Martin = "1";
        private void btnSiguiente_Click(object sender, EventArgs e)

        {
            //
            if (txtUsuario.Text=="Adm" && txtContraseña.Text=="@1a" && (lstModulo.Text=="ADM" || lstModulo.Text=="COM" || lstModulo.Text=="VTA"))
            {
                this.Hide();
                frmBienvenido frmBienvenido = new frmBienvenido();
                frmBienvenido.ShowDialog(); 
                

            }

            else 
            {
                if (txtUsuario.Text == "John" && txtContraseña.Text == "*2b" && lstModulo.Text=="SIST")
                {
                    this.Hide();
                    frmBienvenido frmBienvenido = new frmBienvenido();
                    frmBienvenido.ShowDialog();
                }
                else
                {
                    if (txtUsuario.Text == "Ceci" && txtContraseña.Text == "*@3c" && (lstModulo.Text=="ADM" || lstModulo.Text=="VTA"))
                    {
                        this.Hide();
                        frmBienvenido frmBienvenido = new frmBienvenido();
                        frmBienvenido.ShowDialog();
                    }
                    else
                    {
                        if (txtUsuario.Text == "God" && txtContraseña.Text == "*@#4d" && (lstModulo.Text=="ADM" || lstModulo.Text=="SIST" || lstModulo.Text == "COM" || lstModulo.Text == "VTA"))
                        {
                            this.Hide();
                            frmBienvenido frmBienvenido = new frmBienvenido();
                            frmBienvenido.ShowDialog();
                        }
                        else
                        {
                            // en caso contrario se mostrará un cuadro de mensajes con el texto "Usuario y/o
                            //contraseña incorrectos para el módulo seleccionado". Si la falla se presenta dos veces en forma consecutiva se
                            //cerrará el formulario de Login.
                            ContadorIncorrecto = ContadorIncorrecto + 1;
                            MessageBox.Show("Usuario y/o contraseña incorrectos para el módulo seleccionado");
                            
                            if (ContadorIncorrecto==2)
                            {
                                MessageBox.Show("Limite de intentos alcanzados, cerrando programa");
                                Application.Exit();
                            }
                            
                        }
                    }
                }
            }

            

        }


        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            lstModulo.Enabled = true;
            if (txtContraseña.Text == "")
            {
                lstModulo.Enabled = false;
            }
        }

        private void lstModulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSiguiente.Enabled = true;
            if (lstModulo.Text == "")
            {
                btnSiguiente.Enabled = false;
            }
        }
    }
}
