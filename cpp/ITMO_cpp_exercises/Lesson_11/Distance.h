#include <iostream>

using namespace std;
class Distance 
{
    private:
        int feet; 
        float inches;
    public:
        Distance() : feet (0), inches (0.0)
        {}
        Distance(int ft, float in) : feet (ft), inches (in)
        {}
        
        friend ostream &operator<< (ostream &out, const Distance &dist);
        friend Distance &operator- (const Distance &d1, const Distance &d2);

        void getdist()
        {
            std::cout <<"\nEnter feet: ";
            cin >> feet;
            cout <<"\nEnter inches: ";
            cin >> inches;
        }
        
        void showdist()
        {
            cout << feet << "\'-" << inches << "\"\n";
        }

        Distance operator+ (const Distance&) const;
};

Distance Distance::operator+ (const Distance &d2) const
{
    int f = feet + d2.feet;
    float i = inches + d2.inches; 
    if (i>= 12.0)
    {
        i -= 12.0;
        f++;
    }
    return Distance (f, i); 

}

Distance &operator- (const Distance &d1, const Distance &d2)
{
    int f1 = d1.feet;
    float i = 0.0;
    
    if (d1.inches < d2.inches)
    {
        i = (d1.inches + 12) - d2.inches;
        f1--;
    }
    else
    { 
        i = d1.inches - d2.inches;     
    }
    int f = f1- d2.feet;
    Distance dist_new(f, i);
    return dist_new;
}

ostream &operator<< (ostream &out, const Distance &dist)
{
    out << dist.feet << "\'-" << dist.inches << "\"\n";
    return out;
}


ostream& operator<< (ostream& out, const Distance& dist)
{
    out << dist.feet << "\' - " << dist.inches << "\"\n";
    return out;
}