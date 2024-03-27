
	public class DiscountOnTotal : IDiscountCalculator
	{
		public decimal CalculateDiscount(Order order)
		{
			return order.GetOrderTotal() * (order.GetOrderDiscount() / 100);
		}
	}
	public class DiscountOnPricePerUnit : IDiscountCalculator
	{
		public decimal CalculateDiscount(Order order)
		{
			return order.GetOrderPricePerUnit() * (order.GetOrderDiscount() / 100);
		}
	}
	public class DiscountOnNumberOfUnits : IDiscountCalculator
	{
		public decimal CalculateDiscount(Order order)
		{
			var discountPercent = order.GetOrderDiscount() / order.GetOrderNumberOfUnits();
			return order.GetOrderPricePerUnit() * (1 - discountPercent);
		}
	}
