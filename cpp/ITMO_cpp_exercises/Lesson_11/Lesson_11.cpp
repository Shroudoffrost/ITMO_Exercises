#include <iostream>
#include "Distance.h"
#include <algorithm>
#include <vector>
#include "Point.cpp"
#define POINT
#define DISTANCE

int main()
{
#ifdef DISTANCE
    Distance dist1, dist2, dist3, dist4;
    dist1.getdist();
    dist3 = dist1 + dist2;
    dist4 = dist1 + dist2 + dist3;
    cout << "\ndist1 = ";
    dist1.showdist();
    dist3 = dist1 - dist2;
#endif

#ifdef POINT
    vector<Point> v;
	v.push_back(Point(1, 2));
	v.push_back(Point(10, 12));
	v.push_back(Point(21, 7));
	v.push_back(Point(4, 8));
	sort(v.begin(), v.end());
	for (auto& point : v)
		std::cout << point << '\n';
	return 0; 
#endif


}