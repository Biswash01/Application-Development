namespace Exercise8
{
    internal struct Point2D
    {
        internal float x; 
        internal float y;

         static float CalculateDistance(Point2D p1, Point2D p2)
        {
            float distance= (float)Math.Sqrt(Math.Pow((p1.x - p2.x),2)+Math.Pow(p1.y-p2.y,2));
            return distance;
        }
        static void Main(string[] args)
        {
            Point2D p1 = new Point2D();
            p1.x = 4.2f;
            p1.y = 2.1f;

            Point2D p2= new Point2D();
            p2.x = 3.1f;
            p2.y = 1.5f;

            float distance=CalculateDistance(p1, p2);
            Console.WriteLine("The distance between p1 and p2 is: "+distance);
        }
    }
}