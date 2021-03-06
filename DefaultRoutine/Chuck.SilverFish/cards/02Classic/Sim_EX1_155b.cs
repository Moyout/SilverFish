using Chuck.SilverFish;

namespace SilverFish.cards._02Classic
{
	class Sim_EX1_155b : SimTemplate //* markofnature
	{
        //+4 Health and Taunt.

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.minionGetBuffed(target, 0, 4);
            if (!target.taunt)
            {
                target.taunt = true;
                if (target.own) p.anzOwnTaunt++;
                else p.anzEnemyTaunt++;
            }
        }
	}
}