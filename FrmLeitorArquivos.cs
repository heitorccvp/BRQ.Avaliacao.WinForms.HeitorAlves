using BRQ.Avaliacao.WinForms.HeitorAlves.Data;
using BRQ.Avaliacao.WinForms.HeitorAlves.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRQ.Avaliacao.WinForms.HeitorAlves
{
	public partial class FrmLeitorArquivos : Form
	{
		private Arquivos arquivo = new Arquivos();
		private string logExecucao = string.Empty;
		private string[] linhas = {};
		private List<string> linhasProcessadas = new List<string>();
		private string caminho = string.Empty;

		#region Eventos

		public FrmLeitorArquivos()
		{
			InitializeComponent();
		}

		private void btnSelecione_Click(object sender, EventArgs e)
		{
			selecionarArquivo();
		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			try
			{	
				linhas = arquivo.lerArquivo(caminho);
				int progresso = 1;
				linhasProcessadas.Clear();

				for (int i = 0; i < linhas.Length; i++)
				{
					Thread.Sleep(6000);
					linhasProcessadas.Add(linhas[i]);
					backgroundWorker1.ReportProgress(progresso, linhas[i]);

					if (backgroundWorker1.CancellationPending)
					{
						e.Cancel = true;
						backgroundWorker1.ReportProgress(0);
						return;
					}

					progresso = i + 1;

				}
			}
			catch (Exception)
			{
				throw;
			}

		}

		private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			if (!backgroundWorker1.CancellationPending)
			{
				rtxtLogExecucao.Text += string.Concat("\n",e.UserState);
			}
		}

		private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if (e.Cancelled)
			{
				rtxtLogExecucao.Text += string.Concat("\n", "A leitura foi interrompida");
				gravarArquivoNaBase();
				gravarArquivoDeSaida();
			}
			else if (e.Error != null)
				rtxtLogExecucao.Text += string.Concat("\n", "Ocorreu um erro na leitura");
			else
			{
				gravarArquivoNaBase();
				gravarArquivoDeSaida();
				rtxtLogExecucao.Text += string.Concat("\n", "Todos as linhas foram carregadas");
			}
			
		}

		private void btnParar_Click(object sender, EventArgs e)
		{
			if (backgroundWorker1.IsBusy)
			{
				backgroundWorker1.CancelAsync();
			}
		}

		private void btnIniciar_Click(object sender, EventArgs e)
		{
			if(!string.IsNullOrEmpty(caminho))
				lerArquivo(caminho);
		}

		#endregion

		#region Metodos
		public void selecionarArquivo()
		{
			caminho = arquivo.retornarArquivoSelecionado("*.txt");

			txtDiretorioDeEntrada.Text = caminho;

			if (!validarArquivo(caminho))
			{
				MessageBox.Show("Arquivo invalido");
			}
		}

		public bool validarArquivo(string caminho)
		{
			return arquivo.validarCabecalhoLinhas(caminho, ",", 6, 10, ref logExecucao);
		}

		public void lerArquivo(string caminho)
		{
			if (!backgroundWorker1.IsBusy)
			{
				backgroundWorker1.WorkerReportsProgress = true;
				backgroundWorker1.WorkerSupportsCancellation = true;
				backgroundWorker1.RunWorkerAsync(linhas);
			}
		}

		public void gravarArquivoNaBase()
		{
			acessoDB db = new acessoDB();
			db.gravarArquivoNaBase(linhasProcessadas.ToArray(), ",");
		}

		public void gravarArquivoDeSaida()
		{
			acessoDB db = new acessoDB();
			FileInfo info = new FileInfo(caminho);

			string caminhoSaida = Path.Combine(info.DirectoryName, (info.Name.Replace(info.Extension, "") + "saida.txt"));
			txtDiretorioDeSaida.Text = caminhoSaida;

			string dados = db.lerTabelaTeste(";");
			File.WriteAllText(caminhoSaida, dados);
			
		}

		#endregion
	}
}
