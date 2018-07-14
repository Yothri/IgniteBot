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

        private void btnSetTarget_Click(object sender, System.EventArgs e)
        {
            Networking.SendSetTarget(uint.Parse(txtTargetId.Text), byte.Parse(txtSetTargetBClear.Text));
        }

        private void btnSetDestObj_Click(object sender, System.EventArgs e)
        {
            Networking.SendPlayerDestObj(uint.Parse(txtTargetId.Text), float.Parse(txtSetDestObjRange.Text));
        }

        private void btnMeleeAttack_Click(object sender, System.EventArgs e)
        {
            Networking.SendMeleeAttack(uint.Parse(txtAtkMsg.Text), uint.Parse(txtTargetId.Text), 0, 65536, 0.085f);
        }

        private void btnLoadFocusedObjId_Click(object sender, System.EventArgs e)
        {
            txtTargetId.Text = WorldMng.Instance.GetWorld().GetFocusedObj()?.GetObjId().ToString();
        }
    }
}