
using GestaoDeEquipamentos.ConsoleApp.ModuloChamado;
using GestaoDeEquipamentos.ConsoleApp.ModuloEquipamento;

namespace GestaoDeEquipamentos.ConsoleApp.ModuloFabricante
{
    class TelaFabricante
    {
        public RepositorioFabricante repositorioFabricante;
        public TelaFabricante() 
        {
            repositorioFabricante = new RepositorioFabricante();
        }

        public void ExibirCabecalho()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Controle de Fabricantes");
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine();
        }

        public char ApresentarMenu()
        {
            ExibirCabecalho();

            Console.WriteLine("Escolha a operação desejada:");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1 - Cadastrar Fabricante");
            Console.WriteLine("2 - Editar Fabricante");
            Console.WriteLine("3 - Excluir Fabricante");
            Console.WriteLine("4 - Visualizar Fabricante");

            Console.WriteLine("S - Voltar");

            Console.WriteLine();

            Console.Write("Escolha uma das opções: ");
            char operacaoEscolhida = Convert.ToChar(Console.ReadLine()!);

            return operacaoEscolhida;
        }

        public void CadastrarFabricante()
        {
            ExibirCabecalho();

            Console.WriteLine("Cadastrando Fabricante...");
            Console.WriteLine("--------------------------------------------");
            Fabricante novoFabricante = ObterDadosFabricante();

            repositorioFabricante.CadastrarFabricante(novoFabricante);

            
        }

        public void EditarFabricante()
        {
            ExibirCabecalho();

            Console.WriteLine("Editando Fabricante...");
            Console.WriteLine("--------------------------------------------");

            VisualizarFabricante(false);

            Console.Write("Digite o ID do chamado que deseja editar: ");
            int idFabricante = Convert.ToInt32(Console.ReadLine());
            Fabricante novoFabricante = ObterDadosFabricante();

            bool conseguiuEditar = repositorioFabricante.EditarFabricante(idFabricante, novoFabricante);

            if (!conseguiuEditar)
            {
                Console.WriteLine("Houve um erro durante a edição de um registro...");
                return;
            }

            Console.WriteLine();
            Console.WriteLine("O fabricante foi editado com sucesso!");
        }

        public void ExcluirFabricante()
        {
            ExibirCabecalho();

            Console.WriteLine("Excluindo Fabricante...");
            Console.WriteLine("--------------------------------------------");

            VisualizarFabricante(false);

            Console.Write("Digite o ID da fabricante que deseja excluir: ");
            int idFabricante = Convert.ToInt32(Console.ReadLine());

            bool conseguiuExcluir = repositorioFabricante.ExcluirFabricante(idFabricante);

            if (!conseguiuExcluir)
            {
                Console.WriteLine("Houve um erro durante a exclusão de um registro...");
                return;
            }

            Console.WriteLine();
            Console.WriteLine("O chamado foi excluído com sucesso!");
        }

        public void VisualizarFabricante(bool exibirTitulo)
        {
            if (exibirTitulo)
            {
                ExibirCabecalho();

                Console.WriteLine("Visualizando Fabricantes...");
                Console.WriteLine("--------------------------------------------");
            }

            Console.WriteLine();

            Console.WriteLine(
                "{0, -6} | {1, -12} | {2, -15} | {3, -30}",
                "Id", "Nome do fabricante", "Email do fabricante", "Numero de telefone"
            );

            Fabricante[] fabricantesCadastrados = repositorioFabricante.SelecionarFabricante();

            for (int i = 0; i < fabricantesCadastrados.Length; i++)
            {
                Fabricante f = fabricantesCadastrados[i];

                if (f == null)
                    continue;

                
                Console.WriteLine(
                    "{0, -6} | {1, -12} | {2, -15} | {3, -30}",
                    f.Id, f.NomeFabricante, f.EmailFabricante, f.NumeroTelefone
                );
            }

        }

        

        public Fabricante ObterDadosFabricante()
        {
            Console.Write("Digite o nome da fabricante: ");
            string nomeFabricante = Console.ReadLine()!.Trim();

            Console.Write("Digite o email da fabricante: ");
            string emailFabricante = Console.ReadLine()!.Trim();

            Console.Write("Digite o telefone da fabricante: ");
            int numeroTelefone = Convert.ToInt32(Console.ReadLine()!.Trim());

            VisualizarFabricante(false);

            Fabricante fabricante = new Fabricante(nomeFabricante, emailFabricante, numeroTelefone);

            return fabricante;
        }
    }
}
