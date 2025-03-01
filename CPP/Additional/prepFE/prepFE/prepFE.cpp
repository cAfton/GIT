#include "Header.h"

int main()
{
	vector<Prep> vep;

	int userChoice;
	while (true)
	{
		cout << "1 - add\n2 - erace\n3 - show all\n4 - save\n5 - load\n6 - change...\n0 - exit" << endl;
		cin >> userChoice;
		if (userChoice == 1)
		{
			Prep prep;
			string n;
			cout << "Name: ";
			cin >> n;
			auto it = find_if(vep.begin(), vep.end(), [n](Prep pre) {return pre.getName() == n; });
			if (it == vep.end())
			{
				prep.setName(n);
				cin >> prep;
			}
			else
			{
				do
				{
					cout << "name already exist. Please try another one: ";
					cin >> n;
					it = find_if(vep.begin(), vep.end(), [n](Prep pre) {return pre.getName() == n; });

				} while (it != vep.end());
				prep.setName(n);

				cin >> prep;
			}

			vep.push_back(prep);
		}
		else if (userChoice == 2) {
			cout << "\n\nEnter name: ";
			string name;
			cin >> name;
			auto findIt = find_if(vep.begin(), vep.end(), [name](Prep pre) {return pre.getName() == name; });
			if (findIt != vep.end()) {
				vep.erase(findIt);
				cout << "deleted successfully" << endl;
			}
			else {
				cout << "Didnt find";
			}
		}
		else if(userChoice == 3){
			for_each(vep.begin(), vep.end(), [](Prep pre) {cout << pre << endl; });
		}
		else if (userChoice == 4)
		{
			ofstream file;

			file.open("test.txt");
			if (!file.is_open())
			{
				return 0;
			}
			int c = 0;
			for_each(vep.begin(), vep.end(), [&file, vep, &c](Prep pre) {

				file << pre;
				if (c < vep.size() - 1)
				{
					file << endl;
				}
				c++;
				});

			file.close();
		}
		else if (userChoice == 5)
		{
			ifstream file;

			file.open("test.txt");
			if (!file.is_open())
			{
				return 0;
			}
			string line = "f";

			while (!file.eof())
			{
				Prep pre;
				file >> pre;
				vep.push_back(pre);
			}
			file.close();
		}
		else if (userChoice == 6)
		{
			string findWho;

			cout << "who name: ";
			cin >> findWho;
			auto findIt = find_if(vep.begin(), vep.end(), [findWho](Prep pre) {return pre.getName() == findWho; });
			if (findIt != vep.end())
			{
				cout << "\n1 - name\n2 - else\n3 - int\n4 - bool\n" << endl;
				cin >> userChoice;
				if (userChoice == 1)
				{
					string name;
					cout << "new name: ";
					cin >> name;
					(*findIt).setName(name);
				}
				else if (userChoice == 2)
				{
					string Else;
					cout << "new else: ";
					getline(cin, Else);
					(*findIt).setElse(Else);
				}
				else if (userChoice == 3)
				{
					string tni;
					cout << "new tni: ";
					cin >> tni;
					(*findIt).setTni(stoi(tni));
				}
				else if (userChoice == 4)
				{
					int b;
					cout << "\nBool \n0 - false\n1 - true\n\n";

					cout << "new bool: ";
					cin >> b;
					(*findIt).setIsTF(b);
				}
			}
			else {
				cout << "didnt find" << endl;
			}
		}
		else if (userChoice == 0) {
			ofstream file;

			file.open("test.txt");
			if (!file.is_open())
			{
				return 0;
			}
			int c = 0;
			for_each(vep.begin(), vep.end(), [&file, vep, &c](Prep pre) {

				file << pre;
				if (c < vep.size() - 1)
				{
					file << endl;
				}
				c++;
				});

			file.close();

			return 0;
		}
		else {
			cout << endl;
			cout << endl;
			cout << endl;
			cout << endl;
			cout << endl;
		}
	}

	
}