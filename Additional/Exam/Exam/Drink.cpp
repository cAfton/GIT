#include "Drink.h"

Drink::Drink()
{
}

Drink::Drink(string Name, int Weight, double Price, bool IsAlcoholic) : Dish(Name, "Drink", Weight, Price), isAlcoholic(IsAlcoholic) {}

void Drink::virt()
{
}


ostream& operator<<(ostream& out, const Drink& drink)
{
    out << static_cast<const Dish&>(drink) << (drink.isAlcoholic ? "true" : "false") << endl;

    return out;
}

ofstream& operator<<(ofstream& file, const Drink& drink)
{
    file << static_cast<const Dish&>(drink) << drink.isAlcoholic << ";" << endl;
    return file;
}

istream& operator>>(istream& in, Drink& drink)
{
    drink.LoadCout(in, drink, false);

    cout << "\nIs alcoholic \n0 - no\n1 - yes\n\n>> ";
    in >> drink.isAlcoholic;
    cout << endl;
    return in;
}

ifstream& operator>>(ifstream& file, Drink& drink)
{
    bool last = drink.LoadFile(file, drink, true);
    drink.isAlcoholic = last;

    return file;
}
