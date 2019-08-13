using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_283 : SimTemplate //* C'Thun's Chosen
	{
		//Divine Shield. Battlecry: Give your C'Thun +2/+2 (wherever it is).
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
            {
                p.anzOgOwnCThunHpBonus += 2;
                p.anzOgOwnCThunAngrBonus += 2;
            }
		}
	}
}