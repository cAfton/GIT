#pragma once
#include "Figures.h"
#include <fstream>




class Circle : public Figures {
private:
	int R;
	int X;
	int Y;
public:
	Circle() {
		this->R = 1;
		this->X = 0;
		this->Y = 0;
	}

	Circle(int r, int x, int y) {
		this->R = r;
		this->X = x;
		this->Y = y;
	}
	string Print() {
		string ret = "Circle: " + to_string(this->R) + "\tCordinates (" + to_string(this->X) + "; " + to_string(this->Y) + ")";
		return ret;

	}

	void printInFile() {
		ofstream file(fileName);
		if (!file.is_open())
		{
			return;
		}

		file << "Circle: " << endl;
		file << this->R << endl;
		file << this->X << endl;
		file << this->Y << endl;

		file.close();
	}

	void Save(string path) {
		ofstream file(path, ios::trunc);
		if (!file.is_open())
		{
			throw runtime_error("coudn't open file");
		}

		file << this->R << endl;
		file << this->X << endl;
		file << this->Y << endl;

		file.close();

	}

	void Load(string path) {
		ifstream file(path);
		if (!file.is_open())
		{
			throw runtime_error("coudn't open file");
		}
		string save;
		getline(file, save);
		this->R = stoi(save);

		getline(file, save);
		this->X = stoi(save);

		getline(file, save);
		this->Y = stoi(save);
	}

	float Area() {
		return 3.14 * this->R * this->R;
	
	}

	float Perimetr() {
		return 2 * 3.14 * this->R;
	}

};