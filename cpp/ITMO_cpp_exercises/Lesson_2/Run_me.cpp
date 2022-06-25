#include <iostream>
#include "games_lesson_2.h"
#include "test_chamber.h"
using namespace std;
using namespace games_lesson_2;

int main()
{
    cout << "Is it a leap year? - 1" << endl;
    cout << "Which is bigger? - 2" << endl;
    cout << "Meloch est'? - 3" << endl;
    cout << "Shoot 'em up. - 4" << endl;

    cout << "Choose game: ";

    int game = 0;
    cin >> game;
    if (game == 0)
        test_chamber::test_fun();
    else if (game == 1)
        leap_year();
    else if (game == 2)
        which_is_bigger();
    else if (game == 3)
        meloch_est();
    else if (game == 4)
        bang_bang();
    else
        cout << "Only 4 games are available now";
}