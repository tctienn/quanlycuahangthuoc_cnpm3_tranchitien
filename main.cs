using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

using Excel = Microsoft.Office.Interop.Excel;
//using Word = Microsoft.Office.Interop.Word;


namespace quanlycuahangthuoc
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtTenphong.Text)) || (string.IsNullOrEmpty(txtSoluong.Text)))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
            else
            {
                ListViewItem item = new ListViewItem();
                item.Text = txtTenphong.Text;
                listView1.Items.Add(item);
                //ListViewItem.ListViewSubItem subitem1 = new ListViewItem.ListViewSubItem(item, (txtTenphong.Text));
                //item.SubItems.Add(subitem1);
                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, (txtSoluong.Text));
                item.SubItems.Add(subitem);




                ListViewItem.ListViewSubItem ay = new ListViewItem.ListViewSubItem(item, (demo.Text));
                item.SubItems.Add(ay);

                txtTenphong.Clear();
                txtSoluong.Clear();
                txtTenphong.Focus();


                //string duong_dan = listview.SelectedItems[0].SubItems[2].Text; lấy giá trị của listview
            }

        }

        private void main_Load(object sender, EventArgs e)
        {

            this.rpv.RefreshReport();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                object oMissing = System.Reflection.Missing.Value;
                object oEndOfDoc = "\\endofdoc"; /* \endofdoc is a predefined bookmark */

                //Start Word and create a new document.
                Word._Application oWord;
                Word._Document oDoc;
                oWord = new Word.Application();
                oWord.Visible = true;
                oDoc = oWord.Documents.Add(ref oMissing, ref oMissing,
                ref oMissing, ref oMissing);

                //Insert a paragraph at the beginning of the document.
                Word.Paragraph oPara1;
                oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
                oPara1.Range.Text = "Heading 1";
                oPara1.Range.Font.Bold = 1;
                oPara1.Format.SpaceAfter = 24;    //24 pt spacing after paragraph.
                oPara1.Range.InsertParagraphAfter();

                Thread.Sleep(8000);  //có vấn đề gio word chưa kích hoạt nên phải đợi để tắt form kích hoạt rồi mới chạy
                //Insert a paragraph at the end of the document.
                Word.Paragraph oPara2;
                object oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                oPara2 = oDoc.Content.Paragraphs.Add(ref oRng);
                oPara2.Range.Text = "Heading 2";
                oPara2.Format.SpaceAfter = 6;
                oPara2.Range.InsertParagraphAfter();

                //Insert another paragraph.
                Word.Paragraph oPara3;
                oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                oPara3 = oDoc.Content.Paragraphs.Add(ref oRng);
                oPara3.Range.Text = "This is a sentence of normal text. Now here is a table:";
                oPara3.Range.Font.Bold = 0;
                oPara3.Format.SpaceAfter = 24;
                oPara3.Range.InsertParagraphAfter();

                //Insert a 3 x 5 table, fill it with data, and make the first row
                //bold and italic.
                Word.Table oTable;
                Word.Range wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                oTable = oDoc.Tables.Add(wrdRng, 3, 5, ref oMissing, ref oMissing);
                oTable.Range.ParagraphFormat.SpaceAfter = 6;
                int r, c;
                string strText;
                for (r = 1; r <= 3; r++)
                    for (c = 1; c <= 5; c++)
                    {
                        strText = "r" + r + "c 2" + c;
                        oTable.Cell(r, c).Range.Text = strText;
                    }
                oTable.Rows[1].Range.Font.Bold = 1;
                oTable.Rows[1].Range.Font.Italic = 1;

                //Add some text after the table.
                Word.Paragraph oPara4;
                oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                oPara4 = oDoc.Content.Paragraphs.Add(ref oRng);
                oPara4.Range.InsertParagraphBefore();
                oPara4.Range.Text = "And here's another table:";
                oPara4.Format.SpaceAfter = 24;
                oPara4.Range.InsertParagraphAfter();

                //Insert a 5 x 2 table, fill it with data, and change the column widths.
                wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                oTable = oDoc.Tables.Add(wrdRng, 5, 2, ref oMissing, ref oMissing);
                oTable.Range.ParagraphFormat.SpaceAfter = 6;
                for (r = 1; r <= 5; r++)
                    for (c = 1; c <= 2; c++)
                    {
                        strText = "r" + r + "c" + c;
                        oTable.Cell(r, c).Range.Text = strText;
                    }
                oTable.Columns[1].Width = oWord.InchesToPoints(2); //Change width of columns 1 & 2
                oTable.Columns[2].Width = oWord.InchesToPoints(3);

                //Keep inserting text. When you get to 7 inches from top of the
                //document, insert a hard page break.
                object oPos;
                double dPos = oWord.InchesToPoints(7);
                oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range.InsertParagraphAfter();
                do
                {
                    wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                    wrdRng.ParagraphFormat.SpaceAfter = 6;
                    wrdRng.InsertAfter("A line of text");
                    wrdRng.InsertParagraphAfter();
                    oPos = wrdRng.get_Information
                                           (Word.WdInformation.wdVerticalPositionRelativeToPage);
                }
                while (dPos >= Convert.ToDouble(oPos));
                object oCollapseEnd = Word.WdCollapseDirection.wdCollapseEnd;
                object oPageBreak = Word.WdBreakType.wdPageBreak;
                wrdRng.Collapse(ref oCollapseEnd);
                wrdRng.InsertBreak(ref oPageBreak);
                wrdRng.Collapse(ref oCollapseEnd);
                wrdRng.InsertAfter("We're now on page 2. Here's my chart:");
                wrdRng.InsertParagraphAfter();

                //Insert a chart.
                Word.InlineShape oShape;
                object oClassType = "MSGraph.Chart.8";
                wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                oShape = wrdRng.InlineShapes.AddOLEObject(ref oClassType, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing);

                //Demonstrate use of late bound oChart and oChartApp objects to
                //manipulate the chart object with MSGraph.
                object oChart;
                object oChartApp;
                oChart = oShape.OLEFormat.Object;
                oChartApp = oChart.GetType().InvokeMember("Application",
                BindingFlags.GetProperty, null, oChart, null);

                //Change the chart type to Line.
                object[] Parameters = new Object[1];
                Parameters[0] = 4; //xlLine = 4
                oChart.GetType().InvokeMember("ChartType", BindingFlags.SetProperty,
                null, oChart, Parameters);

                //Update the chart image and quit MSGraph.
                oChartApp.GetType().InvokeMember("Update",
                BindingFlags.InvokeMethod, null, oChartApp, null);
                oChartApp.GetType().InvokeMember("Quit",
                BindingFlags.InvokeMethod, null, oChartApp, null);
                //... If desired, you can proceed from here using the Microsoft Graph 
                //Object model on the oChart and oChartApp objects to make additional
                //changes to the chart.

                //Set the width of the chart.
                oShape.Width = oWord.InchesToPoints(6.25f);
                oShape.Height = oWord.InchesToPoints(3.57f);

                //Add text after the chart.
                wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                wrdRng.InsertParagraphAfter();
                wrdRng.InsertAfter("THE END.");

                //Close this form.
                this.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Excel.Application oXL;
            Excel._Workbook oWB;
            Excel._Worksheet oSheet;
            Excel.Range oRng;

            try
            {
                //Start Excel and get Application object.
                oXL = new Excel.Application();
                oXL.Visible = true;

                Thread.Sleep(8000);
                //Get a new workbook.
                oWB = (Excel._Workbook)(oXL.Workbooks.Add(Missing.Value));
                oSheet = (Excel._Worksheet)oWB.ActiveSheet;

                //Add table headers going cell by cell.
                oSheet.Cells[1, 1] = "First Name";
                oSheet.Cells[1, 2] = "Last Name";
                oSheet.Cells[1, 3] = "Full Name";
                oSheet.Cells[1, 4] = "Salary";

                //Format A1:D1 as bold, vertical alignment = center.
                oSheet.get_Range("A1", "D1").Font.Bold = true;
                oSheet.get_Range("A1", "D1").VerticalAlignment =
                Excel.XlVAlign.xlVAlignCenter;

                // Create an array to multiple values at once.
                string[,] saNames = new string[5, 2];

                saNames[0, 0] = "John";
                saNames[0, 1] = "Smith";
                saNames[1, 0] = "Tom";
                saNames[1, 1] = "Brown";
                saNames[2, 0] = "Sue";
                saNames[2, 1] = "Thomas";
                saNames[3, 0] = "Jane";
                saNames[3, 1] = "Jones";
                saNames[4, 0] = "Adam";
                saNames[4, 1] = "Johnson";

                //Fill A2:B6 with an array of values (First and Last Names).
                oSheet.get_Range("A2", "B6").Value2 = saNames;

                //Fill C2:C6 with a relative formula (=A2 & " " & B2).
                oRng = oSheet.get_Range("C2", "C6");
                oRng.Formula = "=A2 & \" \" & B2";

                //Fill D2:D6 with a formula(=RAND()*100000) and apply format.
                oRng = oSheet.get_Range("D2", "D6");
                oRng.Formula = "=RAND()*100000";
                oRng.NumberFormat = "$0.00";

                //AutoFit columns A:D.
                oRng = oSheet.get_Range("A1", "D1");
                oRng.EntireColumn.AutoFit();

                //Manipulate a variable number of columns for Quarterly Sales Data.
                DisplayQuarterlySales(oSheet);

                //Make sure Excel is visible and give the user control
                //of Microsoft Excel's lifetime.
                oXL.Visible = true;
                oXL.UserControl = true;
            }
            catch (Exception theException)
            {
                String errorMessage;
                errorMessage = "Error: ";
                errorMessage = String.Concat(errorMessage, theException.Message);
                errorMessage = String.Concat(errorMessage, " Line: ");
                errorMessage = String.Concat(errorMessage, theException.Source);

                MessageBox.Show(errorMessage, "Error");
            }

        }

        /// vẫn của excel
        private void DisplayQuarterlySales(Excel._Worksheet oWS)
        {
            Excel._Workbook oWB;
            Excel.Series oSeries;
            Excel.Range oResizeRange;
            Excel._Chart oChart;
            String sMsg;
            int iNumQtrs;

            //Determine how many quarters to display data for.
            for (iNumQtrs = 4; iNumQtrs >= 2; iNumQtrs--)
            {
                sMsg = "Enter sales data for ";
                sMsg = String.Concat(sMsg, iNumQtrs);
                sMsg = String.Concat(sMsg, " quarter(s)?");

                DialogResult iRet = MessageBox.Show(sMsg, "Quarterly Sales?",
                MessageBoxButtons.YesNo);
                if (iRet == DialogResult.Yes)
                    break;
            }

            sMsg = "Displaying data for ";
            sMsg = String.Concat(sMsg, iNumQtrs);
            sMsg = String.Concat(sMsg, " quarter(s).");

            MessageBox.Show(sMsg, "Quarterly Sales");

            //Starting at E1, fill headers for the number of columns selected.
            oResizeRange = oWS.get_Range("E1", "E1").get_Resize(Missing.Value, iNumQtrs);
            oResizeRange.Formula = "=\"Q\" & COLUMN()-4 & CHAR(10) & \"Sales\"";

            //Change the Orientation and WrapText properties for the headers.
            oResizeRange.Orientation = 38;
            oResizeRange.WrapText = true;

            //Fill the interior color of the headers.
            oResizeRange.Interior.ColorIndex = 36;

            //Fill the columns with a formula and apply a number format.
            oResizeRange = oWS.get_Range("E2", "E6").get_Resize(Missing.Value, iNumQtrs);
            oResizeRange.Formula = "=RAND()*100";
            oResizeRange.NumberFormat = "$0.00";

            //Apply borders to the Sales data and headers.
            oResizeRange = oWS.get_Range("E1", "E6").get_Resize(Missing.Value, iNumQtrs);
            oResizeRange.Borders.Weight = Excel.XlBorderWeight.xlThin;

            //Add a Totals formula for the sales data and apply a border.
            oResizeRange = oWS.get_Range("E8", "E8").get_Resize(Missing.Value, iNumQtrs);
            oResizeRange.Formula = "=SUM(E2:E6)";
            oResizeRange.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle
            = Excel.XlLineStyle.xlDouble;
            oResizeRange.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).Weight
            = Excel.XlBorderWeight.xlThick;

            //Add a Chart for the selected data.
            oWB = (Excel._Workbook)oWS.Parent;
            oChart = (Excel._Chart)oWB.Charts.Add(Missing.Value, Missing.Value,
            Missing.Value, Missing.Value);

            //Use the ChartWizard to create a new chart from the selected data.
            oResizeRange = oWS.get_Range("E2:E6", Missing.Value).get_Resize(
            Missing.Value, iNumQtrs);
            oChart.ChartWizard(oResizeRange, Excel.XlChartType.xl3DColumn, Missing.Value,
            Excel.XlRowCol.xlColumns, Missing.Value, Missing.Value, Missing.Value,
            Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            oSeries = (Excel.Series)oChart.SeriesCollection(1);
            oSeries.XValues = oWS.get_Range("A2", "A6");
            for (int iRet = 1; iRet <= iNumQtrs; iRet++)
            {
                oSeries = (Excel.Series)oChart.SeriesCollection(iRet);
                String seriesName;
                seriesName = "=\"Q";
                seriesName = String.Concat(seriesName, iRet);
                seriesName = String.Concat(seriesName, "\"");
                oSeries.Name = seriesName;
            }

            oChart.Location(Excel.XlChartLocation.xlLocationAsObject, oWS.Name);

            //Move the chart so as not to cover your data.
            oResizeRange = (Excel.Range)oWS.Rows.get_Item(10, Missing.Value);
            oWS.Shapes.Item("Chart 1").Top = (float)(double)oResizeRange.Top;
            oResizeRange = (Excel.Range)oWS.Columns.get_Item(2, Missing.Value);
            oWS.Shapes.Item("Chart 1").Left = (float)(double)oResizeRange.Left;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            MessageBox.Show("Ví dụ về cái Icon nè", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void rpv_Load(object sender, EventArgs e)
        {

        }
    }
}
