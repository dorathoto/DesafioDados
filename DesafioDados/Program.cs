// C# 10
using DesafioDados;
using Konsole;
void Wait() => Console.ReadKey(true); //não fecha a tela
const int leftQtd = 1000;
const int rightQtd = 30000000;
var janelaSemPeso = MontaTela.MontarCaixaJanela("Sem PESO", corBackground: ConsoleColor.Blue);


#region Jogada100k
var left = janelaSemPeso.SplitLeft("1k");
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

var right = janelaSemPeso.SplitRight("30M");
var pbR = new ProgressBar(right, rightQtd);
var objDado1M = new JogoDados
{
    QtdJogar = rightQtd,
    StepProgressBar = (rightQtd / 50)
};
objDado1M.Jogar(pbR);
objDado1M.CalcularPorcentagem();
MontaTela.EscreverNaTelaPlacar(right, objDado1M._placar);

#endregion


var janelaComPeso = MontaTela.MontarCaixaJanela("Com PESO", corBackground: ConsoleColor.DarkRed);

#region Jogada100k
var leftComPeso = janelaComPeso.SplitLeft("1k");
var pbLComPeso = new ProgressBar(leftComPeso, leftQtd);
var objDado100kComPeso = new JogoDados
{
    QtdJogar = leftQtd,
    StepProgressBar = (leftQtd / 50)
};
objDado100kComPeso.JogarComPeso(pbLComPeso, 30);
objDado100kComPeso.CalcularPorcentagem();

MontaTela.EscreverNaTelaPlacar(leftComPeso, objDado100kComPeso._placar);
#endregion

#region Jogada100k
var rightComPeso = janelaComPeso.SplitRight("30M");
var pbRComPeso = new ProgressBar(rightComPeso, rightQtd);
var objDado1MComPeso = new JogoDados
{
    QtdJogar = rightQtd,
    StepProgressBar = (rightQtd / 50)
};
objDado1MComPeso.JogarComPeso(pbRComPeso, 30);
objDado1MComPeso.CalcularPorcentagem();

MontaTela.EscreverNaTelaPlacar(rightComPeso, objDado1MComPeso._placar);
#endregion

