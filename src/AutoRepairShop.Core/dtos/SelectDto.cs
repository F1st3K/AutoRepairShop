namespace AutoRepairShop.Core.dtos
{
    public class SelectDto
    {
        public string Filter { get; set; }
        public int FilterColumn { get; set; }

        public enum TypeSort
        {
            ACS,
            DECS
        }
        public TypeSort Sort { get; set; }
        public int SortColumn { get; set; }
        public string Search { get; set; }
        public int SearchColumn { get; set; }
    }
}
