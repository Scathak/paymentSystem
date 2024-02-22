internal class Program
{
	private static void Main(string[] args)
	{
		Order order1 = new Order(
								orderId: "02FB",
								orderName : "Apples",
								orderType: "retail",
								orderDate : "20231015",
								orderTime: "154300",
								orderPlace: "online",
								orderCountry: "US",
								orderTaxStrategyType: "standard_VAT_rate",
								orderPricePerUnit: 2.0M,
								orderNumberOfUnits: 1.0M,
								orderDiscount: 0.0M, 
								orderUnitName: "kg",
								orderCurrency: "USD",
								orderStatus: "OK");
		
		var orderTaxStrategy = new USTaxStrategy();
		var orderDiscountOnTotal = new DiscountOnTotal();
		var newOrder = new OrderProcessor(orderDiscountOnTotal, orderTaxStrategy);

		Console.WriteLine($"New order was created: {order1.GetOrderId()}");
		Console.WriteLine($"{order1.GetOrderName()}: {order1.GetOrderPricePerUnit()} " +
			$"{order1.GetOrderCurrency()} per {order1.GetOrderNumberOfUnits()} {order1.GetOrderUnitName()}");
		Console.WriteLine($"Total: {newOrder.CalculateTotal(order1)} {order1.GetOrderCurrency()}");
	}
}