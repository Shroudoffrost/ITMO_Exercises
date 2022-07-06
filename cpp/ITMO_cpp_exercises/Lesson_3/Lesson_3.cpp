#include <iostream>
#include "Shapes.h"
#include "Lesson_3_fun_pack.h"

//#define BIN_SEARCH
//#define RECURSION
//#define LIMITED_RECURSION
//#define DECOMPOSE_GAUSS
//#define DECOMPOSE
#define CUBIC
#define RECURSIVE_SUM
//#define DEC_TO_BIN

using namespace std;

int main()
{
    std::cout.precision(12);

#ifdef BIN_SEARCH
    std::cout << BinSearch(1237231,5);
#endif

#ifdef RECURSION
    int max_num = 0;
    std::cin >> max_num;
    std::cout << add_numbers(max_num);
#endif

#ifdef LIMITED_RECURSION
    int start_num = 0;
    int end_num = 0;
    std::cout << "Add recurively from: ";
    std::cin >> start_num;
    std::cout << "... to: ";
    std::cin >> end_num;
    if (start_num < end_num)
    {
        std::cout << "No way!";
    }
    else
    {
        std::cout << add_numders(start_num, end_num);
    }
#endif

#ifdef DECOMPOSE_GAUSS

    int A[2] = {-5,3};
    int B[2] = {-7,-3};
    int C[2] = {4,-3};
    int D[2] = {6,1};
    int E[2] = {1,5};

    int ADE_area = get_triangle_area_showlace(A, D, E);
    int ACD_area = get_triangle_area_showlace(A, C, D);
    int ABC_area = get_triangle_area_showlace(A, B, C);
    cout << "ADE area: " << ADE_area << endl;
    cout << "ACD area: " << ACD_area << endl;
    cout << "ABC area: " << ABC_area << endl;
    int pentagon_area = ABC_area + ACD_area + ADE_area;
    cout << pentagon_area;

#endif

#ifdef DECOMPOSE
    Triangle ADE{};
        ADE.p1.x = -5;
        ADE.p1.y = 3;
        ADE.p2.x = 6;
        ADE.p2.y = 1;
        ADE.p3.x = 1;
        ADE.p3.y = 5;
    Triangle ACD{};
        ACD.p1.x = -5;
        ACD.p1.y = 3;
        ACD.p2.x = 4;
        ACD.p2.y = -3;
        ACD.p3.x = 6;
        ACD.p3.y = 1;
    Triangle ABC{};
        ABC.p1.x = -5;
        ABC.p1.y = 3;
        ABC.p2.x = -7;
        ABC.p2.y = -3;
        ABC.p3.x = 4;
        ABC.p3.y = -3;
    double pentagon_area = calculate_pentagon_area(ADE, ACD, ABC);
    std::cout << pentagon_area;

#endif

#ifdef CUBIC
    std::cout.precision(12);

    int cube;
    cin >> cube;
    std::cout << calculate_cubic_root(cube) << endl;

#endif

#ifdef RECURSIVE_SUM
    std::cout << recursive_sum(8);
#endif

#ifdef DEC_TO_BIN
    int n = 0;
    cin >> n;
    std::cout << decimal_to_binary(n) << endl;
#endif
}