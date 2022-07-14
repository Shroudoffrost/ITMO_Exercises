#include "Dot.h"
#include <rpcndr.h>
#include <cmath>
#include <string>
using namespace std;

class Triangle
{
    private:
        Dot *a;
        Dot *b;
        Dot *c;
    public:
        Triangle(Dot *a, Dot *b, Dot *c) : a(a), b(b), c(c)
        {}

        double get_ab()
        {
            return a->distance_to(*b);
        }

        double get_bc()
        {
            return  b->distance_to(*c);
        }
        
        double get_ac()
        {
            return a->distance_to(*c);
        }

        boolean IsNotTriangle(double ab, double bc, double ac)
        {
            if (ac >= ab + bc or ab >= bc + ac or bc >= ab + ac)
                return true;
            return false;
        }

        double TrianglePerimeter()
        {
            double ab;
            double bc;
            double ac;
            ab = a->distance_to(*b);
            bc = b->distance_to(*c);
            ac = a->distance_to(*c);
            if (IsNotTriangle(ab, bc, ac))
                throw Triangle::ExNotTriangle("Triangle");
            return ab + bc + ac;
        }

        double TriangleArea()
        {
            double ab;
            double bc;
            double ac;
            ab = a->distance_to(*b);
            bc = b->distance_to(*c);
            ac = a->distance_to(*c);
            double p = TrianglePerimeter()/ 2;
            return sqrt(p * (p - ab) * (p - bc) * (p - ac));
        }

        class ExNotTriangle
        {
            public:
                string nameObject;
                ExNotTriangle(string nameObj) :nameObject(nameObj) {}
        };
};