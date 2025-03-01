#include <iostream>
#include <string>
#include <algorithm>
#include <thread>
#include <vector>

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
    Array(int M) {
        this->memory = M;
        this->arr = new int[this->memory];
        this->size = 0;
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

    Array(Array&& copy) : arr(copy.arr), size(copy.size), memory(copy.memory) {
        copy.arr = nullptr;
        copy.size = 0;
        copy.memory = 0;
    }

    Array& operator=(Array& arr) {
        this->arr = arr.arr;
        this->size = arr.size;
        this->memory = arr.memory;

        return *this;
    }
    Array& operator=(Array&& arr) {
        this->arr = arr.arr;
        this->size = arr.size;
        this->memory = arr.memory;
        arr.arr = nullptr;
        arr.size = 0;
        arr.memory = 0;
        return *this;
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


void selectionSort(Array& array) {
    for (int smalestIndex = 0; smalestIndex < array.getSize() - 1; smalestIndex++)
    {
        int smalestElem = smalestIndex;

        for (size_t currentIndex = smalestElem+1; currentIndex < array.getSize(); currentIndex++)
        {
            if (array[smalestElem] > array[currentIndex]) {
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

Array BusketSort(Array& arr) {
    int max = arr[0], min = arr[0];
    for (size_t i = 0; i < arr.getSize(); i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        else if (arr[i] < min) {
            min = arr[i];
        }
    }

    Array arr1;//min -> min + (max - min)/3
    Array arr2;//min + (max - min)/3 -> min + (2(max - min)) / 3
    Array arr3;//min + (2(max - min)) / 3 -> max

    for (size_t i = 0; i < arr.getSize(); i++)
    {
        if (arr[i] >= min && arr[i] < min + ((max - min) / 3))
        {
            arr1.Add(arr[i], arr1.getSize());
        }
        else if (arr[i] >= min + ((max - min) / 3) && arr[i] < min + ((2 * (max - min)) / 3)) {
            arr2.Add(arr[i], arr2.getSize());
        }
        else {
            arr3.Add(arr[i], arr3.getSize());
        }
    }

    Array* arras = new Array[3];
    arras[0] = arr1;
    arras[1] = arr2;
    arras[2] = arr3;

    vector<thread> threads;

    for (size_t i = 0; i < 3; i++)
    {
        threads.emplace_back([&arras, i]() {selectionSort(arras[i]); });
    }
    for (auto& thread : threads) { thread.join(); }

    Array sorted(arr.getSize());
    for (size_t i = 0; i < arr1.getSize(); i++)
    {
        sorted.Add(arr1[i], sorted.getSize());
    }
    for (size_t i = 0; i < arr2.getSize(); i++)
    {
        sorted.Add(arr2[i], sorted.getSize());
    }
    for (size_t i = 0; i < arr3.getSize(); i++)
    {
        sorted.Add(arr3[i], sorted.getSize());
    }
   return sorted;
    
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
    for (size_t i = 0; i < arra.getSize(); i++)
    {
        cout << arra[i] << ", ";
    }

    Array newArr = BusketSort(arra);

    for (size_t i = 0; i < arra.getSize(); i++)
    {
        cout << newArr[i] << ", ";
    }





}
