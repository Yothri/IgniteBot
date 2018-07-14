using Engine.Network.Model;
using System.Windows.Forms;

namespace Engine
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnSendChat_Click(object sender, System.EventArgs e)
        {
            Networking.SendChat(txtChatText.Text);
        }
        
        private void btnSendPacket_Click(object sender, System.EventArgs e)
        {
            var hex = txtRawPacketData.Text;
            var bytes = Utils.StringToByteArray(hex);
            using (var p = new NetPacket())
            {
                p.Write(bytes);
                Networking.SendPacket(p);
            }
        }
    }
}