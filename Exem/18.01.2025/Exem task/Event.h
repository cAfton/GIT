#pragma once
#include <iostream>
#include <string>
#include <vector>
#include <algorithm>
#include <fstream>

using namespace std;

class Event
{
	string title; //�����
	string date; //����(������ YYYY-MM-DD)
	string time; //���(HH:MM)
	string location;//���������
	string description;//���������

public:
	Event();
	Event(string title, string date, string time, string location, string description);

	string Title();

	string Date();

	void Title(string title);

	void Date(string date);






	friend istream& operator>>(istream& in, Event& event);

	friend ostream& operator<<(ostream& out, const Event& event);

	//~Event();


};
