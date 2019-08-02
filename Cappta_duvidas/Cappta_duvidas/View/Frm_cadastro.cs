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
	public partial class Frm_cadastro : Form
	{
		public Frm_cadastro()
		{
			InitializeComponent();
		}

		private void BtnGravar_Click(object sender, EventArgs e)
		{
			var cnpj = txtCnpj.Text;
			var pdv = int.Parse(txtPdv.Text);
			var email = txtEmail.Text;

			HandleConfig config = new HandleConfig();
			if (cnpj == "" || pdv == 0  || email == "") { MessageBox.Show("Os dados não podem estar vazios"); return; }
			if (config.CreateFile(cnpj, pdv, email) == false)
			{
				return;
			}

			Frm_principal principal = new Frm_principal();
			this.Hide();
			principal.ShowDialog();



		}
	}
}
