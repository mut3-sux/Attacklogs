Ok go through the the files and see what you need to change
also forgot to mention locate to your attack form where you send a attack and make a text file and name it datetime
 when done hide to back next double click on the launch attack button and put this

                DateTime now = DateTime.Now;
                datetime.Text = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");
                Attacklog.SendMessage(ResponseInformation.loginresponse.UserName, ip.Text, port.Text, time.Text, method.Text, datetime.Text);

if your using another auth than safeguard then define the username 


And also if your using this in two different exe one for ddos panel and one for attack logs include the class in both progerams
and also you can use this in your project by click add and add existing 

thanks for downloading my project i was working on i thought it was cool so i shared it


