using System.Windows.Forms;
using System.Net.Http;
using System.Web.Script.Serialization;
using System;

namespace 图灵聊天机器人
{
    public partial class MainForm : Form
    {
        private const string Key = "74d0ab73b1b9bcb6dc23b8861b2f8e44";
        private readonly string URL = "";

        public MainForm()
        {
            InitializeComponent();
            URL = $"http://www.tuling123.com/openapi/api?key={Key}&info";
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            var r = new Random();
            for(int i =r.Next(20,50);i>=0;i--)
            {
                txt_Name.AppendText(((char)r.Next(33,127)).ToString());
            }
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            SendMessage();
        }
        private async void SendMessage()
        {       
            var hc = new HttpClient();
            var result = await hc.GetStringAsync($"{URL}={txt_MessageBox.Text}&userid={txt_Name.Text}&loc={txt_City.Text}");
            var js = new JavaScriptSerializer();
            var r = new Result();
            r = (Result)js.Deserialize(result, typeof(Result));
            try
            {
                txt_MessageBox.Text=txt_MessageBox.Text.Remove(txt_MessageBox.Text.LastIndexOf('\n'), 1);
            }
            catch { }
            txt_ChatBox.AppendText($"{txt_Name.Text}:\n{txt_MessageBox.Text}\n机器人:\n{r.text}\n");
            txt_MessageBox.Text = "";
            txt_ChatBox.ScrollToCaret();
        }

        private void txt_MessageBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                SendMessage();
                return;
            }
        }
    }
    public class Result
    {
        public int code = 0;
        public string text = "";
    }
}
