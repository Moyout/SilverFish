using SilverFish.Enums;

namespace Chuck.SilverFish.cards._01Basic._07Shaman
{
	class Sim_EX1_246 : SimTemplate //hex
	{
        CardDB.Card card = CardDB.Instance.getCardDataFromID(CardIdEnum.hexfrog);
//    verwandelt einen diener in einen frosch (0/1) mit spott/.

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.minionTransform(target, card);
		}

	}
}