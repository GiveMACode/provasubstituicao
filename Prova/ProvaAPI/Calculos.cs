using ProvaAPI.Models;

namespace ProvaAPI;
public class Calculos
{
 public Calculos(IMC iMC){
    
    iMC.ValorImc = iMC.Peso / iMC.Altura * iMC.Altura; 
     }   
}
