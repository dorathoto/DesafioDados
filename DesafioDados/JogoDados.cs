﻿using DesafioDados.Model;
using Konsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDados
{
    public class JogoDados
    {
        private readonly Random _random;
        internal List<Placar> _placar;

        internal int QtdJogar { get; set; }
        internal int StepProgressBar { get; set; } = 100;

        public JogoDados()
        {
            _random = new Random();
            _placar = new List<Placar>
            {
                new Placar { Face = "1", Qtd = 0, Porcentagem = 0 },
                new Placar { Face = "2", Qtd = 0, Porcentagem = 0 },
                new Placar { Face = "3", Qtd = 0, Porcentagem = 0 },
                new Placar { Face = "4", Qtd = 0, Porcentagem = 0 },
                new Placar { Face = "5", Qtd = 0, Porcentagem = 0 },
                new Placar { Face = "6", Qtd = 0, Porcentagem = 0 }
            };
        }

        internal void Jogar(ProgressBar pb)
        {
            var count = 0;
            for (int i = 0; i < QtdJogar; i++)
            {
                count++;
                if (count == StepProgressBar)
                {
                    pb.Refresh(i, $"Jogada {i}");
                    count = 0;
                }
                var jogada = _random.Next(1, 7);
                var placar = _placar.FirstOrDefault(x => x.Face == jogada.ToString());
                placar.Qtd++;
            }

            // CalcularPorcentagem()
        }

        //sempre será o número 6 com peso
        internal void JogarComPeso(ProgressBar pb, double porcentagemPeso)
        {
            var count = 0;
            for (int i = 0; i < QtdJogar; i++)
            {
                count++;
                if (count == StepProgressBar)
                {
                    pb.Refresh(i, $"Jogada {i}");
                    count = 0;
                }
                var chance = _random.Next(0, 101); 
                var jogada = 0; 
                if (chance <= porcentagemPeso)  
                {
                    jogada = 6;
                }
                else // senão
                {
                    jogada = _random.Next(1, 6);
                }
                var placar = _placar.FirstOrDefault(x => x.Face == jogada.ToString());
                placar.Qtd++;
            }
        }

        internal void CalcularPorcentagem()
        {
            foreach (var item in _placar)
            {
                item.Porcentagem = ((decimal)item.Qtd / (decimal)QtdJogar) * 100;
            }
        }
    }
}
