using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LatexBuildComponent
{
    public partial class LatexConfigDlg : Form
    {
        public LatexConfigDlg(string configXml)
        {
            InitializeComponent();
            var config = XElement.Parse(configXml);
            var index = int.Parse(config.Element("fontSize").Attribute("value").Value);
            fontSelect.SelectedIndex = index;
        }

        public string FontSize { get; set; }

        private void okButton_Click(object sender, EventArgs e)
        {
            FontSize = fontSelect.SelectedIndex.ToString();
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}