using Plugin.CloudFirestore.Attributes;

namespace project_gift_maui.Models;

public class Professor
{
    [Id]
    public string Id { get; set; }
    public string Nome { get; set; }
    public string UserId { get; set; }
}
