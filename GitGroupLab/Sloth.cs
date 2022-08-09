namespace GitGroupLab
{
    public class Sloth : Pet
    {
        public Sloth()
        {
            Speed = 1; // This sloth moves at 1 mph.
        }
        public override void MakeHappyNoise()
        {
            Console.WriteLine("SCREEEEEAAAAACCCCHHHHHH");
        }
    }
}
