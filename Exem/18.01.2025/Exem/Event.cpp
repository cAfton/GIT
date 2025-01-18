#include "Event.h"

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
	int 
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
