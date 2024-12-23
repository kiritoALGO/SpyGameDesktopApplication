using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpyGamev1._0Csharp
{
    public partial class Form1 : SpyGamev1._0Csharp.background
    {
        public Form1()
        {
            InitializeComponent();
        }

    //    private void DisplayWordDocument(string filePath)
    //    {
    //        // Create Word application object
    //        var wordApp = new Word.Application();
    //        wordApp.Visible = false;  // Make Word application invisible

    //        // Open the Word document
    //        Word.Document doc = wordApp.Documents.Open(filePath);

    //        // Display document content in RichTextBox or similar control
    //        string documentText = doc.Content.Text;

    //        // Display in a RichTextBox or any other control
    //        RichTextBox richTextBox = new RichTextBox
    //        {
    //            Text = documentText,
    //            Dock = DockStyle.Fill // Adjust to panel size
    //        };

    //        this.Controls.Add(richTextBox);

    //        // Close the Word document
    //        doc.Close();
    //        wordApp.Quit();
    //    }
    //}
    private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
