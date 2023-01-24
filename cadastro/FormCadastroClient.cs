﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TapecariaSystem.cadastro
{
    public partial class FormCadastroClient : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;
        public FormCadastroClient()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //fazendo o tratamento dos dados 
            if (txtNome.Text.ToString().Trim() == "") //tirando os espaços
            {
                MessageBox.Show("Preencha o Campo nome", "Cadastro funcionários", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Text = "";  // limpa o campo que precisa ser preenchido novamente
                txtNome.Focus();
                return;
            }
            if (txtCpf.Text == "   .   .   -  " || txtCpf.Text.Length < 14)
            {
                MessageBox.Show("Preencha o campo CPF", "Cadastro funcionários", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCpf.Focus();
                return;
            }

            con.AbrirConexao();
            sql = "INSERT INTO tb_cliente ( nome_cliente, endereco_cliente, cep_cliente, cpf_cliente, telefone_cliente, celular_cliente)VALUES( @nome, @endereco, @cep, @cpf, @telefone, @celular)";

            cmd = new MySqlCommand(sql, con.con);

            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
            cmd.Parameters.AddWithValue("@cep", txtCep.Text);
            cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);
            cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
            cmd.Parameters.AddWithValue("@celular",txtCelular.Text);

            cmd.ExecuteNonQuery();
            con.FecharConexao();
        }
    }
}
