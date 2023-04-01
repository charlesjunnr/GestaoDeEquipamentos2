namespace GestaoDeEquipamentos2 //Exercicio de uso de array list
{
    using System.Collections;
    internal class Program
    {
        static ArrayList registroDeNomesEquipamentos = new ArrayList();
        static ArrayList registroDePrecos = new ArrayList();
        static ArrayList registroNumeroSerie = new ArrayList();
        static ArrayList registroData = new ArrayList();
        static ArrayList registroFabricante = new ArrayList();
        static ArrayList registroTituloChamado = new ArrayList();
        static ArrayList registroDescricaoChamado = new ArrayList();
        static ArrayList registroEquipamentoChamado = new ArrayList();
        static ArrayList registroDataAbertura = new ArrayList();
        static ArrayList diasEmAbertoChamados = new ArrayList();

        static int numero = 0, numero2 = 0;
        static int MostrarMenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine(" -------------------------------------------------------------------------------------------");
            Console.WriteLine(" -                Júnior Soluções em Informática - Opções gerais do sistema                -");
            Console.WriteLine(" -------------------------------------------------------------------------------------------");
            Console.WriteLine(" - [1] - Inventário de Equipamentos - ");
            Console.WriteLine(" - [2] - Inventário de Chamados - ");
            Console.WriteLine(" - [3] - Sair - ");
            return Convert.ToInt32(Console.ReadLine());
        }
        static int MostrarMenuChamados()
        {
            Console.Clear();
            Console.WriteLine(" -------------------------------------------------------------------------------------------");
            Console.WriteLine(" -         Inventário de Chamados de Manuntenções Júnior - Soluções em Informática         -");
            Console.WriteLine(" -------------------------------------------------------------------------------------------");
            Console.WriteLine(" - [1] - Registrar um chamado novo - ");
            Console.WriteLine(" - [2] - Visualizar os chamados registrados - ");
            Console.WriteLine(" - [3] - Deletar um chamado registrado - ");
            Console.WriteLine(" - [4] - Editar um chamado registrado - ");
            Console.WriteLine(" - [5] - Sair - ");
            return Convert.ToInt32(Console.ReadLine());
        }
        static int MostrarMenuRegistros()
        {
            Console.Clear();
            Console.WriteLine(" -------------------------------------------------------------------------------------------");
            Console.WriteLine(" -        Inventário de Equipamentos e Manuntenções Júnior - Soluções em Informática       -");
            Console.WriteLine(" -------------------------------------------------------------------------------------------");
            Console.WriteLine(" - [1] - Registrar um equipamento novo - ");
            Console.WriteLine(" - [2] - Visualizar os equipamentos registrados - ");
            Console.WriteLine(" - [3] - Deletar um equipamento registrado - ");
            Console.WriteLine(" - [4] - Editar um equipamento registrado - ");
            Console.WriteLine(" - [5] - Sair - ");
            return Convert.ToInt32(Console.ReadLine());

        }
        static void RegistrarEquipamento()
        {
            Console.Clear();
            Console.WriteLine(" -------------------------------------------------------------------------------------------");
            Console.WriteLine(" ------------------------------- Registro de Equipamentos ---------------------------------- ");
            Console.WriteLine(" -------------------------------------------------------------------------------------------");
            string equipamentos = "";
            while (equipamentos.Count() <= 6)
            {
                Console.WriteLine(" - Digite o nome do equipamento: - ");
                equipamentos = Console.ReadLine()!;

                if (equipamentos.Count() >= 6)
                {
                    registroDeNomesEquipamentos.Add(equipamentos);
                }
                else
                {
                    Console.WriteLine("Nome inválido! Deve ser maior que 6 caracteres. Digite novamente: ");
                }
            }

            Console.WriteLine(" ---    Digite o preço do equipamento:    --- ");
            registroDePrecos.Add(Console.ReadLine());
            Console.WriteLine(" ---    Digite o número de série do equipamento:    --- ");
            registroNumeroSerie.Add(Console.ReadLine());
            Console.WriteLine(" ---    Digite a data de aquisição do equipamento:    --- ");
            registroData.Add(Console.ReadLine());
            Console.WriteLine(" ---    Digite o fabricante do equipamento:    --- ");
            registroFabricante.Add(Console.ReadLine());
        }
        static void RegistrarChamados()
        {
            Console.Clear();
            Console.WriteLine(" -------------------------------------------------------------------------------------------");
            Console.WriteLine("                                  Registro de Chamados                                      ");
            Console.WriteLine(" -------------------------------------------------------------------------------------------");
            string tituloChamado = "";
            while (tituloChamado.Count() <= 6)
            {
                Console.WriteLine(" - Digite o título do chamado: - ");
                tituloChamado = Console.ReadLine()!;

                if (tituloChamado.Count() >= 6)
                {
                    registroTituloChamado.Add(tituloChamado);
                }
                else
                {
                    Console.WriteLine("Nome inválido! Deve ser maior que 6 caracteres. Digite novamente: ");
                }
            }

            Console.WriteLine(" ---    Digite o que ocorreu com o equipamento:    --- ");
            registroDescricaoChamado.Add(Console.ReadLine());
            Console.WriteLine(" ---    Digite o nome do equipamento:    --- ");
            registroEquipamentoChamado.Add(Console.ReadLine());
            Console.WriteLine(" ---    Digite a data de abertura chamado:    --- ");
            registroDataAbertura.Add(Console.ReadLine());
            
        }
        static void DeletarEquipamento()
        {
            Console.WriteLine(" - Digite o número do equipamento que deseja excluir: - ");
            int numeroExcluir = Convert.ToInt32(Console.ReadLine());
            numeroExcluir -= 1;

            registroDeNomesEquipamentos.RemoveAt(numeroExcluir);
            registroDePrecos.RemoveAt(numeroExcluir);
            registroNumeroSerie.RemoveAt(numeroExcluir);
            registroData.RemoveAt(numeroExcluir);
            registroFabricante.RemoveAt(numeroExcluir);
            Console.WriteLine($"- Equipamento excluído com sucesso! -");
        }
        static void DeletarChamados()
        {
            Console.WriteLine(" - Digite o número do chamado que deseja excluir: - ");
            int numeroExcluir = Convert.ToInt32(Console.ReadLine());
            numeroExcluir -= 1;

            registroTituloChamado.RemoveAt(numeroExcluir);
            registroDescricaoChamado.RemoveAt(numeroExcluir);
            registroNumeroSerie.RemoveAt(numeroExcluir);
            registroEquipamentoChamado.RemoveAt(numeroExcluir);
            registroDataAbertura.RemoveAt(numeroExcluir);
            Console.WriteLine($"- Chamado excluído com sucesso! -");
        }
        static void EditarEquipamento()
        {
            Console.WriteLine(" - Digite o número do equipamento que deseja editar: - ");
            int numeroEditar = Convert.ToInt32(Console.ReadLine());
            numeroEditar -= 1;
            Console.WriteLine(" - Digite o nome do equipamento: - ");
            registroDeNomesEquipamentos[numeroEditar] = Console.ReadLine();
            Console.WriteLine(" - Digite o preço do equipamento: - ");
            registroDePrecos[numeroEditar] = Console.ReadLine();
            Console.WriteLine(" - Digite o número de série do equipamento: - ");
            registroNumeroSerie[numeroEditar] = Console.ReadLine();
            Console.WriteLine(" - Digite a data de aquisição do equipamento: - ");
            registroData[numeroEditar] = Console.ReadLine();
            Console.WriteLine(" - Digite o fabricante do equipamento:  - ");
            registroFabricante[numeroEditar] = Console.ReadLine();
            Console.WriteLine($"- Equipamento editado com sucesso! -");
        }
        static void EditarChamados()
        {
            Console.WriteLine(" - Digite o número do chamado que deseja editar: - ");
            int numeroEditar = Convert.ToInt32(Console.ReadLine());
            numeroEditar -= 1;

            string tituloChamado = "";
            while (tituloChamado.Count() <= 6)
            {
                Console.WriteLine(" - Digite o título do chamado: - ");
                tituloChamado = Console.ReadLine()!;

                if (tituloChamado.Count() >= 6)
                {
                    registroTituloChamado[numeroEditar] = tituloChamado; ;
                }
                else
                {
                    Console.WriteLine("Nome inválido! Deve ser maior que 6 caracteres. Digite novamente: ");
                }
            }
            Console.WriteLine(" - Digite o que ocorreu com o equipamento: - ");
            registroDescricaoChamado[numeroEditar] = Console.ReadLine();

            Console.WriteLine(" - Digite o nome do equipamento: - ");
            registroEquipamentoChamado[numeroEditar] = Console.ReadLine();

            Console.WriteLine(" - Digite a data de abertura chamado: - ");
            registroDataAbertura[numeroEditar] = Console.ReadLine();
        }
        static void VisualizarEquipamento()
        {
            numero = 0;
            Console.WriteLine(" --------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($" Número \t Nome do equipamento \t\t Preço \t Número de Série \t Data de Aquisição \t Fabricante ");
            Console.WriteLine(" --------------------------------------------------------------------------------------------------------------------------");
            foreach (string value in registroDeNomesEquipamentos)
            {

                Console.WriteLine($" {numero + 1} \t\t {registroDeNomesEquipamentos[numero]} \t\t R${registroDePrecos[numero]} \t {registroNumeroSerie[numero]} \t\t\t {registroData[numero]} \t\t {registroFabricante[numero]} ");
                Console.WriteLine(" --------------------------------------------------------------------------------------------------------------------------");
                numero++;
            }
            Console.ReadLine();
        }
        static void VisualizarChamados()
        {

            numero = 0;

            for (int i = 0; i < registroDataAbertura.Count; i++) 
            {
                DateTime dataChamado = Convert.ToDateTime(registroDataAbertura[i]);
                diasEmAbertoChamados.Add(dataChamado);
                diasEmAbertoChamados[i] = (Convert.ToInt32(DateTime.Now.Subtract(dataChamado).TotalDays));
            }

            Console.WriteLine(" -----------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"  Número        Título                                  Descrição Equipamento                              Data de abertura       Dias em aberto  ");
            Console.WriteLine(" -----------------------------------------------------------------------------------------------------------------------------------------------------");
            
            for(int j = 0; j < registroDescricaoChamado.Count; j++)
            
            {
                
                Console.WriteLine($" {j + 1} \t {registroDescricaoChamado[j]} \t {registroEquipamentoChamado[j]}  \t\t\t            {registroDataAbertura[j]}  \t\t\t{diasEmAbertoChamados[j]} ");
                Console.WriteLine(" -----------------------------------------------------------------------------------------------------------------------------------------------------");
                
            }
            Console.ReadLine();

        }

        static void Main(string[] args)
        {

            bool ehContinuar = true;
            
            registroDeNomesEquipamentos.Add("Teclado DragonForce");
            registroDeNomesEquipamentos.Add("MouseGPRO HERO");
            registroDePrecos.Add("300");
            registroDePrecos.Add("250");
            registroNumeroSerie.Add("1294");
            registroNumeroSerie.Add("1674");
            registroData.Add("03/02/2020");
            registroData.Add("05/12/2022");
            registroFabricante.Add("Lenovo");
            registroFabricante.Add("Logitech");

            registroTituloChamado.Add("Problema no Teclado ");
            registroDescricaoChamado.Add("A tecla enter do teclado não funciona.");
            registroEquipamentoChamado.Add("Teclado Dragon Force");
            registroDataAbertura.Add("10/02/2022");
            
            DateTime dataChamado = Convert.ToDateTime(registroDataAbertura[0]);
            diasEmAbertoChamados.Add(Convert.ToInt32(DateTime.Now.Subtract(dataChamado).TotalDays));

            do
            {
                int opcaoPrincipal = MostrarMenuPrincipal();
                int opcao;
                switch (opcaoPrincipal)
                {
                    case 1:
                        opcao = MostrarMenuRegistros();
                        switch (opcao)
                        {
                            case 1: RegistrarEquipamento(); break;
                            case 2: VisualizarEquipamento(); break;
                            case 3: DeletarEquipamento(); break;
                            case 4: EditarEquipamento(); break;
                            case 5: ehContinuar = false; break;
                            default: Console.WriteLine(" - Opção inválida! - "); Console.ReadLine(); continue;
                        }
                        break;
                    case 2:
                        int opcao2 = MostrarMenuChamados();
                        switch (opcao2)
                        {
                            case 1: RegistrarChamados(); break;
                            case 2: VisualizarChamados(); break;
                            case 3: DeletarChamados(); break;
                            case 4: EditarChamados(); break;
                            case 5: ehContinuar = false; break;
                            default: Console.WriteLine(" - Opção inválida! - "); Console.ReadLine(); continue;
                        }
                        break;
                    case 3: ehContinuar = false; break;
                    default: Console.WriteLine(" - Opção inválida! - "); Console.ReadLine(); continue;
                }
            } while (ehContinuar == true);
        }
    }
}
