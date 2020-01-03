using System;
using System.Collections.Generic;

namespace AddressBook
{
	[SerializableAttribute]
    public class CA_Province
	{
		public string Name { get; set; }
		public string Abbreviation { get; set; }

		public CA_Province(string abbreviation, string name)
		{
			Abbreviation = abbreviation;
			Name = name;
		}

		public static CA_Province FromInt(int input)
		{
            CA_Province[] provicnes = ProvinceArray.Provinces();

			if (input >= 0 && input < provicnes.Length)
				return provicnes[input];
			else
				throw new IndexOutOfRangeException(String.Format("Invalid province index {0}", input));
		}
	}

	static class ProvinceArray
    {
		static List<CA_Province> provinces;

		static ProvinceArray()
		{
            provinces = new List<CA_Province>(50);
			provinces.Add(new CA_Province("AB", "Alberta"));
			provinces.Add(new CA_Province("BC", "British Columbia"));
			provinces.Add(new CA_Province("MB", "Manitoba"));
			provinces.Add(new CA_Province("NB", "New Brunswick"));
			provinces.Add(new CA_Province("NL", "Newfoundland and Labrador"));
			provinces.Add(new CA_Province("NT", "Northwest Territories"));
			provinces.Add(new CA_Province("NS", "Nova Scotia"));
			provinces.Add(new CA_Province("NU", "Nunavut"));
			provinces.Add(new CA_Province("ON", "Ontario"));
			provinces.Add(new CA_Province("PE", "Prince Edward Island"));
			provinces.Add(new CA_Province("QC", "Quebec"));
			provinces.Add(new CA_Province("SK", "Saskatchewan"));
			provinces.Add(new CA_Province("YT", "Yukon"));
		}

		public static string[] Abbreviations()
		{
			List<string> abbrevList = new List<string>(provinces.Count);
			foreach (var state in provinces)
			{
				abbrevList.Add(state.Abbreviation);
			}
			return abbrevList.ToArray();
		}

		public static string[] Names()
		{
			List<string> nameList = new List<string>(provinces.Count);
			foreach (var state in provinces)
			{
				nameList.Add(state.Name);
			}
			return nameList.ToArray();
		}

		public static CA_Province[] Provinces()
		{
			return provinces.ToArray();
		}
	}
}
