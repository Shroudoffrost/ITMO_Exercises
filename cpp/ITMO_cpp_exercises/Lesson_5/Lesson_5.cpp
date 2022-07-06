#include <iostream>
#include "Lesson_5_fun_pack.h"
//#define ARRAY_TINKER_1
#define ARRAY_TINKER_2
using namespace std;

int main()
{
#ifdef ARRAY_TINKER_1
    const int size = 10;
    //int *array_1 = fill_array(size);
    int pre_filled_array[10] = {-1,-3,2,3,4,5,6,7,8,9};
    int *array_2      = pre_filled_array;
    double sum        = calculate_sum_of_elements(array_2, size);
    double mean       = sum/10;
    double sum_pos    = calculate_sum_of_positives(array_2,size);
    double sum_neg    = calculate_sum_of_negatives(array_2,size);
    double s_even_ixs = calculate_sum_of_even_ix_vals(array_2,size);
    double s_odd_ixs  = calculate_sum_of_odd_ix_vals(array_2,size);
    int *peaks_bio    = find_peaks(array_2,size);
    int low_peak      = *peaks_bio;
    int low_peak_ix   = *(peaks_bio+1);
    int hi_peak       = *(peaks_bio+2);
    int hi_peak_ix    = *(peaks_bio+3);

    cout << "Total sum = "<< sum << endl;
    cout << "Positive sum = "<< sum_pos << endl;
    cout << "Negative sum = "<< sum_neg << endl;
    cout << "Even ixs sum = "<< s_even_ixs << endl;
    cout << "Odd ixs sum = "<< s_odd_ixs << endl;
    cout << "Mean = " << mean << endl;
    cout << "Low peak = "<< low_peak << " at ix [" << low_peak_ix << "]" << endl;
    cout << "High peak = "<< hi_peak << " at ix [" << hi_peak_ix << "]" <<endl;
    cout << "MUltiply over = " << calculate_multiple_within_peaks(array_2, low_peak_ix, hi_peak_ix) << endl;
    cout << "Multiply over = " << calculate_multiple_within_peaks(array_2, peaks_bio) << endl;
#endif

#ifdef ARRAY_TINKER_2
    
    int a[]={1,2,3,4,5,6,7,2};
    int b[]={7,6,5,4,3,2,1,3};
    int size = sizeof(a)/sizeof(a[0]);
    int *c;
    c = fill_array_by_picking_highs(size,a,b);
    for (int i = 0;i < size; i++)
    {
        cout << c[i] << " ";
        cout << endl;
    }
    delete []c;

#endif
}