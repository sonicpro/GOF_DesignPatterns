namespace MazeGame.Impl
{
    public class EnchantedRoom : Room
    {
        private Spell spell;

        public EnchantedRoom(int number, Spell spell) : base(number)
        {
            this.spell = spell;
        }
    }
}
