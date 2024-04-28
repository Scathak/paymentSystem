namespace PaymentSystem
{
	public class Order(
						string orderId,
						string orderName,
						string orderType,
						string orderDate,
						string orderTime,
						string orderPlace,
						string orderCountry,
						string orderTaxStrategyType,
						decimal orderPricePerUnit,
						decimal orderNumberOfUnits,
						decimal orderDiscount,
						string orderUnitName,
						string orderCurrency,
						string orderStatus)
	{
		private string _orderId = orderId;
		private string _orderName = orderName;
		private string _orderType = orderType;
		private string _orderDate = orderDate;
		private string _orderTime = orderTime;
		private string _orderPlace = orderPlace;
		private string _orderCountry = orderCountry;
		private string _orderTaxStrategyType = orderTaxStrategyType;
		private decimal _orderPricePerUnit = orderPricePerUnit;
		private decimal _orderNumberOfUnits = orderNumberOfUnits;
		private decimal _orderDiscount = orderDiscount;
		private string _orderUnitName = orderUnitName;
		private string _orderCurrency = orderCurrency;
		private string _orderStatus = orderStatus;

		public string GetOrderId()
		{
			return _orderId;
		}
		public string GetOrderName()
		{
			return _orderName;
		}
		public string GetOrderType()
		{
			return _orderType;
		}
		public string GetOrderDate()
		{
			return _orderDate;
		}
		public string GetOrderTime()
		{
			return _orderTime;
		}
		public string GetOrderPlace()
		{
			return _orderPlace;
		}
		public string GetOrderCountry()
		{
			return _orderCountry;
		}
		public string GetOrderTaxStrategyType()
		{
			return _orderTaxStrategyType;
		}
		public decimal GetOrderTotal()
		{
			return _orderPricePerUnit * _orderNumberOfUnits;
		}
		public decimal GetOrderPricePerUnit()
		{
			return _orderPricePerUnit;
		}
		public decimal GetOrderNumberOfUnits()
		{
			return _orderNumberOfUnits;
		}
		public decimal GetOrderDiscount()
		{
			return _orderDiscount;
		}
		public string GetOrderUnitName()
		{
			return _orderUnitName;
		}
		public string GetOrderCurrency()
		{
			return _orderCurrency;
		}
		public string GetOrderStatus()
		{
			return _orderStatus;
		}
	}
}