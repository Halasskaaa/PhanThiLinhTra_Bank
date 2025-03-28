using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
	internal abstract class Owner
	{
		private string name;

		protected Owner(string name)
		{
			this.name = name;
		}

		public string Name { get => name; set => name = value; }
	
	}
}
