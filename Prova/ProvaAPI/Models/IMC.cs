namespace ProvaAPI.Models;
public class IMC
{
        public int IMCId { get; set; }
        public float ValorImc { get; set; }
        public float Peso { get; set; }
        public float Altura { get; set; }
        public string? Classificacao { get; set; }
}
