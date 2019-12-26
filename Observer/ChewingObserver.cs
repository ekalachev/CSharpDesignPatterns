using Observer;

namespace Observer
{
    internal class ChewingObserver : BaseObserver
    {
        public Reaction OnChewing(object objChewed)
        {
            if (objChewed is Sprinkler)
            {
                return Reaction.BadDog;
            }

            return Reaction.GoodGirl;
        }
    }
}