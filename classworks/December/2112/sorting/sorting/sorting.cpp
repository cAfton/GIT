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

    void Swap(int a, int b) {
        int temp = this->arr[a];
        this->arr[a] = this->arr[b];
        this->arr[b] = temp;
    }

    int getSize() {
        return this->size;
    }

    void Del() {

    }
};

//Знаходимо наймений елемент масиву і закидаємо його на початок
//Тоді шукаємо наступний найменший елемент і ставимо його на друге місце
//Повторюємо до останього елементу


void selectionSort(Array& array) {
    for (int smalestIndex = 0; smalestIndex < array.getSize() - 1; smalestIndex++)
    {
        int smalestElem = smalestIndex;

        for (size_t currentIndex = smalestElem+1; currentIndex < array.getSize(); currentIndex++)
        {
            if (array[smalestElem] < array[currentIndex]) {
                smalestElem = currentIndex;
            }
        }
        array.Swap(smalestIndex, smalestElem);
    }

}

void selectionSortByNazarchik(Array& array) {
    int mainIndex = 0;
    while (mainIndex != array.getSize() - 1) {
        int indexOfSmalestElem = mainIndex;
        for (size_t currentIndex = mainIndex;  currentIndex  < array.getSize();  currentIndex ++)
        {
            if (array[currentIndex] < array[indexOfSmalestElem])
                indexOfSmalestElem = currentIndex;
        }
        array.Swap(mainIndex, indexOfSmalestElem);
        mainIndex++;
    }
}

int main()
{
    Array arra;
    arra.Add(2, 0);
    arra.Add(1, 1);
    arra.Add(10, 2);
    arra.Add(4, 3);
    arra.Add(8, 4);
    arra.Add(7, 2);

    arra.Swap(0, 3);


    for (int i = 0; i < arra.getSize(); i++)
    {
        cout << arra[i] << endl;
    }

    cout << endl;

    selectionSort(arra);

    for (int i = 0; i < arra.getSize(); i++)
    {
        cout << arra[i] << endl;
    }

    cout << endl;

    selectionSortByNazarchik(arra);

    for (int i = 0; i < arra.getSize(); i++)
    {
        cout << arra[i] << endl;
    }
}
