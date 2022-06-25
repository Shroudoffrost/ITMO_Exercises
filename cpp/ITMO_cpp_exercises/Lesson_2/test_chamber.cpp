#include <iostream>
#include <ctime>
using namespace std;

namespace test_chamber
{
    void test_fun()
    {
        int dummy = 0;
        const int constant_num = 5;
        int const *pointer = &constant_num;
        std::cout << constant_num << std::endl;
        std::cout << &constant_num;
    }
}