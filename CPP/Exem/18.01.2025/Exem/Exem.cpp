#include "Event.h"

bool SortChronological(Event& event1, Event& event2) {
	return event2 > event1;
}

bool SortAntichronological(Event& event1, Event& event2) {
	return event1 > event2;
}

int main()
{
	vector<Event> calendar;
	string filepath = "Event.txt";
	ifstream file;

	file.open(filepath);
	if (!file.is_open())
	{
		return 0;
	}

	string line;

	while (!file.eof())
	{
		Event event;
		file >> event;
		calendar.push_back(event);
	}
	file.close();

	int userChoice;
	while (true)
	{
		cout << "1 - Add a new event\n2 - Find an event\n3 - Show all\n4 - Edit event\n5 - Delete event\n6 - Show all events in chronological order\n0 - exit" << endl;
		cin >> userChoice;
		if (userChoice == 1)
		{
			Event newEvent;
			string newName;
			cout << "Enter a name for the new event: ";
			cin >> newName;
			auto it = find_if(calendar.begin(), calendar.end(), [newName](Event tmpEvent) {return tmpEvent.Title() == newName; });
			if (it == calendar.end())
			{
				newEvent.Title(newName);
				cin >> newEvent;
			}
			else
			{
				do
				{
					cout << "Name already exist. Please try another one: ";
					cin >> newName;
					it = find_if(calendar.begin(), calendar.end(), [newName](Event tmpEvent) {return tmpEvent.Title() == newName; });

				} while (it != calendar.end());
				newEvent.Title(newName);

				cin >> newEvent;
			}

			calendar.push_back(newEvent);
		}
		else if (userChoice == 2) {
			while (true)
			{
				cout << "Search by name or date?:";
				string choice;
				cin >> choice;
				if (choice == "name")
				{
					string nameToSearch;
					cout << "\nEnter the name you want to search for:";
					cin >> nameToSearch;

					auto it = find_if(calendar.begin(), calendar.end(), [nameToSearch](Event tmpEvent) {return tmpEvent.Title() == nameToSearch; });

					if (it == calendar.end())
					{
						int choice;
						cout << "An event with that name does not exist, please try again or add it in the main menu. (Enter 0 to exit to the main menu, 1 to continue):";
						cin >> choice;
						if (choice == 0)
							break;
						else
							continue;
					}
					else
					{
						cout << *it;
						break;
					}
				}
				else if (choice == "date")
				{
					string dateToSearch;
					cout << "\nEnter the date(YYYY-MM-DD) you want to search for:";
					cin >> dateToSearch;

					auto it = find_if(calendar.begin(), calendar.end(), [dateToSearch](Event tmpEvent) {return tmpEvent.Title() == dateToSearch; });

					if (it == calendar.end())
					{
						int choice;
						cout << "An event with that date does not exist, please try again or add it in the main menu. (Enter 0 to exit to the main menu, 1 to continue):";
						cin >> choice;
						if (choice == 0)
							break;
						else
							continue;
					}
					else
					{
						cout << *it;
						break;
					}
				}
				else
				{
					int choice;
					cout << "\nEnter \"name\" to search by name or \"date\" to search by date. Enter 1 to continue and 0 to exit to the main menu:";
					cin >> choice;
					if (choice == 0)
						break;
					else
						continue;
				}
			}
			system("pause");
		}
		else if (userChoice == 3) {
			for_each(calendar.begin(), calendar.end(), [](Event tmpEvent) {cout << tmpEvent << endl; });
		}
		else if (userChoice == 4)
		{
			string findWho;

			cout << "Enter the name of the event you want to edit: ";
			cin >> findWho;
			auto findIt = find_if(calendar.begin(), calendar.end(), [findWho](Event tmpEvent) {return tmpEvent.Title() == findWho; });
			while (true)
			{
				if (findIt != calendar.end())
				{
					cout << "\n1 - Name\n2 - Date\n3 - Time\n4 - Location\n5 - Description\n0 - That's all." << endl;
					cin >> userChoice;
					if (userChoice == 1)
					{
						string Title;
						cout << "\nNew name: ";
						cin >> Title;
						(*findIt).Title(Title);
					}
					else if (userChoice == 2)
					{
						string Date;
						cout << "\nNew else: ";
						getline(cin, Date);
						(*findIt).Date(Date);
					}
					else if (userChoice == 3)
					{
						string Time;
						cout << "\nNew Time: ";
						cin >> Time;
						(*findIt).Time(Time);
					}
					else if (userChoice == 4)
					{
						string Location;
						cout << "\nNew Location: ";
						cin >> Location;
						(*findIt).Location(Location);
					}
					else if (userChoice == 5) {
						string Description;
						cout << "\nNew Description: ";
						cin >> Description;
						(*findIt).Description(Description);
					}
					else if (userChoice == 0)
						break;
				}
				else {
					cout << "Didnt find" << endl;
				}
			}
			
		}
		else if (userChoice == 5) {
			cout << "\n\nEnter name: ";
			string Title;
			cin >> Title;
			auto findIt = find_if(calendar.begin(), calendar.end(), [Title](Event tmpEvent) {return tmpEvent.Title() == Title; });
			if (findIt != calendar.end()) {
				calendar.erase(findIt);
				cout << "Deleted successfully" << endl;
			}
			else {
				cout << "Didnt find";
			}
		}
		else if (userChoice == 6) {
			int choice;
			cout << "How to sort?(1-Chronological||2-Antichronological):";
			cin >> choice;
			if (choice == 1)
				sort(calendar.begin(), calendar.end(), SortChronological);

			else if (choice == 2)
				sort(calendar.begin(), calendar.end(), SortAntichronological);
			else
				continue;
			for_each(calendar.begin(), calendar.end(), [](Event tmpEvent) {cout << tmpEvent.Date() << endl; });
		}
		else if (userChoice == 0) {
			ofstream file;

			file.open(filepath);
			if (!file.is_open())
			{
				return 0;
			}
			int tmp = 0;
			for_each(calendar.begin(), calendar.end(), [&file, calendar, &tmp](Event tmpEvent) {

				file << tmpEvent;
				if (tmp < calendar.size() - 1)
				{
					file << endl;
				}
				tmp++;
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
		system("pause");
		system("cls");
	}

}
