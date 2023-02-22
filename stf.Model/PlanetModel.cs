namespace stf.Model;

public sealed record PlanetModel
{
    public int Id { get; init; }
    public string? Name { get; init; }
    public string? Description { get; init; }
}