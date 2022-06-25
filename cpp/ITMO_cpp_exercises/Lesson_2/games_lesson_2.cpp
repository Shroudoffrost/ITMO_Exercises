#include <iostream>
#include <cstdlib>
#include <string>
#include <ctime>
#include "bang_bang.h"
#include "comparator.h"
#include "test_chamber.h"

using namespace std;

namespace games_lesson_2
{
    void leap_year()
    {
        int year = 0;
        cout << "year: " << endl;
        cin >> year;
    
        if(is_leap(year))
            cout << year <<" is leap year" << endl;
        else
            cout << year <<" is not leap year" << endl;
        cin >> year;
    }

    void which_is_bigger()
    {
        std::cout << "There are 10 numbers. Set them: ";
        int this_num = largest_num_in(fill_array(10),10);
        std::cout << "the largest number is " << this_num << endl;
    }

    void meloch_est()
    {
        int meloch[3] = {10,5,2};
        int zarplata = 148;
        int desyatki = 0;
        int pyataki = 0;
        int dvushki = 0;
        int *p_meloch = meloch;

        cout << "\nMEJlO4b ECTb? " << endl;
        find_meloch(zarplata, p_meloch, desyatki, pyataki, dvushki);
        cout << "\nY MEHR BCErO " << zarplata << " PY6JlEU. " << ends;
        cout << "TYT " << desyatki << " DECRTOK, " << ends;
        cout << pyataki + " pyaTAK, " << ends;
        if(dvushki > 1)
            cout << "\n" << dvushki + " DBYshKu. " << endl;
        else 
            cout << "\n" << dvushki + " DBYshKA. " << endl;
    }

    void bang_bang()
    {
        int radius_1 = 1;
        int radius_2 = 2;
        int radius_3 = 3;
        int attempts = 10;

        shooting_gallery(
            attempts, radius_1, radius_2, radius_3);
    }
}