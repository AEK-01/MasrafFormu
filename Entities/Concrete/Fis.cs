using Core.Entities;

namespace Entities
{
    public class Fis : IEntity
    { 
        public int Id { get; set; }
        public string FisNo { get; set; } 
        public string Date { get; set; }
        public string Company { get; set; }
        public string FisType { get; set; }
        public string Description { get; set; }
        public double VatValue { get; set; }
        public double TotalCost { get; set; } 

    }

}
