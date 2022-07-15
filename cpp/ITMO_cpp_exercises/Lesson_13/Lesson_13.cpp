#include <iostream>
#include <string>
#include <windows.h>
using namespace std;

class Item 
{
    private: 
        string title; 
        double price;
    public: 
        virtual void getdata() 
        {
            cout << "\nEnter title: ";
            cin >> title;
            cout << "Enter price: ";
            cin >> price;
        }

        virtual void putdata() 
        {
            cout << "\nTitle: " << title;
            cout << "\nPrice: " << price;
        }
};

class Paperbook: public Item 
{
    private:
        int pages;
    public:
        void getdata()
        {
            Item::getdata();
            cout << "Enter pages amount: ";
            cin >> pages;
        }
        void putdata() 
        {
        Item::putdata();
        cout << "\nPages: " << pages;
        }
};

class AudioBook: public Item
{
    private:
        double time;
    public:
        void getdata()
        {
            Item::getdata();
            cout << "Enter duration: ";
            cin >> time;
        }

        void putdata()
        {
            Item::putdata();
            cout << "\nDuration: " << time;
        }
};

int main()
{
    Item* pubarr [100];
    int n = 0;
    char choice;
    do
    {
        cout << "\nData for [b]ook or [a]udio book (b/a)?";
        cin >> choice;
        if(choice == 'b')
        pubarr[n] = new Paperbook;
        else
        pubarr[n] = new AudioBook; 
        pubarr[n++]->getdata(); 
        cout << "Continue ((у/n)?";
        cin >> choice;
    }
    while(choice == 'y');

    for(int j=0; j<n; j++)
    {
        pubarr[j]->putdata();
        cout << endl;
    }
    return 0;
}