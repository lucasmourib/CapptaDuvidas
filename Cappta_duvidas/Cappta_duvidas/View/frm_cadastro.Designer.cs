namespace Cappta_duvidas
{
	partial class Frm_cadastro
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
			this.txtPdv = new System.Windows.Forms.TextBox();
			this.lblCnpj = new System.Windows.Forms.Label();
			this.lblPDV = new System.Windows.Forms.Label();
			this.btnGravar = new System.Windows.Forms.Button();
			this.lblEmail = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			// 
			// txtPdv
			// 
			this.txtPdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPdv.Location = new System.Drawing.Point(42, 121);
			this.txtPdv.Name = "txtPdv";
			this.txtPdv.Size = new System.Drawing.Size(83, 26);
			this.txtPdv.TabIndex = 2;
			// 
			// lblCnpj
			// 
			this.lblCnpj.AutoSize = true;
			this.lblCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCnpj.Location = new System.Drawing.Point(38, 33);
			this.lblCnpj.Name = "lblCnpj";
			this.lblCnpj.Size = new System.Drawing.Size(49, 20);
			this.lblCnpj.TabIndex = 3;
			this.lblCnpj.Text = "CNPJ";
			// 
			// lblPDV
			// 
			this.lblPDV.AutoSize = true;
			this.lblPDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPDV.Location = new System.Drawing.Point(38, 98);
			this.lblPDV.Name = "lblPDV";
			this.lblPDV.Size = new System.Drawing.Size(42, 20);
			this.lblPDV.TabIndex = 4;
			this.lblPDV.Text = "PDV";
			// 
			// btnGravar
			// 
			this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGravar.Location = new System.Drawing.Point(157, 232);
			this.btnGravar.Name = "btnGravar";
			this.btnGravar.Size = new System.Drawing.Size(75, 29);
			this.btnGravar.TabIndex = 5;
			this.btnGravar.Text = "Gravar";
			this.btnGravar.UseVisualStyleBackColor = true;
			this.btnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmail.Location = new System.Drawing.Point(38, 154);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(53, 20);
			this.lblEmail.TabIndex = 7;
			this.lblEmail.Text = "E-mail";
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(42, 177);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(156, 26);
			this.txtEmail.TabIndex = 6;
			// 
			// txtCnpj
			// 
			this.txtCnpj.Culture = new System.Globalization.CultureInfo("");
			this.txtCnpj.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCnpj.Location = new System.Drawing.Point(42, 56);
			this.txtCnpj.Mask = "00.000.000/0000-00";
			this.txtCnpj.Name = "txtCnpj";
			this.txtCnpj.Size = new System.Drawing.Size(156, 26);
			this.txtCnpj.TabIndex = 8;
			// 
			// Frm_cadastro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(244, 282);
			this.Controls.Add(this.txtCnpj);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.btnGravar);
			this.Controls.Add(this.lblPDV);
			this.Controls.Add(this.lblCnpj);
			this.Controls.Add(this.txtPdv);
			this.MaximizeBox = false;
			this.Name = "Frm_cadastro";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox txtPdv;
		private System.Windows.Forms.Label lblCnpj;
		private System.Windows.Forms.Label lblPDV;
		private System.Windows.Forms.Button btnGravar;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.MaskedTextBox txtCnpj;
	}
}