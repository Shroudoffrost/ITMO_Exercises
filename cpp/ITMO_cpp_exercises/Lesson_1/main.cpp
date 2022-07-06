#include <iostream>
#include "Polygon.cpp"
#include "office_supplies.h"
using namespace std;

int main()
{
    int sum = 0;
    int num_of_points = 0;

    cout << "enter number of points of the polygon: ";
    cin >> num_of_points;

    Polygon polygon;
    polygon.points[num_of_points][2];

    //cout << "enter X and Y coordinates for " << num_of_points << " points";
    for(int p = 0; p < num_of_points; p++)
    {
        cout << "Enter coordinates for point " << (p+1) << std::endl;
        for(int c = 0; c < 2; c++)
        {
            cin >> polygon.points[p][c];
        }
    }


    office_supplies::measure(polygon, num_of_points, sum);

    /*
    cout << "Enter edges perimeter\nassert meters" << endl;
    int p;
    cin >> p;
    int edge = p/3;
    int hp = p/2;
    int area = sqrt(hp*(hp-edge)*(hp-edge)*(hp-edge));
    cout << "Area of the triangula ABC is " << area << endl;
    return 0;
    */
}
