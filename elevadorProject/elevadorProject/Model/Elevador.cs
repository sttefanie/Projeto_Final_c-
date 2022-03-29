using System;


namespace elevadorProject
{
    internal class Elevador
    {
        //responsavel pelo andar atual
        public int AtualAndar;
        //AndarAtual

        //responsavel por total de pessoas no elevador
        public int PeopleTotal;
        //TotalPessoas

        //responsavel pelo total andares
        public readonly int TotalAndares;

        //responsavel pelo total capacidade max
        public readonly int TotalCapacidade;


        //Iniciar as váriaveis
        public Elevador(int capacidade, int andares)
        {
            TotalAndares = andares;
            TotalCapacidade = capacidade;

        }

       //Adicionar pessoas

        public void Entrar()
        {
            if (PeopleTotal < TotalCapacidade)
            {
                PeopleTotal++;
                string exibaQuantidades = PeopleTotal == 1 ? $"{PeopleTotal} Entrou no elevador." : $"{PeopleTotal} Pessoas entraram no elevador.";
                Console.WriteLine(exibaQuantidades);
            }
            else
            {
                Console.WriteLine($"Infelizmente não é possivel ultrapassar a capacidade de {TotalCapacidade} de pessoas no elevador.");
            }
        }


        public void Sair()
        {
           if(PeopleTotal > 0)
           {
           PeopleTotal--;
                Console.WriteLine("Uma pessoa saiu do elevador.");
           }
            else
            {
               Console.WriteLine("O elevador está vazio.");
            }
        }
        


        //Responsavel por subir nos andares 
        public void Subir()
        {
            if(AtualAndar < TotalAndares)
            {
                AtualAndar++;
                string exibaAndarAtual = AtualAndar != 0 ? $"O elevador chegou ao {AtualAndar}ª andar" : $"Descendo para {AtualAndar}ª andar.";
                Console.WriteLine(exibaAndarAtual);
            }
            else
            {
                Console.WriteLine($"O  elevador está no {AtualAndar}ª que é o último");
            }
        }

        public void Descer()
        {
            if(AtualAndar > 0)
            {
                AtualAndar--;
                string exibaAtualAndar = AtualAndar == 0 ? $"O elevador chegou ao térreo" : $"Descendo para o {AtualAndar}ª andar.";
                    Console.WriteLine(exibaAtualAndar);
            }
            else
            {
                Console.WriteLine("Elevador está no térreo!");
            }
        }

    }
}
