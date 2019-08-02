using Cappta_duvidas.Controller;
using System;
using System.Windows.Forms;

namespace Cappta_duvidas
{
	public partial class Frm_principal : Form
	{
		HandleConfig config;
		public Frm_principal()
		{
			InitializeComponent();
			this.config = new HandleConfig();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

		}

		private void btn_cancel_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://cappta.force.com/ajuda/s/article/Como-cancelar-uma-venda");
		}

		private void btn_reimp_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://cappta.force.com/ajuda/s/article/Como-reimprimir-o-comprovante-de-uma-venda");
		}

		private void btn_portal_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://cappta.force.com/ajuda/s/article/Meu-primeiro-acesso-no-Portal-de-Vendas-Cappta");
		}

		private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://cappta.force.com/ajuda/s/");
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Frm_principal_Load(object sender, EventArgs e)
		{

		}

		private void btn_acesso_Click(object sender, EventArgs e)
		{
			try
			{
				string nome = txtNome.Text;
				string caso = txtCaso.Text;
				if (nome == "")
				{
					MessageBox.Show("O nome não pode estar vazio");
					return;
				}

				NeedSupport.CallNeedSupport(config.ReturnConfig(), nome, caso);

			}
			catch (Exception)
			{
				MessageBox.Show("Ocorreu um erro");
			}
		}
	}
}
