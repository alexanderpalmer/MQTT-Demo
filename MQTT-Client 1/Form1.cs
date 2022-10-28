using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace MQTT_Client_1
{
    public partial class Form1 : Form
    {
        // More Information about M2Mqtt 
        // https://m2mqtt.wordpress.com/using-mqttclient/
        MqttClient mqttClient;

        public Form1()
        {
            InitializeComponent();
        }

        private void CmdSendMessage_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                if (mqttClient.IsConnected)
                {
                    mqttClient.Publish("Client1/Message", Encoding.UTF8.GetBytes(TxtInput.Text));
                }
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                mqttClient = new MqttClient("192.168.1.150");
                mqttClient.MqttMsgPublishReceived += MQTT_Client_MqttMsgPublishReceived;
                mqttClient.Subscribe(new string[] { "Client2/Message" }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
                mqttClient.Connect("Client1", "mqttuser", "novonyx");
            });
        }


        private void MQTT_Client_MqttMsgPublishReceived(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs e)
        {
            var message = Encoding.UTF8.GetString(e.Message);
            LstOutput.Invoke((MethodInvoker)(() => LstOutput.Items.Add(message)));
        }
    }
}
