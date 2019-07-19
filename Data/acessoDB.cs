using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRQ.Avaliacao.WinForms.HeitorAlves.Data
{
	public class acessoDB
	{

		public void gravarArquivoNaBase(string[] linhas, string separador)
		{
			try
			{
				DataTable dt = new DataTable("Teste");
				string[] cabecalho = linhas.First().Split(Convert.ToChar(separador));

				for (int i = 0; i < cabecalho.Length; i++)
					dt.Columns.Add(new DataColumn(cabecalho[i]));

				for (int i = 0; i < linhas.Length; i++)
				{
					if (i == 0)
						i = i + 1;

					string[] linha = linhas[i].Split(Convert.ToChar(separador));

					DataRow dr = dt.NewRow();
					dr.ItemArray = linha;
					dt.Rows.Add(dr);
				}

				using (var cn = new SqlConnection(strConn()))
				{
					cn.Open();

					using (var bCopy = new SqlBulkCopy(cn, SqlBulkCopyOptions.TableLock, null))
					{
						bCopy.DestinationTableName = "Teste";
						bCopy.WriteToServer(dt);
					}
				}

			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

		}

		public string lerTabelaTeste(string separador)
		{
			try
			{
				DataTable dt = new DataTable();

				SqlDataAdapter Objadapter = new SqlDataAdapter("select * from Teste", strConn());

				Objadapter.Fill(dt);

				StringBuilder dados = new StringBuilder();

				for (int iColuna = 0; iColuna < dt.Columns.Count; iColuna++)
				{
					dados.Append(string.Concat(dt.Columns[iColuna].ColumnName, separador));
				}
				dados.Append(Environment.NewLine);

				for (int i = 0; i < dt.Rows.Count; i++)
				{
					if (i > 0)
					{
						for (int iColuna = 0; iColuna < dt.Columns.Count; iColuna++)
						{
							dados.Append(string.Concat(dt.Rows[i][dt.Columns[iColuna].ColumnName].ToString().Trim(), separador));
						}
						dados.Append(Environment.NewLine);
					}

				}

				return dados.ToString();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		private string strConn()
		{
			return @"Data Source=localhost\SQLEXPRESS;Initial Catalog=TESTE;Integrated Security=True";
		}

	}
}
