using ProjetoMVCA38.BLL;
using ProjetoMVCA38.DTO;
using ProjetoMVCA38.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMVCA38
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }


        
        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                tblClienteDTO objcliente = new tblClienteDTO();
                objcliente.Email_cliente = txt_email.Text.Trim();
                objcliente.Senha_cliente = txt_senha.Text.Trim();
                this.Visible = false;
                tblClienteBLL bllCliente = new tblClienteBLL();
                if (bllCliente.Autenticar(objcliente.Email_cliente, objcliente.Senha_cliente))
                {
                    MessageBox.Show("Cliente Localizado", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmdados dados = new frmdados();
                    dados.ShowDialog();
                    this.Visible = true;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Cliente Não Localizado", "Falho!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }


        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
