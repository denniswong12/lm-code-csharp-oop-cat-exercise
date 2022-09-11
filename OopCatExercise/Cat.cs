namespace OopCatExercise
{
	public abstract class Cat : ICat
	{
		public bool IsAsleep { get; private set; }
		public int AverageHeight { get; private set; }
		public string Setting { get; private set; }

        protected Cat(int averageHeight, string setting)
        {
            AverageHeight = averageHeight;
            Setting = setting;
        }

        public abstract string Eat();

        public void GoToSleep()
        {
            IsAsleep = true;
        }

        public void WakeUp()
        {
            IsAsleep = false;
        }
	}
}
