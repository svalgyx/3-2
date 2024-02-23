namespace HW3_2
{
    public sealed class Single : Array
    {
        private int Len { get; set; }
        private int[] array;
        public Single(string init, int len) : base(init)
        {
            Len = len;
            array = new int[len];
        }

        protected override void UserAr() {
            string[] inputs = Console.ReadLine().Split(' ');
            for (int i = 0; i < Len; i++)
            {
                array[i] = int.Parse(inputs[i]);
            }
        }

        protected override void RandomAr() {
            Rnd rnd = new Rnd();
            for (int i = 0; i < Len; i++)
            {
                array[i] = rnd.Next(0, 1000);
            }
        }

        public void Create()
        {
            if (base.Init)
            {
                UserAr();
            }
            else
            {
                RandomAr();
            }
        }

        public override void Write()
        {
            Console.WriteLine("Writing single array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public override double Average()
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("Counted the average value of the array: ");
            return (double)sum / (double)(Len);
        }
    }
}
