using System; 

class BuscaLinear
{
    static void Main()
    {
        int[] numeros = new int[5];

        Console.WriteLine("Digite cinco numeros inteiros: ");

        //loop for para iterar 5 vezes 
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Digite o numero {i+1}: ");
            string input = Console.ReadLine();
        }

        Console.Write("\n Digite o número que deseja buscar: ");
        string inputChave = Console.ReadLine();

        int indiceEncontrado = LinearSearch(numeros,inputChave);

        if (indiceEncontrado != -1)
        {
            Console.WriteLine($"\n O número {inputChave} foi encontrado no índice: {indiceEncontrado}");
        }
        else
        {
            Console.WriteLine($"\n O número {inputChave} não foi encontrado no vetor.");
        }
        
    }

    static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i< arr.Length; i++)
        {
            if (arr[i] == target)
            {
                return i;
            }
        }
        return -1;
    }
}