#include <iostream>
#include "Time.h"
#include "Student.h"
#include "IdCard.h"
#define STUDENT
//#define TIME

int main()
{
#ifdef STUDENT
    string name;
    string last_name;
    cout << "Name: ";
    getline(cin, name);
    cout<< "Last name: ";
    getline(cin, last_name);

    IdCard *card = new IdCard(123, "card name");
    Student *student02 = new Student(name, last_name, card);
    int scores[5];
    int sum = 0;
    for (int i = 0; i < 5; ++i)
    {
        cout << "Score " << i+1 << ": ";
        cin >> scores[i];
        sum += scores[i];
    }
    student02->set_scores(scores);
    double average_score = sum / 5.0;
    student02->set_average_score(average_score);
    cout << "Average ball for " << student02->get_name() << " "
         << student02->get_last_name() << " is "
         << student02->get_average_score() << endl;
    cout <<"IdCard: " << student02->getIdCard().getNumber() << endl;
    cout <<"Category: " << student02->getIdCard().getCategory() << endl;


    delete student02; 
#endif


#ifdef TIME
    int seconds = 8013;
    Time *time = new Time(0, 0, seconds);
    cout << time->show_time();
#endif
}