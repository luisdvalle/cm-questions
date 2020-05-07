namespace CMSolution.Question3
{
    public class CmAreaUtility
    {
        public static double GetArea(int input1, int input2, int input3)
        {
            if (input1 < 0 || input2 < 0 || input3 < 0 || 
                !IsValidTriangle(input1, input2, input3))
            {
                throw new InvalidTriangleException("Inputs cannot form a valid triangle");
            }

            var triangle = new Triangle(input1, input2, input3);

            return triangle.Area();
        }

        private static bool IsValidTriangle(int side1, int side2, int side3)
        {
            if (side1 + side2 <= side3 || 
                side1 + side3 <= side2 || 
                side2 + side3 <= side1)
            {
                return false;
            }

            return true;
        }
    }
}
