#pragma once
#include "Student.h"

Student::Student() : Person(first_name, last_name)
{}

Student::Student(string fn, string ln, string ph_n, School *sch) : Person(fn, ln) 
{
    this->set_phone_num(ph_n);
    this->set_school(sch);
}

void Student::set_name(string fn, string ln)
{
    first_name = fn;
    last_name = ln;
}

void Student::set_phone_num(string ph_n)
{
    phone_num = ph_n;
}

void Student::set_school(School *sch)
{
    school = sch;
}

string Student::get_name()
{
    return first_name +" "+last_name+"\n";
}

string Student::get_phone_num()
{
    return phone_num+"\n";
}

string Student::get_school_info()
{
    return school->school_name +", "+ school->location
        +", "+school->phone_num +", "+ school->specialization+"\n";
}