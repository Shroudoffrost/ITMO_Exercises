package Lesson2;

import java.lang.System;
import java.util.Scanner;
import java.util.Arrays;

import static java.lang.System.out;

public class Lesson2
{
    int i = 0;
    int index = 0;
    int array_size = 0;
    int[] array_1 = {1,2, 3, 4, 5, -1, 5, 6, 23, 67, 1, 788, 32, 455, 2, 3};
    int[] array_to_sort = new int[array_size];
    int odd_num = 1;
    int lcm = 15;
    int div_by_3 = 0;
    int div_by_5 = 0;
    int div_by_3_and_5 = 0;
    int a = 0;
    int b = 0;
    int c = 0;
    Scanner scanner = new Scanner(System.in);

    public void Task_1()
    {
        out.println("\n====== task 4 ====== \n");
        for (odd_num = 1; odd_num < 100; odd_num = odd_num + 2)
        {
            out.println(odd_num);
                                    }
        out.println("\n===== --end-- ====== \n");
                                                    }

    public void Task_2()
    {
        out.println("\n===== task 2 ====== \n");

        while (div_by_3 < 97)
        {
            div_by_3 = div_by_3 + 3;
            out.println("divisible by 3: " + div_by_3);
                                                          }
        out.println("---");

        while (div_by_5 < 100)
        {
            div_by_5 = div_by_5 + 5;
            out.println("divisible by 5: " + div_by_5);
                                                          }
        out.println("---");

        while (div_by_3_and_5 < 85)
        {
            div_by_3_and_5 = div_by_3_and_5 + lcm;
            out.println("divisible by 3 and 5: " + div_by_3_and_5);
                                                                      }


        out.println("\n====== --end-- ====== \n");
                                                     }

    public void Task_3()
    {
        out.print("\n====== task 3 ====== \n");

        out.print("enter operand A");
        a = scanner.nextInt();

        out.print("enter operand B");
        b = scanner.nextInt();

        out.print("enter operand C");
        c = scanner.nextInt();

        if (c == a + b)
        {
            out.println("true");
                                   }
        else
        {
            out.println("not true");
                                       }

        out.println("\n====== --end-- ====== \n");
                                                            }

    public void Task_4()
    {
        out.println("\n====== task 4 ====== \n");

        out.println("enter operand A");
        a = scanner.nextInt();

        out.println("enter operand B");
        b = scanner.nextInt();

        out.println("enter operand C");
        c = scanner.nextInt();

        if (a < b && b < c)
        {
            out.println("true");
                                   }
        else
        {
            out.println("false");
                                    }

        out.println("\n====== --end-- ====== \n");
                                                     }

    public void Task_5()
    {
        out.println("\n====== task 5 ====== \n");

        if (array_1[0] == 3 && array_1[12] == 3)
        {
            out.println("true");
                                   }
        else
        {
            out.println("false");
                                    }

        out.println("\n====== --end-- ====== \n");
                                                     }

    public void Task_6_search_by_key()
    {
        out.println("\n====== task 6 ====== \n");

        Arrays.sort(array_1);
        out.println(Arrays.binarySearch(array_1, 1));
        out.println(Arrays.binarySearch(array_1, 3));

        out.println("\n====== --end-- ====== \n");
                                                     }

    public void Task_7_check_if_sorted_asc()
    {
        for(i = 0; i < array_1.length; i++)
        {
            if(array_1[index] < array_1[index+1])
            {
                out.println("index "+index+" is smaller than "+(index+1));
                index++;
                           }
            else
            {
                out.println("failure\nnot sorted\nIndex "+index+" is bigger than "+(index+1));
                break;
                         }
        }
    }

    public int[] Task_8_sizeable_array()
    {
        out.print("Create new array. enter size: ");
        array_size = scanner.nextInt();
        out.println("size is " + array_size);
        out.print("enter numbers for the array: ");
        int[] array_2 = new int[array_size];

        for(i = 0; i < array_size; i++)
        {
            array_2[i] = scanner.nextInt();
            out.println("successfully added with index " + "[" + i + "] – " +array_2[i]);
                                                                                            }
        out.println(Arrays.toString(array_2));
        return array_to_sort;
                               }

    public void Task_9_swap_ends()
    {
        out.println(Arrays.toString(array_1)+"\nArray size is "+array_1.length+"\nNow swapping ends");
        int ix_tail = array_1.length - 1;
        int head = array_1[0];
        int tail = array_1[ix_tail];
        array_1[0] = tail;
        array_1[ix_tail] = head;
        out.println(Arrays.toString(array_1));
                                                 }

    public static void Task_10_find_unique()
    {}

    public static int[] Task_11_merge_sort(int[] array_to_sort)
    {
        out.println(Arrays.toString(array_to_sort));
        if(array_to_sort.length < 2)
        {
            return array_to_sort;
                              }
        int array_mid = array_to_sort.length / 2;
        int[] left_part = new int[array_mid];
        int[] right_part;
        if(array_to_sort.length % 2 == 0)
        {
            right_part = new int[array_mid];
                                                }
        else
        {
            right_part = new int[array_mid + 1];
                                                    }
        for (int i = 0; i < array_mid; i++)
        {
            left_part[i] = array_to_sort[i];
                                          }
        for (int i = 0; i < right_part.length; i++)
        {
            right_part[i] = array_to_sort[array_mid + i];
                                                       }
        left_part = Task_11_merge_sort(left_part);
        right_part = Task_11_merge_sort(right_part);

        return merge_parts(left_part, right_part);
                                                        }

    private static int[] merge_parts(int[] left_part, int[] right_part)
    {
        int[] result_array = new int[left_part.length + right_part.length];
        int left_part_length = 0;
        int right_part_length = 0;
        int result_pointer = 0;

        while(left_part_length < left_part.length || right_part_length < right_part.length)
        {
            if(left_part_length < left_part.length && right_part_length < right_part.length)
            {
                if(left_part[left_part_length] < right_part[right_part_length])
                {
                    result_array[result_pointer++] = left_part[left_part_length++];
                                                                                  }
                else
                {
                    result_array[result_pointer++] = right_part[right_part_length++];
                                                                                    }

                                                                                        }
            else if(left_part_length < left_part.length)
            {
                result_array[result_pointer++] = left_part[left_part_length++];
                                                                                }
            else if(right_part_length < right_part.length)
            {
                result_array[result_pointer++] = right_part[right_part_length++];
                                                                                  }
        }
        return result_array;
    }


//    public static void main(String[] args)
//    {
//        Lesson2 l2 = new Lesson2();
//        l2.Task_11_merge_sort(l2.array_1);
//    }
}

