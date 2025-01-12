#pragma once
#include <iostream>
#include <vector>
#include <string>
#include <algorithm>

using namespace std;


class Order
{
    string orderId;
    string customerName;
    vector<string> items;
    double totalAmount;
public:
	Order(string orderId, string customerName, double totalAmount);

    Order();

    friend ostream& operator<<(ostream& out, const Order& order);
    
    friend istream& operator>>(istream& in, Order& order);

    string getOrderId();

    string getName();

    double getAmount();


};