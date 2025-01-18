#pragma once
#include "Dish.h"

class Drink: public Dish
{
	bool isAlcoholic;
public:
	Drink();

	Drink(string Name, string Category, int Weight, double Price, bool IsAlcoholic) : Dish(Name, Category, Weight, Price), isAlcoholic(IsAlcoholic){}

	void setCategory(string newCategory);
};
