using CabInvoiceGenerator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CabInvoiceGenerator
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenDistanceAndTimeShouldReturnTotalFare()
        {
            InvoiceGenerator invoice = new InvoiceGenerator(RideType.NORMAL);
            double distance = 2.0;
            int time = 5;
            double expected = 25;

            double fare = invoice.CalculateFare(distance, time);

            Assert.AreEqual(expected, fare);
        }

        [TestMethod]
        public void GivenMultipleRideShouldReturnInvoiceSummary()
        {
            InvoiceGenerator invoice = new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };

            InvoiceSummary invoiceSummary = invoice.CalculateFare(rides);
            InvoiceSummary Expected = new InvoiceSummary(2, 27.0);

            Assert.AreEqual(Expected, invoiceSummary);
        }
    }
}