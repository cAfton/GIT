#include "Dish.h"

Dish::Dish(){}

Dish::Dish(string Name, string Category, int Weight, double Price): name(Name), category(Category), weight(Weight), price(Price){}

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
	cout << "\nCategory: ";
	cin.ignore();
	getline(in, dish.category);
	cout << "\nWeight: ";
	in >> dish.weight;
	cout << "\nPrice: ";
	in >> dish.price;
	cout << endl;

	return in;
}

ostream& operator<<(ostream& out, const Dish& dish)
{
	out << "Name: " << dish.name << endl;
	out << "Category: " << dish.category << endl;
	out << "Weight: " << dish.weight << endl;
	out << "Price: " << dish.price << endl;

	return out;
}

ofstream& operator<<(ofstream& file, const Dish& dish)
{
	file << dish.name << ";" << dish.category << ";" << dish.weight << ";" << dish.price << ";";

	return file;
}

ifstream& operator>>(ifstream& file, Dish& dish)
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

	it2 = find(it1, line.end(), ';');
	temp = string(it1, it2);
	dish.price = stod(temp);


	return file;
}
