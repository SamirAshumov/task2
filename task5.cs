// 5. Verilmiş integer array-in  bütün elementlərini stringə çevirib ekrana çap edin. Məsələn, {-2,3,4,-5} verilibsə, "-2 3 4 -5" çapa verilməlidir. (optional)

int[] intMassivi = { -2, 7, -13, 24, 35 };
string[] stringMassivi = new string[intMassivi.Length];


for (int i = 0; i < intMassivi.Length; i++)
{
    stringMassivi[i] = intMassivi[i] + "";
    
}

for (int k = 0; k < stringMassivi.Length; k++)
{
    Console.Write(stringMassivi[k]);
    if (k < stringMassivi.Length - 1)
    {
        Console.Write(" ");
    }
}