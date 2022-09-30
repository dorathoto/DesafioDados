// C# 10
using DesafioDados;
using Konsole;
void Wait() => Console.ReadKey(true); //não fecha a tela
int leftQtd = 100000;
int rightQtd = 10000;
var janelaSemPeso = MontaTela.MontarCaixaJanela("Sem PESO", corBackground: ConsoleColor.Blue);
#region Jogada100k
var left = janelaSemPeso.SplitLeft("100k");
var pbL = new ProgressBar(left, leftQtd);
var objDado100k = new JogoDados
{
    QtdJogar = leftQtd,
    StepProgressBar = (leftQtd / 50)
};
objDado100k.Jogar(pbL);
objDado100k.CalcularPorcentagem();

MontaTela.EscreverNaTelaPlacar(left, objDado100k._placar);
#endregion

#region Jogada1M

var right = janelaSemPeso.SplitRight("1M");
var pbR = new ProgressBar(right, rightQtd);
var objDado1M = new JogoDados
{
    QtdJogar = rightQtd,
    StepProgressBar = (rightQtd / 50)
};
objDado1M.Jogar(pbL);
objDado1M.CalcularPorcentagem();
MontaTela.EscreverNaTelaPlacar(right, objDado1M._placar);

#endregion


var janelaComPeso = MontaTela.MontarCaixaJanela("Com PESO", corBackground: ConsoleColor.DarkRed);

#region Jogada100k
var leftComPeso = janelaComPeso.SplitLeft("100k");
var pbLComPeso = new ProgressBar(left, leftQtd);
var objDado100kComPeso = new JogoDados
{
    QtdJogar = leftQtd,
    StepProgressBar = (leftQtd / 50)
};
objDado100kComPeso.Jogar(pbL);
objDado100kComPeso.CalcularPorcentagem();

MontaTela.EscreverNaTelaPlacar(left, objDado100kComPeso._placar);
#endregion

