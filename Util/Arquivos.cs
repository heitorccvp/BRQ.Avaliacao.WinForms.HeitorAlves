using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRQ.Avaliacao.WinForms.HeitorAlves.Util
{
	public class Arquivos
	{
		/// <summary>
		/// Selecionar um arquivo em um diretório e retornar o caminho
		/// </summary>
		/// <param name="filtroPorTipo">Definir um tipo de arquivo</param>
		/// <returns></returns>
		public string retornarArquivoSelecionado(string filtroPorTipo)
		{
			string arquivo = string.Empty;

			OpenFileDialog open = new OpenFileDialog();
			open.Filter = "txt files (*.txt)|*.txt";
			open.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); ;
			DialogResult arquivoSelecionado = open.ShowDialog();

			if (arquivoSelecionado == DialogResult.OK)
			{
				arquivo = open.FileName;
			}
			else if(arquivoSelecionado == DialogResult.Cancel)
			{
				arquivo = string.Empty;
			}

			return arquivo;
		}

		public bool validarCabecalhoLinhas(string caminho, string separador,int minimoColunas, int minimoLinhas, ref string messageRetorno)
		{
			bool valido = false;

			if (File.Exists(caminho))
			{
				string[] linhas = File.ReadAllLines(caminho);

				if (linhas.Length > 0)
				{
					string cabecalho = linhas.First();

					if (cabecalho.Length > 0)
					{
						string[] colunas = cabecalho.Split(Convert.ToChar(separador));

						if (colunas.Length < minimoColunas)
							messageRetorno = "Cabeçalho inválido";
						else
						{
							valido = true;
						}
					}
					else
					{
						messageRetorno = "Cabeçalho inválido";
						valido = false;
					}

					if (linhas.Length < minimoLinhas)
					{
						messageRetorno = string.Format("O número de linhas {0} é inválido", minimoLinhas);
						valido = false;
					}
					
				}
			}
			else
				valido = false;
			
			return valido;
		}

		public string[] lerArquivo(string caminho)
		{
			return File.ReadAllLines(caminho);
		}

	}
}
