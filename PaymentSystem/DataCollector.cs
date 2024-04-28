using Newtonsoft.Json;

namespace PaymentSystem
{
	public interface IReader
	{
		public VATRatesByCountry? ReadAll();
	}
	public class FileReader(string fullPath) : IReader
	{
		private readonly string _fileName = fullPath;

		public VATRatesByCountry? ReadAll()
		{
			try
			{
				using var r = new StreamReader(fullPath);
				var json = r.ReadToEnd();


				var output = JsonConvert.DeserializeObject<VATRatesByCountry>(json);

				return output;
			}
			catch (FileNotFoundException e)
			{
				Console.WriteLine($"The tax rates file was not found: '{e}'");
			}
			catch (DirectoryNotFoundException e)
			{
				Console.WriteLine($"The directory was not found: '{e}'");
			}
			catch (IOException e)
			{
				Console.WriteLine($"The tax rates file could not be opened: '{e}'");
			}
			return null;
		}
	}
	public class StringService
	{
		public static VATRatesByCountry? GetStrings(IReader reader)
		{
			return reader.ReadAll();
		}
	}
	public class VATRatesByCountry
	{
		public Dictionary<string, VATRates> Countries { get; set; }
	}
	public class VATRates
	{
		public decimal standard_VAT_rate { get; set; }
		public decimal[] reduced_rates { get; set; }
	}

	public class TaxInfoContainer
	{
		public VATRatesByCountry? TaxInfo { get; set; }

		public decimal GetVATRate(string countryName, string type, int index)
		{
			decimal output = 0;
			if (TaxInfo != null && TaxInfo.Countries.ContainsKey(countryName))
			{
				VATRates countryInfo = TaxInfo.Countries[countryName];
				output = type == "standard_VAT_rate" ? countryInfo.standard_VAT_rate : countryInfo.reduced_rates[index];
			}
			return output;
		}
	}
}

