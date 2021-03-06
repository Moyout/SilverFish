using Chuck.SilverFish;

namespace SilverFish.cards._02Classic
{
	class Sim_EX1_238 : SimTemplate //lightningbolt
	{

//    verursacht $3 schaden. überladung:/ (1)

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int dmg = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
            p.minionGetDamageOrHeal(target, dmg);
            if (ownplay) p.ueberladung++;
		}

	}
}