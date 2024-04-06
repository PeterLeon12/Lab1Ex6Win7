//Ex 6
//Scrieti un program care va verifica daca un numar citit de la tastatura este par sau
//impar
// In cazul in care numarul este par, programul va afisa “par” iar in caz contrar, “impar”.


Console.WriteLine("Scrieti un numar");
int numar = int.Parse(Console.ReadLine());

if (numar % 2 == 0)
{
    Console.WriteLine("Numarul dv este par");
}
else
{
    Console.WriteLine("Numarul dv. est imnpar");
}
