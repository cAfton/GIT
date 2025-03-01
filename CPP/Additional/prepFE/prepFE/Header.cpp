#include "Header.h"

Prep::Prep()
{

}

Prep::Prep(string strN, string strE, int tni, bool isTF): strName(strN), strElse(strE), tni(tni), isTF(isTF)
{
}

string Prep::getName()
{
	return this->strName;
}

void Prep::setName(string n)
{
	this->strName = n;
}

void Prep::setElse(string e)
{
	this->strElse = e;
}

void Prep::setTni(int t)
{
	this->tni = t;
}

void Prep::setIsTF(int i)
{
	this->isTF = i;
}

istream& operator>>(istream& in, Prep& prep)
{

	
	cout << "\nElse: ";
	cin.ignore();
	getline(in, prep.strElse);
	cout << "\nInt: ";
	in >> prep.tni;
	cout << "\nBool \n0 - false\n1 - true\n\n>> ";
	in >> prep.isTF;
	cout << endl;

	return in;
}

ostream& operator<<(ostream& out, const Prep& prep)
{
	out << "Name: " << prep.strName << endl;
	out << "Else: " << prep.strElse << endl;
	out << "Int: " << prep.tni << endl;
	out << "Bool: ";
	if (prep.isTF)
		out << "true" << endl;
	else
		out << "false" << endl;

	return out;
}

ofstream& operator<<(ofstream& file, const Prep& prep)
{
	file << prep.strName << ";" << prep.strElse << ";" << prep.tni << ";" << prep.isTF << ";";

	return file;
}

ifstream& operator>>(ifstream& file, Prep& prep)
{
	string line;
	getline(file, line);

	auto it1 = find(line.begin(), line.end(), ';');
	prep.strName = string(line.begin(), it1);
	it1++;

	auto it2 = find(it1, line.end(), ';');
	prep.strElse = string(it1, it2);
	it1 = it2 + 1;

	it2 = find(it1, line.end(), ';');
	prep.tni = stoi(string(it1, it2));
	it1 = it2 + 1;

	it2 = find(it1, line.end(), ';');
	prep.isTF = stoi(string(it1, it2));


	return file;
}
