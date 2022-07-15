#pragma once
#include <ostream>
using namespace std;

class Point
{
    private:
	    int x;
	    int y;
	    friend Point& operator+(const Point &, const Point &);
	    friend Point& operator+(const Point &, const int &);
	    friend ostream &operator<< (ostream &, const Point&);
    public:
	    Point()
        {}
	    Point(int x, int y) : x(x), y(y)
        {}

	    Point &operator+= (const Point &p2)
        {
		    x += p2.x;
		    y += p2.y;
		    return *this;
	    }
};

ostream &operator<< (ostream& out, const Point& point)
{
	out << "(" << point.x << ", " << point.y << ")" << endl;
	return out;
}
Point &operator+ (const Point& p1, const Point& p2)
{
	Point p_sum;
	p_sum.x = p1.x + p2.x;
	p_sum.y = p1.y + p2.y;
	return p_sum;
}

Point &operator+ (const Point &p1, const int &d)
{
	Point sumPoints;
	sumPoints.x = p1.x + d;
	sumPoints.y = p1.y + d;
	return sumPoints;
}