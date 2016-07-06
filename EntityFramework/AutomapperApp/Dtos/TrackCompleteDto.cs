namespace AutomapperApp.Dtos
{
    public class TrackCompleteDto
    {
        public int TrackId { get; set; }

        public string Name { get; set; }

        public string Album { get; set; }

        public string MediaType { get; set; }

        public string Genre { get; set; }

        public string Composer { get; set; }

        public int Milliseconds { get; set; }

        public int? Bytes { get; set; }

        public decimal UnitPrice { get; set; }
    }
}
