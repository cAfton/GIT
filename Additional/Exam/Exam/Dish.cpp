#include "Dish.h"

Dish::Dish(){}

Dish::Dish(string Name, string Category, int Weight, double Price): name(Name), category(Category), weight(Weight), price(Price) {}

void Dish::PrintFile(ofstream& file, const Dish& dish) const
{
	file << dish.name << ";" << dish.category << ";" << dish.weight << ";" << dish.price << ";";
}

void Dish::PrintCout(ostream& out, const Dish& dish) const
{
	out << "Name: " << dish.name << endl;
	out << "Category: " << dish.category << endl;
	out << "Weight: " << dish.weight << endl;
	out << "Price: " << dish.price << endl;
}

bool Dish::LoadFile(ifstream& file, Dish& dish, bool toDo)
{
	string line, temp;
	getline(file, line);

	auto it1 = find(line.begin(), line.end(), ';');
	dish.name = string(line.begin(), it1);
	it1++;

	auto it2 = find(it1, line.end(), ';');
	dish.category = string(it1, it2);
	it1 = it2 + 1;

	it2 = find(it1, line.end(), ';');
	dish.weight = stoi(string(it1, it2));
	it1 = it2 + 1;

	it2 = find(it1, line.end(), '-');
	temp = string(it1, it2);
	dish.price = stod(temp);
	
	if (toDo)
	{
		it1 = it2 + 1;

		it2 = find(it1, line.end(), '-');
		temp = string(it1, it2);
		toDo = stoi(temp);
	}

	return toDo;
}

void Dish::LoadCout(istream& in, Dish& dish, bool is)
{
	if (is)
	{
		cout << "\nCategory: ";
		cin.ignore();
		getline(in, dish.category);
	}
	else {
		dish.category = "drink";
	}
	
	cout << "\nWeight: ";
	in >> dish.weight;
	cout << "\nPrice: ";
	in >> dish.price;
	cout << endl;

}


string Dish::getName()
{
	return this->name;
}

string Dish::getCategory()
{
	return this->category;
}

void Dish::setName(string newName)
{
	this->name = newName;
}

void Dish::setWeight(int newWeight)
{
	this->weight = newWeight;
}

void Dish::setPrice(double newPrice)
{
	this->price = newPrice;
}

istream& operator>>(istream& in, Dish& dish)
{
	dish.LoadCout(in, dish, true);
	return in;
}

ostream& operator<<(ostream& out, const Dish& dish)
{
	dish.PrintCout(out, dish);

	return out;
}

ofstream& operator<<(ofstream& file, const Dish& dish)
{
	dish.PrintFile(file, dish);

	return file;
}

ifstream& operator>>(ifstream& file, Dish& dish)
{
	

	return file;
}
