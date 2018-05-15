using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using ChatDbObjects;

namespace chatclient
{
    public partial class Form1 : Form
    {
        Socket socket;
        delegate void strDelegate(String msg);
        strDelegate myDelegate;
        void addMessageToLog(String msg) {
            this.messageLog.AppendText(DateTime.Now.ToShortTimeString() + ": " + msg+"\n");
        }
        void listenMessages()
        {
            byte[] buffer = new byte[256];

            //socket.Listen(5);
            while (true)
            {
                try
                {
                    MemoryStream stream = new MemoryStream();
                    int total_bytes = 0;
                    do
                    {
                        int bytes = socket.Receive(buffer);
                        stream.Write(buffer, 0, bytes);
                        total_bytes += bytes;
                        //builder.Append(Encoding.Unicode.GetString(buffer, 0, bytes));
                    }

                    while (socket.Available > 0);
                    //socket.Shutdown(SocketShutdown.Both);
                    //socket.Close();
                    var obj = DbObject.Deserialize(stream);
                    if (obj.action == dbAction.QUERY_SUCCESS)
                    {
                        User u = (User)obj.objects[0];
                        String log = u.login + ", " + u.firstname + ", " + u.lastname + ", " + u.email + ";\n";
                        Console.WriteLine(log);
                        messageLog.Invoke(myDelegate, new object[] { log });
                    }
                    else
                    {
                        Console.WriteLine("Неверный ошибка в БД");
                    }
                }
                catch (System.Runtime.Serialization.SerializationException e)
                {
                    Console.WriteLine(e.ToString());
                }
                catch (SocketException e)
                {
                    throw e;
                }
            }


        }
        public Form1()
        {
            InitializeComponent();
            myDelegate = addMessageToLog;
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            
            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8000);
            // подключаемся к удаленному хосту
            socket.Connect(ipPoint);
            
            Task t = new Task(listenMessages);
            
            t.Start();
        }
        private void sendMessage(String msg)
        {
            //byte[] buffer = Encoding.Unicode.GetBytes(msg);
            DbObject sendObj = new DbObject(dbAction.NONE, dbSelectAction.SELECT_ALL_USERS);
            byte[] buffer = DbObject.Serialize(sendObj);
            socket.Send(buffer);
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            sendMessage(this.messageBox.Text);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            messageLog.AppendText(messageBox.Text+"\n");
            messageBox.Text = "";
            messageBox.Focus();
        }

        private void messageBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendMessage(messageBox.Text);
                //messageLog.AppendText(messageBox.Text + "\n");
                messageBox.Text = "";
            }
                
        }
    }
}
