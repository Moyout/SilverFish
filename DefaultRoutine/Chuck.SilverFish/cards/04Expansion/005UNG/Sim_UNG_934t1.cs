using Chuck.SilverFish;
using SilverFish.Enums;

namespace SilverFish.cards._04Expansion._005UNG
{
	class Sim_UNG_934t1 : SimTemplate //* Sulfuras
	{
		//Battlecry: Your Hero Power: becomes 'Deal 8 damage to a random enemy.'

        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardIdEnum.UNG_934t1);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
            p.setNewHeroPower(CardIdEnum.BRM_027p, ownplay); // DIE, INSECT!
        }
    }
}