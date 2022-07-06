#include <iostream>
#include <cmath>
#include "Shapes.h"

long double BinSearch(double a, int n)
{
    double Left_pointer = 0;
    double Right_pointer = a;
    while (Right_pointer - Left_pointer > 1e-10)
    {
        double Mid = (Left_pointer + Right_pointer) / 2;
        std::cout << "Left_pointer = " << Left_pointer << " | Right_pointer = " << Right_pointer << " | Mid = "<< Mid << std::endl;
        if (Mid*Mid*Mid < a)
        {
            std::cout << "Mid*Mid = " << Mid*Mid*Mid << " < "<< a << "\tLeft_pointer -> " << Mid << std::endl;
            Left_pointer = Mid;
        }
        else
        {
            std::cout << "Mid*Mid*Mid = " << Mid*Mid*Mid << " > "<< a << "\tRight_pointer -> " << Mid << std::endl;
            Right_pointer = Mid;
        }
    }
    return Right_pointer;
}

int add_numders(int start_num)
{
    if (start_num == 1)
        return 1;
    else
        std::cout << start_num << std::endl;
        return (start_num + add_numders(start_num - 1));
}

int add_numders(int start_num, int end_num)
{
    if(start_num == end_num)
        return 1;
    else
        std::cout << start_num << std::endl;
        return (start_num + add_numders(start_num - 1, end_num));
}

int get_triangle_area_shoelace(int *p1,int *p2, int *p3)
{
    std::cout << *p1 << " ";
    std::cout << *(p1+1);

    return ( (*(p1)**(p2+1) + *(p2)**(p3+1) + *(p3)**(p1+1) - *(p1+1)**p2 - *(p2+1)**p3 - *(p3+1)**p1) / 2) ;
}

double calculate_side_length(Point &p1, Point &p2)
{
    return sqrt( (p1.x - p2.x)*(p1.x - p2.x) + (p1.y - p2.y)*(p1.y - p2.y) );
}

double calculate_triangle_area(Triangle &triangle)
{
    double side_1 = calculate_side_length(triangle.p1, triangle.p2);
    double side_2 = calculate_side_length(triangle.p2, triangle.p3);
    double side_3 = calculate_side_length(triangle.p3, triangle.p1);
    double hp = (side_1 + side_2 + side_3) / 2;
    return sqrt( hp*(hp-side_1) * (hp-side_2) * (hp-side_3) );
}

double calculate_pentagon_area(Triangle &ADE, Triangle &ACD, Triangle &ABC)
{
    double pentagon_area;
    ADE.area = calculate_triangle_area(ADE);
    ACD.area = calculate_triangle_area(ACD);
    ABC.area = calculate_triangle_area(ABC);

    pentagon_area = ADE.area + ACD.area + ABC.area;
    return pentagon_area;
}

double calculate_cubic_root(int cube)
{
    double r = cube;
    while (r*r*r - cube > 1E-10)
    {
        r = ( (cube + 2*(r*r*r)) / (r*r) ) / 3;
    }
    return r;
}

int recursive_sum(int start_num)
{
    if (start_num > 0)
    {
        std::cout << start_num << std::endl;
        return (start_num*5 + recursive_sum(start_num - 1));
    }
    else return 0;
}

int decimal_to_binary(int n, long binary)
{
    int p = 0;
    while(n - pow(2,p) >= pow(2,p))
    {
        p++;
    }
    binary = binary + pow(10,p);
    int remainder = n - pow(2,p);
    if(remainder > 0)
        decimal_to_binary(remainder, binary);
    else return binary;
}

int decimal_to_binary(int n)
{
    long binary = 0;
    if(n != 0)
    {
        if(n > 0)
        {
            if(n <= 255)
            {
                return decimal_to_binary(n, binary);
            }
            else
            {
                return -0x80;
            }
        }
        else
        {
            if(n >= -127)
            {
                n *= -1;
                binary = 10000000;
                return decimal_to_binary(n, binary);
            }
            else
            {
                return -0x80;
            }
        }
    }
    else return binary;
}