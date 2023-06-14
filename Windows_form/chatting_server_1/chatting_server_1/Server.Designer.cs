using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace chatting_server_1
{
    public partial class Server
    {
        TcpListener server;
        TcpClient client;

        StreamReader reader;
        StreamWriter writer;
        NetworkStream stream;

        Thread ReceiveThread;
        bool Connected;

        private delegate void AddTextDelegate(string strText);
        public Server()
        {
            InitializeComponent();
        }
        private void Listen()
        {
            // 1.채팅방에 텍스트 추가 -> delegate 함수
            AddTextDelegate AddText = new AddTextDelegate(textBox1.AppendText);

            // 2.서버 세팅
            IPAddress addr = IPAddress.Parse("127.0.0.1");
            int port = 8080;
            server = new TcpListener(addr, port);
            server.Start();

            Invoke(AddText, "Server Start" + "\r\n");

            // 3.클라이언트 세팅
            client = server.AcceptTcpClient();
            Connected = true;

            Invoke(AddText, "Connected to Client" + "\r\n");

            // 4. stream 생성
            stream = client.GetStream();
            reader = new StreamReader(stream);
            writer = new StreamWriter(stream);

            // 5. receive 쓰레드 start
            ReceiveThread = new Thread(new ThreadStart(Receive));
            ReceiveThread.Start();
        }

        // 클라이언트한테 메세지오면 채팅화면에 출력해주기위해 실행시키는 메서드
        // stream 계속 모니터링하다가 canread(클이 보내서 stream에 메세지들오면)되면 리더가 읽어서 채팅화면에 출력
        // 서버에서 클라이언트로 메세지 보내고 싶으면 버튼 누르면 됨.
        private void Receive()
        {
            AddTextDelegate AddText = new AddTextDelegate(textBox1.AppendText);

            while (Connected)
            {
                // stream 에 data 있을 때
                if (stream.CanRead)
                {
                    string receiveChat = reader.ReadLine();
                    if (receiveChat != null && receiveChat.Length > 0)
                        Invoke(AddText, "You : " + receiveChat + "\r\n");
                }
            }
        }
        // 버튼 눌러서 채팅 보내는 과정
        private void button_server_send_Click(object sender, EventArgs e)
        {
            // 채팅방에 메세지 추가
            textBox1.AppendText("Me : "+ textBox2.Text + "\r\n");

            // 클라이언트에 채팅보냄
            writer.WriteLine(textBox2.Text);
            writer.Flush();

            textBox2.Clear();
        }
        
        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            Connected = false;
            if (reader != null) reader.Close();
            if (writer != null) writer.Close();
            if (server != null) server.Stop();
            if (client != null) client.Close();
            if (ReceiveThread != null) ReceiveThread.Abort();
        }

        private void Server_Load(object sender, EventArgs e)
        {
            Thread ListenThread = new Thread(new ThreadStart(Listen));
            ListenThread.Start();
        }
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(448, 393);
            button1.Name = "button1";
            button1.Size = new Size(99, 32);
            button1.TabIndex = 0;
            button1.Text = "send";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("한컴 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(43, 31);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(504, 281);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("한컴 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(43, 350);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(343, 75);
            textBox2.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}