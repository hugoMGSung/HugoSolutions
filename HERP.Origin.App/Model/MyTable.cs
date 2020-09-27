namespace HERP.Origin.App.Model
{
    public class MyTable
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ParentId { get; set; }
    }

    public class TMenu
    {
        public int Idx { get; set; }
        public int Parent_Idx { get; set; } 
        public string ID { get; set; }
        public int? Class { get; set; }
        public string Name { get; set; }
        public int Orders { get; set; }
        public string UseYn { get; set; }
        public string UserId { get; set; }
    }

    public class TErpUser
    {

    }
}
