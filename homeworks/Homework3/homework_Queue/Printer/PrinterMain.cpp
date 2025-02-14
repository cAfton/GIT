#include "Printer.h"

int main()
{

    Queue queue;
    Client client1("name1", 1, "12:34   18/10/2024");
    Client client2("name2", 2, "12:45   18/10/2024");
    Client client3("name3", 3, "12:58   18/10/2024");
    Client client4("name4", 4, "12:40   18/10/2024");
    Client client5("name5", 5, "13:55   19/10/2024");
    Client client6("name6", 6, "14:34   19/10/2024");

    queue.push(client1);
    queue.push(client2);
    queue.push(client3);
    queue.push(client4);
    queue.push(client5);
    queue.push(client6); 

    cout << queue << endl;

    cout << queue.peek().getName() << " //// ";
    cout << queue.peek().getPriority() << " //// ";
    cout << queue.peek().getTime() << endl;


    try {
        cout << queue.pop() << endl;
        cout << queue.pop() << endl;
        cout << queue.pop() << endl;
        cout << queue.pop() << endl;
        cout << queue.pop() << endl;
        cout << queue.pop() << endl;
        cout << queue.pop() << endl;
        cout << queue.pop() << endl;
        cout << queue.pop() << endl;
        cout << queue.pop() << endl;
        cout << queue.pop() << endl;
        cout << queue.pop() << endl;
        cout << queue.pop() << endl;
        cout << queue.pop() << endl;
        cout << queue.pop() << endl;
        cout << queue.pop() << endl;
        cout << queue.pop() << endl;
        cout << queue.pop() << endl;
        cout << queue.pop() << endl;
        cout << queue.pop() << endl;
        cout << queue.pop() << endl;
        cout << queue.pop() << endl;
        cout << queue.pop() << endl;
        cout << queue.pop() << endl;
    }
    catch(runtime_error){
        cout << "error poping" << endl;
    }
}

