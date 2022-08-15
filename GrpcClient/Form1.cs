using Grpc.Core;
using Grpc.Net.Client;
using GrpcService;

namespace GrpcClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGRPC_Click(object sender, EventArgs e)
        {
            var channel = GrpcChannel.ForAddress("http://localhost:5123");
            //var channel = GrpcChannel.ForAddress("https://localhost:7123");
            var client = new Greeter.GreeterClient(channel);
            String user = "you";

            var reply = client.SayHello(new HelloRequest { Name = user });
            MessageBox.Show(reply.Message);



        }
    }
}