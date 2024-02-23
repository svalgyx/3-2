namespace HW3_2
{
    public abstract class Array
    {
        protected bool Init { get; set; }

        public abstract void Write();

        public abstract double Average();

        protected abstract void Randoms();

        protected abstract void Users();

        public Array(string init)
        {
            Init = true;
            if (init == "no")
            {
                Init = false;
            }
        }
    }
}
