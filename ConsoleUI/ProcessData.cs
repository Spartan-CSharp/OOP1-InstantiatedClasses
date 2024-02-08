using System;

namespace ConsoleUI
{
	internal static class ProcessData
	{
		internal static void GatherPersonData(PersonModel person)
		{
			Console.Write("What is your first name: ");
			person.FirstName = Console.ReadLine();
			Console.Write("What is your last name: ");
			person.LastName = Console.ReadLine();
			Console.Write("What is your street address: ");
			person.Address = new AddressModel
			{
				StreetAddress = Console.ReadLine()
			};
			Console.Write("What is your city: ");
			person.Address.City = Console.ReadLine();
			Console.Write("What is your state: ");
			person.Address.State = Console.ReadLine();
			Console.Write("What is your zip code: ");
			person.Address.ZipCode = Console.ReadLine();
		}

		internal static void OutputPersonData(PersonModel person)
		{
			Console.WriteLine($"{person.FirstName} {person.LastName} lives at {person.Address.StreetAddress}, {person.Address.City} {person.Address.State} {person.Address.ZipCode}.");
		}
	}
}
