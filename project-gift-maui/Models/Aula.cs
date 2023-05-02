using Plugin.CloudFirestore.Attributes;

namespace project_gift_maui.Models;

public class Aula
{
    [Id]
    public string Id { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataTermino { get; set; }
    public string ProfessorId { get; set; }
    public string CursoId { get; set; }
    public string DisciplinaId { get; set; }
}
