using ProjetoMVCA38.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMVCA38.BLL
{
    class tblClienteBLL
    {
        private DALMVC daoBanco = new DALMVC();

        public Boolean Autenticar(string email, string senha)
        {
            string consulta = string.Format($@"select * from tbl_clienteA38 where email_cliente = '{email}' and senha_cliente='{senha}';");
            DataTable dt = daoBanco.ConsultarDadosTabela(consulta);
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean VerificarDados(string nome, string cpf, string mae)
        {
            string consulta = string.Format($@"select * from tbl_clienteA38 where nome_cliente='{nome}' and cpf_cliente='{cpf}' and nome_mae='{mae}';");
            DataTable dt = daoBanco.ConsultarDadosTabela(consulta);
            if (dt.Rows.Count == 1)
            {
                return true;

            }
            else
            {
                return false;
            }
        }


        public string RecuperarSenha(string email)
        {

            string consulta = string.Format($@"select * from tbl_clienteA38 where email_cliente = '{email}';");
            DataTable dt = daoBanco.ConsultarDadosTabela(consulta);
            if (dt.Rows.Count == 1)
            {
                return dt.Rows[0]["senha_cliente"].ToString();

            }
            else
            {
                return "";
            }
        }
    }
}
