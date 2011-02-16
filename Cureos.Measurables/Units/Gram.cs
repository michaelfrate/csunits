namespace Cureos.Measurables.Units
{
    public sealed class Gram : GenericUnit
    {
        #region FIELDS

        public static readonly Gram Instance;

        #endregion

        #region CONSTRUCTORS

        static Gram()
        {
            Instance = new Gram();
        }

        private Gram()
            : base("g", KiloGram.Instance)
        {

        }

        #endregion
    }
}