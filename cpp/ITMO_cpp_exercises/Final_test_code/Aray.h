#include <cstdlib>
#include <iostream>
  
using namespace std;
  
class Aray
{
    private:
        int* ptr;
        int size;
    public:
        Aray(int*, int);
        int &operator[](int);
        int *print() const;
};

Aray::Aray(int* p, int s = 0)
{
    size = s;
    if (s != 0) {
        ptr = new int[s];
        for (int i = 0; i < s; i++)
            ptr[i] = p[i];
    }
}

int& Aray::operator[](int ix)
{
    if (ix >= size) {
        cout << "Array index out of range";
        exit(0);
    }
    return ptr[ix];
}
  
int *Aray::print() const
{
    for (int i = 0; i < size; i++)
    {
        return (ptr+i);
    }
}