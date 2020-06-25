using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   
using System.Windows.Forms;
using ProjetoMVCA38.BLL;
using ProjetoMVCA38.DAL;
using ProjetoMVCA38.DTO;

namespace ProjetoMVCA38.UI
{
    public partial class frmdados : Form
    {
        public frmdados()
        {
            InitializeComponent();
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            try
            {
                tblClienteDTO objcliente = new tblClienteDTO();
                objcliente.Cpf_cliente = txtCpfA38.Text.Trim();
                objcliente.Nome_cliente = txt_nomecompletoA38.Text.Trim();
                objcliente.Nome_mae = txt_nomemaeA38.Text.Trim();
                tblClienteBLL bllCliente = new tblClienteBLL();

                if (bllCliente.VerificarDados(objcliente.Nome_cliente, objcliente.Cpf_cliente, objcliente.Nome_mae))
                {
                    MessageBox.Show("Beneficiário Localizado no Banco de dados.", "Processo em Análise", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Beneficiário Não Localizado no Banco de dados.", "Benefício Negado", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtCpfA38_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsDigit(e.KeyChar))
            {
                
                e.Handled = true;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_sair(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
