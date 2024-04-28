namespace PaymentSystem
{
	public class AlgeriaTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "AlgeriaTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Algeria", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class Antigua_and_BarbudaTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "Antigua_and_BarbudaTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Antigua_and_Barbuda", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class AndorraTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "AndorraTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Andorra", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class ArgentinaTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "ArgentinaTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Argentina", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class ArmeniaTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "ArmeniaTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Armenia", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class ArubaTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "ArubaTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Aruba", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class AustraliaTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "AustraliaTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Australia", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class AzerbaijanTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "AzerbaijanTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Azerbaijan", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class BahamasTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "BahamasTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Bahamas", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class BahrainTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "BahrainTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Bahrain", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class BangladeshTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "BangladeshTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Bangladesh", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class BarbadosTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "BarbadosTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Barbados", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class BelizeTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "BelizeTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Belize", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class BermudaTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "BermudaTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Bermuda", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class BoliviaTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "BoliviaTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Bolivia", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class BotswanaTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "BotswanaTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Botswana", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class BrazilTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "BrazilTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Brazil", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class British_Virgin_IslandsTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "British_Virgin_IslandsTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("British_Virgin_Islands", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class BruneiTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "BruneiTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Brunei", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class BulgariaTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "BulgariaTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Bulgaria", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class CanadaTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "CanadaTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Canada", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class Cayman_IslandsTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "Cayman_IslandsTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Cayman_Islands", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class ChileStrategy : ITaxStrategy
	{
		public string Name { get; } = "ChileTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Chile", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class ChinaTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "ChinaTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("China", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class ColombiaTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "ColombiaTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Colombia", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class Cook_IslandsTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "Cook_IslandsTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Cook_Islands", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class Costa_RicaTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "Costa_RicaTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Costa_Rica", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class CuraçaoTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "CuraçaoTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Curaçao", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class UAETaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "UAETaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("UAE", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class EcuadorTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "EcuadorTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Ecuador", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class EgyptTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "EgyptTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Egypt", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class El_SalvadorTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "El_SalvadorTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("El_Salvador", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class Equatorial_GuineaTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "Equatorial_GuineaTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Equatorial_Guinea", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class EthiopiaTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "EthiopiaTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Ethiopia", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class Faroe_IslandsTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "Faroe_IslandsTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Faroe_Islands", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class GeorgiaTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "GeorgiaTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Georgia", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class GibraltarTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "GibraltarTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Gibraltar", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class GuatemalaTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "GuatemalaTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Guatemala", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class GuernseyTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "GuernseyTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Guernsey", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class Hong_KongTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "Hong_KongTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Hong_Kong", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class IndiaTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "IndiaTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("India", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class IndonesiaTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "IndonesiaTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Indonesia", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class IraqTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "IraqTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Iraq", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class Isle_of_ManTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "Isle_of_ManTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Isle_of_Man", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class IsraelTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "IsraelTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Israel", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class JapanTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "JapanTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Japan", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class JerseyTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "JerseyTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Jersey", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class KazakhstanTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "KazakhstanTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Kazakhstan", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class South_KoreaTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "South_KoreaTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("South_Korea", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class KuwaitTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "KuwaitTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Kuwait", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class LaosTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "LaosTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Laos", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class LebanonTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "LebanonTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Lebanon", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class MalaysiaTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "MalaysiaTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Malaysia", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class MauritaniaTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "MauritaniaTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Mauritania", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class MauritiusTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "MauritiusTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Mauritius", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class MexicoTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "MexicoTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Mexico", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class MoroccoTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "MoroccoTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Morocco", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class New_ZealandTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "New_ZealandTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("New_Zealand", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class NigeriaTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "NigeriaTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Nigeria", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class OmanTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "OmanTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Oman", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class PakistanTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "PakistanTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Pakistan", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class PanamaTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "PanamaTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Panama", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class PeruTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "PeruTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Peru", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class PhilippinesTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "PhilippinesTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Philippines", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class Puerto_RicoTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "Puerto_RicoTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Puerto_Rico", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class QatarTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "QatarTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Qatar", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}

	public class RussiaTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "RussiaTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Russia", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class Saudi_ArabiaTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "Saudi_ArabiaTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Saudi_Arabia", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class SingaporeTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "SingaporeTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Singapore", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class Sri_LankaTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "Sri_LankaTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Sri_Lanka", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class TaiwanTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "TaiwanTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Taiwan", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class TanzaniaTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "TanzaniaTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Tanzania", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class TajikistanTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "TajikistanTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Tajikistan", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class ThailandTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "ThailandTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Thailand", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class TunisiaTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "TunisiaTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Tunisia", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class TurkeyTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "TurkeyTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Turkey", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class Turks_and_CaicosTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "Turks_and_CaicosTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Turks_and_Caicos", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class UkraineTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "UkraineTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Ukraine", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class UgandaTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "UgandaTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Uganda", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class United_KingdomTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "United_KingdomTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("United_Kingdom", "reduced_rates", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class UruguayTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "UruguayTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Uruguay", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class USATaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "USATaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("USA", "reduced_rates", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class UzbekistanTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "UzbekistanTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Uzbekistan", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class VanuatuTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "VanuatuTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Vanuatu", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class VenezuelaTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "VenezuelaTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Venezuela", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
	public class VietnamTaxStrategy : ITaxStrategy
	{
		public string Name { get; } = "VietnamTaxStrategy";
		public decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer)
		{
			var tax = taxContainer.GetVATRate("Vietnam", "standard_VAT_rate", 0);
			return order.GetOrderTotal() * (tax / 100);
		}
	}
}
