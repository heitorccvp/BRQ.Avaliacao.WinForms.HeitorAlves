namespace BRQ.Avaliacao.WinForms.HeitorAlves
{
	partial class FrmLeitorArquivos
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLeitorArquivos));
			this.lblArquivoEntrada = new System.Windows.Forms.Label();
			this.toolStripFmrLeitorArquivos = new System.Windows.Forms.ToolStrip();
			this.btnIniciar = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnParar = new System.Windows.Forms.ToolStripButton();
			this.txtDiretorioDeEntrada = new System.Windows.Forms.TextBox();
			this.txtDiretorioDeSaida = new System.Windows.Forms.TextBox();
			this.lblDiretorioDeSaida = new System.Windows.Forms.Label();
			this.btnSelecione = new System.Windows.Forms.Button();
			this.lblLogExecucao = new System.Windows.Forms.Label();
			this.rtxtLogExecucao = new System.Windows.Forms.RichTextBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.toolStripFmrLeitorArquivos.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblArquivoEntrada
			// 
			this.lblArquivoEntrada.AutoSize = true;
			this.lblArquivoEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblArquivoEntrada.Location = new System.Drawing.Point(24, 48);
			this.lblArquivoEntrada.Name = "lblArquivoEntrada";
			this.lblArquivoEntrada.Size = new System.Drawing.Size(172, 24);
			this.lblArquivoEntrada.TabIndex = 1;
			this.lblArquivoEntrada.Text = "Arquivo de Entrada";
			// 
			// toolStripFmrLeitorArquivos
			// 
			this.toolStripFmrLeitorArquivos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnIniciar,
            this.toolStripSeparator1,
            this.btnParar});
			this.toolStripFmrLeitorArquivos.Location = new System.Drawing.Point(0, 0);
			this.toolStripFmrLeitorArquivos.Name = "toolStripFmrLeitorArquivos";
			this.toolStripFmrLeitorArquivos.Size = new System.Drawing.Size(697, 25);
			this.toolStripFmrLeitorArquivos.TabIndex = 2;
			this.toolStripFmrLeitorArquivos.Text = "toolStrip1";
			// 
			// btnIniciar
			// 
			this.btnIniciar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnIniciar.Image = ((System.Drawing.Image)(resources.GetObject("btnIniciar.Image")));
			this.btnIniciar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnIniciar.Name = "btnIniciar";
			this.btnIniciar.Size = new System.Drawing.Size(43, 22);
			this.btnIniciar.Text = "Iniciar";
			this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// btnParar
			// 
			this.btnParar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnParar.Image = ((System.Drawing.Image)(resources.GetObject("btnParar.Image")));
			this.btnParar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnParar.Name = "btnParar";
			this.btnParar.Size = new System.Drawing.Size(38, 22);
			this.btnParar.Text = "Parar";
			this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
			// 
			// txtDiretorioDeEntrada
			// 
			this.txtDiretorioDeEntrada.Location = new System.Drawing.Point(28, 75);
			this.txtDiretorioDeEntrada.Name = "txtDiretorioDeEntrada";
			this.txtDiretorioDeEntrada.Size = new System.Drawing.Size(572, 20);
			this.txtDiretorioDeEntrada.TabIndex = 3;
			// 
			// txtDiretorioDeSaida
			// 
			this.txtDiretorioDeSaida.Location = new System.Drawing.Point(28, 146);
			this.txtDiretorioDeSaida.Name = "txtDiretorioDeSaida";
			this.txtDiretorioDeSaida.Size = new System.Drawing.Size(572, 20);
			this.txtDiretorioDeSaida.TabIndex = 4;
			// 
			// lblDiretorioDeSaida
			// 
			this.lblDiretorioDeSaida.AutoSize = true;
			this.lblDiretorioDeSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDiretorioDeSaida.Location = new System.Drawing.Point(24, 119);
			this.lblDiretorioDeSaida.Name = "lblDiretorioDeSaida";
			this.lblDiretorioDeSaida.Size = new System.Drawing.Size(132, 24);
			this.lblDiretorioDeSaida.TabIndex = 5;
			this.lblDiretorioDeSaida.Text = "Diretório Saída";
			// 
			// btnSelecione
			// 
			this.btnSelecione.Location = new System.Drawing.Point(606, 73);
			this.btnSelecione.Name = "btnSelecione";
			this.btnSelecione.Size = new System.Drawing.Size(71, 23);
			this.btnSelecione.TabIndex = 6;
			this.btnSelecione.Text = "Selecione";
			this.btnSelecione.UseVisualStyleBackColor = true;
			this.btnSelecione.Click += new System.EventHandler(this.btnSelecione_Click);
			// 
			// lblLogExecucao
			// 
			this.lblLogExecucao.AutoSize = true;
			this.lblLogExecucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLogExecucao.Location = new System.Drawing.Point(24, 190);
			this.lblLogExecucao.Name = "lblLogExecucao";
			this.lblLogExecucao.Size = new System.Drawing.Size(158, 24);
			this.lblLogExecucao.TabIndex = 7;
			this.lblLogExecucao.Text = "Log de execução";
			// 
			// rtxtLogExecucao
			// 
			this.rtxtLogExecucao.Location = new System.Drawing.Point(28, 217);
			this.rtxtLogExecucao.Name = "rtxtLogExecucao";
			this.rtxtLogExecucao.Size = new System.Drawing.Size(649, 163);
			this.rtxtLogExecucao.TabIndex = 9;
			this.rtxtLogExecucao.Text = "";
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
			this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
			// 
			// FrmLeitorArquivos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(697, 403);
			this.Controls.Add(this.rtxtLogExecucao);
			this.Controls.Add(this.lblLogExecucao);
			this.Controls.Add(this.btnSelecione);
			this.Controls.Add(this.lblDiretorioDeSaida);
			this.Controls.Add(this.txtDiretorioDeSaida);
			this.Controls.Add(this.txtDiretorioDeEntrada);
			this.Controls.Add(this.toolStripFmrLeitorArquivos);
			this.Controls.Add(this.lblArquivoEntrada);
			this.Name = "FrmLeitorArquivos";
			this.Text = "...::: Leitor de Arquivos :::...";
			this.toolStripFmrLeitorArquivos.ResumeLayout(false);
			this.toolStripFmrLeitorArquivos.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblArquivoEntrada;
		private System.Windows.Forms.ToolStrip toolStripFmrLeitorArquivos;
		private System.Windows.Forms.ToolStripButton btnIniciar;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton btnParar;
		private System.Windows.Forms.TextBox txtDiretorioDeEntrada;
		private System.Windows.Forms.TextBox txtDiretorioDeSaida;
		private System.Windows.Forms.Label lblDiretorioDeSaida;
		private System.Windows.Forms.Button btnSelecione;
		private System.Windows.Forms.Label lblLogExecucao;
		private System.Windows.Forms.RichTextBox rtxtLogExecucao;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
	}
}

