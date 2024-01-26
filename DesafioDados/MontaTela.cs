using Konsole;
using static System.ConsoleColor;


namespace DesafioDados
{
    public class MontaTela
    {
        public static IConsole MontarCaixaJanela(string nome, System.ConsoleColor corBackground)
        {
            var janela = Window.OpenBox(nome, 120, 12, new BoxStyle()
            {
                ThickNess = LineThickNess.Double,
                Title = new Colors(White, Blue),
            });
            janela.BackgroundColor = corBackground;
            return janela;
        }
        
        public static void EscreverNaTelaPlacar(IConsole con, List<DesafioDados.Model.Placar> retorno)
        {
            foreach (var item in retorno)
            {
                Tick(con, item.Face, item.Qtd, item.Porcentagem);
            }
        }


        static void Tick(IConsole con, string face, int qtd, decimal porcentagem)
        {
            con.Write(White, $"Face {face}    ");
            con.Write(Black, $" Qtd.: {qtd}    ");
            con.Write(Yellow, $"Porc.: {porcentagem}%");
            con.WriteLine("");
        }


    }
}
