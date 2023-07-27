using System;
public class Program {
    static void Main(string[] args)
    {
        /*
        int[] n = new int[3];
        Console.Write("Digite o primeiro número: ");
        n[0] = Convert.ToInt32( Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        n[1] = Convert.ToInt32(Console.ReadLine());
        n[2] = (n[0] + n[1]) / 2;
        Console.WriteLine("A média entre eles é = "+n[2]);*/
        List<string> listaDEnomes = new List<string>();
        listaDEnomes.Add("Iury");
        listaDEnomes.Add("Alice");
        listaDEnomes.Add("bebbel");
        listaDEnomes.Add("Iury");
        listaDEnomes.Add("abel");//adiciona tudo
        listaDEnomes.Insert(0,"Saula");//ele introduz um componente na posição que vc quer
        //listaDEnomes.Sort();//Organiza a lista em ordem alfabética
        //listaDEnomes.Reverse();//lista organizada ao contrário ao reverso.
        //listaDEnomes.Remove("abel");//remove o iten descrevido
        //listaDEnomes.RemoveAt(0);//Remove a posição referida.
        //listaDEnomes.RemoveRange(0, 2);//Remove em um intervalo de elemnetos ituados desntro da lista
        //listaDEnomes.Clear();//Remoe todos os elementos de uma lista.
        //listaDEnomes.Count();//Capacidade e tamanho da minha lista.
        //listaDEnomes.Contains("bebbel");//vê se determinado elemento está presente na lista.
        //listaDEnomes.IndexOf("abel");//mostra a posição do elemnto na lista
        List<string> nome = new List<string>();
        nome.Add("Iury");
        nome.Add("Ezequiel");
        nome.Add("Naruto");
        listaDEnomes.AddRange(nome);//adiciona uma lista em outra
        listaDEnomes.InsertRange(0, nome);//adiciona uma lista em outra na posição que vc quiser
        foreach (string str in listaDEnomes)
        {
            Console.WriteLine(str);//repassa e percorre o array
        }


    }
}