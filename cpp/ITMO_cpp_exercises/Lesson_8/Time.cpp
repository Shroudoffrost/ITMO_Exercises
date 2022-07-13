#include "Time.h"
#include <string>
using std::string;
using std::to_string;

Time::Time() : hours(0), minutes(0), seconds(0)
{}
Time::Time(int h, int m, int s) : hours(h), minutes(m), seconds(s)
{
    if(s >= 60)
    {
        minutes += s/60;
        seconds = s % 60;
    }
    
    if(minutes >= 60)
    {
        hours += minutes / 60;
        minutes = minutes % 60;
    }
}

string Time::show_time()
{
    string h;
    string m;
    string s;
    
    if(hours < 10) h = "0"+to_string(hours)+":";
    else h = to_string(hours)+":";
    
    if(minutes < 10) m = "0"+to_string(minutes)+":";
    else m = to_string(minutes)+":";

    if(seconds < 10) s = "0"+to_string(seconds);
    else s = to_string(seconds);

    return h+m+s;
}