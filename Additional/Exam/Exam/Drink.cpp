#include "Drink.h"
#include "Meal.h"

Drink::Drink(string Name, int Weight, double Price, bool IsAlcoholic) : Dish(Name, "Drink", Weight, Price), isAlcoholic(IsAlcoholic) {}


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
    drink.LoadCout(in, drink);

    cout << "\nBool \n0 - false\n1 - true\n\n>> ";
    in >> drink.isAlcoholic;
    cout << endl;
    return in;
}

ifstream& operator>>(ifstream& file, Drink& drink)
{
    string last = drink.LoadFile(file, drink);
    auto it3 = find(last.begin(), last.end(), '-');
    auto it4 = find(last.begin(), last.end(), '-');

    string is = string(it3, it4);
    drink.isAlcoholic = stoi(is);

    return file;
}
