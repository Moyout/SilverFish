using System;
using System.Collections.Generic;
using System.Text;

namespace Chuck.SilverFish
{
	class Pen_NEW1_033 : PenTemplate //leokk
	{

//    andere befreundete diener haben +1 angriff.
		public override int getPlayPenalty(Playfield p, Minion m, Minion target, int choice, bool isLethal)
		{
		return 0;
		}

	}
}