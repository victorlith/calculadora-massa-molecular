using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Globalization;


namespace WindowsFormsApp12
{
    public partial class BuscarElemento : Form
    {
        Conexao con = new Conexao();
        SQLiteCommand cmd = new SQLiteCommand();
        SQLiteDataReader dr;

        public BuscarElemento()
        {
            InitializeComponent();
        }

        public string Maiuscula(TextBox tb)
        {
            TextInfo texto = new CultureInfo("pt-Br", true).TextInfo;
            tb.Text = texto.ToTitleCase(tb.Text);
            return tb.Text;
        }

        private void AdicionarElementos_Load(object sender, EventArgs e)
        {

        }

		private void btnBuscarElemento_Click(object sender, EventArgs e)
		{
            try
            {
                cmd.Connection = con.conectar();

                cmd.CommandText = "SELECT * FROM TABELA WHERE SIMBOLO = @SIMBOLO";
                cmd.Parameters.AddWithValue("@SIMBOLO", tbNomeElemento.Text);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lbSimboloElemento.Text = (string)dr["simbolo"];
                    lbNomeElemento.Text = (string)dr["nome_elemento"];
                    lbCamadaElemento.Text = (string)dr["camada_eletrons"];
                    lbMassaElemento.Text = (string)dr["massa"];
                }
                dr.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.desconectar();
            }

            try
            {
                cmd.Connection = con.conectar();

                cmd.CommandText = "SELECT * FROM TABELA WHERE NOME_ELEMENTO = @NOME";
                cmd.Parameters.AddWithValue("@NOME", tbNomeElemento.Text);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lbSimboloElemento.Text = (string)dr["simbolo"];
                    lbNomeElemento.Text = (string)dr["nome_elemento"];
                    lbCamadaElemento.Text = (string)dr["camada_eletrons"];
                    lbMassaElemento.Text = (string)dr["massa"];
                }
                dr.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.desconectar();
            }
        }

		private void tbNomeElemento_Leave(object sender, EventArgs e)
		{
            Maiuscula(tbNomeElemento);
		}

		private void tbNomeElemento_KeyDown(object sender, KeyEventArgs e)
		{
            if (e.KeyValue == 13)
            {
                Maiuscula(tbNomeElemento);

                try
                {
                    cmd.Connection = con.conectar();

                    cmd.CommandText = "SELECT * FROM TABELA WHERE SIMBOLO = @SIMBOLO";
                    cmd.Parameters.AddWithValue("@SIMBOLO", tbNomeElemento.Text);
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        lbSimboloElemento.Text = (string)dr["simbolo"];
                        lbNomeElemento.Text = (string)dr["nome_elemento"];
                        lbCamadaElemento.Text = (string)dr["camada_eletrons"];
                        lbMassaElemento.Text = (string)dr["massa"];
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.desconectar();
                }

                try
                {
                    cmd.Connection = con.conectar();

                    cmd.CommandText = "SELECT * FROM TABELA WHERE NOME_ELEMENTO = @NOME";
                    cmd.Parameters.AddWithValue("@NOME", tbNomeElemento.Text);
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        lbSimboloElemento.Text = (string)dr["simbolo"];
                        lbNomeElemento.Text = (string)dr["nome_elemento"];
                        lbCamadaElemento.Text = (string)dr["camada_eletrons"];
                        lbMassaElemento.Text = (string)dr["massa"];
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.desconectar();
                }
            }
		}

		private void tbNomeElemento_TextChanged(object sender, EventArgs e)
		{
            Maiuscula(tbNomeElemento);
		}
	}
}
