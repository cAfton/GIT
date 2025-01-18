#pragma once
#include <iostream>
#include <string>
#include <vector>
#include <algorithm>
#include <fstream>

using namespace std;

class Event
{
	string title; //Назва
	string date; //дата(формат YYYY-MM-DD)
	string time; //час(HH:MM)
	string location;//Додатково
	string description;//Додатково

	bool isFirstDateGreater(string& date1, string& date2);

public:
	Event();
	Event(string title, string date, string time, string location, string description);

	string Title();

	string Date();

	string Time();

	string Location();

	string Description();

	void Title(string title);

	void Date(string date);

	void Time(string time);

	void Location(string location);

	void Description(string description);

	

	


	bool operator>(Event& other);

	friend istream& operator>>(istream& in, Event& event);

	friend ostream& operator<<(ostream& out, const Event& event);

	//~Event();


};
