namespace ProvaAPI.Models;
public class Aluno
{
    public int AlunoId { get; set; }
    public string? Nome { get; set; }
    public string? DataDeNascimento { get; set; }
    public IMC? IMC { get; set; }
    public int IMCId { get; set; }
    

}
