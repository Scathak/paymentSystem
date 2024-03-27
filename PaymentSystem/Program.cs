public class Program
{

	private static void Main(string[] args)
	{
		Order order1 = new Order(
								orderId: "02FB",
								orderName: "Apples",
								orderType: "retail",
								orderDate: "20231015",
								orderTime: "154300",
								orderPlace: "online",
								orderCountry: "United_Kingdom",
								orderTaxStrategyType: "standard_VAT_rate",
								orderPricePerUnit: 2.0M,
								orderNumberOfUnits: 1.0M,
								orderDiscount: 0.0M,
								orderUnitName: "kg",
								orderCurrency: "USD",
								orderStatus: "OK");


		var orderDiscountOnTotal = new DiscountOnTotal();

		var fileReader = new FileReader("\\VATTaxByCountry.json");

		var taxContainer = new TaxInfoContainer();
		taxContainer.TaxInfo = StringService.GetStrings(fileReader);

		var newOrderProcessor = new OrderProcessor(orderDiscountOnTotal, taxContainer);

		Console.WriteLine($"New order was created: {order1.GetOrderId()}");
		Console.WriteLine($"{order1.GetOrderName()}: {order1.GetOrderPricePerUnit()} " +
			$"{order1.GetOrderCurrency()} per {order1.GetOrderNumberOfUnits()} {order1.GetOrderUnitName()}");
		Console.WriteLine($"Total: {newOrderProcessor.CalculateTotal(order1)} {order1.GetOrderCurrency()}");





	}

}


