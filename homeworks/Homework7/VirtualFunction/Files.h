#pragma once
#include <iostream>
#include <fstream>
#include <bitset>
#include <string>

using namespace std;


class File {
public:

    void openFile(ifstream& file, string path);

    void closeFile(ifstream& file);

    virtual void Display(string path);


};

class FileASCII : public File {
public:

    void Display(string path) override;
};


class FileBit : public File {
public:

    void Display(string path) override;
};