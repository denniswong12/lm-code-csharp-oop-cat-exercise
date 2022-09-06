namespace OopCatExercise
{
	public abstract class Cat : ICat
	{
		public bool IsAsleep = false;
		public int AverageHeight;
		public string Setting;

        public void GoToSleep()
        {
            IsAsleep = true;
        }

        public void WakeUp()
        {
            IsAsleep = false;
        }

        public virtual string Eat()
        {
			return "";
        }
	}
}
