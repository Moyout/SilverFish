namespace Chuck.SilverFish.cards._02Classic._03Mage
{
    class Sim_CS2_031 : SimTemplate //* Ice Lance
	{
        //Freeze a character. If it was already Frozen, deal $4 damage instead.

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4);
            
            if (target.frozen)
            {
                p.minionGetDamageOrHeal(target, dmg);
            }
            else
            {
                p.minionGetFrozen(target);
            }
		}
	}
}