using ProvaAPI.Models;

namespace ProvaAPI;
public class Calculos
{
 public Calculos(Aluno aluno,IMC iMC ){
    
    iMC.ValorImc = aluno.Peso / aluno.Altura * aluno.Altura; 
     }   
}
