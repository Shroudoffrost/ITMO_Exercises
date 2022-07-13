#pragma once
#include <string>
using namespace std;

class Time
{
    private:
        int hours;
        int minutes;
        int seconds;
    public:
        Time();
        Time(int, int, int);
        string show_time();
};

