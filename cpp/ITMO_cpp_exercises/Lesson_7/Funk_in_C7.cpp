#include <iostream>
#include "Spare_time.h"

Time set_time()
{
    Time Spare_time;
    std::cout << "set hours ";
    std::cin >> Spare_time.hours;
    std::cout << "set minutes ";
    std::cin >> Spare_time.minutes;
    std::cout << "set seconds ";
    std::cin >> Spare_time.seconds;
    return Spare_time;
}