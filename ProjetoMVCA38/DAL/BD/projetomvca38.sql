CREATE DATABASE projetomvca38;
USE projetomvca38;

CREATE TABLE tbl_clienteA38(
id_cliente int not null,
nome_cliente varchar(45) not null,
sobrenome_cliente varchar(45) not null,
email_cliente varchar(50) not null,
senha_cliente varchar(45) not null,
cpf_cliente varchar(11) not null,
nome_mae varchar(50) not null,
tp_usuario int not null
);

INSERT INTO tbl_clienteA38 (id_cliente, nome_cliente, sobrenome_cliente,
email_cliente, senha_cliente, cpf_cliente, nome_mae, tp_usuario) VALUES ('1', 'matheus', 'eugenio', 'matheus@g.com', '123456', '12412412412', 'valeria eugenia', '02');
INSERT INTO tbl_clienteA38 (id_cliente, nome_cliente, sobrenome_cliente,
email_cliente, senha_cliente, cpf_cliente, nome_mae, tp_usuario) VALUES ('1', 'matheus', 'eugenio', 'm@g.com', '123456', '12412412412', 'valeria eugenia', '02');

DROP table tbl_clienteA38;
DROP DATABASE ProjetoMVCA38;