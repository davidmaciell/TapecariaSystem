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
    public partial class FormCadastroClient : Form
    {
        Conexao con = new Conexao();
        string sql;
        string varid;
        string cpfAntigo;
        MySqlCommand cmd;
        public FormCadastroClient()
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
                MessageBox.Show("Preencha o Campo nome", "Cadastro funcionários", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Text = "";  // limpa o campo que precisa ser preenchido novamente
                txtNome.Focus();   //focus para a seta voltar exatamente onde tem que preencher             
            }
            if (txtCpf.Text == "   .   .   -  " || txtCpf.Text.Length < 14)
            {
                MessageBox.Show("Preencha o campo CPF", "Cadastro funcionários", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCpf.Focus();
            }

            con.AbrirConexao();
            sql = "INSERT INTO tb_cliente ( nome_cliente, endereco_cliente, cep_cliente, cpf_cliente, telefone_cliente, celular_cliente, date)VALUES( @nome, @endereco, @cep, @cpf, @telefone, @celular, curDate())";

            cmd = new MySqlCommand(sql, con.con);

            cmd.Parameters.AddWithValue("@nome", txtNome.Text.ToUpper().Trim());
            cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text.ToUpper().Trim());
            cmd.Parameters.AddWithValue("@cep", txtCep.Text);
            cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);
            cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
            cmd.Parameters.AddWithValue("@celular", txtCelular.Text);

            cmd.ExecuteNonQuery();
            con.FecharConexao();

            MessageBox.Show("Salvo com sucesso!", "Cadastro Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtCpf.Enabled = true;
            txtCep.Enabled = true;
            txtEndereco.Enabled = true;
            txtTelefone.Enabled = true;
            txtCelular.Enabled = true;
            btnNovo.Enabled = false;
        }
        private void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtCpf.Enabled = false;
            txtCep.Enabled = false;
            txtEndereco.Enabled = false;
            txtTelefone.Enabled = false;
            txtCelular.Enabled = false;
        }
        private void LimparCampos()
        {
            txtNome.Text = "";
            txtCpf.Text = "";
            txtCep.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
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
            grid.Columns[2].HeaderText = "Endereço";
            grid.Columns[3].HeaderText = "CEP";
            grid.Columns[4].HeaderText = "CPF";
            grid.Columns[5].HeaderText = "Telefone";
            grid.Columns[6].HeaderText = "Celular";
            grid.Columns[7].HeaderText = "Data";

            //grid.Columns[5].Width = 50;
            grid.Columns[0].Visible = false;
        }
        private void Listar()  //esse função vai trazer os dados do banco para minha grid
        {
            con.AbrirConexao();  //chamo o abrir conexão 
            sql = "SELECT * FROM tb_cliente ORDER BY nome_cliente asc";
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
            txtEndereco.Text = grid.CurrentRow.Cells[2].Value.ToString();
            cpfAntigo = grid.CurrentRow.Cells[4].Value.ToString();
            txtCep.Text = grid.CurrentRow.Cells[3].Value.ToString();
            txtCpf.Text = grid.CurrentRow.Cells[4].Value.ToString();
            txtTelefone.Text = grid.CurrentRow.Cells[5].Value.ToString();
            txtCelular.Text = grid.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "") //valida se o cpf e nome está preenchido
            {
                MessageBox.Show("Preencha o Campo Nome", "Cadastro Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }
            if (txtCpf.Text == "   .   .   -  " || txtCpf.Text.Length < 14)
            {
                MessageBox.Show("Preencha o campo CPF", "Cadastro funcionários", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCpf.Focus();
                return;
            }
            // abre a conexão
            con.AbrirConexao();
            sql = "UPDATE tb_cliente SET nome_cliente = @nome, endereco_cliente = @endereco, cep_cliente = @cep, cpf_cliente = @cpf, telefone_cliente = @telefone , celular_cliente = @celular WHERE id_cliente = @ID";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@id", varid);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text.ToUpper().Trim());
            cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text.ToUpper().Trim());
            cmd.Parameters.AddWithValue("@cep", txtCep.Text);
            cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);
            cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
            cmd.Parameters.AddWithValue("@celular", txtCelular.Text);

            //verifica se o cpf já existe
            if (txtCpf.Text != cpfAntigo)
            {
                MySqlCommand cmdVerificar;
                cmdVerificar = new MySqlCommand("SELECT * FROM tb_cliente WHERE cpf_cliente = @cpf", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmdVerificar;
                cmdVerificar.Parameters.AddWithValue("@cpf", txtCpf.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("CPF já Existe", "Cadastro de Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtCpf.Text = "";
                    txtCpf.Focus();
                    return;
                }


            }
            cmd.ExecuteNonQuery();
            con.FecharConexao();
            Listar();

            MessageBox.Show("Registro Editado com Sucesso", "Cadastro Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = true;
            desabilitarCampos();
            LimparCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult DialogResult = MessageBox.Show("Deseja mesmo Excluir", "Cadastro Funcionários", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
            {
                con.AbrirConexao();
                sql = "DELETE FROM tb_cliente WHERE id_cliente = @id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", varid);

                cmd.ExecuteNonQuery();
                con.FecharConexao();
                Listar();

                MessageBox.Show("Registro Excluído com Sucesso", "Cadastro Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Information);
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