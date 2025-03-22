using System;
using System.Net.Sockets;
using System.Text;

class Client
{
    static void Main()
    {
        TcpClient client = new TcpClient("127.0.0.1", 5000);
        NetworkStream stream = client.GetStream();

        while (true)  // Цикл для безперервного вводу
        {
            Console.Write("Enter message: ");
            string message = Console.ReadLine();
            if (string.IsNullOrEmpty(message)) break;  // Вихід з циклу, якщо нічого не введено

            byte[] data = Encoding.UTF8.GetBytes(message);
            stream.Write(data, 0, data.Length);
        }

        client.Close();
    }
}