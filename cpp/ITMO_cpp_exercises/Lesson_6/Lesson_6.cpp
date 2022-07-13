#include <iostream>
#include <fstream>
#include <string>
//#define RW
#define DIALOG
using namespace std;

int main()
{
#ifdef RW
    int const size = 100;
    
    double nums[size]; // fill
    for (int i = 0; i < size; i++)
    {
        nums[i] = (rand() % 100);
    }

    fstream file_writer("Sample.txt", ios::out | ios::binary);
    if(!file_writer)
    {
        cout << "File not opened\n" << endl;
        return 1;
    }

    file_writer.write((char *) &nums, sizeof(nums));
    file_writer.close();

    ifstream file_reader("Sample.txt", ios::in | ios::binary);
    if(!file_reader)
    {
        cout << "Error opening file" << endl;
    }
    file_reader.read((char *) &nums, sizeof(nums));

    double sum = 0;
    int amt = sizeof(nums) / sizeof(double);

    for (int i = 0; i < amt; i++)
    {
        sum += nums[i];
        cout << nums[i] <<' ';
    }
    cout << "\nsum = " << sum << endl;
    file_reader.close();
#endif

#ifdef DIALOG

    const int limit = 400;
    char dialog[limit];
    cin.get(dialog, limit, '$');
    ofstream fout("Dialog.txt");
    fout << dialog;

#endif
}