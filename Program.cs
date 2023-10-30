Console.WriteLine("---Operações com inteiros");

int intX = 2;
int intY = 5;
int intSoma = intX + intY;
int intSubtracao = intX - intY;
int intMultiplicacao = intX * intY;
int intDivisao = intX / intY;

Console.WriteLine($"{intX} + {intY} = {intSoma}");
Console.WriteLine($"{intX} - {intY} = {intSubtracao}");
Console.WriteLine($"{intX} * {intY} = {intMultiplicacao}");
Console.WriteLine($"{intX} / {intY} = {intDivisao}");

Console.WriteLine("---Literais em ponto flutuante");

double a = 1;
double b = +1;
double c = -1;
double d = 0.1;
double e = .1;
double f = 1.0;
double g = 1e0;
double h = 1d;

Console.WriteLine($"a={a}");
Console.WriteLine($"b={b}");
Console.WriteLine($"c={c}");
Console.WriteLine($"d={d}");
Console.WriteLine($"e={e}");
Console.WriteLine($"f={f}");
Console.WriteLine($"g={g}");
Console.WriteLine($"h={h}");

Console.WriteLine("--- Operações com ponto flutuante: double");

double doubleX = 2;
double doubleY = 5;
double doubleSoma = doubleX + doubleY;
double doubleSubtracao = doubleX - doubleY;
double doubleMultiplicacao = doubleX * doubleY;
double doubleDivisao = doubleX / doubleY;

Console.WriteLine($"{doubleX} + {doubleY} = {doubleSoma}");
Console.WriteLine($"{doubleX} - {doubleY} = {doubleSubtracao}");
Console.WriteLine($"{doubleX} * {doubleY} = {doubleMultiplicacao}");
Console.WriteLine($"{doubleX} / {doubleY} = {doubleDivisao}");

Console.WriteLine("--- Operações com ponto flutuante: decimal");

decimal decimalX = 2;
decimal decimalY = 5;
decimal decimalSoma = decimalX + decimalY;
decimal decimalSubtracao = decimalX - decimalY;
decimal decimalMultiplicacao = decimalX * decimalY;
decimal decimalDivisao = decimalX / decimalY;

Console.WriteLine($"{decimalX} + {decimalY} = {decimalSoma}");
Console.WriteLine($"{decimalX} - {decimalY} = {decimalSubtracao}");
Console.WriteLine($"{decimalX} * {decimalY} = {decimalMultiplicacao}");
Console.WriteLine($"{decimalX} / {decimalY} = {decimalDivisao}");

Console.WriteLine("--- Formatação de números em ponto flutuante");
Console.WriteLine($"Double {doubleDivisao} | Decimal = {decimalDivisao} -- sem formatação");
Console.WriteLine($"Double {doubleDivisao:N} | Decimal = {decimalDivisao:N} -- formato Número");
Console.WriteLine($"Double {doubleDivisao:C} | Decimal = {decimalDivisao:C} -- formato Moeda");
Console.WriteLine($"Double {doubleDivisao:C3} | Decimal = {decimalDivisao:C3} -- formato Moeda, 3 casas");
Console.WriteLine($"Double {doubleDivisao:N4} | Decimal = {decimalDivisao:N4} -- formato Número, 4 casas");
Console.WriteLine($"Double {doubleDivisao:N30} | Decimal = {decimalDivisao:N30} -- formato Número, 30 casas");

Console.WriteLine("--- Conversões double/decimal");
double doubleConversao = doubleX + Convert.ToDouble(decimalX);
decimal decimalConversao = decimalX + Convert.ToDecimal(doubleX);
Console.WriteLine($"Double {doubleConversao} | Decimal = {decimalConversao} -- conversão");

Console.WriteLine("--- Conversões com string");
double doubleString = Convert.ToDouble("5,3");
Console.WriteLine($"Double {doubleString:N4} -- conversão de string para double");
decimal decimalString = Convert.ToDecimal("5,3");
Console.WriteLine($"Decimal {decimalString:N4} -- conversão de string para decimal");

string stringDouble = doubleDivisao.ToString("N4");
Console.WriteLine($"Double {stringDouble}");
string stringDecimal = decimalDivisao.ToString("N4");
Console.WriteLine($"Decimal {stringDecimal}");

Console.WriteLine("--- Entrada via teclado");
Console.Write("Digite um número...:");

string stringDigitada = Console.ReadLine();
Console.WriteLine($"String = {stringDigitada}");
double doubleDigitado = Convert.ToDouble(stringDigitada);
Console.WriteLine($"Double = {doubleDigitado}");
decimal decimalDigitado = Convert.ToDecimal(stringDigitada);
Console.WriteLine($"Decimal = {decimalDigitado}");