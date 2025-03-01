#pragma once
#include "Dish.h"

class Meal: public Dish {
public:
	void virt() override;

	friend ostream& operator<<(ostream& out, const Meal& meal);

	friend ofstream& operator<<(ofstream& file, const Meal& meal); //запис в файл

	friend istream& operator>>(istream& file, Meal& meal);

	friend ifstream& operator>>(ifstream& file, Meal& meal);
};