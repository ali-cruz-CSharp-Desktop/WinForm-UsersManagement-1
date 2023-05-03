using SuperSimpleTcp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsersManagement.General
{
    public class MonitorApp
    {
        private string ipServer = "192.168.1.224";
        private string puertoServer = "9001";

        SimpleTcpClient client;

        private void Events_Disconnected(object sender, ConnectionEventArgs e)
        {
            //this.Invoke((MethodInvoker)delegate
            //{
            //    //txbInfo.Text += $"Servidor Desconectado. {Environment.NewLine}";
            //});
        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            //this.Invoke((MethodInvoker)delegate
            //{
            //    //txbInfo.Text += $"Server: {Encoding.UTF8.GetString(e.Data.ToArray())} {Environment.NewLine}";
            //    //MostrarNotificacion(Encoding.UTF8.GetString(e.Data.ToArray()));
            //});
        }

        private void Events_Connected(object sender, ConnectionEventArgs e)
        {
            //this.Invoke((MethodInvoker)delegate
            //{
            //    //txbInfo.Text += $"Servidor Conectado. {Environment.NewLine}";
            //});
        }

        public void ConectToServer()
        {
            try
            {
                //IPAddress ipAddress = Dns.GetHostEntry(TxbServer.Text).AddressList[0];
                //string ipp = ipAddress.MapToIPv4().ToString();
                string ip4 = string.Empty;

                IPAddress[] ipAddress = Dns.GetHostAddresses(ipServer);
                foreach (IPAddress adress in ipAddress)
                {
                    if (adress.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        ip4 = adress.ToString();
                    }
                }

                client = new SimpleTcpClient(ip4, Convert.ToInt32(puertoServer));
                client.Connect();

                client.Events.Connected += Events_Connected;
                client.Events.DataReceived += Events_DataReceived;
                client.Events.Disconnected += Events_Disconnected;


                if (client.IsConnected)
                {
                    Console.WriteLine("Conectado al server");
                }
                else
                {
                    
                }

            }
            catch (Exception ex)
            {
                
            }
        }


        private void EnviarMensaje(string msgToServer)
        {
            if (client.IsConnected)
            {
                if (!string.IsNullOrEmpty(msgToServer))
                {
                    client.Send(msgToServer);
                   
                }
            }
        }



    }
}
