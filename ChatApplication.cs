using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using ChatDbObjects;

namespace chatclient
{
        class ChatApplication
    {
        int port = 8000;
        IPEndPoint ipPoint;
        String IP;
        Socket listenSocket;

        public void setIP(String ip,int Port)
        {
            this.IP = ip;
            this.port = Port;
            this.ipPoint = new IPEndPoint(IPAddress.Parse(this.IP), port);

        }

        public ChatApplication()
        {
            listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

        }
        public void connectToSocket()
        {
            try
            {
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                // подключаемся к удаленному хосту
                socket.Connect(ipPoint);
                Console.Write("Введите сообщение:");
                string message = Console.ReadLine();
                byte[] data = Encoding.Unicode.GetBytes(message);
                socket.Send(data);

                // получаем ответ
                data = new byte[256]; // буфер для ответа
                StringBuilder builder = new StringBuilder();
                int bytes = 0; // количество полученных байт

                do
                {
                    bytes = socket.Receive(data, data.Length, 0);
                    builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                }
                while (socket.Available > 0);

                var obj = DbObject.Deserialize(data);
                User u = (User)obj.objects[0];
                Console.WriteLine("Login: {u.login}, {u.firstname}, {u.lastname}");

                //Console.WriteLine("ответ сервера: " + builder.ToString());

                // закрываем сокет
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }

    }
}
