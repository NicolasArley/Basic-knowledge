namespace Business.Triangles
{
    public class Triangle
    {
        public Triangle()
        {
            side = 3;
            Base = 1;
            height = 1;
        }

        public Triangle(int numside)
        {
            side = numside;
            Base = 1;
            height = 1;
        }

        public string GetTriangle()
        {
            return "Information about the triangle: " + "Number of equal sides: " + side + " Number of bases: " + Base + " Number of hieghts: " + height;
        }

        private int side;

        private int Base;

        private int height;

    }

}
