using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Http;
using System.Text;

namespace Hype_Discord
{
    public partial class Form : System.Windows.Forms.Form
    {
        readonly string HelpText = "Enter Account Token Here..";
        public Form()
        {
            InitializeComponent();
            TextBox.Text = HelpText;
            Selector.SelectedItem = "Purple";
        }

        private void TextBox_Click(object sender, EventArgs e)
        {
            if(TextBox.Text == HelpText)
            {
                TextBox.Text = null;
            }
        }

        private async void Active_Click(object sender, EventArgs e)
        {
            string Token = TextBox.Text;

            if (Token.Length == 59 || Token.Length == 88)
            {
                int Selected;
                if (Selector.SelectedItem == "Purple")
                {
                    Selected = 1;
                }
                else if(Selector.SelectedItem == "Red")
                {
                    Selected = 2;
                }
                else
                {
                    Selected = 3;
                }

                using (var Client = new HttpClient()) 
                {
                    string Body = @"{""house_id"":" + Selected + "}";
                    Client.DefaultRequestHeaders.Add("Authorization", Token);
                    var Response = await Client.PostAsync("https://discord.com/api/v8/hypesquad/online", new StringContent(Body, Encoding.UTF8,"application/json"));
                    string ResponseStatus = Response.StatusCode.ToString();

                    if(ResponseStatus == "NoContent")
                    {
                        MessageBox.Show("Done!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if(ResponseStatus == "429"){
                        MessageBox.Show("Too Many Requests","Message",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }
                    else if(ResponseStatus == "Unauthorized")
                    {
                        MessageBox.Show("Wrong Token","Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Unexpected Error","Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("This Is Not A Token!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Active_MouseHover(object sender, EventArgs e)
        {
            Active.BackColor = SystemColors.ButtonHighlight;
            Active.Cursor = Cursors.Hand;
        }

        private void Active_MouseLeave(object sender, EventArgs e)
        {
            Active.BackColor = SystemColors.GradientActiveCaption;
        }

    }
}
