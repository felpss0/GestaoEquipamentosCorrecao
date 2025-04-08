
using GestaoDeEquipamentos.ConsoleApp.ModuloEquipamento;

namespace GestaoDeEquipamentos.ConsoleApp.ModuloFabricante
{
    class Fabricante
    {
        public int Id;
        public string NomeFabricante;
        public string EmailFabricante;
        public int NumeroTelefone;


        public Fabricante(string nomeFabricante, string emailFabricante, int numeroTelefone)
        {
            
            NomeFabricante = nomeFabricante;
            EmailFabricante = emailFabricante;
            NumeroTelefone = numeroTelefone;
        }





    }
}
