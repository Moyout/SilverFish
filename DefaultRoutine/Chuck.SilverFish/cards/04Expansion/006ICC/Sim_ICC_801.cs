using Chuck.SilverFish;
using SilverFish.Enums;

namespace SilverFish.cards._04Expansion._006ICC
{
    class Sim_ICC_801: SimTemplate //* Howling Commander
    {
        // Battlecry: Draw a Divine Shield minion from your deck.

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            p.drawACard(CardName.unknown, m.own);
        }
    }
}