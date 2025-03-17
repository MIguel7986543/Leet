Console.Clear();
String nomeDigitado;
String nomeLeet; 

Console.WriteLine();

nomeDigitado = Console.ReadLine()!;
nomeLeet = nomeDigitado.Replace("A","4").
                        Replace("E","3");

Console.WriteLine($" {nomeLeet}!");