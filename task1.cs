// 1. Array'dəki ən kiçik elementi tapıb ekrana yazdırın.

int[] massiv = { 45, 13, 24, 54, 65, 76, 99 };

int enKicikEded = massiv[0];

for (int i=0; i <massiv.GetLength(0); i++)
{
    if (massiv[i] < enKicikEded)
        enKicikEded = massiv[i];
      
}

Console.WriteLine("Massivin en kicik elementi : " + enKicikEded);
