namespace NavigationOfSoltrianius.GameCode;

public class Point(int theX, int theY)
{
    private int myX;
    private int myY;
    public Point()
    {
        this.myX = theX;
        this.myY = theY;
    }

    public int getX()
    {
        return myX;
    }

    public int getY()
    {
        return getY;
    }

    public static Point Add(Point theFirst, Point theSecond)
    {
        Point result = (theFirst.myX + theSecond.myX) + (theFirst.myY + theSecond.myY);
        return result;
    }
}