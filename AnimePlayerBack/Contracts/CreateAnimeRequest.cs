using System.Globalization;

namespace AnimePlayerBack.Contracts
{
    public class CreateAnimeRequest
    {
        public string Name { get; set; }

        public int Episodes { get; set; }

        public int Seasons { get; set; }
    }
}

