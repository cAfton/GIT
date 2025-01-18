#pragma once
#include "Car.h"
#include <fstream>

void findBy(const vector<Car>& cars, int userChoice, const string& query) {
    vector<Car> results;
    if (userChoice == 1) { // Пошук за ім'ям
        copy_if(cars.begin(), cars.end(), back_inserter(results), [&query](const Car& car) {
            return car.getName() == query;
            });
    }
    else if (userChoice == 2) { // Пошук за роком
        int year = stoi(query);
        copy_if(cars.begin(), cars.end(), back_inserter(results), [year](const Car& car) {
            return car.getYear() == year;
            });
    }
    else if (userChoice == 3) { // Пошук за об'ємом
        int volume = stoi(query);
        copy_if(cars.begin(), cars.end(), back_inserter(results), [volume](const Car& car) {
            return car.getVolume() == volume;
            });
    }
    else if (userChoice == 4) { // Пошук за ціною
        int price = stoi(query);
        copy_if(cars.begin(), cars.end(), back_inserter(results), [price](const Car& car) {
            return car.getPrice() == price;
            });
    }

    if (results.empty()) {
        cout << "No matching cars found.\n";
    }
    else {
        for (const auto& car : results) {
            cout << car << endl << endl;
        }
    }
}

void writeToFile(const vector<Car>& cars, const string& filename) {
    ofstream file(filename);
    if (!file) {
        cerr << "Error opening file for writing.\n";
        return;
    }
    for (const auto& car : cars) {
        file << car.getName() << " " << car.getYear() << " " << car.getVolume() << " " << car.getPrice() << "\n";
    }
    file.close();
    cout << "Data successfully written to file.\n";
}

void readFromFile(vector<Car>& cars, const string& filename) {
    ifstream file(filename);
    if (!file) {
        cerr << "Error opening file for reading.\n";
        return;
    }
    cars.clear();
    string name;
    int year, volume, price;
    while (file >> name >> year >> volume >> price) {
        cars.emplace_back(name, year, volume, price);
    }
    file.close();
    cout << "Data successfully loaded from file.\n";
}

void addNewCar(vector<Car>& cars) {
    Car newCar;
    cin >> newCar;

    cars.push_back(newCar);
}

void viewCars(const vector<Car>& cars) {
    for_each(cars.begin(), cars.end(), [](Car car) {cout << car << endl << endl; });
}

void deleteCar(vector<Car>& cars) {
    Car carToFind;
    cout << "Enter information about car to delete: \n" << endl;
    cin >> carToFind;
    auto it = find(cars.begin(), cars.end(), carToFind);
    cars.erase(it);
}

void sortBy(vector<Car>& cars, int userChoise) {
    if (userChoise == 1)
    {
        sort(cars.begin(), cars.end(), [](Car car1, Car car2) {return car1.getName() > car2.getName(); });
    }
    else if (userChoise == 2) {
        sort(cars.begin(), cars.end(), [](Car car1, Car car2) {return car1.getYear() > car2.getYear(); });
    }
    else if (userChoise == 3) {
        sort(cars.begin(), cars.end(), [](Car car1, Car car2) {return car1.getVolume() > car2.getVolume(); });
    }
    else if (userChoise == 4) {
        sort(cars.begin(), cars.end(), [](Car car1, Car car2) {return car1.getPrice() > car2.getPrice(); });
    }

    viewCars(cars);
}