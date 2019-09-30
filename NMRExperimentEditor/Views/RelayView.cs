using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NMRExperimentEditor.Model;

namespace NMRExperimentEditor.Views
{
    public partial class RelaysView : UserControl
    {
        private bool relaySetting = false;

        public RelaysView()
        {
            InitializeComponent();
        }

        private void RelayCheckedChanged(object sender, EventArgs e)
        {
            if (relaySetting)
                return;

            var relays = GetRelays();
            var code = Helpers.RelayStatusToByte(relays);

            relayCode.Value = code;
        }

        private RelayStatus GetRelays()
        {
            RelayStatus result = RelayStatus.Empty;

            if (relay1.Checked) result |= RelayStatus.Relay1;
            if (relay2.Checked) result |= RelayStatus.Relay2;
            if (relay3.Checked) result |= RelayStatus.Relay3;
            if (relay4.Checked) result |= RelayStatus.Relay4;
            if (relay5.Checked) result |= RelayStatus.Relay5;
            if (relay6.Checked) result |= RelayStatus.Relay6;

            return result;
        }

        private void relayCode_ValueChanged(object sender, EventArgs e)
        {
            var relay = Helpers.ByteToRelayStatus((byte)relayCode.Value);

            relaySetting = true;

            relay1.Checked = relay.HasFlag(RelayStatus.Relay1);
            relay2.Checked = relay.HasFlag(RelayStatus.Relay2);
            relay3.Checked = relay.HasFlag(RelayStatus.Relay3);
            relay4.Checked = relay.HasFlag(RelayStatus.Relay4);
            relay5.Checked = relay.HasFlag(RelayStatus.Relay5);
            relay6.Checked = relay.HasFlag(RelayStatus.Relay6);

            relaySetting = false;
        }
       
        public bool Hexadecimal
        {
            get => relayCode.Hexadecimal;
            set
            {
                if (relayCode.Hexadecimal == value)
                    return;

                relayCode.Hexadecimal = value;
            }
        }
    }
}
