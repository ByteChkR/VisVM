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
    public partial class ArrayEditor : Form
    {

        private readonly JArray m_Array;
        private bool m_Edited;
        public ArrayEditor(JArray array)
        {
            m_Array = array;
            InitializeComponent();
            ReloadContent(true);
            Closing += ArrayEditor_Closing;
        }

        private void ArrayEditor_Closing(object sender, CancelEventArgs e)
        {
            if(m_Edited)
            DialogResult = DialogResult.OK; //We Changed
        }

        private void ReloadContent(bool init = false)
        {
            lb_Array.Items.Clear();
            foreach (JToken jToken in m_Array)
            {
                lb_Array.Items.Add(jToken);
            }

            m_Edited = !init;
        }

        private void DuplicateSelected()
        {
            foreach ( JToken checkedItem in lb_Array.CheckedItems )
            {
                m_Array.Add( checkedItem );
            }

            ReloadContent();
        }

        private void RemoveSelected()
        {
            foreach (JToken checkedItem in lb_Array.CheckedItems)
            {
                m_Array.Remove(checkedItem);
            }
            ReloadContent();
        }

        private void btn_Duplicate_Click(object sender, EventArgs e)
        {
            DuplicateSelected();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            RemoveSelected();
        }
    }
}
