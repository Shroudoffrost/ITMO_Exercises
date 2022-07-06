#include <iostream>
#include <cmath>
int solve_quadratic_equation(double a, double b, double c, double &x1, double &x2)
{
    double D = (b*b) - (4*a*c);
    x1 = (-b + sqrt(D)) / (2*a);
    x2 = (-b - sqrt(D)) / (2*a);
    
    if (isnan(x1) || isnan(x2)) {
        return -1;
    }
    else {
        if(x1 == x2) return 0;
        else return 1;
    }
}

bool Input(int &a, int &b)
{
    if(a != 0 || b != 0)
    {
        std::cin >> a >> b;
        return true;
    }
    else return false;
}