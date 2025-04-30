using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CrudWmeDaniel
{
    public partial class cadusuarios : Form
    {
        public cadusuarios()
        {
            InitializeComponent();

            textBox_nome.Enabled = false;
            textBox_num.Enabled = false;
            textBox_CPF.Enabled = false;
            textBox_email.Enabled = false;
            textBox_endereco.Enabled = false;
            textBox_pesquisa_nome.Enabled = false; //nao pesquisa nome antes de cadastrar usuarios
            textBox_uf.Enabled = false;
            textBox_bairro.Enabled = false;
            maskedTextBox_Telefone.Enabled = false;
            textBox_cidade.Enabled = false;
        }
        SqlConnection sqlcon = null; //conexao com banco
        private string strCon = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CadClientes;Data Source=DESKTOP-7QPFUBV\\SQLEXPRESS";
        private string strSql = string.Empty;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            textBox_nome.Enabled = true;
            textBox_num.Enabled = true;
            textBox_CPF.Enabled = true;
            textBox_email.Enabled = true;
            textBox_endereco.Enabled = true;
            textBox_pesquisa_nome.Enabled = false;
            textBox_uf.Enabled = true;
            textBox_bairro.Enabled = true;
            maskedTextBox_Telefone.Enabled = true;
            textBox_cidade.Enabled = true;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            strSql = "Insert into CadClientesTable (Nome,ID,Telefone,Email,Endereco,Bairro,Cidade,Num,UF) values (@Nome,@ID,@Telefone,@Email,@Endereco,@Bairro,@Cidade,@Num,@UF)";

            sqlcon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlcon);

            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = textBox_nome.Text;
            comando.Parameters.Add("@Num", SqlDbType.VarChar).Value = textBox_num.Text;
            comando.Parameters.Add("@ID", SqlDbType.VarChar).Value = textBox_CPF.Text;
            comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = textBox_email.Text;
            comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = textBox_endereco.Text;
            //  comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = textBox_pesquisa_nome.Text;
            comando.Parameters.Add("@UF", SqlDbType.VarChar).Value = textBox_uf.Text;
            comando.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = textBox_bairro.Text;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = maskedTextBox_Telefone.Text;
            comando.Parameters.Add("@Cidade", SqlDbType.VarChar).Value = textBox_cidade.Text;

            try
            {
                sqlcon.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro efetuado!");
                textBox_pesquisa_nome.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }

            textBox_nome.Clear();
            textBox_num.Clear();
            textBox_CPF.Clear();
            textBox_email.Clear();
            textBox_endereco.Clear();
            textBox_pesquisa_nome.Clear();
            textBox_uf.Clear();
            textBox_bairro.Clear();
            maskedTextBox_Telefone.Clear();
            textBox_cidade.Clear();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            strSql = "select*from CadClientesTable where Nome=@pesquisa";

            sqlcon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlcon);

            comando.Parameters.Add("@pesquisa", SqlDbType.VarChar).Value = textBox_pesquisa_nome.Text;

            try
            {
                if (textBox_pesquisa_nome.Text == string.Empty)
                {
                    MessageBox.Show("Digite um nome!");
                }

                sqlcon.Open();

                SqlDataReader dr = comando.ExecuteReader();

                if (dr.HasRows == false)
                {
                    throw new Exception("Nome não cadastrado!!");
                }

                dr.Read();

                textBox_nome.Text = Convert.ToString(dr["Nome"]);
                textBox_num.Text = Convert.ToString(dr["Num"]);
                textBox_CPF.Text = Convert.ToString(dr["ID"]);
                textBox_email.Text = Convert.ToString(dr["Email"]);
                textBox_endereco.Text = Convert.ToString(dr["Endereco"]);
                textBox_uf.Text = Convert.ToString(dr["UF"]);
                textBox_bairro.Text = Convert.ToString(dr["Bairro"]);
                maskedTextBox_Telefone.Text = Convert.ToString(dr["Telefone"]);
                textBox_cidade.Text = Convert.ToString(dr["Cidade"]);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlcon.Close();
            }

            textBox_pesquisa_nome.Clear();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {

            strSql = "update CadClientesTable set Nome=@Nome,ID=@ID,Telefone=@Telefone,Email=@Email,Endereco=@Endereco,Bairro=@Bairro,Cidade=@Cidade,Num=@Num,UF=@UF";

            sqlcon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlcon);

            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = textBox_nome.Text;
            comando.Parameters.Add("@Num", SqlDbType.VarChar).Value = textBox_num.Text;
            comando.Parameters.Add("@ID", SqlDbType.VarChar).Value = textBox_CPF.Text;
            comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = textBox_email.Text;
            comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = textBox_endereco.Text;
            comando.Parameters.Add("@UF", SqlDbType.VarChar).Value = textBox_uf.Text;
            comando.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = textBox_bairro.Text;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = maskedTextBox_Telefone.Text;
            comando.Parameters.Add("@Cidade", SqlDbType.VarChar).Value = textBox_cidade.Text;

            try
            {
                sqlcon.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro alterado com êxito!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlcon.Close();
            }

            textBox_nome.Clear();
            textBox_num.Clear();
            textBox_CPF.Clear();
            textBox_email.Clear();
            textBox_endereco.Clear();
            textBox_pesquisa_nome.Clear();
            textBox_uf.Clear();
            textBox_bairro.Clear();
            maskedTextBox_Telefone.Clear();
            textBox_cidade.Clear();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            strSql = "delete from CadClientesTable where Nome=@Nome";

            sqlcon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlcon);

            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = textBox_nome.Text;

            try
            {

                sqlcon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Exclusão realizada!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }

            textBox_nome.Clear();
            textBox_num.Clear();
            textBox_CPF.Clear();
            textBox_email.Clear();
            textBox_endereco.Clear();
            textBox_pesquisa_nome.Clear();
            textBox_uf.Clear();
            textBox_bairro.Clear();
            maskedTextBox_Telefone.Clear();
            textBox_cidade.Clear();
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            string strSql = "SELECT * FROM CadClientesTable";
            using (SqlConnection sqlcon = new SqlConnection(strCon))
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(strSql, sqlcon);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView_clientes.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao listar dados: " + ex.Message);
                }
            }
        }
    }
}
