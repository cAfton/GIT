#pragma once
#include <iostream>
#include <string>
#include <vector>
#include <algorithm>
#include <fstream>

using namespace std;

class Prep {
	string strName;
	string strElse;
	int tni;
	bool isTF;
public:

	Prep();

	Prep(string strN, string strE, int tni, bool isTF);

	friend istream& operator>>(istream& in, Prep& prep);

	friend ostream& operator<<(ostream& out, const Prep& prep);

	friend ofstream& operator<<(ofstream& file, const Prep& prep); //запис в файл

	friend ifstream& operator>>(ifstream& file, Prep& prep); //запис з файлу

	string getName();

	void setName(string n);
	void setElse(string e);
	void setTni(int t);
	void setIsTF(int i);

};
