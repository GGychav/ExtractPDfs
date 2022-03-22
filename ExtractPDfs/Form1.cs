using System;
using System.Collections.Generic;
//using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;
using System.IO;

using iText.Kernel.Pdf.Canvas.Parser.Listener;
using iText.Kernel.Pdf;
//using iText.Kernel.Geom;
using iText.Kernel.Pdf.Canvas.Parser;
//using iText.IO;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Colors;
using iText.Kernel.Pdf.Canvas.Draw;

namespace ExtractPDfs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Tool Tip Setup

            ToolTip toolTip1 = new ToolTip();
            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text
            toolTip1.SetToolTip(this.SplitCheckBox3, "Split the file per Item found. Creates miltiple files.");
            toolTip1.SetToolTip(this.OpenDestcheckBox4, "Opens the folder containing the extracted files.");
            toolTip1.SetToolTip(this.OpenExtractedcheckBox2, "Opens the single extracted file only using the system's default application.");

           


        }

    
        //Global Vars

        //Path for the Instructions manual
        public static string locationToInstructionsPdf = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "PDF_Extract_instructions.pdf");

        private void Closebutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PDFbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Browse PDF Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "pdf",
                Filter = "pdf files (*.pdf)|*.pdf",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PDFtextBox.Text = openFileDialog1.FileName;
                StatusrichTextBox.Text += "PDF File Selected." + Environment.NewLine;
                StatusrichTextBox.Text += openFileDialog1.FileName + Environment.NewLine;
            }
        }

        private void CSVbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Browse PDF Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "csv",
                Filter = "csv files (*.csv)|*.csv",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                CSVtextBox.Text = openFileDialog1.FileName;
                StatusrichTextBox.Text += "CSV File Selected." + Environment.NewLine;
                StatusrichTextBox.Text += openFileDialog1.FileName + Environment.NewLine;
            }
        }

        private void Startutton_Click(object sender, EventArgs e)
        {

            
            //Update the Details text
            Statuslabel1.Text = "Working...";
            Statuslabel1.Invalidate();
            Statuslabel1.Update();

            

            StatusrichTextBox.Focus();
            StatusrichTextBox.AppendText("Starting Extraction" + Environment.NewLine);

            //Setup Variables

            
            List<KeyValuePair<int, string>> IDKeys = new List<KeyValuePair<int, string>>();
            string csvfFilePath = CSVtextBox.Text;
            string pdfFilePath = PDFtextBox.Text;
            string singleItemIndex = SearchtextBox.Text;
            string indexType = "";
        

            StatusrichTextBox.AppendText("Indexing PDF file" + Environment.NewLine);




            //Function Calls *****************************

            //Index PDF ++++++++++++++++++++++++++++++++++++++++++++++++

           if (IDNumradioButton1.Checked)
            { indexType = "id"; }

           IDKeys = ID_Index(pdfFilePath, singleItemIndex, indexType);


            //Extract PDFs from Index ++++++++++++++++++++++++++++++++++++++++++++++++++++
            if (File.Exists(csvfFilePath))
            {
                //Extract from CSV
                Extract_the_PDFs(pdfFilePath, csvfFilePath, IDKeys, false);

            }
            else
            {
                //Extract Index from search text entry
                Extract_the_PDFs(pdfFilePath, csvfFilePath, IDKeys, true);
            }

            StatusrichTextBox.AppendText("Finished Processing");
            Statuslabel1.Invalidate();
            Statuslabel1.Update();
            progressBar1.Maximum = 100;
            progressBar1.Value = 100;
            Statuslabel1.Text = "Done!";
           

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                DetailsgroupBox2.Visible = true;
                this.MinimumSize = new Size(this.Width, this.Height);
                this.Height = this.Height + 225;

            }
            else if (!checkBox1.Checked)
            {
                DetailsgroupBox2.Visible = false;
                this.MinimumSize = new Size(this.Width, this.Height - DetailsgroupBox2.Height);
                this.Height = this.Height - DetailsgroupBox2.Height;
            }


            
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (TextradioButton2.Checked)
            {
                numericUpDown1.Enabled = false;
                SearchtextBox.Enabled = true;
                CSVtextBox.Enabled = false;
                CSVbutton.Enabled = false;
                CSVtextBox.Text = null;
                Startutton.Enabled = false;


            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (IDNumradioButton1.Checked)
            {
                numericUpDown1.Enabled = true;
                SearchtextBox.Enabled = false;
                SearchtextBox.Text = null;
                CSVtextBox.Enabled = true;
                CSVbutton.Enabled = true;
                CSVtextBox.Text = null;
            }
        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            File.WriteAllBytes(locationToInstructionsPdf, Properties.Resources.Instructions); 
            System.Diagnostics.Process.Start(locationToInstructionsPdf); 

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show( "PDf Extractor 1.0", "About PDf Extractor");
        }


 
        List<KeyValuePair<int, string>> ID_Index(string PdfFile, string singleText, string dataType)
        {

            //Setup Variabled
            var list = new List<KeyValuePair<int, string>>();
            var reg = new Regex(@"\b\d{" + numericUpDown1.Value + @"}\b");
             
            string PreviousMatch ="";



            Statuslabel1.Text = "Indexing... ";
            Statuslabel1.Invalidate();
            Statuslabel1.Update();



            // Intialize a new PdfReader instance with the contents of the source Pdf file:  

            PdfReader reader = new PdfReader(PdfFile);
            PdfDocument pdfDoc = new PdfDocument(reader);


            //setup progresss for indexing
            progressBar1.Maximum = pdfDoc.GetNumberOfPages();


            //Search through every page of the document for the index item.
            for (int pageNumber = 1; pageNumber <= pdfDoc.GetNumberOfPages(); pageNumber++)
            {

                progressBar1.Value = pageNumber;

                //Read contents of page
                ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                string currentPageText = PdfTextExtractor.GetTextFromPage(pdfDoc.GetPage(pageNumber), strategy);


                //If the Index data requested is a numerial value, use the number of digits chosen by the number numberic up down control
                if (dataType == "id")
                {
                    //Check with the regular expression
                    Match matched = reg.Match(currentPageText);
                    

                    //If found add the key value pair to the list if found. If there is no number found, then assume the page is the same ID index as the previous page.
                    if (matched.Success)
                            {
                list.Add(new KeyValuePair<int, string>(pageNumber, matched.Value));
                StatusrichTextBox.AppendText(pageNumber + "," + matched.ToString() + Environment.NewLine);
                        PreviousMatch = matched.Value;
                    }
                    else
                    {
                        list.Add(new KeyValuePair<int, string>(pageNumber, PreviousMatch));
                        StatusrichTextBox.AppendText(pageNumber + "," + PreviousMatch + Environment.NewLine);

                    }
                   
                    
                    
                }
                //Add the key value pair to the list if the index is not numberical and instead the string in the search text box
                else 
                {

                    if (currentPageText.IndexOf(singleText, StringComparison.OrdinalIgnoreCase) >= 0)
                    {

                        list.Add(new KeyValuePair<int, string>(pageNumber, singleText));
                        StatusrichTextBox.AppendText(pageNumber + "," + singleText + Environment.NewLine);
                    }
                }

                


            }

            //Close the source PDF handle and return the key value pair list.
            pdfDoc.Close();
            return list;

        }

        void Extract_the_PDFs(string PdfFile, string csvFile, List<KeyValuePair<int, string>> pdfKeys, bool single )
        {

            //----------------------------------------------------------------------------------------------------------------------------------------------------

            // Intialize a new PdfReader instance with the contents of the source Pdf file:  
            PdfReader readerExtract = new PdfReader(PdfFile);
            PdfDocument pdfDocExtract = new PdfDocument(readerExtract);

            List IDsNotFound = new List().SetListSymbol("");

       

           

            Statuslabel1.Text = "Extracting... ";
            Statuslabel1.Invalidate();
            Statuslabel1.Update();

            // EXTRACT single Item ##############################################################


            if(single)
            {
                //open the source PDF

                FileInfo file = new FileInfo(PdfFile);
                string pdfFileName = file.Name.Substring(0, file.Name.LastIndexOf(".")) + "-" + SearchtextBox.Text;
                string outputPath = file.Directory.FullName;
                string FilePath = outputPath + "\\" + pdfFileName + ".pdf";
                StatusrichTextBox.AppendText("File to extract " + FilePath + Environment.NewLine);

                List<int> allKeys = (from kvp in pdfKeys select kvp.Key).Distinct().ToList();
                PdfDocument OutpdfDoc = new PdfDocument(new PdfWriter(FilePath));

                foreach (int myKey in allKeys)
                {
                    pdfDocExtract.CopyPagesTo(myKey, myKey, OutpdfDoc);
                }
                //Close handles
                pdfDocExtract.Close();
                OutpdfDoc.Close();

                //Open extracted folder if the check box is selected.
                if (OpenDestcheckBox4.Checked)
                {
                    System.Diagnostics.Process.Start(outputPath);
                }

            }
            else
            {
                //Extract Based in CSV
                
                FileInfo file = new FileInfo(PdfFile);

                //Memory Stream to create the extracted document

                var MEMstream = new MemoryStream();
                var writer = new PdfWriter(MEMstream);
                var pdf = new PdfDocument(writer);

                //Set up extracted file variables
                string pdfFileName = file.Name.Substring(0, file.Name.LastIndexOf(".")) + "-Extracted";
                string outputPath = file.Directory.FullName;
                string FilePath = outputPath + "\\" + pdfFileName + ".pdf";
                StatusrichTextBox.AppendText("File to extract " + FilePath + Environment.NewLine);

                //working list to extract multiple pages based on index searched to keep them together.
                List<KeyValuePair<int, string>> MultiExtract = new List<KeyValuePair<int, string>>();

                PdfDocument OutpdfDoc = new PdfDocument(writer);


                //Progess bar setup for extraction
                var lines = File.ReadAllLines(csvFile);
                var count = 0;
                progressBar1.Value = 0;
                progressBar1.Maximum = lines.Length;



                //------------- search the list for the input file contents and extract the matching page to the new PDF
                foreach (string ID in System.IO.File.ReadLines(csvFile))
                {
                    
                    StatusrichTextBox.AppendText("Looking for: " + ID + "...." + Environment.NewLine);

                    //Find the ID in the keyvalue pair to get the page number for extracting.
                                        
                    MultiExtract = pdfKeys.FindAll(x => x.Value == ID);

                    //If more than one occurance of the index value is found, extract all the pages together.
                    if (MultiExtract.Count > 0)
                    {
                        //If split files is cheched initialize a new pdf writer and export file name that included the serached index value.
                        if (SplitCheckBox3.Checked)
                        {
                            
                            string multi_pdfFileName = file.Name.Substring(0, file.Name.LastIndexOf(".")) + "-" + ID;
                            string multi_outputPath = file.Directory.FullName;
                            string Multi_FilePath = multi_outputPath + "\\" + multi_pdfFileName + ".pdf";
                            PdfDocument multi_OutpdfDoc = new PdfDocument(new PdfWriter(Multi_FilePath));


                            foreach (KeyValuePair<int, string> kvp in MultiExtract)
                            {                               

                                StatusrichTextBox.AppendText("Found " + ID + " On page " + kvp.Key + " ... Extracting." + Environment.NewLine);
                                pdfDocExtract.CopyPagesTo(kvp.Key, kvp.Key, multi_OutpdfDoc);
                            }
                            //Close the pdf writer to create the file and prepare for the new file to extract
                            multi_OutpdfDoc.Close();
                            StatusrichTextBox.AppendText("File extracted " + Multi_FilePath + Environment.NewLine);

                        }
                        //Extract the pages without splitting the files
                        else
                        {
                            foreach (KeyValuePair<int, string> kvp in MultiExtract)
                            {
                                StatusrichTextBox.AppendText("Found " + ID + " On page " + kvp.Key + " ... Extracting." + Environment.NewLine);
                                pdfDocExtract.CopyPagesTo(kvp.Key, kvp.Key, OutpdfDoc);
                            }
                        }
                       

                    }
                    //If the serached vakue is not found, add that value to the not found pdf 
                    else
                    {
                        IDsNotFound.Add(ID);
                        System.Console.WriteLine("Did not find Key for {0}", ID);
                        StatusrichTextBox.AppendText("Did not find " + ID + Environment.NewLine);
                    }


                    //Increment the counter for the status bar
                    progressBar1.Value = count;
                    count++;

                }

                //Write IDs not found to PDF
                Statuslabel1.Text = "Writing missing... ";
                Statuslabel1.Invalidate();
                Statuslabel1.Update();
                progressBar1.Maximum = 0;
                progressBar1.Maximum = 100;
                progressBar1.Value = 75;

                StatusrichTextBox.AppendText("Extracting list of items not found" + Environment.NewLine);
                // Create pdf file of not found IDs
                
                string ErrorpdfFileName = file.Name.Substring(0, file.Name.LastIndexOf(".")) + "-Not_Found";
                string ErrorFilePath = outputPath + "\\" + ErrorpdfFileName + ".pdf";
                PdfDocument ErrorOutpdfDoc = new PdfDocument(new PdfWriter(ErrorFilePath));
                Document Errordocument = new Document(ErrorOutpdfDoc);



                //Create the PDF document layout with the not found items.
                Paragraph header = new Paragraph("NOT FOUND").SetTextAlignment(TextAlignment.CENTER).SetFontSize(20).SetFontColor(ColorConstants.RED);


                Errordocument.Add(header);

                // Line separator
                LineSeparator ls = new LineSeparator(new SolidLine());
                Errordocument.Add(ls);

                Paragraph newline = new Paragraph(new Text("\n"));
                Errordocument.Add(newline);


                

                Console.WriteLine(IDsNotFound);

                Errordocument.Add(IDsNotFound);

                //If the extracting function extracted multiple files, then this checks that the initial writer pdf is empty and closes it without writing to disk if empty or writes the file if there are pages present.
                if (OutpdfDoc.GetNumberOfPages() > 0)
                {
                    OutpdfDoc.Close();


                    var result = MEMstream.ToArray();


                    File.WriteAllBytes(FilePath, result);
                    StatusrichTextBox.AppendText("File extracted " + FilePath + Environment.NewLine);
                }


                else
                {
                    OutpdfDoc.Close();
                }

                //Close handles
                pdfDocExtract.Close();
                
                ErrorOutpdfDoc.Close();

                
                StatusrichTextBox.AppendText("Not found " + ErrorFilePath + Environment.NewLine);

                if (OpenDestcheckBox4.Checked)
                {
                    System.Diagnostics.Process.Start(outputPath);
                }
                if (OpenExtractedcheckBox2.Checked)
                {
                    System.Diagnostics.Process.Start(FilePath);
                }
                
                //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$ END CSV PDF EXTRACT $$$$$$$$$$$$$$$$$$$$$$$$$
            }
                 


            


        }

        private void PDFtextBox_TextChanged(object sender, EventArgs e)
        {
            CSVbutton.Enabled = true;
        }

        private void CSVtextBox_TextChanged(object sender, EventArgs e)
        {
            Startutton.Enabled = true;
        }

        private void SearchtextBox_TextChanged(object sender, EventArgs e)
        {
            Startutton.Enabled= true;
        }

        private void SplitCheckBox3_CheckedChanged(object sender, EventArgs e)
        {

            if (SplitCheckBox3.Checked)
            {
                OpenExtractedcheckBox2.Checked = false;
                OpenExtractedcheckBox2.Enabled = false;
            }
            if (!SplitCheckBox3.Checked)
            {
                
                OpenExtractedcheckBox2.Enabled = true;
            }
            
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Delete the manual pdf file on close if it exitsts.
            //System temp folder cleanup
            if(File.Exists(locationToInstructionsPdf))
                {

                File.Delete(locationToInstructionsPdf);
                }
            

        }
    }
}
