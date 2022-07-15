#pragma once
#include <string>
#include "Employer.h"
using std::string;

class School
{
    private:
        string school_name;
        string location;
        string phone_num;
        string specialization;
        friend class Student;
    public:
        School();
        School(string,string,string,string);
        string show_info();
};