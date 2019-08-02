using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cappta_duvidas.Model
{
	class Config
	{
		public string Cnpj { get; set; }
		public string Pdv { get; set; }
		public string Email { get; set; }
		
		public override string ToString()
		{
			return Cnpj + " " + Pdv + " " + Email;
		}
	}
}
