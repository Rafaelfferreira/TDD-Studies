using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingKataProject
{
    public class Game
    {
        private int[] rolls = new int[21]; //criando um array que armazene os rolls
        private int currentRoll = 0; //ponteiro que mostra em qual roll esta

        public void roll(int pins)
        {
            rolls[currentRoll] = pins;
            currentRoll++;
        }

        public int scoreGame()
        {
            int score = 0;
            int frameIndex = 0; //current roll
            for (int frame = 0; frame < 10; frame++)
            {
                if (isStrike(frameIndex))
                {
                    score += 10 + strikeBonus(frameIndex);
                    frameIndex++;
                }
                else if (isSpare(frameIndex)) //thats a spare
                {
                    score += rolls[frameIndex] + rolls[frameIndex + 1] + rolls[frameIndex + 2];
                    frameIndex += 2;
                }
                else
                {
                    score += rolls[frameIndex] + rolls[frameIndex + 1];
                    frameIndex += 2;
                }
            }
            return score;
        }

        public bool isSpare(int frameIndex)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1] == 10;
        }

        public bool isStrike(int frameIndex)
        {
            return rolls[frameIndex] == 10;
        }

        public int strikeBonus(int frameIndex)
        {
            return rolls[frameIndex + 1] + rolls[frameIndex + 2];
        }
    }
}
