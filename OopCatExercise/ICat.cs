namespace OopCatExercise
{
	public interface ICat
	{
        public void GoToSleep();
        public void WakeUp();
        public string Eat();

        public bool IsAsleep { get; }
        public int AverageHeight { get; }
        public string Setting { get; }
    }
}
