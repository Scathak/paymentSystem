namespace TestProject1
{
	public class UnitTest1
	{
		[Theory]
		[InlineData("C:\\jfk08\\_prog\\paymentSystem\\PaymentSystem\\VATTaxByCountry.json")]
		[InlineData("C:\\jfk08\\_prog\\paymentSystem\\PaymentSystem\\VATTaxByCountr.json")]
		public void Test1(string path)
		{

			var fileReader = new FileReader(path);
			//Assert.True(fileReader == null, "Object not created");

			var VATRates = fileReader?.ReadAll();
			Assert.True(VATRates == null, "Empty object");
		}
	}
}