/*Uma empresa vende o mesmo produto para quatro diferentes estados. Cada estado possui uma taxa diferente de imposto sobre o produto
(MG 7%; SP 12 %; RJ 15 %; MS 8 %). Faça um programa em que o usuário entre com o valor (double) e o estado (string) destino do 
produto e o programa retorne o preço final do produto acrescido do imposto do estado em que ele será vendido. Se o estado digitado
não for válido, mostrar uma mensagem de erro;*/

const double mg = 7;
const double sp = 12;
const double rj = 15;
const double ms = 8;

Console.WriteLine("Digite o valor do produto");
double valorProduto = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a sigla do estado:");
string destino = Console.ReadLine();

string toString(string estado) { 
    return "O valor do produto para o estado do " + estado + " é: R$";} 

double calculoImposto(double produto, double estado) { 
    return Math.Round(((produto * (estado/100)) + produto), 2);
}

if (destino.ToLower().Equals("mg") || destino.ToLower().Equals("minas gerais"))
{
    Console.WriteLine(toString("mg") + calculoImposto(valorProduto, mg));
}
else if (destino.ToLower().Equals("sp") || destino.ToLower().Equals("sao paulo") || destino.ToLower().Equals("são paulo"))
{
    Console.WriteLine(toString("SP") + calculoImposto(valorProduto, sp));
}
else if (destino.ToLower().Equals("rj") || destino.ToLower().Equals("rio de janeiro"))
{
    Console.WriteLine(toString("RJ") + calculoImposto(valorProduto, rj));
}
else if (destino.ToLower().Equals("ms") || destino.ToLower().Equals("mato grosso do sul") || destino.ToLower().Equals("mato grosso"))
{   
    Console.WriteLine(toString("MS") + calculoImposto(valorProduto, ms));
}
else { Console.WriteLine("Usuário digitou um estado inválido!");}




