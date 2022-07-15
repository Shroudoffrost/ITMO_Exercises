#include <iostream>
#include <vector>
#include "Human.h"
#include "Student.h"
#include "Teacher.h"

using namespace std;

int main()
{
    vector<int> scores;
    scores.push_back(5);
    scores.push_back(3);
    scores.push_back(4);
    scores.push_back(4);
    scores.push_back(5);
    scores.push_back(3);
    scores.push_back(3);
    scores.push_back(3);
    scores.push_back(3);

    Student *student = new Student("Petrov", "Ivan", "Alekseyevich", scores);

    //cout << student->get_full_name() << endl;
    //cout << "Average score: " << student->get_average_score() << endl;
    
    unsigned int teacher_work_time = 40;

    Teacher *teacher = new Teacher("Sergeyev", "Dmitro", "Sergeyevich", teacher_work_time);
    //cout << tch->get_full_name() << endl;
    //cout << "Working hours: " << tch->get_work_time() << endl;

    void(*funk)();
    int opt;
    cin >> opt;
    
    switch (opt)
    {
    case 1:
        funk;
    case 2:
        funk = teacher->get_work_time;
    default:
        break;
    }
    
    
    cout << funk();

    return 0;
}