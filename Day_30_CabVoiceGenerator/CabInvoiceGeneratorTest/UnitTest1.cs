using Day_30_CabVoiceGenerator;

namespace InvoiceGenerator
{
    public class CanInvoiceTest
    {
        InvoiceGenerator invoicegenerator;
        [SetUp]
        public void Setup()
        {
            invoicegenerator = new InvoiceGenerator(RideType.NORMAL);
        }

        [Test]
        public void GivenDistanceAndTimeReturnTotalFair()
        {
            //assert
            int distance = 2;
            int time = 5;
            double expected = 25;
            InvoiceGenerator generator = new InvoiceGenerator(RideType.NORMAL);
            //act

            double actual = generator.CalculateTotalFair(distance, time);
        }
    }
}