#include <iostream>
#include "Time.h"

int main()
{
    int seconds = 8013;
    Time *time = new Time(0, 0, seconds);
    cout << time->show_time();
}