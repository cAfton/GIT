#include "Meal.h"

void Meal::virt()
{

}

ostream& operator<<(ostream& out, const Meal& meal)
{
    out << static_cast<const Dish&>(meal)<< endl;

    return out;
}

ofstream& operator<<(ofstream& file, const Meal& meal)
{
    file << static_cast<const Dish&>(meal) << endl;
    return file;
}

istream& operator>>(istream& in, Meal& meal)
{
    meal.LoadCout(in, meal);

    return in;
}

ifstream& operator>>(ifstream& file, Meal& meal)
{
    meal.LoadFile(file, meal);

    return file;
}
