using Plugin.CloudFirestore.Attributes;

namespace project_gift_maui.Models;

public class Disciplina
{
    [Id]
    public string Id { get; set; }
    public string Nome { get; set; }
}
