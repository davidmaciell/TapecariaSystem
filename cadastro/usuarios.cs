using System;
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
    public partial class usuario : Form
    {
        Conexao con = new Conexao(); 
        string sql;
        string varid;
        string cpfAntigo;
        MySqlCommand cmd;
        public usuario()
        {
            InitializeComponent();
        }
        private void FormCadastroClient_Load(object sender, EventArgs e)
        {
            Listar();
            btnCancelar.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //fazendo o tratamento dos dados 
            if (txtNome.Text.ToString() == "") //tirando os espaços
            {
                MessageBox.Show("Preencha o Campo nome", "Cadastro Usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Text = "";  // limpa o campo que precisa ser preenchido novamente
                txtNome.Focus();   //focus para a seta voltar exatamente onde tem que preencher             
            }
            if (txtCpf.Text == "   .   .   -  " || txtCpf.Text.Length < 14)
            {
                MessageBox.Show("Preencha o campo CPF", "Cadastro Usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCpf.Focus();
            }

            con.AbrirConexao();
            sql = "INSERT INTO tb_usuarios ( nome_usuario, cpf_usuario, celular_usuario, senha_usuario)VALUES( @nome, @cpf, @celular, MD5(@senha))";

            cmd = new MySqlCommand(sql, con.con);

            cmd.Parameters.AddWithValue("@nome", txtNome.Text.ToUpper().Trim());
            cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);
            cmd.Parameters.AddWithValue("@celular", txtCelular.Text);
            cmd.Parameters.AddWithValue("@senha",txtSenha.Text);

            cmd.ExecuteNonQuery();
            con.FecharConexao();

            MessageBox.Show("Salvo com sucesso!", "Cadastro Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            LimparCampos();
            Listar();    //logo após salvar ele já atualiza a lista para mostrar o que acabei de cadastrar
            desabilitarCampos();

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            txtNome.Focus();
            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
        }

        private void habilitarCampos()
        {
            btnSalvar.Enabled = true;
            txtNome.Enabled = true;
            txtSenha.Enabled = true;
            txtCpf.Enabled = true;
            txtCelular.Enabled = true;
            btnNovo.Enabled = false;
        }
        private void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtCpf.Enabled = false;
            txtCelular.Enabled = false;
            txtSenha.Enabled = false;
        }
        private void LimparCampos()
        {
            txtNome.Text = "";
            txtSenha.Text = "";
            txtCpf.Text = "";
            txtCelular.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            desabilitarCampos();
            btnNovo.Enabled = true;
            //btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void FormatarGD()  //formatação dos meus campos da grid
        {
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "Nome";   
            grid.Columns[2].HeaderText = "CPF";
            grid.Columns[3].HeaderText = "Celular";

            //grid.Columns[5].Width = 50;
            grid.Columns[0].Visible = false;
        }
        private void Listar()  //esse função vai trazer os dados do banco para minha grid
        {
            con.AbrirConexao();  //chamo o abrir conexão 
            sql = "SELECT * FROM tb_usuarios ORDER BY nome_usuario asc";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.FecharConexao();

            FormatarGD();
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            habilitarCampos();
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = true;
            varid = grid.CurrentRow.Cells[0].Value.ToString();// essa váriavel que declarei no começo vai receber o id para edição.
            txtNome.Text = grid.CurrentRow.Cells[1].Value.ToString();
            cpfAntigo = grid.CurrentRow.Cells[2].Value.ToString();
            txtCpf.Text = grid.CurrentRow.Cells[3].Value.ToString();
            txtCelular.Text = grid.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "") //valida se o cpf e nome está preenchido
            {
                MessageBox.Show("Preencha o Campo Nome", "Cadastro Usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }
            if (txtCpf.Text == "   .   .   -  " || txtCpf.Text.Length < 14)
            {
                MessageBox.Show("Preencha o campo CPF", "Cadastro Usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCpf.Focus();
                return;
            }
            // abre a conexão
            con.AbrirConexao();
            sql = "UPDATE tb_usuarios SET nome_usuario = @nome, senha_usuario = MD5(@senha), cpf_usuario = @cpf, celular_usuario = @celular WHERE id_usuario = @ID";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@id", varid);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text.ToUpper().Trim());
            cmd.Parameters.AddWithValue("@senha", txtSenha.Text);
            cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);
            cmd.Parameters.AddWithValue("@celular", txtCelular.Text);

            //verifica se o cpf já existe
            if (txtCpf.Text != cpfAntigo)
            {
                MySqlCommand cmdVerificar;
                cmdVerificar = new MySqlCommand("SELECT * FROM tb_usuarios WHERE cpf_usuario = @cpf", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmdVerificar;
                cmdVerificar.Parameters.AddWithValue("@cpf", txtCpf.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("CPF já Existe", "Cadastro de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtCpf.Text = "";
                    txtCpf.Focus();
                    return;
                }


            }
            cmd.ExecuteNonQuery();
            con.FecharConexao();
            Listar();

            MessageBox.Show("Registro Editado com Sucesso", "Cadastro Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = true;
            desabilitarCampos();
            LimparCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string nomeTemp;
            nomeTemp = txtNome.Text;

            DialogResult DialogResult = MessageBox.Show($"Deseja mesmo Excluir {nomeTemp} ?" , "Cadastro Funcionários", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
            {
                con.AbrirConexao();
                sql = "DELETE FROM tb_usuarios WHERE id_usuario = @id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", varid);

                cmd.ExecuteNonQuery();
                con.FecharConexao();
                Listar();

                MessageBox.Show("Registro Excluído com Sucesso", "Cadastro Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.Enabled = true;
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnSalvar.Enabled = true;
                desabilitarCampos();
                LimparCampos();

            }
            else if (DialogResult == DialogResult.No) {
                Listar();
            }
        }

       
    }

}