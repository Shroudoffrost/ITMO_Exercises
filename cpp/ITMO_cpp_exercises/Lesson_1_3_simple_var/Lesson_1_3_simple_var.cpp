#include <iostream>
using namespace std;

int main()
{
    int shape[5][2] = { {2,3},{-2,4},{-4,1},{-1,-4},{5,-2} };
    /*
    setter
    for(int p = 0; p < 5; p++)
    {
        std::cout << "Enter coordinates for point " << (p+1) << std::endl;
        for(int c = 0; c < 2; c++)
        {
            std::cin >> shape[p][c];
        }
    }
    */
    //getter
    for(int p = 0; p < 5; p++)
    {
        for(int c = 0; c < 2; c++)
        {
            std::cout << shape[p][c] << "\t";
        }
        std::cout << "\n";
    }

    int sum = 0;
    for(int p = 0; p < 4; p++)
    {
        int positive_pair = shape[p][0]*shape[p+1][1];
        int negative_pair = -shape[p][1]*shape[p+1][0];
        sum = sum + positive_pair + negative_pair;
    }
    cout << "Area of the pentagon is " << (double)sum/2 << endl;

    return 0;
}