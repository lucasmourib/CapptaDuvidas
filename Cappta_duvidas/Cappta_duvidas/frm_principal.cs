using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cappta_duvidas
{
	public partial class frm_principal : Form
	{
		public frm_principal()
		{
			InitializeComponent();
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

		private void btn_boleto_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://cappta.force.com/ajuda/s/article/Segunda-via-de-boleto");
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
	}
}
