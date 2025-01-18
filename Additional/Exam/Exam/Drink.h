#pragma once
#include "Dish.h"

class Drink: public Dish
{
	bool isAlcoholic;
public:
	Drink();

	Drink(string Name, int Weight, double Price, bool IsAlcoholic);

	void virt() override;

	friend ostream& operator<<(ostream& out, const Drink& drink);

	friend ofstream& operator<<(ofstream& file, const Drink& drink); //запис в файл

	friend istream& operator>>(istream& file, Drink& drink);

	friend ifstream& operator>>(ifstream& file, Drink& drink);

	bool getAlc() {
		return this->isAlcoholic;
	}
};
