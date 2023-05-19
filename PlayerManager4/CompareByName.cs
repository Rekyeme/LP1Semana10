using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManager4
{
    public class CompareByName: IComparer<Player>
    {
        private readonly bool ascendente;

        public CompareByName(bool ascendente)
        {
            this.ascendente = ascendente;
        }

        public Comparison(Player x, Player y)
        {
            int final = string.Compare(x.Name, y.Name);
            if (!ascendente)
                final *= -1;

            return final;
        }
    }
}