namespace ClassAdv
{
    internal class Box
    {
        private int width;
        private int height;

        public int MyProperty { get; set; }

        public int Width
        {
            get { return width; }
            set
            {
                if (value <= 0)
                {
                    width = 0;
                }
                width = value;
            }
        }

        public int Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                {
                    height = 0;
                }
                height = value;
            }
        }



        public Box(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
    }
}