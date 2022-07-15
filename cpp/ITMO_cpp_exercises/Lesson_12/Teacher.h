#pragma once
#include "human.h"
#include <string>

class Teacher : public Human
{
    private:
        unsigned int work_time;
    public:
        Teacher(
            string last_name, string name, string second_name, unsigned int work_time)
            : Human(last_name, name, second_name)
        {
            this->work_time = work_time;
        }

        unsigned int get_work_time()
        {
            return this->work_time;
        }
};