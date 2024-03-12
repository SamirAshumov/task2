// 4. Verilmiş integer array-in  bütün elementlərini müsbətə çevirib yeni bir array'ə tərsinə yığın və ekrana çap edin. Məsələn, {-2,3,4,-5} verilibsə, {5,4,3,2} almalıyıq cavab olaraq.

int[] massiv = { -8, 12, -25, 33, -44, -56 };

int saygac = 0;

int[] yeniMassiv = new int [6];

for (saygac = massiv.Length - 1; saygac >= 0; saygac--)
{
    if (massiv[saygac] < 0)

    {
        massiv[saygac] = -massiv[saygac];
    }

    yeniMassiv[saygac] = massiv[saygac];

    Console.WriteLine(yeniMassiv[saygac]);

}



                        