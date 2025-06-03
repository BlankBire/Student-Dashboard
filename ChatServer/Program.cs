using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

class Program
{
    //private static List<TcpClient> clients = new List<TcpClient>(); //Broadcast
    private static Dictionary<string, TcpClient> clients = new Dictionary<string, TcpClient>();
    private static TcpListener server;

    static void Main(string[] args)
    {
        int port = 8000;
        server = new TcpListener(IPAddress.Any, port);
        server.Start();
        Console.WriteLine($"Server is running on port {port}");

        while (true)
        {
            TcpClient client = server.AcceptTcpClient();
            Console.WriteLine("Client connected");
            Thread clientThread = new Thread(() => HandleClient(client));
            clientThread.Start();
        }
    }

    private static void HandleClient(TcpClient client)
    {
        NetworkStream stream = client.GetStream();
        byte[] buffer = new byte[1024];
        string username = "";

        try
        {
            // Đọc username đầu tiên
            int nameBytes = stream.Read(buffer, 0, buffer.Length);
            username = Encoding.UTF8.GetString(buffer, 0, nameBytes).Trim();
            Console.WriteLine($"User connected: {username}");

            lock (clients)
            {
                clients[username] = client;
            }

            int bytesRead;
            while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) != 0)
            {
                string fullMessage = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                Console.WriteLine($"Received from {username}: {fullMessage}");

                string[] parts = fullMessage.Split('|');
                if (parts.Length == 2)
                {
                    string recipient = parts[0].Trim();
                    string message = parts[1].Trim();

                    if (clients.ContainsKey(recipient))
                    {
                        TcpClient recipientClient = clients[recipient];
                        NetworkStream recipientStream = recipientClient.GetStream();

                        byte[] msgBuffer = Encoding.UTF8.GetBytes($"{username}|{message}");
                        recipientStream.Write(msgBuffer, 0, msgBuffer.Length);
                    }

                    // Gửi lại cho chính người gửi (nếu muốn đồng bộ realtime)
                    if (clients.ContainsKey(username))
                    {
                        TcpClient senderClient = clients[username];
                        NetworkStream senderStream = senderClient.GetStream();

                        byte[] msgBuffer = Encoding.UTF8.GetBytes($"{username}|{message}");
                        senderStream.Write(msgBuffer, 0, msgBuffer.Length);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error with user {username}: {ex.Message}");
        }
        finally
        {
            lock (clients)
            {
                if (!string.IsNullOrEmpty(username) && clients.ContainsKey(username))
                    clients.Remove(username);
            }
            client.Close();
            Console.WriteLine($"User disconnected: {username}");
        }
    }
}