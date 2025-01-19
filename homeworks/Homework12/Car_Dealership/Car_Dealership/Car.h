#pragma once
#include <iostream>
#include <string>
#include <vector>
#include <algorithm>

using namespace std;

class Car {
    string name;
    int year;
    int volume;
    int price;
public:
    Car();

    Car(string name, int year, int volume, int price);

    string getName() const;

    int getYear() const;

    int getVolume() const;

    int getPrice() const;

    friend ostream& operator<<(ostream& out, const Car& car);

    friend istream& operator>>(istream& in, Car& car);

    bool operator==(Car car);

};