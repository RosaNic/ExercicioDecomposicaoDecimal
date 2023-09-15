 int NumeroDigitado, 
    Centena,
    Dezena,
    Unidade;

 Console.WriteLine
    ("--- Decomposição Decimal ---");

Console.WriteLine
    ("Digite um número inteiro...: ");

NumeroDigitado = Convert.ToInt32(Console.ReadLine());

Console.WriteLine
    ($"\nO número {NumeroDigitado} possui: ");

Centena = NumeroDigitado / 100;

Dezena = (NumeroDigitado % 100) / 10;

Unidade = (NumeroDigitado % 100) % 10;

Console.WriteLine
    ($"{Unidade,10} Unidade(s)");

Console.WriteLine
    ($"{Dezena,10} Dezenas(s)");

Console.WriteLine
    ($"{Centena,10} Centena(s)");
