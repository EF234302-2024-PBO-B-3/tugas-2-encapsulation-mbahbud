using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Invoicing
{
    public class Invoice
    {
        private string _partNumber;
        private string _partDescription;
        private int _quantity;
        private double _price;

        public string PartNumber
        {
            get { return _partNumber; }
            set { _partNumber = value; }
        }

        public string PartDescription
        {
            get { return _partDescription; }
            set { _partDescription = value; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value < 0 ? 0 : value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value < 0 ? 0.0 : value; }
        }

        public Invoice(string partNumber, string partDescription, int quantity, double price)
        {
            _partNumber = partNumber;
            _partDescription = partDescription;
            Quantity = quantity;  
            Price = price;        
        }
        public double GetInvoiceAmount()
        {
            return Quantity * Price;
        }
    }
}
