#pragma once
#include <string>
using namespace std;

class Person
{
    public:
        Person(){};
        Person(string fn,string ln)
        {
            first_name = fn;
            last_name = ln;
        };

        string first_name;
        string last_name;

        virtual string get_name()=0;
        virtual void set_name(string fn, string ln)=0;
};