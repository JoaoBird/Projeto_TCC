using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;

namespace Projeto_TCC
{


    public partial class Cadastro : Form
    {
        conexao con = new conexao();

        public Cadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
            string nome = box_nome.Text;
            string nome_resp = box_nome_r.Text;
            string email = box_email.Text;
            string cpf = box_cpf.Text;
            string cpf_resp = box_cpf_r.Text;
            string rg = box_rg.Text;
            string rg_resp = box_rg_r.Text;
            string senha = box_senha.Text;
            DateTime data = data_nasc.Value;
            int idade = DateTime.Now.Year - data.Year;
            int logar = 0;
            int logar2 = 1;
            if (idade < 18)
            {
                if (nome_resp == "" || cpf_resp == "" || rg_resp == "")
                {
                    MessageBox.Show("O usuáruio é menor de idade \nInsira o nome do responsável, seu CPF e RG", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logar2 = 0;
                }
                else { logar2 = 1; }
            }
            if (nome == "" || email == "" || cpf == "" || rg == "" || senha == "" || nome.Length >= 45 || email.Length >= 45 || nome.Length >= 45 || cpf.Length > 11 || rg.Length > 15 || senha.Length > 45 || logar2 == 0)
            {
                MessageBox.Show("Existe algum campo em branco ou com número de caracteres superior ao seu limite", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logar = 0;
            }
            else
            {
                
                logar = 1;
            }
            /*if (logar == 1 && logar2 == 1)
            {
               
            }*/
            
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            TimeSpan idade;
            idade = DateTime.Now.Date - data_nasc.Value.Date;
            double idade_real = idade.TotalDays / 365;
            long endereco;
            if (con.conectar())
            {
                MessageBox.Show("Conectado");
            }
            try
            {
                if (idade_real<18 &&( box_cpf_r.Text=="" || box_nome_r.Text=="" || box_rg_r.Text==""))
                {
                    MessageBox.Show("Informe os dados do responsavel", "Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                MySqlConnection conexao = con.getconexao();
                string sql = "insert into tb_endereco(estado, cidade, bairro, rua, cep, numero_casa, complemento) values" +
                    "('" + box_estado.Text + "','" + box_cidade.Text + "','" + box_bairro.Text + "','" + box_rua.Text + "','" + box_cep.Text + "','" + box_num.Text + "','" + box_comp.Text + "')";
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                conexao.Open();
                comando.ExecuteNonQuery();
                endereco = comando.LastInsertedId;
                //  string sqlend = "select id_endereco from tb_endereco where rua=" + box_rua.Text + "&& numero_casa=" + box_num.Text + ";";
                string sql2 = "insert into tb_cadastro(Nome,nome_responsavel,cpf_responsavel,cpf,como_ficou_sabendo,rg_responsavel,rg,e_mail,data_nascimento,numero_telefone,senha,id_endereco)" +
                    "values('" + box_nome.Text + "','" + box_nome_r.Text + "','" +box_cpf_r.Text  + "','" + box_cpf.Text + "','" + box_sabendo.Text + "','" + box_rg_r.Text + "','" + box_rg.Text + "','" + box_email.Text + "','" + data_nasc.Value.ToString("yyyy-MM-dd") + "','" + box_fone.Text + "','" + box_senha.Text+ "',"+ endereco+")";
                
                MySqlCommand comando1 = new MySqlCommand(sql2, conexao);
                
                comando1.ExecuteNonQuery();
                MessageBox.Show("cadastro com sucesso"); 

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha" + ex.Message);
            }
            finally
            {
                con.desconectar();
            }
        }

        private void box_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_fone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

    }
}