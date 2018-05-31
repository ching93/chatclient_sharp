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
using System.Windows.Forms;

namespace chatclient
{
    public class ChatApplication
    {
        int port = 8000;
        IPEndPoint ipPoint;
        String IP;
        Socket socket;
        public delegate void strDelegate(dbResult result);
        //strDelegate myDelegate;
        public event strDelegate messageIncome;
        User currentUser;
        int bufferSize = 512;
        public bool started { get; private set; } = false;
        Form currentForm;
        public bool isVerified { get; private set; } = false;
        
        public bool isStarted()
        {
            return started;
        }
        void listenMessages()
        {
            started = true;
            int comingBufferSize = socket.ReceiveBufferSize;
            while (true)
            {
                try
                {
                    MemoryStream stream = new MemoryStream();
                    byte[] buffer = new byte[comingBufferSize];
                    int totalBytes = 0;
                    do
                    {
                        int bytes = socket.Receive(buffer);
                        stream.Write(buffer, 0, bytes);
                        totalBytes += bytes;
                    }
                    while (socket.Available > 0);
                    Console.WriteLine("Получено " + totalBytes + " байтов");
                    var result = (dbResult)DbObject.Deserialize(stream);
                    Console.WriteLine(result.action.ToString());
                    switch (result.action)
                    {
                        case dbAction.VERIFY_USER:
                            if (result.isSuccessful)
                            {
                                this.currentUser = (User)result.objects[0];
                                isVerified = true;
                            }
                            break;
                    }
                    currentForm.Invoke(messageIncome, result);
                    stream.Close();
                }
                catch (SerializationException e)
                {
                    Console.WriteLine(e.ToString());
                }
                catch (SocketException e)
                {
                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();
                    started = false;
                    throw e;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw e;
                }
            }
        }
        public void setIP(String ip,int Port)
        {
            this.IP = ip;
            this.port = Port;
            this.ipPoint = new IPEndPoint(IPAddress.Parse(this.IP), port);

        }

        public ChatApplication(bool startListen, Form form)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            ipPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8000);
            this.currentForm = form;
            
            if (startListen)
            {
                this.Start();
            }
        }
        public void setForm(Form form)
        {
            this.currentForm = form;

        }
        public void Start()
        {
            socket.Connect(ipPoint);
            Task t = new Task(listenMessages);
            t.ContinueWith((Task ts) => { Console.WriteLine("escape from cycle "+t.Id); });
            t.Start();
        }
        public void setCurrentUser(User newUser)
        {
            dbRequest request = new dbRequest(dbAction.VERIFY_USER, dbSelectAction.NONE, null, newUser);
            sendRequest(request);
        }
        public void getAllUsers()
        {
            dbRequest request = new dbRequest(dbAction.NONE, dbSelectAction.SELECT_ALL_USERS, currentUser, null);
            sendRequest(request);
        }
        public void signUpUser(User newUser)
        {
            dbRequest request = new dbRequest(dbAction.ADD_USER, dbSelectAction.NONE, currentUser, newUser);
            sendRequest(request);
        }
        public void requestRoles()
        {
            dbRequest request = new dbRequest(dbAction.NONE, dbSelectAction.SELECT_ROLES, null, null);
            sendRequest(request);
        }
        public User getCurrentUser()
        {
            return this.currentUser;
        }
        public void sendRequest(dbRequest request)
        {
            byte[] bytes = DbObject.Serialize(request);
            MemoryStream stream = new MemoryStream(bytes);
            int totalBytes = 0;
            Console.WriteLine("need to send " + bytes.Length + " bytes");
            while (stream.Position < stream.Length)
            {
                byte[] buffer = new byte[socket.ReceiveBufferSize];
                int byteCount = stream.Read(buffer, 0, socket.ReceiveBufferSize);
                totalBytes += byteCount;
                this.socket.Send(buffer,byteCount,SocketFlags.None);
            }
            Console.WriteLine("sent " + totalBytes + " bytes");
            stream.Close();
        }
    }
}
