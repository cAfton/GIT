#include "Order.h"

int main()
{
	vector<Order> orders;
	int userChoice;
	while (true)
	{
		cout << "1. Add a new order \n2. Find an order by ID \n3. Delete order by ID \n4. Display all orders \n5. Filter orders by customer \n6. Sort orders by amount \n7. End the program\n\nYour choice: ";
		cin >> userChoice;

		if (userChoice == 1)
		{
			cout << endl;
			cout << endl;
			Order newOrder;
			cin >> newOrder;
			orders.push_back(newOrder);
			cout << endl;
			cout << endl;
		}
		else if(userChoice == 2)
		{
			cout << "\n\nEnter ID: ";
			string id;
			cin >> id;
			auto findOrder = find_if(orders.begin(), orders.end(), [id](Order order) {return order.getOrderId() == id; });
			if (findOrder != orders.end()) {
				cout << "found:   " << *findOrder << endl;
			}
			else {
				cout << "Didnt find" << std::endl;
			}
		}
		else if(userChoice == 3)
		{
			cout << "\n\nEnter ID: ";
			string id;
			cin >> id;
			auto findId = find_if(orders.begin(), orders.end(), [id](Order order) {return order.getOrderId() == id; });
			if (findId != orders.end()) {
				orders.erase(findId);
				cout << "deleted successfully" << endl;
			}
			else {
				cout << "Didnt find";
			}
		}
		else if(userChoice == 4)
		{
			cout << endl;
			cout << endl;
			for_each(orders.begin(), orders.end(), [](Order order) {cout << order; });
			cout << endl;
			cout << endl;
		}
		else if(userChoice == 5)
		{
			cout << "\n\nEnter name: ";
			string name;
			cin >> name;
			for_each(orders.begin(), orders.end(), [name](Order order) {
				if (order.getName() == name) {
					cout << "order from " << order.getName() << ": " << order.getOrderId() << endl;
				}
				});
		}
		else if(userChoice == 6)
		{
			sort(orders.begin(), orders.end(), [](Order a, Order b) {
				return a.getAmount() < b.getAmount();
			});
		}
		else if(userChoice == 7)
		{
			cout << "\n\n\nthank you for shoping!" << endl;
			return 0;
		}
		else
		{
			cout << "\n\nerror\n\n" << endl;
		}
	}

}