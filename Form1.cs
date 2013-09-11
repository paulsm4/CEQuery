using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using FileNet.Api.Collection;
using FileNet.Api.Constants;
using FileNet.Api.Core;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private string[] sampleQueries = 
        {
            "select * from Document",
            "select d.[Name], d.[Id] from Document d where d.[Creator] = 'p8admin'",
            "select Name, Id, MajorVersionNumber, MinorVersionNumber, VersionSeries\n" + 
            "  from Document where Document.This INFOLDER '/eForms' and IsCurrentVersion=true",
            // "select Name, Id from Document where Creator='p8admin' and IsClass(Document, StoredSearch)",
            "select Name, Id from Document where IsClass(Document, StoredSearch)",
            "select * from FormPolicy",
            "select d.[Name], d.[Id] from Document d where DateCreated > 20120101T000000Z",
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                Log("Connecting to CE(" + edtCeUri.Text + ")...");
                CEUtil ceUtil =
                    CEUtil.GetInstance(edtCeUri.Text, edtObjectStore.Text, edtCeUser.Text, edtPassword.Text, Log);

                // Make query
                IDocumentSet documents = ceUtil.queryDocs(edtCeQuery.Text, 20, 50);

                // Display results
                int ct = 0;
                IEnumerator it = documents.GetEnumerator();
                while (it.MoveNext())
                {
                    IDocument d = (IDocument)it.Current;
                    Log("d[" + ct++ + "]=" + d.Name + ", " + d.Id.ToString() + "...");
                    it.MoveNext();
                }
                Log("  #/rows=" + ct);
                Log("");
            }
            catch (Exception ex)
            {
                Log("Error: " + ex.Message);
                Log(ex.StackTrace);
            }
        }

        private void cbSampleQueries_SelectedIndexChanged(object sender, EventArgs e)
        {
            edtCeQuery.Text = cbSampleQueries.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitUi();
        }

        private void InitUi()
        {
            cbSampleQueries.Items.AddRange (sampleQueries);
            cbSampleQueries.SelectedIndex = 0;
        }

        public void Log(string msg)
        {
            edtStatus.AppendText(msg + Environment.NewLine);
        }

    }
}
