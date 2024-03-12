// 2. Array'in içərisindəki sözləri tərsinə çevirən bir alqoritm yazın

string[] sozler = { "Samir", "Root", "Admin" };

for (int j = 0; j < sozler.Length; j++)
{

    string ters = "";


    for (int i = sozler[j].Length - 1; i >= 0; i--)
    {
        ters += sozler[j][i];        
    }

    Console.WriteLine(ters);
}