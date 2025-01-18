#include "Dish.h"
#include "Meal.h"
#include "Drink.h"

int main()
{
	vector<Dish*> menu;

	ifstream file;

	file.open("menu.txt");
	if (!file.is_open())
	{
		return 0;
	}

	while (!file.eof())
	{
		Drink dish;
		file >> dish;
		menu.push_back(&dish);
	}

	file.close();

	int userChoice;
	while (true)
	{
		//cout << "1 - add new dish\n2 - erace\n3 - show all\n4 - save\n5 - load\n6 - change...\n0 - exit" << endl;
		cout << "1 - add new dish\n2 - find by name\n3 - change...\n4 - delete dish\n5 - print menu...\n6 - save\n0 - exit\n\n>>  ";
		cin >> userChoice;
		if (userChoice == 1)
		{
			Dish dish;
			string name;
			cout << "Name: ";
			cin >> name;
			auto it = find_if(menu.begin(), menu.end(), [name](Dish dish) {return dish.getName() == name; });
			if (it == menu.end())
			{
				dish.setName(name);
				cin >> dish;
			}
			else
			{
				do
				{
					cout << "name already exist. Please try another one: ";
					cin >> name;
					it = find_if(menu.begin(), menu.end(), [name](Dish dish) {return dish.getName() == name; });

				} while (it != menu.end());
				dish.setName(name);

				cin >> dish;
			}

			menu.push_back(dish);
		}
		else if (userChoice == 2)
		{
			string name;
			cout << "Name: ";
			cin >> name;
			cout << endl;
			auto findDish = find_if(menu.begin(), menu.end(), [name](Dish dish) {return dish.getName() == name; });

			cout << *(findDish) << endl;
		}
		else if (userChoice == 3)
		{
			string findDish;

			cout << "Name to change: ";
			cin >> findDish;
			auto findIt = find_if(menu.begin(), menu.end(), [findDish](Dish dish) {return dish.getName() == findDish; });
			if (findIt != menu.end())
			{
				cout << "\n1 - change price\n2 - change weight" << endl;
				cin >> userChoice;
				if (userChoice == 1)
				{
					double price;
					cout << "new price: ";
					cin >> price;
					(*findIt).setPrice(price);
				}
				else if (userChoice == 2)
				{
					int weight;
					cout << "new weight: ";
					cin >> weight;
					(*findIt).setWeight(weight);
				}
			}
			else {
				cout << "didnt find dish wigh such name" << endl;
			}
		}
		else if (userChoice == 4)
		{
			cout << "\n\nEnter name to delete: ";
			string name;
			cin >> name;
			auto findIt = find_if(menu.begin(), menu.end(), [name](Dish dish) {return dish.getName() == name; });
			if (findIt != menu.end()) {
				menu.erase(findIt);
				cout << "deleted successfully" << endl;
			}
			else {
				cout << "Didnt find dish with such name" << endl;
			}
		}
		else if (userChoice == 5)
		{
			cout << "\n1 - print by category\n2 - print all\n\n>>  ";
			cin >> userChoice;
			if (userChoice == 1)
			{
				string category;
				cout << "print category: ";
				cin.ignore();
				getline(cin, category);
				for_each(menu.begin(), menu.end(), [category](Dish dish) {
					if (dish.getCategory() == category) 
					{
						cout << dish << endl;
					} 
				});
			}
			else if (userChoice == 2)
			{
				for_each(menu.begin(), menu.end(), [](Dish dish) {cout << dish << endl; });
			}
			else {
				cout << "wrong option" << endl;
			}
			cout << endl;
		}
		else if (userChoice == 6)
		{
			ofstream file;

			file.open("menu.txt");
			if (!file.is_open())
			{
				return 0;
			}

			int c = 0;
			for_each(menu.begin(), menu.end(), [&file, menu, &c](Dish dish) {
				file << dish;
				if (c < menu.size() - 1)
				{
					file << endl;
				}
				c++;
			});

			file.close();
		}
		else if (userChoice == 0) {
			ofstream file;

			file.open("menu.txt");
			if (!file.is_open())
			{
				return 0;
			}
			int c = 0;
			for_each(menu.begin(), menu.end(), [&file, menu, &c](Dish dish) {

				file << dish;
				if (c < menu.size() - 1)
				{
					file << endl;
				}
				c++;
				});

			file.close();

			return 0;
		}

		else {
			cout << "wrong option\n\n" << endl;
		}
	}


}