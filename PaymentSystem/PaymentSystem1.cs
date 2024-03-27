public interface IDiscountCalculator
{
	decimal CalculateDiscount(Order order);
}
public interface ITaxStrategy
{
	public string Name { get; }
	decimal FindTaxAmount(Order order, TaxInfoContainer taxContainer);
}
public class OrderProcessor
{
	private readonly IDiscountCalculator _discountCalculator;
	//private readonly ITaxStrategy _taxStrategy;
	private readonly List<ITaxStrategy> _taxStrategyByCountry;
	private readonly TaxInfoContainer _taxContainer;
	public OrderProcessor(IDiscountCalculator discountCalculator, TaxInfoContainer taxContainer)
	{

		_discountCalculator = discountCalculator;
		_taxContainer = taxContainer;
		_taxStrategyByCountry = [new AlgeriaTaxStrategy { }, new USATaxStrategy { }, new United_KingdomTaxStrategy { }];
	}
	public decimal CalculateTotal(Order order)
	{
		decimal itemTotal = order.GetOrderTotal();
		decimal discountAmount = _discountCalculator.CalculateDiscount(order);

		var _taxStrategy = GetTaxStrategyByCountry(order.GetOrderCountry());

		decimal taxAmount = _taxStrategy.FindTaxAmount(order, _taxContainer);
		return itemTotal - discountAmount + taxAmount;
	}
	public ITaxStrategy GetTaxStrategyByCountry(string country)
	{
		return _taxStrategyByCountry.Find(obj => obj.Name == (country + "TaxStrategy"));
	}
}
public class DiscountCalculatorAdapter : IDiscountCalculator
{
	public decimal CalculateDiscount(Order order)
	{
		return DiscountCalculator.CalculateDiscount(order);
	}
}

public class DiscountCalculator
{
	public static decimal CalculateDiscount(Order order)
	{
		throw new NotImplementedException();
	}
}

