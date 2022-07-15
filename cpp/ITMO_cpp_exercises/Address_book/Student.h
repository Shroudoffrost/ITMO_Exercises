#pragma once
#include "Person.h"
#include "School.h"
using namespace std;

class Student : public Person
{
    private:
        string diploma_project;
        string phone_num;
        School *school;
        friend class School;
    public:
        Student();
        Student(string fn, string ln, string ph_n, School *);
        void set_name(string fn, string ln);
        void set_phone_num(string ph_n);
        void set_school(School *sch);
        string Person::get_name();
        string get_phone_num();
        string get_school_info();
};