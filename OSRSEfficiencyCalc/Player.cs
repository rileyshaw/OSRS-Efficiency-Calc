using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSRSEfficiencyCalc
{
    public class Player
    {
        String name;
        public int[] levels = new int[23];
        public int[] curxp = new int[23];
        public int[] xpremaining = new int[23];


        public Player()
        {
            name = "";
            for (int i = 0; i < 23; i++)
            {
                levels[i] = 1;
                curxp[i] = 0;
                xpremaining[i] = 83;
            }
        }
        public Player(String name, String response)
        {
            name = response.Replace("_", " ");
            char[] delimiterChars = { ',', '\n' };
            string[] words = response.Split(delimiterChars);
            for (int i = 0; i < 23; i++)
            {
                levels[i] = int.Parse(words[((i + 1) * 3) + 1]);
                curxp[i] = int.Parse(words[((i + 1) * 3) + 2]);
                xpremaining[i] = getXpToLevel(curxp[i]);
            }
        }
        public int getXpToLevel(int curXp)
        {
            int lvl = 1;
            while (Definitions.xpreqs[lvl] < curXp)
            {
                lvl++;
                if (lvl == 99)
                {
                    return 0;
                }
            }
            return Definitions.xpreqs[lvl] - curXp;
        }

    }

}
