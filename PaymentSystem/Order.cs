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

	internal string GetOrderId()
	{
		return _orderId;
	}
	internal string GetOrderName()
	{
		return _orderName;
	}
	internal string GetOrderType()
	{
		return _orderType;
	}
	internal string GetOrderDate()
	{
		return _orderDate;
	}
	internal string GetOrderTime()
	{
		return _orderTime;
	}
	internal string GetOrderPlace()
	{
		return _orderPlace;
	}
	internal string GetOrderCountry()
	{
		return _orderCountry;
	}
	internal string GetOrderTaxStrategyType()
	{
		return _orderTaxStrategyType;
	}
	internal decimal GetOrderTotal()
	{
		return _orderPricePerUnit * _orderNumberOfUnits;
	}
	internal decimal GetOrderPricePerUnit()
	{
		return _orderPricePerUnit;
	}
	internal decimal GetOrderNumberOfUnits()
	{
		return _orderNumberOfUnits;
	}
	internal decimal GetOrderDiscount()
	{
		return _orderDiscount;
	}
	internal string GetOrderUnitName()
	{
		return _orderUnitName;
	}
	internal string GetOrderCurrency()
	{
		return _orderCurrency;
	}
	internal string GetOrderStatus()
	{
		return _orderStatus;
	}

}