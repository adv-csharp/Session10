using RestSharp;
using System.Threading;

namespace RestClient
{
    public partial class Form1 : Form
    {
        class Post
        {
            public int UserId { get; set; }
            public int Id { get; set; }
            public string Title { get; set; }
            public string Body { get; set; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            //https://jsonplaceholder.typicode.com/posts
            //get

            var client = new HttpClient();
            var resp = await client.SendAsync(new HttpRequestMessage { 
                Method = HttpMethod.Get, 
                RequestUri = new Uri("https://jsonplaceholder.typicode.com/posts") });

            if(resp.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var posts = await resp.Content.ReadAsAsync<Post[]>();
                dataGridView1.DataSource = posts;
            }
        }

        private async void btnAddPost_Click(object sender, EventArgs e)
        {
            // RestSharp 
            var client = new RestSharp.RestClient("https://jsonplaceholder.typicode.com");
            var request = new RestRequest("posts");
            request.AddJsonBody(new Post { Title = "jadid", Body = "jadidtar", UserId = 1 });
            var response = await client.PostAsync(request);
            MessageBox.Show(response.StatusCode.ToString());
        }
    }
}