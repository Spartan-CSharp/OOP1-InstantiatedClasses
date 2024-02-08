using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
	internal class PersonModel
	{
		internal string FirstName
		{
			get; set;
		}
		internal string LastName
		{
			get; set;
		}
		internal AddressModel Address
		{
			get; set;
		}
	}
}
