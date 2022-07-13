struct Time
{
    int hours;
    int minutes;
    int seconds;

    Time find_time(Time t1)
    {
        Time dt;

        
        dt.hours = hours + t1.hours;
        dt.minutes = minutes + t1.minutes;
        dt.seconds = seconds + t1.seconds;
    
        if(dt.seconds >= 60)
        {
            dt.minutes += dt.seconds/60;
            dt.seconds = dt.seconds % 60;
        }
    
        if(dt.minutes >= 60)
        {
            dt.hours += dt.minutes/60;
            dt.minutes = dt.minutes % 60;
        }
        return dt;
    }

    Time kill_time(Time time_left, Time leasure)
    {
        if(time_left.hours < leasure.hours)
        {
            Time no_time {0,0,0};
            return no_time;
        }
        if(time_left.seconds - leasure.seconds < 0)
        {
            time_left.minutes--;
            time_left.seconds += 60;
        }
        time_left.seconds -= leasure.seconds;

        if(time_left.minutes - leasure.minutes < 0)
        {
            time_left.hours--;
            time_left.minutes += 60;
        }
        time_left.minutes -= leasure.minutes;

        time_left.hours -= leasure.hours;

        return time_left;
    }

    
};