#pragma once
#include <iostream>
#include <string>
#include <vector>
#include <fstream>
#include <algorithm>

using namespace std;


class Dish {
	string name;
	string category;
	int weight;
	double price;
public:

	Dish();

	Dish(string Name, string Category, int Weight, double Price);

	friend istream& operator>>(istream& in, Dish& dish);

	friend ostream& operator<<(ostream& out, const Dish& dish);

	friend ofstream& operator<<(ofstream& file, const Dish& dish);

	friend ifstream& operator>>(ifstream& file, Dish& dish); //запис з файлу

	void PrintFile(ofstream& file, const Dish& dish) const;

	void PrintCout(ostream& out, const Dish& dish) const;

	bool LoadFile(ifstream& file, Dish& dish, bool toDo);

	void LoadCout(istream& in, Dish& dish, bool is);

	string getName();
	string getCategory();

	void setName(string newName);
	void setWeight(int newWeight);
	void setPrice(double newPrice);

	virtual void virt() = 0;



}; 




