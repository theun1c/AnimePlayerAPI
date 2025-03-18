namespace AnimePlayerBack.Contracts
{
    /// <summary>
    /// Cards Response
    /// </summary>
    /// <param name="Id"></param>
    /// <param name="Title"></param>
    /// <param name="Description"></param>
    /// <param name="Link"></param>
    public class AnimeCardResponse
    (
        Guid Id,
        string Title,
        string Description,
        string Link
    );
}
