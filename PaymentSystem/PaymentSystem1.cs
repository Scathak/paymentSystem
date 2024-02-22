public interface IDiscountCalculator 
{
	decimal CalculateDiscount(Order order);
}
public interface ITaxStrategy 
{
	decimal FindTaxAmount (Order order);
}
public class OrderProcessor
{
	private readonly IDiscountCalculator _discountCalculator;
	private readonly ITaxStrategy _taxStrategy;
	public OrderProcessor(IDiscountCalculator discountCalculator, ITaxStrategy taxStrategy){
		_taxStrategy = taxStrategy;
		_discountCalculator = discountCalculator;
	}
	public decimal CalculateTotal(Order order){
		decimal itemTotal = order.GetOrderTotal();
		decimal discountAmount = _discountCalculator.CalculateDiscount(order);
		decimal taxAmount = _taxStrategy.FindTaxAmount(order);
		return itemTotal - discountAmount + taxAmount;		
	}		
}
public class DiscountCalculatorAdapter : IDiscountCalculator {
	public decimal CalculateDiscount (Order order) {
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

