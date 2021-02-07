using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows.Forms;
using SafeGuard;

namespace Devil_Supreme.Forms
{
    public class Attacklog
    {

        static string Name = "Attack Logs";
        static string Url = "https://Yourwebsite.com/";//make a website you can use 000webhost and make a website and put it here
        static string Key = "Yourkey";// key youll use to authorise with 
                                      // look at the php and edit whats necessary and then go to file manager on your webhosting and put the attacklog.txt and the php file in the public html

            // if your using this in diifferent exe's and this is the exe different from your ddos panel then delete the following  but if your using this in the same exe then dont delete anything unless your defining the username to your auth!!
            //here
        public static async void SendMessage(string username, string ip, string port, string time, string method, string datatime)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(ip) || string.IsNullOrWhiteSpace(port) || string.IsNullOrWhiteSpace(time) || string.IsNullOrWhiteSpace(method) || string.IsNullOrWhiteSpace(datatime)) return;

            using (var client = new HttpClient())
            {
                try
                {
                    string SendMessage = await client.GetStringAsync($"{Url}/attacksent.php?&key={Key}&user={ResponseInformation.loginresponse.UserName}&ip={ip}&port={port}&time={time}&method={method}&datatime={datatime}");// if you didnt know what ResponseInformation.loginresponse.UserName is then thats what you edit to define the username btw
                }
                catch (Exception ex)
                {
                }
            }
        }
        // to here 
        // we delete this for what isnt needed
        // also delete safeguard as its a referance and you dont need it if you deleted it and also add the referance to the auth if your using another one if using in the same exe
        public static async Task<string> Getlogs()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    string Alltext = await client.GetStringAsync($"{Url}/attacklog.txt");
                    if (string.IsNullOrWhiteSpace(Alltext)) return "No attack Logs or cleared logs";
                    else return Alltext;
                }
                catch (Exception ex)
                {
                    return "";
                }
            }
        }
    }
}
