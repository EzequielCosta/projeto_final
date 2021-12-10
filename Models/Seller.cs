namespace democsharp.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public string Email { get; set; }

        public System.DateTime BirthDate { get; set; }

        public double BaseSalary { get; set; }    

        public int DepartmentId { get; set; }

        public Department Department { get; set; }        



    }
}