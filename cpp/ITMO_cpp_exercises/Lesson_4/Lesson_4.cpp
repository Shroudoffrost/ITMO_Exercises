#include <iostream>
#include "Lesson_4_fun_pack.h"
#define QUADRATIK
#define INPUT
using namespace std;

int main()
{
#ifdef QUADRATIK
    double a , b , c, x1, x2;
    cout << "Set coefficients a b & c: " << endl;
    cin >> a >> b >> c;

    switch(solve_quadratic_equation(a, b ,c, x1 ,x2))
    {    
        case 0:
            cout << "Only one root: x = " << x1 << endl;
            break;
        case 1:
            cout << "x1 = " << x1 << endl;
            cout << "x2 = " << x2 << endl;
            break;
        case -1:
            cout << "Undefined" << endl;
            break;
    }
#endif

#ifdef INPUT

    int a, b;
    if(!Input(a,b))
    { 
        cerr << "error";
        return 1;
    }
    int s = a + b;
    return 0;

#endif
}