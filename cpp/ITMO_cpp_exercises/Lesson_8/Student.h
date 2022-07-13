#pragma once
#include <string>
#include "IdCard.h"
using namespace std;
class Student
{
    private:
        IdCard *idcard;
        int scores[5];
        double average_score;
        string name;
        string last_name;
    public:
        Student(string, string, IdCard);
        ~Student();
        
        void setIdCard(IdCard *c);
        IdCard getIdCard();
        void save();
        Student(string name, string last_name, IdCard* id);
        void set_name(string);
        string get_name();
        void set_last_name(string);
        string get_last_name();
        void set_scores(int []);
        void set_average_score(double);
        double get_average_score();
};