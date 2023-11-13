// See https://aka.ms/new-console-template for more information
using caQuestão1;

string input = Console.ReadLine();

pilha parentese = new pilha();
bool verifica = true;

foreach(char c in input)
{
    if (c == '(')
    {
        parentese.push(c);
    }
    else if (c == ')' ) 
    {
        if (parentese.estaVazia())
        {
            verifica = false;
        }
        else
        {
            parentese.pop();
        }
    }
}
if (parentese.estaVazia())
{
    verifica = true;
}
else
{
    verifica &= false;
}

if (verifica)
{
    Console.WriteLine("A expressão é valida");
}
else
{
    Console.WriteLine("A expressao não é valida");
}