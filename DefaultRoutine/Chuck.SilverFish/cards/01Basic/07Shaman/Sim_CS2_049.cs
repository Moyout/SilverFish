using Chuck.SilverFish;
using SilverFish.Enums;

namespace SilverFish.cards._01Basic._07Shaman
{
    /// <summary>
    /// Totemic Call
    /// ͼ���ٻ�
    /// </summary>
    public class Sim_CS2_049 : SimTemplate
    {
        //Hero Power: Summon a random Totem.

        CardDB.Card searing = CardDB.Instance.getCardDataFromID(CardIdEnum.CS2_050);
        CardDB.Card healing = CardDB.Instance.getCardDataFromID(CardIdEnum.NEW1_009);
        CardDB.Card wrathofair = CardDB.Instance.getCardDataFromID(CardIdEnum.CS2_052);
        CardDB.Card stoneclaw = CardDB.Instance.getCardDataFromID(CardIdEnum.CS2_051);

        /// <summary>
        /// "LocStringEnUs": "<b>Hero Power</b>\nSummon a random Totem.",
        /// "LocStringZhCn": "<b>Ӣ�ۼ���</b>\n����ٻ�һ��\nͼ�ڡ�",
        /// </summary>
        /// <param name="p"></param>
        /// <param name="ownplay"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            CardDB.Card kid;
            int otherTotems = 0;
            bool wrath = false;
            foreach (Minion m in (ownplay) ? p.ownMinions : p.enemyMinions)
            {
                switch (m.name)
                {
                    case CardName.searingtotem: otherTotems++; continue;
                    case CardName.stoneclawtotem: otherTotems++; continue;
                    case CardName.healingtotem: otherTotems++; continue;
                    case CardName.wrathofairtotem: wrath = true; continue;
                }
            }
            if (p.isLethalCheck)
            {
                if (otherTotems == 3 && !wrath) kid = wrathofair;
                else kid = healing;
            }
            else
            {
                if (!wrath)
                {
                    kid = wrathofair;
                }
                else
                {
                    kid = searing;
                }

                if (p.ownHeroHasDirectLethal())
                {
                    kid = stoneclaw;
                }
            }
            p.CallKid(kid, pos, ownplay, false);
        }
    }

    public class Sim_CS2_049_H1 : Sim_CS2_049
    {

    }

    public class Sim_CS2_049_H2 : Sim_CS2_049
    {

    }

    public class Sim_CS2_049_H3 : Sim_CS2_049
    {

    }

}