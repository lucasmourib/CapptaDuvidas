using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Cappta_duvidas.Model;
using System.Text.RegularExpressions;

namespace Cappta_duvidas
{
	class HandleConfig
	{
		private string Caminho { get; set; }
		private ValidateEmail validateEmail = new ValidateEmail();
		public Config config;
		public HandleConfig()
		{
			Caminho = @"C:\CapptaDuvidas";
			this.config = new Config();
		}
		public bool CreateFile(string cnpj, int pdv, string email)
		{

			StreamWriter sw;
			try
			{
				string newCnpj;
				if (Directory.Exists(this.Caminho) == false)
				{
					Directory.CreateDirectory(this.Caminho);
				}

				if (validateEmail.EmailIsValid(email) == false)
				{
					MessageBox.Show("Email incorreto");
					return false;
				}
				
				sw = File.CreateText(this.Caminho + @"\config.txt");
				newCnpj = Regex.Replace(cnpj, "[^0-9]", "");
				sw.WriteLine("Cnpj: " + newCnpj);
				sw.WriteLine("Pdv: " + pdv);
				sw.WriteLine("Email: "+email);

				sw.Close();
				return true;

			}
			catch (Exception)
			{
				MessageBox.Show("Não foi possível criar o arquivo com as informações do cliente.");
				return false;
			}

		}
		public Config ReturnConfig()
		{
			var lines = File.ReadAllLines(this.Caminho + @"\config.txt");
			
			foreach (string line in lines)
			{
				if (line.Contains("Cnpj") == true)
				{
					this.config.Cnpj = line;
				}
				if (line.Contains("Pdv") == true)
				{
					this.config.Pdv = line;
				}
				if (line.Contains("Email") == true)
				{
					this.config.Email = line.Substring(7);
				}
			}


			return config;
		}

		public bool ConfigExists()
		{
			return File.Exists(this.Caminho + @"\config.txt");

		}

		public override string ToString()
		{
			return config.ToString();
		}
	}
}
