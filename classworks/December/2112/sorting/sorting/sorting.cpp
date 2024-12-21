#include <iostream>
#include <string>
#include <algorithm>
using namespace std;

class Array{
    int* arr;
    int size;
    int memory;
public:
    Array(){
        this->arr = new int[5];
        this->size = 0;
        this->memory = 5;
    }
    Array(int* Array, int M, int S) {
        this->memory = M;
        this->size = S;
        for (size_t i = 0; i < S; i++)
        {
            this->arr[i] = Array[i];
        }
        
    }
    ~Array() {
        cout << "end" << endl;
        delete[] arr;
    }

    int operator[] (int index) {
        for (size_t i = 0; i < this->size; i++)
        {
            if (i == index)
            {
                return this->arr[i];
            }
        }
    }

    void Add(int Elem, int Pos) {
        if (this->size == this->memory)
        {
            memory += 5;
            int* temp = new int[memory];
            bool isAdded = false;
            for (size_t i = 0; i < this->size + 1; i++)
            {
                if (i == Pos)
                {
                    temp[i] = Elem;
                    isAdded = true;
                }
                else if (isAdded)
                {
                    temp[i] = this->arr[i - 1];
                }
                else {
                    temp[i] = this->arr[i];
                }
            }
            delete[] this->arr;
            this->arr = temp;
            size++;
        }
        else {
            if (Pos == this->size)
            {
                arr[Pos] = Elem;
                this->size++;
                return;
            }
            else if (Pos == this->size - 1)
            {
                arr[size] = arr[size - 1];
                arr[Pos] = Elem;
                this->size++;
                return;
            }
            int t = arr[Pos];
            arr[Pos] = Elem;
            int temp = arr[Pos + 1];
            for (size_t i = Pos + 1; i < this->size + 1; i++)
            {
                arr[i] = t;
                t = temp;
                if (i == this->size) {
                    arr[i + 1] = t;
                    this->size++;
                    return;
                }
                else {
                    temp = arr[i + 1];
                }

            }
        }
    }

    int getSize() {
        return this->size;
    }

    void Del() {

    }
};


int main()
{
    Array arra;
    arra.Add(1, 0);
    arra.Add(2, 1);
    arra.Add(3, 2);
    arra.Add(4, 3);
    arra.Add(5, 4);
    arra.Add(7, 2);

    for (int i = 0; i < 6; i++)
    {
        cout << arra[i] << endl;
    }
}
