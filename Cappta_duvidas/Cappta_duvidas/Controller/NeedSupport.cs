using Cappta_duvidas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cappta_duvidas.Controller
{
	class NeedSupport
	{

		public static void CallNeedSupport(Config config, string name, string caseNumber)
		{
			string link;

			link = $"https://api.swi-rc.com/integration/integration_api.php?uid=48fdd462-68df-11e3-b2ba-12313931119b%7C2109" +
				$"&customer_number= {config.Cnpj} {config.Pdv} " +
				$"&customer_email={config.Email}&customer_name={name}&problem_description={caseNumber}";


			System.Diagnostics.Process.Start(link);

		}
	}
}
