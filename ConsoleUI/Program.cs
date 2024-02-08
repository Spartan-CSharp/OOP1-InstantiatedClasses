using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<PersonModel> people = new List<PersonModel>();
			bool isnotdone = true;

			do
			{
				PersonModel person = new PersonModel();
				ProcessData.GatherPersonData(person);
				people.Add(person);
				Console.Write("Add another (Yes/No): ");
				string addanother = Console.ReadLine();
				if ( addanother.ToLower() == "no" )
				{
					isnotdone = false;
				}
			} while ( isnotdone );

			Console.WriteLine();

			foreach ( PersonModel person in people )
			{
				ProcessData.OutputPersonData(person);
			}

			_ = Console.ReadLine();
		}
	}
}
