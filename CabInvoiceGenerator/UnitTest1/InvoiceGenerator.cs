using System;

namespace CabInvoiceGeneratorUnitTest
{
    internal class InvoiceGenerator
    {
        private object nORMAL;

        public InvoiceGenerator(object nORMAL)
        {
            this.nORMAL = nORMAL;
        }

        internal double CalculateFare(double distance, int time)
        {
            throw new NotImplementedException();
        }

        internal InvoiceSummary CalculateFare(Ride[] rides)
        {
            throw new NotImplementedException();
        }
    }
}