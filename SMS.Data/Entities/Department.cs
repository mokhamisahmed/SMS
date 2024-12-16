namespace SMS.Data.Entities
{
    public class Department
    {
        public int Id { get; set; }

        public string Name { get; set; }


        public String superVisorId { get; set; }

        public ApplicationUser superVisor { get; set; }


        public List<Teacher> teachers { get; set; }

    }
}