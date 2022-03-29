using System;



namespace elevadorProject.View
{
    internal class ElevadorView
    {

        //Exibição Meno de opções
        public void Projeto(Elevador elevador)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine($@"Quantidade de andares do edifício: { elevador.TotalAndares } { Environment.NewLine }
                    Capacidade máxima permitida no elevador ao subir ou descer: { (elevador.TotalCapacidade <= 1 ? elevador.TotalCapacidade + " pessoa" : elevador.TotalCapacidade + " pessoas") } { Environment.NewLine }
                    Quantidade atual de pessoa (as) no elevador: { (elevador.PeopleTotal <= 1 ? elevador.PeopleTotal + " pessoa" : elevador.PeopleTotal + " pessoas") } { Environment.NewLine }
                    Andar Atual: { (elevador.AtualAndar == 0 ? "Térreo" : elevador.AtualAndar + "º") } { Environment.NewLine } 
                    Escolha e informe uma das opções do elevador: { Environment.NewLine }
                    1 - Entrar no elevador
                    2 - Sair do elevador
                    3 - Subir um andar 
                    4 - Descer um andar 
                    5 - Finalizar o simulador
                ");

                var option = Console.ReadLine();
                Console.Clear();


                switch (option)
                {
                    case "1": elevador.Entrar(); break;
                    case "2": elevador.Sair(); break;
                    case "3": elevador.Subir(); break;
                    case "4": elevador.Descer(); break;
                    case "5": continuar = false; break;
                    default:
                        Console.WriteLine("Opção não é válida, informe apenas os números das opções."); break;
                }
            }
            //while (continuar); //enquanto for verdadeiro faça.         
        }

    }
}
   