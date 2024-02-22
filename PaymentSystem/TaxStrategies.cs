public class USTaxStrategy : ITaxStrategy
{
	public decimal FindTaxAmount(Order order)
	{
		return order.GetOrderTotal() * (7.25M / 100);
	}
}
public class UKTaxStrategy : ITaxStrategy
{
	public decimal FindTaxAmount(Order order)
	{
		return order.GetOrderTotal() * (20.0M / 100);
	}
}