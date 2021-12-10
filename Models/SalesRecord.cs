namespace democsharp.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public System.DateTime Date { get; set; }
        public double Amount { get; set; }

        public int StatusId { get; set; }
        public Status Status { get; set; }        
        public int SellerId { get; set; }    
        public Seller Seller { get; set; }    
    }
}