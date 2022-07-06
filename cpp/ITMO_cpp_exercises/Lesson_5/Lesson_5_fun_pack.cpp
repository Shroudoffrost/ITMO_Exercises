#pragma once
#include <iostream>

int* fill_array(int size)
{
    int *array_body = new int[size];
    for(int i = 0; i < size; i++)
    {
        std::cout << "array_body[" << i << "]= "; 
        std::cin >> array_body[i];
    };

    return array_body;
}

int calculate_sum_of_elements(int *array_body, int size)
{
    int sum = 0;
    for (int i = 0; i < size; i++)
    {
        sum += *(array_body+i);
    }
    return sum;
}

int calculate_sum_of_positives(int *array_body, int size)
{
    int sum = 0;
    for (int i = 0; i < size; i++)
    {
        if(*(array_body+i) > 0)
            sum += *(array_body+i);
    }
    return sum;
}

int calculate_sum_of_negatives(int *array_body, int size)
{
    int sum = 0;
    for (int i = 0; i < size; i++)
    {
        if(*(array_body+i) < 0)
            sum -= *(array_body+i);
    }
    return -1*sum;
}

int calculate_sum_of_even_ix_vals(int *array_body, int size)
{
    int sum = 0;
    for (int i = 0; i < size/2; i += 2)
    {
        if(*(array_body+i) > 0)
            sum += *(array_body+i);
    }
    return sum;    
}

int calculate_sum_of_odd_ix_vals(int *array_body, int size)
{
    int sum = 0;
    for (int i = 1; i < size/2; i += 2)
    {
        if(*(array_body+i) > 0)
            sum += *(array_body+i);
    }
    return sum;
}

int* find_peaks(int *array_body, int size)
{
    int peaks_bio[4] = {*(array_body), 0, *(array_body), 0};
    for(int i = 0; i < size; i++)
    {
        if(*(array_body+i) < *(peaks_bio))
        {
            *(peaks_bio) = *(array_body+i);
            *(peaks_bio+1) = i;
        }

        if(*(array_body+i) > *(peaks_bio+2))
        {
            *(peaks_bio+2) = *(array_body+i);
            *(peaks_bio+3) = i;
        }
            
    }
    return peaks_bio;
}

int calculate_multiple_within_peaks(
    int *array_body, int low_ix, int hi_ix)
{
    int sum = 1;
    for(int i = low_ix; i <= hi_ix; i++)
    {
        sum *= *(array_body+i);
    }
    return sum;
}

int calculate_multiple_within_peaks(int *array_body, int *peaks_bio)
{
    int low_ix = *(peaks_bio+1);
    int hi_ix = *(peaks_bio+3);
    int sum = 1;
    for(int i = low_ix; i <= hi_ix; i++)
    {
        sum *= *(array_body+i);
    }
    return sum;
}

int* fill_array_by_picking_highs(int size, int *a, int *b)
{
    int *c = new int[size];
    for(int i = 0; i < size; i++)
    {
        if(*(a+i) >=*(b+i)) c[i] = *(a+i);
        else *(c+i) = *(b+i);
    }
    return c;
}