#include <iostream>
#include <math.h>
#include "Dot.h"
#include "Triangle.cpp"

using namespace std;

int main()
{
    cout << "Enter triangle verticies coords\n";
    double ax, ay, bx, by, cx, cy;
    cin >> ax>> ay >> bx >> by >> cx >> cy;

    Dot a(ax, ay);
    Dot b(bx, by);
    Dot c(cx, cy);

    try
    {
        Triangle triangle(&a, &b, &c);
        cout << "АВ = " << triangle.get_ab() << " ВC = " << triangle.get_bc() << " AC = " << triangle.get_ac() << endl;
        cout << "Perimeter = " << triangle.TrianglePerimeter() << endl;
        cout << "Area = " << triangle.TriangleArea() << endl;

        //Triangle triangle(a, b, c);
        //cout <<"АВ = "<< triangle.get_ab() << " ВC = " << triangle.get_bc() << " AC = "<< triangle.get_ac() << endl;
        //cout << "Периметр треугольника " << triangle.TrianglePerimeter() << endl;
        //cout << "Площадь треугольника " << triangle.TriangleArea() << endl;
    }
    catch (Triangle::ExNotTriangle& ex)
    {
        cout << "\nNot a triangle" << ex.nameObject;
    }
} 