#include <iostream>

int subtract(int &minuend, int &subtrahend)
{
    return minuend - subtrahend;
}

void find_meloch(int zarplata, int *p_meloch, int &desyatki, int &pyataki, int &dvushki)
{
    if(zarplata >= *p_meloch)
    {
        while(zarplata >= *p_meloch)
        {
            zarplata = subtract(zarplata, *p_meloch);
            desyatki++;
        }
    }
    if(zarplata >= *(p_meloch+1))
    {
        while(zarplata >= *(p_meloch+1))
        {
            zarplata = subtract(zarplata, *(p_meloch+1));
            pyataki++;
        }
    }
    if(zarplata >= *(p_meloch+2))
    {
        while(zarplata >= *(p_meloch+2))
        {
            zarplata = subtract(zarplata, *(p_meloch+2));
            dvushki++;
        }
    }
}

int compare(int num_1,int num_2)
{
    if (num_1 > num_2)
        return num_1;
    else return num_2;
}

int largest_num_in(int *array, int size)
{
    int largest_num = 0;

    for(int i = 0; i < size; i++)
    {
        largest_num = compare(*(array+(i)), largest_num);
    }
    return largest_num;
}

int* fill_array(int size)
{
    int *array_body = new int[size];
    for(int i = 0; i < size; i++)
    {
        std::cout << "set array element " << i+1 << ": ";
        std::cin >> *(array_body+(i));
    };

    return array_body;
}

bool is_leap(int year)
{
    return year % 4 == 0 && year % 100 != 0 || year % 400 == 0;
}
