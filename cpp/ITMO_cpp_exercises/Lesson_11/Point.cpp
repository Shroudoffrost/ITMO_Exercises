#include <ostream>


using namespace std;

class Point
{
    private:
	    double x;
	    double y;
	    friend ostream& operator<< (ostream&, const Point&);
	    friend bool operator<( const Point&,  const Point&);
    public:
	    Point(double x, double y) : x(x), y(y)
        {}
        double DistanceToCenter() const
        {
		    return sqrt(x*x + y*y);
	    }

	    double DistanceTo(const Point& point) const
        {
		    return sqrt(pow(point.x - x, 2) + pow(point.y - y, 2));
	    }
};

ostream& operator<< (ostream& out, const Point& point)
{
	out << "[" << point.x <<", " << point.y << "]" <<endl;
	return out;
}

bool operator<( const Point& point1,  const Point& point2)
{
	if (point1.DistanceToCenter() < point2.DistanceToCenter()) return true;
	return false;
}