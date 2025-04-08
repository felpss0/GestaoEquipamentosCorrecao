
using GestaoDeEquipamentos.ConsoleApp.ModuloEquipamento;

namespace GestaoDeEquipamentos.ConsoleApp.ModuloFabricante
{
    class Fabricante
    {
        public int Id;
        public Equipamento NomeFabricante;
        public string EmailFabricante;
        public int NumeroTelefone;


        public Fabricante(int idFabricante, Equipamento nomeFabricante, string emailFabricante, int numeroTelefone)
        {
            Id = idFabricante;
            NomeFabricante = nomeFabricante;
            EmailFabricante = emailFabricante;
            NumeroTelefone = numeroTelefone;
        }





    }
}
