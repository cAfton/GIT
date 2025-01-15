#include "Functions.h"

int main()
{
    vector<Car> cars;
    string filename = "cars.txt";
    readFromFile(cars, filename);

    string query;
    int userChoice = -1;
    do {
        system("cls");
        cout << "1 - add new car\n2 - delete car\n3 - view cars\n4 - sort by...\n5 - find by...\n6 - save to file\n7 - load from file\n0 - exit\n" << endl;
        cin >> userChoice;
        system("cls");

        switch (userChoice) {
        case 1:
            addNewCar(cars);
            break;
        case 2:
            deleteCar(cars);
            break;
        case 3:
            viewCar s(cars);
            system("pause");
            break;
        case 4:
            cout << "Sort by\n\n1 - name\n2 - year\n3 - volume\n4 - price\n" << endl;
            cin >> userChoice;
            sortBy(cars, userChoice);
            system("pause");
            break;
        case 5:
            cout << "Find by\n\n1 - name\n2 - year\n3 - volume\n4 - price\n" << endl;
            cin >> userChoice;
            cin.ignore();
            cout << "Enter value to search for: ";
            
            getline(cin, query);
            findBy(cars, userChoice, query);
            system("pause");
            break;
        case 6:
            writeToFile(cars, filename);
            system("pause");
            break;
        case 7:
            readFromFile(cars, filename);
            system("pause");
            break;
        case 0:
            writeToFile(cars, filename);
            break;
        default:
            cout << "Invalid choice, try again.\n";
            system("pause");
            break;
        }
    } while (userChoice != 0);
}
