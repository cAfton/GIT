#include "Order.h"

Order::Order(string orderId, string customerName, double totalAmount)
{
	this->orderId = orderId;
	this->customerName = customerName;
	this->totalAmount = totalAmount;
}

Order::Order(){}

void Order::setId(string orderId)
{
	this->orderId = orderId;
}

string Order::getOrderId()
{
	return this->orderId;
}

string Order::getName()
{
	return this->customerName;
}

double Order::getAmount()
{
	return this->totalAmount;
}

ostream& operator<<(ostream& out, const Order& order)
{
	out << "ID: " << order.orderId;
	out << ", customer name: " << order.customerName;
	out << ", items: [";
	for_each(order.items.begin(), order.items.end(), [&out, order](string ord) {
		out << ord;
		if (*(order.items.end() - 1) != ord)
		{
			out << ", ";
		}
		});
	out << "], total amount: " << order.totalAmount << "grn" << endl;

	return out;
}

istream& operator>>(istream& in, Order& order)
{
	order.items.clear();
	
	cout << "\nCustomer name: ";
	in >> order.customerName;
	cout << "\nEnter the number of items: ";
	int num; string item;
	cin >> num;
	for (size_t i = 0; i < num; i++)
	{ 
		cout << "item " << i + 1 << ": ";
		in >> item;
		cout << endl;

		order.items.push_back(item);
	 }
	cout << "\nTotal amount: ";
	in >> order.totalAmount;

	return in;
}
