using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace VisVM.UI.JsonViewer
{
    public partial class JsonViewerForm : Form
    {

        private Dictionary < TreeNode, JToken? > m_Map = new Dictionary < TreeNode, JToken? >();
        private readonly string m_Path;
        public static JsonViewerForm CreateFromString(string jsonStr)
        {
            return new(JObject.Parse(jsonStr));
        }

        public static JsonViewerForm CreateFromFile(string path)
        {
            return new(path, JObject.Parse(File.ReadAllText(path)));
        }

        public JsonViewerForm(string path, JObject obj)
        {
            m_Path = path;
            InitializeComponent();
            tvTree.NodeMouseDoubleClick += TvTree_NodeMouseDoubleClick;
            Reload(obj);
        }

        public JsonViewerForm( JObject obj ) : this( null, obj )
        {
           
        }

        private void Reload() => Reload( m_Map[tvTree.Nodes[0]] as JObject );

        private void Reload(JObject obj)
        {
            m_Map.Clear();
            tvTree.Nodes.Clear();
            tvTree.Nodes.Add(AddSelf(CreateBranchNode("Root", obj), obj));
        }

        private void TvTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if ( m_Map[e.Node] is JArray a )
            {
                ArrayEditor ed = new ( a );

                if ( ed.ShowDialog() == DialogResult.OK )
                {
                    Reload();
                }
            }
            else if (m_Map[e.Node] is JValue v)
            {
                (string key, string value) = ParseKvp(e.Node.Text);
                
                ValueViewerForm vvf = new (v, key);
                if ( vvf.ShowDialog() == DialogResult.OK )
                {
                    e.Node.Text = GetKvp( key, vvf.Value );
                }
            }
        }

        private TreeNode AddSelf(TreeNode tn,  JObject obj )
        {
            
            foreach ( KeyValuePair < string, JToken? > values in obj )
            {
                if ( values.Value == null )
                    tn.Nodes.Add(CreateLeafNode(values.Key, null, null));
                else if(values.Value is JObject j)
                {
                    tn.Nodes.Add( AddSelf(CreateBranchNode(values.Key, j ), j));
                }
                else if (values.Value is JArray a)
                {
                    tn.Nodes.Add(AddArraySelf(CreateBranchNode(values.Key, a), a));
                }
                else
                {
                    tn.Nodes.Add( CreateLeafNode(values.Key, values.Value.ToString(), values.Value));
                }
            }

            return tn;
        }

        private TreeNode AddArraySelf( TreeNode tn, JArray array )
        {
            int i = 0;
            foreach (JToken jToken in array)
            {
                if (jToken is JObject j)
                {
                    tn.Nodes.Add(AddSelf(CreateBranchNode(i.ToString(), j), j));
                }else if ( jToken is JArray a )
                {
                    tn.Nodes.Add( AddArraySelf( CreateBranchNode( i.ToString(), a ), a ) );
                }
                else
                {
                    tn.Nodes.Add(CreateLeafNode(i.ToString(), jToken.ToString(), jToken));
                }

                i++;
            }

            return tn;
        }

        private TreeNode CreateBranchNode(string key, JObject value)
        {
            TreeNode tn = new TreeNode(key);
            m_Map[tn] = value;

            return tn;
        }
        private TreeNode CreateBranchNode(string key, JArray value)
        {
            TreeNode tn = new TreeNode(key);
            m_Map[tn] = value;

            return tn;
        }

        private TreeNode CreateLeafNode( string key, string value, JToken? jValue )
        {
            TreeNode tn = new TreeNode( GetKvp( key, value ) );
            m_Map[tn] = jValue;

            return tn;
        }

        private string GetKvp( string key, string value ) => $"{key}::{value}";

        private (string, string) ParseKvp( string kvp )
        {
            string[] s = kvp.Split( new[] { "::" }, StringSplitOptions.None );

            return ( s[0], s[1] );
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            ValueViewerForm vvd = new (m_Map[tvTree.Nodes[0]], "Confirm Changes to File:" );

            if ( vvd.ShowDialog() == DialogResult.OK )
            {
                if ( m_Path != null )
                {
                    File.WriteAllText(m_Path, vvd.Value );
                }
                else if(sfd_JsonFile.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText( sfd_JsonFile.FileName, vvd.Value );
                }
            }
        }
    }
}
