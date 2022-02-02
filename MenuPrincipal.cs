using System;
using System.Data.SQLite;
using System.Globalization;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
	public partial class MenuPrincipal : Form
	{
		Conexao con = new Conexao();
		SQLiteCommand cmd = new SQLiteCommand();
		SQLiteDataReader dr;

		public double massa1, massa2, massa3, massa4, massa5, resultado1, resultado2, resultado3, resultado4, resultado5, resultado6;

		//Variaveis para armazenar o nome dos Elementos
		public string nome1, nome2, nome3, nome4, nome5;

		//Variaveis para carcular o percentual dos Elementos
		public double porcentagem1, porcentagem2, porcentagem3, porcentagem4, porcentagem5;

		private void tbElemento1_TextChanged(object sender, EventArgs e)
		{

		}

		private void tbElemento1_Leave(object sender, EventArgs e)
		{
			Maiuscula(tbElemento1);
		}

		private void tbElemento2_TextChanged(object sender, EventArgs e)
		{

		}

		private void tbElemento2_Leave(object sender, EventArgs e)
		{
			Maiuscula(tbElemento2);
		}

		private void tabelaPeriodicaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TabelaPeriodica tb = new TabelaPeriodica();
			tb.Show();
		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void label10_Click(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

        private void button1_Click_3(object sender, EventArgs e)
        {
			
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
		{

		}

		private void label11_Click(object sender, EventArgs e)
		{

		}

		private void buscarElementosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			BuscarElemento bf = new BuscarElemento();
			bf.Show();
		}

		private void button1_Click_2(object sender, EventArgs e)
		{

		}

		private void label12_Click(object sender, EventArgs e)
		{

		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void menuToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void tbElemento3_Leave(object sender, EventArgs e)
		{
			Maiuscula(tbElemento3);
		}

		private void tbElemento4_Leave(object sender, EventArgs e)
		{
			Maiuscula(tbElemento4);
		}

		private void tbElemento5_Leave(object sender, EventArgs e)
		{
			Maiuscula(tbElemento5);
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			//TextBox Elementos
			tbElemento1.Clear();
			tbElemento2.Clear();
			tbElemento3.Clear();
			tbElemento4.Clear();
			tbElemento5.Clear();

			//TextBox Quantidades
			tbQuantidade1.Clear();
			tbQuantidade2.Clear();
			tbQuantidade3.Clear();
			tbQuantidade4.Clear();
			tbQuantidade5.Clear();

			//TextBox Resultado
			tbResultado.Clear();

			//RichTextBox
			rtbResultados.Clear();
		}

		private void button1_Click(object sender, EventArgs e)
		{



		}

		private void tbelemento_TextChanged(object sender, EventArgs e)
		{

		}

		public MenuPrincipal()
		{
			InitializeComponent();
		}

		public string Maiuscula(TextBox tBox)
		{
			TextInfo text = new CultureInfo("pt-BR", true).TextInfo;
			tBox.Text = text.ToTitleCase(tBox.Text);
			return tBox.Text;
		}

		private void btnCalcular_Click(object sender, EventArgs e)
		{
			//Calculo com 1 Elemento
			if (tbElemento2.Text == "" && tbElemento3.Text == "" && tbElemento4.Text == "" && tbElemento5.Text == "")
			{
				try
				{
					cmd.Connection = con.conectar();

					int quantidade1;

					quantidade1 = Convert.ToInt32(tbQuantidade1.Text);


					cmd.CommandText = "SELECT * FROM TABELA WHERE SIMBOLO = @SIMBOLO";

					cmd.Parameters.AddWithValue("@SIMBOLO", tbElemento1.Text);

					dr = cmd.ExecuteReader();

					while (dr.Read())
					{
						massa1 = Convert.ToDouble(dr["massa"]);
						nome1 = (string)dr["nome_elemento"];

						resultado1 = quantidade1 * massa1;

						tbResultado.Text = resultado1.ToString() + " g/mol";

						porcentagem1 = 100;
						rtbResultados.Text = "Fórmula: " + tbElemento1.Text + tbQuantidade1.Text + "\n" +
							"Massa Molar: " + resultado1.ToString() + " g/mol" + "\n" +
							"--------------------------------\n" +
							"Percentual dos Elemento(s):" + "\n" +
							nome1 + ": " + porcentagem1.ToString() + " %";
					}
					dr.Close();

				}
				catch (Exception ex)
				{

					MessageBox.Show(ex.Message);
				}
				finally
				{
					con.desconectar();
				}
			}
			//Calculo com 2 Elementos
			else if (tbElemento3.Text == "" && tbElemento4.Text == "" && tbElemento5.Text == "")
			{
				try
				{
					cmd.Connection = con.conectar();

					int quantidade1, quantidade2;

					quantidade1 = Convert.ToInt32(tbQuantidade1.Text);
					quantidade2 = Convert.ToInt32(tbQuantidade2.Text);

					cmd.CommandText = "SELECT * FROM TABELA WHERE SIMBOLO = @SIMBOLO";
					cmd.Parameters.AddWithValue("@SIMBOLO", tbElemento1.Text);
					dr = cmd.ExecuteReader();

					while (dr.Read())
					{
						massa1 = Convert.ToDouble(dr["massa"]);
						nome1 = (string)dr["nome_elemento"];
						resultado1 = massa1 * quantidade1;

					}
					dr.Close();

					cmd.CommandText = "SELECT * FROM TABELA WHERE SIMBOLO = @SIMBOLO";
					cmd.Parameters.AddWithValue("@SIMBOLO", tbElemento2.Text);
					dr = cmd.ExecuteReader();

					while (dr.Read())
					{
						massa2 = Convert.ToDouble(dr["massa"]);
						nome2 = (string)dr["nome_elemento"];
						resultado2 = massa2 * quantidade2;
					}
					dr.Close();

					//Resultado Final
					resultado3 = resultado1 + resultado2;
					tbResultado.Text = resultado3.ToString() + " g/mol";

					//Porcentagem dos Elementos
					porcentagem1 = (resultado1 * 100) / resultado3;
					porcentagem2 = (resultado2 * 100) / resultado3;
					rtbResultados.Text = "Fórmula: " + tbElemento1.Text + tbQuantidade1.Text + tbElemento2.Text + tbQuantidade2.Text + "\n" +
						"Massa Molar: " + resultado3.ToString() + " g/mol" + "\n" +
						"--------------------------------\n" +
						"Percentual dos Elemento(s):" + "\n" +
						nome1 + ": " + porcentagem1.ToString("F2") + " %" + "\n" +
						nome2 + ": " + porcentagem2.ToString("F2") + " %";
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				finally
				{
					con.desconectar();
				}
			}
			//Calculo com 3 Elementos
			else if (tbElemento4.Text == "" && tbElemento5.Text == "")
			{
				try
				{
					int quantidade1, quantidade2, quantidade3;

					quantidade1 = Convert.ToInt32(tbQuantidade1.Text);
					quantidade2 = Convert.ToInt32(tbQuantidade2.Text);
					quantidade3 = Convert.ToInt32(tbQuantidade3.Text);

					cmd.Connection = con.conectar();

					cmd.CommandText = "SELECT * FROM TABELA WHERE SIMBOLO = @SIMBOLO";
					cmd.Parameters.AddWithValue("@SIMBOLO", tbElemento1.Text);
					dr = cmd.ExecuteReader();

					while (dr.Read())
					{
						massa1 = Convert.ToDouble(dr["massa"]);
						nome1 = (string)dr["nome_elemento"];
						resultado1 = massa1 * quantidade1;

					}
					dr.Close();

					cmd.CommandText = "SELECT * FROM TABELA WHERE SIMBOLO = @SIMBOLO";
					cmd.Parameters.AddWithValue("@SIMBOLO", tbElemento2.Text);
					dr = cmd.ExecuteReader();

					while (dr.Read())
					{
						massa2 = Convert.ToDouble(dr["massa"]);
						nome2 = (string)dr["nome_elemento"];
						resultado2 = massa2 * quantidade2;
					}
					dr.Close();

					cmd.CommandText = "SELECT * FROM TABELA WHERE SIMBOLO = @SIMBOLO";
					cmd.Parameters.AddWithValue("@SIMBOLO", tbElemento3.Text);
					dr = cmd.ExecuteReader();

					while (dr.Read())
					{
						massa3 = Convert.ToDouble(dr["massa"]);
						nome3 = (string)dr["nome_elemento"];
						resultado3 = massa3 * quantidade3;
					}
					dr.Close();

					//Resultados do Calculo
					resultado4 = resultado1 + resultado2 + resultado3;
					tbResultado.Text = resultado4.ToString() + " g/mol";

					//Porcentagem dos Elementos
					porcentagem1 = (resultado1 * 100) / resultado4;
					porcentagem2 = (resultado2 * 100) / resultado4;
					porcentagem3 = (resultado3 * 100) / resultado4;
					rtbResultados.Text = "Fórmula: " + tbElemento1.Text + tbQuantidade1.Text + tbElemento2.Text + tbQuantidade2.Text + tbElemento3.Text + tbQuantidade3.Text + "\n" +
						"Massa Molar: " + resultado4.ToString() + " g/mol" + "\n" +
						"--------------------------------\n" +
						"Percentual dos Elemento(s):" + "\n" +
						nome1 + ": " + porcentagem1.ToString("F2") + " %" + "\n" +
						nome2 + ": " + porcentagem2.ToString("F2") + " %" + "\n" +
						nome3 + ": " + porcentagem3.ToString("F2") + " %";


				}
				catch (Exception ex)
				{

					MessageBox.Show(ex.Message);
				}
				finally
				{
					con.desconectar();
				}
			}
			//Calculo com 4 Elementos
			else if (tbElemento5.Text == "")
			{
				try
				{
					int quantidade1, quantidade2, quantidade3, quantidade4;

					quantidade1 = Convert.ToInt32(tbQuantidade1.Text);
					quantidade2 = Convert.ToInt32(tbQuantidade2.Text);
					quantidade3 = Convert.ToInt32(tbQuantidade3.Text);
					quantidade4 = Convert.ToInt32(tbQuantidade4.Text);

					cmd.Connection = con.conectar();

					cmd.CommandText = "SELECT * FROM TABELA WHERE SIMBOLO = @SIMBOLO";
					cmd.Parameters.AddWithValue("@SIMBOLO", tbElemento1.Text);
					dr = cmd.ExecuteReader();

					while (dr.Read())
					{
						massa1 = Convert.ToDouble(dr["massa"]);
						nome1 = (string)dr["nome_elemento"];
						resultado1 = massa1 * quantidade1;

					}
					dr.Close();

					cmd.CommandText = "SELECT * FROM TABELA WHERE SIMBOLO = @SIMBOLO";
					cmd.Parameters.AddWithValue("@SIMBOLO", tbElemento2.Text);
					dr = cmd.ExecuteReader();

					while (dr.Read())
					{
						massa2 = Convert.ToDouble(dr["massa"]);
						nome2 = (string)dr["nome_elemento"];
						resultado2 = massa2 * quantidade2;
					}
					dr.Close();

					cmd.CommandText = "SELECT * FROM TABELA WHERE SIMBOLO = @SIMBOLO";
					cmd.Parameters.AddWithValue("@SIMBOLO", tbElemento3.Text);
					dr = cmd.ExecuteReader();

					while (dr.Read())
					{
						massa3 = Convert.ToDouble(dr["massa"]);
						nome3 = (string)dr["nome_elemento"];
						resultado3 = massa3 * quantidade3;
					}
					dr.Close();

					cmd.CommandText = "SELECT * FROM TABELA WHERE SIMBOLO = @SIMBOLO";
					cmd.Parameters.AddWithValue("@SIMBOLO", tbElemento4.Text);
					dr = cmd.ExecuteReader();

					while (dr.Read())
					{
						massa4 = Convert.ToDouble(dr["massa"]);
						nome4 = (string)dr["nome_elemento"];
						resultado4 = massa4 * quantidade4;
					}
					dr.Close();

					//Resultados do Calculo
					resultado5 = resultado1 + resultado2 + resultado3 + resultado4;
					tbResultado.Text = resultado5.ToString() + " g/mol";

					//Porcentagem dos Elementos
					porcentagem1 = (resultado1 * 100) / resultado5;
					porcentagem2 = (resultado2 * 100) / resultado5;
					porcentagem3 = (resultado3 * 100) / resultado5;
					porcentagem4 = (resultado4 * 100) / resultado5;
					rtbResultados.Text = "Fórmula: " + tbElemento1.Text + tbQuantidade1.Text + tbElemento2.Text + tbQuantidade2.Text + tbElemento3.Text + tbQuantidade3.Text + tbElemento4.Text + tbQuantidade4.Text + "\n" +
						"Massa Molar: " + resultado5.ToString() + " g/mol" + "\n" +
						"--------------------------------\n" +
						"Percentual dos Elemento(s):" + "\n" +
						nome1 + ": " + porcentagem1.ToString("F2") + " %" + "\n" +
						nome2 + ": " + porcentagem2.ToString("F2") + " %" + "\n" +
						nome3 + ": " + porcentagem3.ToString("F2") + " %" + "\n" +
						nome4 + ": " + porcentagem4.ToString("F2") + " %";
				}
				catch (Exception ex)
				{

					MessageBox.Show(ex.Message);
				}
				finally
				{
					con.desconectar();
				}
			}
			//Calculo com 5 Elementos
			else
			{
				try
				{
					int quantidade1, quantidade2, quantidade3, quantidade4, quantidade5;

					quantidade1 = Convert.ToInt32(tbQuantidade1.Text);
					quantidade2 = Convert.ToInt32(tbQuantidade2.Text);
					quantidade3 = Convert.ToInt32(tbQuantidade3.Text);
					quantidade4 = Convert.ToInt32(tbQuantidade4.Text);
					quantidade5 = Convert.ToInt32(tbQuantidade5.Text);

					cmd.Connection = con.conectar();

					cmd.CommandText = "SELECT * FROM TABELA WHERE SIMBOLO = @SIMBOLO";
					cmd.Parameters.AddWithValue("@SIMBOLO", tbElemento1.Text);
					dr = cmd.ExecuteReader();

					while (dr.Read())
					{
						massa1 = Convert.ToDouble(dr["massa"]);
						nome1 = (string)dr["nome_elemento"];
						resultado1 = massa1 * quantidade1;

					}
					dr.Close();

					cmd.CommandText = "SELECT * FROM TABELA WHERE SIMBOLO = @SIMBOLO";
					cmd.Parameters.AddWithValue("@SIMBOLO", tbElemento2.Text);
					dr = cmd.ExecuteReader();

					while (dr.Read())
					{
						massa2 = Convert.ToDouble(dr["massa"]);
						nome2 = (string)dr["nome_elemento"];
						resultado2 = massa2 * quantidade2;
					}
					dr.Close();

					cmd.CommandText = "SELECT * FROM TABELA WHERE SIMBOLO = @SIMBOLO";
					cmd.Parameters.AddWithValue("@SIMBOLO", tbElemento3.Text);
					dr = cmd.ExecuteReader();

					while (dr.Read())
					{
						massa3 = Convert.ToDouble(dr["massa"]);
						nome3 = (string)dr["nome_elemento"];
						resultado3 = massa3 * quantidade3;
					}
					dr.Close();

					cmd.CommandText = "SELECT * FROM TABELA WHERE SIMBOLO = @SIMBOLO";
					cmd.Parameters.AddWithValue("@SIMBOLO", tbElemento4.Text);
					dr = cmd.ExecuteReader();

					while (dr.Read())
					{
						massa4 = Convert.ToDouble(dr["massa"]);
						nome4 = (string)dr["nome_elemento"];
						resultado4 = massa4 * quantidade4;
					}
					dr.Close();

					cmd.CommandText = "SELECT * FROM TABELA WHERE SIMBOLO = @SIMBOLO";
					cmd.Parameters.AddWithValue("@SIMBOLO", tbElemento5.Text);
					dr = cmd.ExecuteReader();

					while (dr.Read())
					{
						massa5 = Convert.ToDouble(dr["massa"]);
						nome5 = (string)dr["nome_elemento"];
						resultado4 = massa5 * quantidade5;
					}
					dr.Close();

					//Resultados do Calculo
					resultado6 = resultado1 + resultado2 + resultado3 + resultado4 + resultado5;
					tbResultado.Text = resultado6.ToString() + " g/mol";

					//Porcentagem dos Elementos
					porcentagem1 = (resultado1 * 100) / resultado6;
					porcentagem2 = (resultado2 * 100) / resultado6;
					porcentagem3 = (resultado3 * 100) / resultado6;
					porcentagem4 = (resultado4 * 100) / resultado6;
					porcentagem5 = (resultado5 * 100) / resultado6;
					rtbResultados.Text = "Fórmula: " + tbElemento1.Text + tbQuantidade1.Text + tbElemento2.Text + tbQuantidade2.Text + tbElemento3.Text + tbQuantidade3.Text + tbElemento4.Text + tbQuantidade4.Text + tbElemento5.Text + tbQuantidade5.Text +  "\n" +
						"Massa Molar: " + resultado6.ToString() + " g/mol" + "\n" +
						"--------------------------------\n" +
						"Percentual dos Elemento(s):" + "\n" +
						nome1 + ": " + porcentagem1.ToString("F2") + " %" + "\n" +
						nome2 + ": " + porcentagem2.ToString("F2") + " %" + "\n" +
						nome3 + ": " + porcentagem3.ToString("F2") + " %" + "\n" +
						nome4 + ": " + porcentagem4.ToString("F2") + " %" + "\n" + 
						nome5 + ": " + porcentagem5.ToString("F2") + " %" + "\n";
				}
				catch (Exception ex)
				{

					MessageBox.Show(ex.Message);
				}
				finally
				{
					con.desconectar();
				}
			}

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
