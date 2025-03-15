namespace AnimePlayerBack.Contracts
{
    public class AnimeResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Episodes { get; set; }
        public int Seasons { get; set; }
    }
}
