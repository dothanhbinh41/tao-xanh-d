using System.Diagnostics;

try
{
    // See https://aka.ms/new-console-template for more information


    var command = "echo Hello World";

    //    command = @"sudo iptables  -t nat -N TAOXANH
    //sudo iptables  -t nat -A TAOXANH -d 0.0.0.0/8 -j RETURN
    //sudo iptables  -t nat -A TAOXANH -d 10.0.0.0/8 -j RETURN
    //sudo iptables  -t nat -A TAOXANH -d 100.64.0.0/10 -j RETURN
    //sudo iptables  -t nat -A TAOXANH -d 127.0.0.0/8 -j RETURN
    //sudo iptables  -t nat -A TAOXANH -d 169.254.0.0/16 -j RETURN
    //sudo iptables  -t nat -A TAOXANH -d 172.16.0.0/12 -j RETURN
    //sudo iptables  -t nat -A TAOXANH -d 192.168.0.0/16 -j RETURN
    //sudo iptables  -t nat -A TAOXANH -d 198.18.0.0/15 -j RETURN
    //sudo iptables  -t nat -A TAOXANH -d 224.0.0.0/4 -j RETURN
    //sudo iptables  -t nat -A TAOXANH -d 240.0.0.0/4 -j RETURN
    //# Anything should be redirected to port 12345
    //sudo iptables  -t nat -A TAOXANH -p tcp -j REDIRECT --to-ports 12345
    //# Any tcp connection should be redirected to TAOXANH chain
    //sudo iptables  -t nat -A OUTPUT -p tcp -j TAOXANH";


    Console.WriteLine("Start Command " + command);
    using (Process proc = new Process())
    {
        proc.StartInfo.FileName = "/bin/sh";
        proc.StartInfo.Arguments = "-c \" echo vo ly \"";
        proc.StartInfo.UseShellExecute = false;
        proc.Start();

        proc.WaitForExit();
    }

}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
