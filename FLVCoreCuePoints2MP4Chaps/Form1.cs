using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace FLVCoreCuePoints2MP4Chaps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoadXML_Click(object sender, EventArgs e)
        {
            dataGridViewIN.DataSource = null;
            dataGridViewIN.Rows.Clear();

            dataGridViewOUT.DataSource = null;
            dataGridViewOUT.Rows.Clear();


            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XmlReader xmlFile;
                    DataSet ds = new DataSet();
                    xmlFile = XmlReader.Create(ofd.FileName, new XmlReaderSettings());

                    ds.ReadXml(xmlFile);

                    for (int i = 0; i < ds.Tables["CuePoint"].Rows.Count; i++)
                    {
                        int timeFrames = int.Parse(ds.Tables["CuePoint"].Rows[i]["Time"].ToString());
                        Console.WriteLine(timeFrames);

                        int mseconds = 0;
                        int seconds = 0;
                        int minutes = 0;
                        int hours = 0;

                        if (timeFrames >= 1000)
                        {
                            seconds = timeFrames / 1000;
                            mseconds = timeFrames % 1000;

                            if (seconds >= 60)
                            {
                                minutes = seconds / 60;
                                seconds = seconds % 60;
                                if (minutes >= 60)
                                {
                                    hours = minutes / 60;
                                    minutes = minutes % 60;
                                }

                            }
                        }

                        String mSecString = "";
                        String secString = "";
                        String minString = "";
                        String hourString = "";


                        if (mseconds < 100)
                        {
                            mSecString = "0" + mseconds;
                            if (mseconds < 10) mSecString = "00" + mseconds;
                        }
                        else mSecString = mseconds.ToString();
                        if (seconds < 10) secString = "0" + seconds;
                        else secString = seconds.ToString();
                        if (minutes < 10) minString = "0" + minutes;
                        else minString = minutes.ToString();
                        if (hours < 10) hourString = "0" + hours;
                        else hourString = hours.ToString();

                        Console.WriteLine(hourString + ":" + minString + ":" + secString+":"+mSecString);
                        


                        dataGridViewIN.Rows.Add(ds.Tables["CuePoint"].Rows[i]["Time"].ToString(), ds.Tables["CuePoint"].Rows[i]["Name"].ToString());
                        dataGridViewOUT.Rows.Add(hourString + ":" + minString + ":" + secString + "." + mSecString, ds.Tables["CuePoint"].Rows[i]["Name"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void buttonSaveAuphonicChaps_Click(object sender, EventArgs e)
        {
            if (dataGridViewOUT.RowCount>0)
            {
                SaveFileDialog speichern = new SaveFileDialog();
                speichern.Title = "Save Chapters Auphonic-compatible";
                speichern.FileName = "auphonicChaps.txt";

                if (speichern.ShowDialog() == DialogResult.OK)
                {
                    System.IO.StreamWriter objWriter;

                    objWriter = new System.IO.StreamWriter(speichern.FileName);

                    int count = dataGridViewOUT.Rows.Count;

                    for (int row = 0; row < count; row++)
                    {

                        objWriter.WriteLine(dataGridViewOUT.Rows[row].Cells[0].Value.ToString() + " " + dataGridViewOUT.Rows[row].Cells[1].Value.ToString());
                    }
                    objWriter.Close();
                }
            }
            else MessageBox.Show("Table is empty, no Chaptermarks to save");
        }
    }
}
