using System.Collections.Generic;
using Chuck.SilverFish;
using SilverFish.Enums;

namespace SilverFish.cards._03Adventure._001NAX.FP1
{
	class Sim_FP1_022 : SimTemplate //* voidcaller
	{
        //Deathrattle: Put a random Demon from your hand into the battlefield.
        CardDB.Card c = CardDB.Instance.getCardDataFromID(CardIdEnum.EX1_301);//felguard

        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (m.own)
            {
                List<Handmanager.Handcard> temp = new List<Handmanager.Handcard>();
                foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if ((TAG_RACE)hc.card.race == TAG_RACE.DEMON)
                    {
                        temp.Add(hc);
                    }
                }

                temp.Sort((x, y) => x.card.Attack.Value.CompareTo(y.card.Attack));

                foreach (Handmanager.Handcard mnn in temp)
                {
                    p.CallKid(mnn.card, p.ownMinions.Count, true, false);
                    p.removeCard(mnn);
                    break;
                }
            }
            else
            {
                if (p.enemyAnzCards >= 1)
                {
                    p.CallKid(c, p.enemyMinions.Count, false, false);
                }
            }
        }
	}
}