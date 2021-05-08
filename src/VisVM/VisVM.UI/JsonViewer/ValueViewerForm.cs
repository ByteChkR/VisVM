using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json.Linq;

namespace VisVM.UI.JsonViewer
{
    public partial class ValueViewerForm : Form
    {

        public string Value => rtb_Value.Text;

        private JToken m_Token;
        public ValueViewerForm(JToken token, string key)
        {
            m_Token = token;
            InitializeComponent();
            lbl_PropertyName.Text = key;
            rtb_Value.Text = token.Value<object>().ToString();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            object o=null;
            switch(m_Token.Type)
            {
                case JTokenType.Object:
                    DialogResult = DialogResult.OK;
                    Close();
                    return;
                case JTokenType.Integer:
                    o = long.Parse( rtb_Value.Text );
                    break;

                case JTokenType.Float:
                    o = float.Parse(rtb_Value.Text);
                    break;

                case JTokenType.String:
                    o = rtb_Value.Text;
                    break;

                case JTokenType.Boolean:
                    o = bool.Parse( rtb_Value.Text );
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            (m_Token as JValue).Value = o;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
