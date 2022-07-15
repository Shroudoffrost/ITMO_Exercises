#include <iostream>
#include "School.h"
#include "Student.h"
#include <fstream>

using namespace std;

int main()
{
    string last_names[10]  {"Ivanov",
                            "Petrov",
                            "Semyonov",
                            "Maksimov",
                            "Ulyanov",
                            "Dzhugashvili",
                            "Voronin",
                            "Romanov",
                            "Potyomkin",
                            "Fyodorov"};
    string first_names[10] {"Dmitriy",
                            "Yuriy",
                            "Stepan",
                            "Arkadiy",
                            "Vladimir",
                            "Iosif",
                            "Vladislav",
                            "Aleksey",
                            "Semyon",
                            "Ivan"};
    string phone_numbers[10] {"8-951-837-49-50",
                              "375-9-230-27-23",
                              "8-495-73-46-54",
                              "8-812-835-2221",
                              "8-800-555-35-35",
                              "8-941-549-94-01",
                              "1-2648-841-438",
                              "8-8112-23-47-54",
                              "8-971-234-37-54",
                              "8-960-881-34-65"};

    string school_name = "I aM TOo a university";
    string location = "Saint_petersburg, Fl";
    string phone_num = "+1-2343-42-69";
    string specialization = "IT";

    School *IMTO_University = new School(
        school_name, location, phone_num, specialization);
    
    fstream writer;
    writer.open("Student list.txt", ios::app);

    for (int i = 0; i < 10; i++)
    {
        Student *student = new Student(
            *(first_names+i), *(last_names+i), *(phone_numbers+i), IMTO_University);
        writer << "Student "+student->get_name()
            << student->get_phone_num()
            << student->get_school_info()+"\n";
        delete student;
    }

    writer.close();

    return 0;
}

