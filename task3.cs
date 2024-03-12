// 3. Array'in içərisindəki sözlərin sırasını tərsinə çevirən bir alqoritm yazın.

string[] sozler = { "Birinci soz", "Ikinci soz", "Ucuncu soz" };

for (int i = sozler.Length - 1; i >= 0; i--)
{
    Console.WriteLine(sozler[i]);
}