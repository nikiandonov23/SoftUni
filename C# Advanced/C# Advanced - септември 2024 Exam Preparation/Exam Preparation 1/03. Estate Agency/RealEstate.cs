namespace EstateAgency
{
    public class RealEstate
    {
        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }



        private string postalCode;
        public string PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }


        private decimal price;
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }



        private double size;
        public double Size
        {
            get { return size; }
            set { size = value; }
        }

        public RealEstate()
        {

        }


        public RealEstate(string address, string postalCode, decimal price, double size)
        {
            this.address = address;
            this.postalCode = postalCode;
            this.price = price;
            this.size = size;
        }

        public override string ToString()
        {
            return $"Address: {Address}, PostalCode: {PostalCode}, Price: ${Price}, Size: {Size} sq.m.";
        }
       
    }
}