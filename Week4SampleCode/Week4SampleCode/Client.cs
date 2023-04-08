
using System.Net.Sockets;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Week4SampleCode
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private TcpClient tcpClient;
        private string data;
        //private NetworkStream ns;
        private const int serverPort = 8080;
        private Thread clientThread;
        private StreamReader sReader;
        private StreamWriter sWriter;
        private bool stoptcpClient = true;

        private delegate void SafeCallDelegate(string text);
        private void UpdateChatHistorySafeCall(string text)
        {
            if (msgBox.InvokeRequired)
            {
                var d = new SafeCallDelegate(UpdateChatHistorySafeCall);
                msgBox.Invoke(d, new object[] { text });
            }
            else
            {
                msgBox.Text += text + "\n";
            }
        }

        private void ClientReceive()
        {
            sReader = new StreamReader(tcpClient.GetStream());

            while (!stoptcpClient && tcpClient.Connected)
            {
                // Application.DoEvents();
                string rcvdata = sReader.ReadLine();
                UpdateChatHistorySafeCall(rcvdata);
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            try
            {
                stoptcpClient = false;

                tcpClient = new TcpClient();

                //1. Create IP endpoint
                IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
                IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, serverPort);



                //2. Call connect function of TCPClient class
                tcpClient.Connect(ipEndPoint);

                //3. using streamwrite and tcpClient.GetStream()
                sWriter = new StreamWriter(tcpClient.GetStream());


                //4. using variable sWriter to write username into stream
                string username = usernameBox.Text;
                sWriter.WriteLine(username);
                sWriter.Flush();



                //5. Create new Thread(ClientReceive)
                clientThread = new Thread(ClientReceive);

                //6. Start Thread
                clientThread.Start();

              

               // MessageBox.Show("Connected");
               //connectButton.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                data = sendMsgBox.Text;
                //7. using streamwriter to send data (readline function)
                sWriter.WriteLine(data);
                sWriter.Flush();

                sendMsgBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            stoptcpClient = true;
            clientThread = null;
            tcpClient.Close();

            MessageBox.Show("Disconnected.");
        }
    }
}
