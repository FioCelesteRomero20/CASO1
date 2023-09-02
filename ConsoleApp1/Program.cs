// See https://aka.ms/new-console-template for more information

Console.WriteLine("Ingrese el numero de personas: ");
int NP = int.Parse(Console.ReadLine());
float TOT = 0f;
if (NP > 300)
{
    TOT = NP * 75;
    
}
else
{
    if (NP > 200)
    {
        TOT = NP * 85;
        
    }
    else
    {
        TOT = NP * 95;
        
    }
}
Console.WriteLine("El total es: " + TOT);
