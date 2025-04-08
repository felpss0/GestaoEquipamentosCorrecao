using GestaoDeEquipamentos.ConsoleApp.Compartilhado;
using GestaoDeEquipamentos.ConsoleApp.ModuloEquipamento;

namespace GestaoDeEquipamentos.ConsoleApp.ModuloFabricante
{
    class RepositorioFabricante
    {
        public Fabricante[] fabricante = new Fabricante[100];
        public int contadorFabricantes = 0;

        public void CadastrarFabricante(Fabricante novoFabricante)
        {
            novoFabricante.Id = GeradorIds.GerarIdFabricante();

            fabricante[contadorFabricantes++] = novoFabricante;
        }

        public bool EditarFabricante(int idFabricante, Fabricante fabricanteEditado)
        {
            for (int i = 0; i < fabricante.Length; i++)
            {
                if (fabricante[i] == null) continue;

                else if (fabricante[i].Id == idFabricante)
                {
                    fabricante[i].NomeFabricante = fabricanteEditado.NomeFabricante;
                    fabricante[i].EmailFabricante = fabricanteEditado.EmailFabricante;
                    fabricante[i].NumeroTelefone = fabricanteEditado.NumeroTelefone;
                    

                    return true;
                }
            }

            return false;
        }

        public bool ExcluirFabricante(int idFabricante)
        {
            for (int i = 0; i < fabricante.Length; i++)
            {
                if (fabricante[i] == null) continue;

                else if (fabricante[i].Id == idFabricante)
                {
                    fabricante[i] = null;

                    return true;
                }
            }

            return false;
        }

        public Fabricante[] SelecionarFabricante()
        {
            return fabricante;
        }

        public Fabricante SelecionarFabricantePorId(int idFabricante)
        {
            for (int i = 0; i < fabricante.Length; i++)
            {
                Fabricante f = fabricante[i];

                if (f == null)
                    continue;

                else if (f.Id == idFabricante)
                    return f;
            }

            return null;
        }
    }
}
