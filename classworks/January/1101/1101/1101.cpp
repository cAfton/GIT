#include <iostream>
#include <fstream>
#include <vector>
#include <string>
#include <algorithm>

using namespace std;

class User {
    string login;
    string password;
public:

    User(string name, string pass): login(name), password(pass){}

    bool LogIn(string log, string pass){
        if (this->login == log && this->password == pass)
        {
            return true;
        }
        else {
            return false;
        }
    }
    void printUser() {
        cout << this->login << endl;
        cout << this->password << endl;
    }

    ~User() {
        cout << "User dest" << endl;
    }
};

class Admin : public User {
public:
    Admin(string name, string pass) : User(name, pass) {};


    ~Admin() {
        cout << "Admin dest" << endl;
    }
};

class CommonUser : public User {
public:
    CommonUser(string name, string pass) : User(name, pass) {};

    ~CommonUser() {
        cout << "CommonUser dest" << endl;
    }
};

class BlockedUser : public User {
public:
    BlockedUser(string name, string pass) : User(name, pass) {};

    ~BlockedUser() {
        cout << "BlockedUser dest" << endl;
    }
};

int main()
{
    vector<User*> users;
    ifstream file;
    file.open("users.txt");

    if (!file.is_open())
    {
        return 0;
    }

    string line;
    getline(file, line);
    while (!file.eof())
    {
        getline(file, line);
        if (line == "admin")
        {
            string login, pass;

            while (true)
            {
                getline(file, line);
                if (line != "-")
                {
                    login = line;
                }
                else {
                    break;
                }
                getline(file, line);
                if (line != "-")
                {
                    pass = line;
                }
                else {
                    break;
                }

                

                users.push_back(new Admin(login, pass));
            }
        }
        else if (line == "user")
        {
            string login, pass;

            while (true)
            {
                getline(file, line);
                if (line != "-")
                {
                    login = line;
                }
                else {
                    break;
                }
                getline(file, line);
                if (line != "-")
                {
                    pass = line;
                }
                else {
                    break;
                }


                users.push_back(new CommonUser(login, pass));
            }
        }
        else if(line == "blocked") {
            string login, pass;

            while (true)
            {
                getline(file, line);
                if (line != "-")
                {
                    login = line;
                }
                else {
                    break;
                }
                getline(file, line);
                if (line != "-")
                {
                    pass = line;
                }
                else {
                    break;
                }


                users.push_back(new BlockedUser(login, pass));
            }
        }
    }

    for_each(users.begin(), users.end(), [](auto user) {user->printUser(); });

    string name, password;

    cout << "please enter name: ";
    cin >> name;
    cout << "please enter password: ";
    cin >> password;

    auto it = find_if(users.begin(), users.end(), [name, password](auto user) { return user->LogIn(name, password); });
    bool entered = false;

    if (it != users.end())
    {
        BlockedUser* Bloc = static_cast<BlockedUser*> (*it);
        if (Bloc == nullptr)
        {
            entered = true;
        }
        else {
            cout << "you are blocked" << endl;
        }

    }


    
    cout << entered << endl;

    
}