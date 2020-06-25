using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMVCA38.DTO
{
    class tblClienteDTO
    {
        private int id_cliente, tp_usuario;
        private string nome_cliente, sobrenome_cliente, email_cliente, cpf_cliente, senha_cliente, nome_mae;

        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public int Tp_usuario { get => tp_usuario; set => tp_usuario = value; }

        public string Email_cliente
        {
            set
            {
                if (value != string.Empty)
                {
                    this.email_cliente = value;
                }
                else
                {
                    throw new Exception("O campo email é obrigatório");
                }
            }
            get
            {
                return this.email_cliente;
            }

        }
        public string Senha_cliente
        {
            set
            {
                if (value != string.Empty)
                {
                    this.senha_cliente = value;
                }
                else
                {
                    throw new Exception("O campo senha é obrigatório");
                }
            }


            get
            {
                return this.senha_cliente;
            }

        }

        public string Nome_cliente
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nome_cliente = value;
                }
                else
                {
                    throw new Exception("O campo nome é obrigatório");
                }
            }

            get
            {
                return this.nome_cliente;
            }

        }
        public string Sobrenome_cliente
        {
            set
            {
                if (value != string.Empty)
                {
                    this.sobrenome_cliente = value;
                }
                else
                {
                    throw new Exception("O campo sobrenome é obrigatório");
                }
            }

            get
            {
                return this.sobrenome_cliente;
            }

        }
        public string Cpf_cliente
        {
            set
            {
                if (value != string.Empty)
                {
                    this.cpf_cliente = value;
                }
                else
                {
                    throw new Exception("O campo cpf é obrigatório");
                }
            }


            get
            {
                return this.cpf_cliente;
            }

        }
        public string Nome_mae
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nome_mae = value;
                }
                else
                {
                    throw new Exception("O campo nome mãe é obrigatório");
                }
            }


            get
            {
                return this.nome_mae;
            }

        }





    }
}
