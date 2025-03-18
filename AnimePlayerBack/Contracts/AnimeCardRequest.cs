using System.Globalization;

namespace AnimePlayerBack.Contracts
{
    /// <summary>
    /// Cards Request
    /// </summary>
    /// <param name="Title"></param>
    /// <param name="Description"></param>
    /// <param name="Link"></param>
    public record class AnimeCardRequest
    (
        string Title,
        string Description,
        string Link
    );
}

