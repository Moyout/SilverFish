using Chuck.SilverFish;

namespace SilverFish.cards._02Classic
{
	class Sim_EX1_145 : SimTemplate //preparation
	{

//    der nächste zauber, den ihr in diesem zug wirkt, kostet (3) weniger.
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (ownplay)
            {
                p.playedPreparation = true;
            }
		}

	}
}