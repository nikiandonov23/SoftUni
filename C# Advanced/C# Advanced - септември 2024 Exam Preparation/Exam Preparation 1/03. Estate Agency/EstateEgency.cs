using System.Runtime.CompilerServices;
using System.Text;

namespace EstateAgency
{
    public class EstateAgency
    {
        private List<RealEstate> realEstates;

        public List<RealEstate> RealEstates
        {
            get { return realEstates; }
            set { realEstates = value; }
        }
        private int capacity;

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }




        private int count;
        public int Count
        {
            get
            {
                count = RealEstates.Count;

                return count;
            }

        }

        public EstateAgency(int capacity)
        {
            this.capacity = capacity;
            RealEstates = new List<RealEstate>();
        }

        public void AddRealEstate(RealEstate realEstate)
        {
            if (RealEstates.Count < Capacity)
            {
                if (RealEstates.Any(x => x.Address == realEstate.Address))
                {
                    //do nothing
                }
                else
                {
                    RealEstates.Add(realEstate);
                }
            }
        }
       
        public bool RemoveRealEstate(string address)
        {
            if (realEstates.Any(x => x.Address == address))
            {
                RealEstates.Remove(RealEstates.FirstOrDefault(x => x.Address == address));
                return true;
            }
            else { return false; }
        }
        
        public List<RealEstate> GetRealEstates(string postalCode)
        {
            List<RealEstate> toBeReturned = RealEstates.Where(x => x.PostalCode == postalCode).ToList();
            return toBeReturned;
        }

      
        public RealEstate GetCheapest()
        {
            RealEstate estateToBeReturned = new RealEstate();
            foreach (var estate in realEstates)
            {
                estateToBeReturned = estate;
                if (estate.Price < estateToBeReturned.Price)
                {
                    estateToBeReturned = estate;
                }
            }
            return estateToBeReturned;
        }

        public double GetLargest()
        {
            double sizeToBeReturned = 0;
            foreach (var estate in RealEstates)
            {

                if (estate.Size > sizeToBeReturned)
                {
                    sizeToBeReturned = estate.Size;
                }
            }
            return sizeToBeReturned;
        }

        public string EstateReport()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Real estates available:");
            for (int i = 0; i < RealEstates.Count; i++)
            {
                result.AppendLine(RealEstates[i].ToString());
            }
            return result.ToString().Trim();
        }

    }
}
