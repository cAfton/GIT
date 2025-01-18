#include "Event.h"

bool Event::isFirstDateGreater(string& date1, string& date2)
{
	if (date1.substr(0, 4) > date2.substr(0, 4)) {
		return true;
	}
	else if (date1.substr(0, 4) < date2.substr(0, 4)) {
		return false;
	}

	if (date1.substr(5, 2) > date2.substr(5, 2)) {
		return true;
	}
	else if (date1.substr(5, 2) < date2.substr(5, 2)) {
		return false;
	}

	return date1.substr(8, 2) > date2.substr(8, 2);
}

Event::Event()
{
	/*this->title = "Null";
	this->date = "Null";
	this->time = "Null";*/
}

Event::Event(string title, string date, string time, string location, string description)
{
	this->title = title;
	this->date = date;
	this->time = time;
	this->location = location;
	this->description = description;
}

string Event::Title()
{
	return this->title;
}

string Event::Date()
{
	return this->date;;
}

string Event::Time()
{
	return this->time;
}

string Event::Location()
{
	return this->location;
}

string Event::Description()
{
	return this->description;
}

void Event::Title(string title)
{
	this->title = title;
}

void Event::Date(string date)
{
	this->date = date;
}

void Event::Time(string time)
{
	this->time = time;
}

void Event::Location(string location)
{
	this->location = location;
}

void Event::Description(string description)
{
	this->description = description;
}



bool Event::operator>(Event& other)
{
	return isFirstDateGreater(this->date, other.date);
}

istream& operator>>(istream& in, Event& event)
{
	cout << "\nDate(YYYY-MM-DD): ";
	cin.ignore();
	getline(in, event.date);

	cout << "\nTime(HH:MM): ";
	in >> event.time;

	cout << "\nlocation: ";
	in >> event.location;

	cout << "\ndescription: ";
	in >> event.description;

	cout << endl;

	return in;
}

ostream& operator<<(ostream& out, const Event& event)
{
	out << "Name: " << event.title << endl;
	out << "Date: " << event.date << endl;
	out << "Time: " << event.time << endl;
	out << "location: " << event.location << endl;
	out << "description: " << event.description << endl;

	return out;
}

ofstream& operator<<(ofstream& file, const Event& event)
{
	file << event.title << ";" << event.date << ";" << event.time << ";" << event.location << ";" << event.description << ";";

	return file;
}

ifstream& operator>>(ifstream& file, Event& event)
{
	string line;
	getline(file, line);

	auto it1 = find(line.begin(), line.end(), ';');
	event.title = string(line.begin(), it1);
	it1++;

	auto it2 = find(it1, line.end(), ';');
	event.date = string(it1, it2);
	it1 = it2 + 1;

	it2 = find(it1, line.end(), ';');
	event.time = string(it1, it2);
	it1 = it2 + 1;

	it2 = find(it1, line.end(), ';');
	event.location = string(it1, it2);
	it1 = it2 + 1;

	it1 = find(it2, line.end(), ';');
	event.description = string(it2, it1);

	return file;
}
