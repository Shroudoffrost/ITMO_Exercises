#include <iostream>
#include "Spare_time.h"
#include "Funk_in_C7.h"
//#define SOME_TIME
#define BACK_TO_THE_ROOTS
using namespace std;
 
int main()
{
#ifdef SOME_TIME
    Time spare_time;
    Time tea_time;
    spare_time.hours = 0;
    spare_time.minutes = 54;
    spare_time.seconds = 8000;
    tea_time.hours = 0;
    tea_time.minutes = 45;
    tea_time.seconds = 32;
    Time time_left = time_left.find_time(tea_time);
    Time leasure;
    leasure = {0, 45, 50};
    time_left = time_left.kill_time(time_left, leasure);
    if(time_left.hours == 0 && time_left.minutes == 0 && time_left.seconds == 0 )
    {
        cout << "You are dead." << endl;
    }
    else
    {
        cout << "Still got some time to kill: " << time_left.hours << " hours, " << time_left.minutes << " minutes and " << time_left.seconds << " seconds left." << endl;
    }
#endif

#ifdef BACK_TO_THE_ROOTS

#endif
}