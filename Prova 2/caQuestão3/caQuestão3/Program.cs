using caQuestão3;


ventilador _ventilador = new ventilador();

pilha ordem = new pilha();

ordem.push(0);
ordem.push(1);
ordem.push(2);
ordem.push(3);

string velho = Console.ReadLine("Qual a peça quebrada?");
string novo = Console.ReadLine("Qual a peça nova?");

int n = _ventilador.atribuipeça(velho);
int m = _ventilador.atribuipeça(novo);

ordem.pop(n);

for (int i = 0; i < m; i++)
{
    ordem.push(i);
}

