#pragma once
#include <iostream>
using namespace std;

class Stack
{
    private:
	    int stack[10];
	    int size = 0;

	    void reset()
        {
		    for (int i = 0; i < 10; i++) {
			    stack[i] = 0;
		    }
		    size = 0;
	    }

	    bool push(int data)
        {
		    if (size == 10) return false;
		    stack[size] = data;
		    size++;
		    return true;
	    }

	    void pop()
        {
		    if (size == 0)
            {
			    cout << "Go pop yourself" << endl;
			    return;
		    }
		    stack[size - 1] = 0;
		    size--;
	    }

	    void print() {
		    for (int i = 0; i < size; i++)
		    cout << stack[i] << " " << endl;
	    }
};