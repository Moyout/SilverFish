using Chuck.SilverFish;
using SilverFish.Enums;

namespace SilverFish.cards._02Classic
{
	class Sim_EX1_160a : SimTemplate //* summonapanther
	{
        //Summon a 3/2 Panther.
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardIdEnum.EX1_160t);//panther

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            p.CallKid(kid, pos, ownplay, false);
		}
	}
}