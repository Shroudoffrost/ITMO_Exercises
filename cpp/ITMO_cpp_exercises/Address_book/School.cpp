#include "School.h"
#include "Student.h"

School::School(){}

School::School(string sn, string loc, string ph_n, string spec) 
    : school_name(sn), location(loc), phone_num(ph_n), specialization(spec)
{}

string School::show_info()
{
    return school_name +", "+ location +", "+ phone_num +", "+ specialization+"\n";
}