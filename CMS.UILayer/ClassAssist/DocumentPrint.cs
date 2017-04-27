
//*************************************************************************************************
//** 创建人:桂书丛
//** 类名称:DocumentPrint
//** 类功能:数据打印(&P)类
//** 创建日期:2012-12-28
//** 描 述: 数据打印(&P)的实现
//** 整理日期：2012-12-28
//*************************************************************************************************

using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
namespace CMS.UILayer.ClassAssist
{
    class DocumentPrint
    {
        private static StringFormat StrFormat;
        private static StringFormat StrFormatComboBox;
        private static Button CellButton;
        private static CheckBox CellCheckBox;
        private static ComboBox CellComboBox;

        private static int TotalWidth;          // 求和列的宽度
        private static int RowPos;              // 目前位置印刷行
        private static bool NewPage;            // 如果达到了新的一页指示
        private static int PageNo;              // 页数打印(&P)
        private static ArrayList ColumnLefts = new ArrayList();  //左柱坐标
        private static ArrayList ColumnWidths = new ArrayList(); // 列宽度
        private static ArrayList ColumnTypes = new ArrayList();  // 数据类型的列
        private static int CellHeight;          // 高度的DataGrid单元格
        private static int RowsPerPage;         // 数每页的行
        private static System.Drawing.Printing.PrintDocument printDoc =
                       new System.Drawing.Printing.PrintDocument();  //PrintDocumnet对象用于印刷

        private static string PrintTitle = string.Empty;  // 页面标题的
        private static DataGridView dgv;        // DataGridView对象的内容打印(&P)
        private static List<string> SelectedColumns = new List<string>();   // 由用户选定的列打印(&P)。
        private static List<string> AvailableColumns = new List<string>();
        private static bool PrintAllRows = true;
        private static bool FitToPageWidth = true;
        private static int HeaderHeight = 0;

        public static void Print_DataGridView(DataGridView dgv1)
        {
            PrintPreviewDialog ppvw;
            try
            {
                // 使用的DataGridView对象打印(&P)
                dgv = dgv1;

                // 在DataGridView获取所有Coulmns名称
                AvailableColumns.Clear();
                foreach (DataGridViewColumn c in dgv.Columns)
                {
                    if (!c.Visible) continue;
                    AvailableColumns.Add(c.HeaderText);
                }

                // 显示打印(&P)设置窗体
                frmOther.frmPrintSet dlg = new CMS.UILayer.frmOther.frmPrintSet(AvailableColumns);
                //PrintOptions dlg = new PrintOptions(AvailableColumns);
                if (dlg.ShowDialog() != DialogResult.OK) return;

                PrintTitle = dlg.PrintTitle;
                PrintAllRows = dlg.PrintAllRows;
                FitToPageWidth = dlg.FitToPageWidth;
                SelectedColumns = dlg.GetSetlectedColumns();

                RowsPerPage = 0;

                ppvw = new PrintPreviewDialog();
                ppvw.Document = printDoc;

                // Showing the Print Preview Page
                printDoc.BeginPrint += new System.Drawing.Printing.PrintEventHandler(PrintDoc_BeginPrint);
                printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(PrintDoc_PrintPage);
                if (ppvw.ShowDialog() != DialogResult.OK)
                {
                    printDoc.BeginPrint -= new System.Drawing.Printing.PrintEventHandler(PrintDoc_BeginPrint);
                    printDoc.PrintPage -= new System.Drawing.Printing.PrintPageEventHandler(PrintDoc_PrintPage);
                    return;
                }

                // 打印(&P)对话框
                printDoc.Print();
                printDoc.BeginPrint += new System.Drawing.Printing.PrintEventHandler(PrintDoc_BeginPrint);
                printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(PrintDoc_PrintPage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        private static void PrintDoc_BeginPrint(object sender,
                    System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                // 单元格的内容打印(&P)
                StrFormat = new StringFormat();
                StrFormat.Alignment = StringAlignment.Near;
                StrFormat.LineAlignment = StringAlignment.Center;
                StrFormat.Trimming = StringTrimming.EllipsisCharacter;

                // 单元格的内容打印(&P)
                StrFormatComboBox = new StringFormat();
                StrFormatComboBox.LineAlignment = StringAlignment.Center;
                StrFormatComboBox.FormatFlags = StringFormatFlags.NoWrap;
                StrFormatComboBox.Trimming = StringTrimming.EllipsisCharacter;

                ColumnLefts.Clear();
                ColumnWidths.Clear();
                ColumnTypes.Clear();
                CellHeight = 0;
                RowsPerPage = 0;

                // For various column types
                CellButton = new Button();
                CellCheckBox = new CheckBox();
                CellComboBox = new ComboBox();

                // 列的类型
                TotalWidth = 0;
                foreach (DataGridViewColumn GridCol in dgv.Columns)
                {
                    if (!GridCol.Visible) continue;
                    if (!DocumentPrint.SelectedColumns.Contains(GridCol.HeaderText)) continue;
                    TotalWidth += GridCol.Width;
                }
                PageNo = 1;
                NewPage = true;
                RowPos = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void PrintDoc_PrintPage(object sender,
                    System.Drawing.Printing.PrintPageEventArgs e)
        {
            int tmpWidth, i;
            int tmpTop = e.MarginBounds.Top;
            int tmpLeft = e.MarginBounds.Left;

            try
            {
                // 在开始的第一页，这样可以节省的宽度和高度页眉和CoulmnType
                if (PageNo == 1)
                {
                    foreach (DataGridViewColumn GridCol in dgv.Columns)
                    {
                        if (!GridCol.Visible) continue;
                        // 跳过如果当前列未选中
                        if (!DocumentPrint.SelectedColumns.Contains(GridCol.HeaderText)) continue;


                        if (FitToPageWidth)
                            tmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                       (double)TotalWidth * (double)TotalWidth *
                                       ((double)e.MarginBounds.Width / (double)TotalWidth))));
                        else
                            tmpWidth = GridCol.Width;

                        HeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font, tmpWidth).Height) + 11;

                        // 保存的宽度与高度headres和ColumnType
                        ColumnLefts.Add(tmpLeft);
                        ColumnWidths.Add(tmpWidth);
                        ColumnTypes.Add(GridCol.GetType());
                        tmpLeft += tmpWidth;
                    }
                }

                // 打印(&P)当前页，由一排排
                while (RowPos <= dgv.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = dgv.Rows[RowPos];
                    if (GridRow.IsNewRow || (!PrintAllRows && !GridRow.Selected))
                    {
                        RowPos++;
                        continue;
                    }

                    CellHeight = GridRow.Height;

                    if (tmpTop + CellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        DrawFooter(e, RowsPerPage);
                        NewPage = true;
                        PageNo++;
                        e.HasMorePages = true;
                        return;
                    }
                    else
                    {
                        if (NewPage)
                        {
                            // 绘制标题
                            e.Graphics.DrawString(PrintTitle, new Font(dgv.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                            e.Graphics.MeasureString(PrintTitle, new Font(dgv.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String s = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();

                            e.Graphics.DrawString(s, new Font(dgv.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(s, new Font(dgv.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString(PrintTitle, new Font(new Font(dgv.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            // 绘制列
                            tmpTop = e.MarginBounds.Top;
                            i = 0;
                            foreach (DataGridViewColumn GridCol in dgv.Columns)
                            {
                                if (!GridCol.Visible) continue;
                                if (!DocumentPrint.SelectedColumns.Contains(GridCol.HeaderText))
                                    continue;

                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new Rectangle((int)ColumnLefts[i], tmpTop,
                                    (int)ColumnWidths[i], HeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)ColumnLefts[i], tmpTop,
                                    (int)ColumnWidths[i], HeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)ColumnLefts[i], tmpTop,
                                    (int)ColumnWidths[i], HeaderHeight), StrFormat);
                                i++;
                            }
                            NewPage = false;
                            tmpTop += HeaderHeight;
                        }

                        // 绘制列内容
                        i = 0;
                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (!Cel.OwningColumn.Visible) continue;
                            if (!SelectedColumns.Contains(Cel.OwningColumn.HeaderText))
                                continue;

                            //为TextBox列
                            if (((Type)ColumnTypes[i]).Name == "DataGridViewTextBoxColumn" ||
                                ((Type)ColumnTypes[i]).Name == "DataGridViewLinkColumn")
                            {
                                e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                        new SolidBrush(Cel.InheritedStyle.ForeColor),
                                        new RectangleF((int)ColumnLefts[i], (float)tmpTop,
                                        (int)ColumnWidths[i], (float)CellHeight), StrFormat);
                            }
                            //为 Button 列
                            else if (((Type)ColumnTypes[i]).Name == "DataGridViewButtonColumn")
                            {
                                CellButton.Text = Cel.Value.ToString();
                                CellButton.Size = new Size((int)ColumnWidths[i], CellHeight);
                                Bitmap bmp = new Bitmap(CellButton.Width, CellButton.Height);
                                CellButton.DrawToBitmap(bmp, new Rectangle(0, 0,
                                        bmp.Width, bmp.Height));
                                e.Graphics.DrawImage(bmp, new Point((int)ColumnLefts[i], tmpTop));
                            }
                            // 为 CheckBox 列
                            else if (((Type)ColumnTypes[i]).Name == "DataGridViewCheckBoxColumn")
                            {
                                CellCheckBox.Size = new Size(14, 14);
                                CellCheckBox.Checked = (bool)Cel.Value;
                                Bitmap bmp = new Bitmap((int)ColumnWidths[i], CellHeight);
                                Graphics tmpGraphics = Graphics.FromImage(bmp);
                                tmpGraphics.FillRectangle(Brushes.White, new Rectangle(0, 0,
                                        bmp.Width, bmp.Height));
                                CellCheckBox.DrawToBitmap(bmp,
                                        new Rectangle((int)((bmp.Width - CellCheckBox.Width) / 2),
                                        (int)((bmp.Height - CellCheckBox.Height) / 2),
                                        CellCheckBox.Width, CellCheckBox.Height));
                                e.Graphics.DrawImage(bmp, new Point((int)ColumnLefts[i], tmpTop));
                            }
                            //为 ComboBox列
                            else if (((Type)ColumnTypes[i]).Name == "DataGridViewComboBoxColumn")
                            {
                                CellComboBox.Size = new Size((int)ColumnWidths[i], CellHeight);
                                Bitmap bmp = new Bitmap(CellComboBox.Width, CellComboBox.Height);
                                CellComboBox.DrawToBitmap(bmp, new Rectangle(0, 0,
                                        bmp.Width, bmp.Height));
                                e.Graphics.DrawImage(bmp, new Point((int)ColumnLefts[i], tmpTop));
                                e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                        new SolidBrush(Cel.InheritedStyle.ForeColor),
                                        new RectangleF((int)ColumnLefts[i] + 1, tmpTop, (int)ColumnWidths[i]
                                        - 16, CellHeight), StrFormatComboBox);
                            }
                            // 为 Image列
                            else if (((Type)ColumnTypes[i]).Name == "DataGridViewImageColumn")
                            {
                                Rectangle CelSize = new Rectangle((int)ColumnLefts[i],
                                        tmpTop, (int)ColumnWidths[i], CellHeight);
                                Size ImgSize = ((Image)(Cel.FormattedValue)).Size;
                                e.Graphics.DrawImage((Image)Cel.FormattedValue,
                                        new Rectangle((int)ColumnLefts[i] + (int)((CelSize.Width - ImgSize.Width) / 2),
                                        tmpTop + (int)((CelSize.Height - ImgSize.Height) / 2),
                                        ((Image)(Cel.FormattedValue)).Width, ((Image)(Cel.FormattedValue)).Height));

                            }


                            e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)ColumnLefts[i],
                                    tmpTop, (int)ColumnWidths[i], CellHeight));

                            i++;

                        }
                        tmpTop += CellHeight;
                    }

                    RowPos++;
                    // 对于它计算的第一页每页行
                    if (PageNo == 1) RowsPerPage++;
                }

                if (RowsPerPage == 0) return;

                // 写页脚（页码）
                DrawFooter(e, RowsPerPage);

                e.HasMorePages = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void DrawFooter(System.Drawing.Printing.PrintPageEventArgs e,
                    int RowsPerPage)
        {
            double cnt = 0;

            // 打印(&P)的行数
            if (PrintAllRows)
            {
                if (dgv.Rows[dgv.Rows.Count - 1].IsNewRow)
                    cnt = dgv.Rows.Count - 2; // 当在DataGridView不允许添加(&A)行
                else
                    cnt = dgv.Rows.Count - 1; // 当在DataGridView允许添加(&A)行
            }
            else
                cnt = dgv.SelectedRows.Count;

            // 页面底部的页码
            string PageNum = " 第 " + PageNo.ToString()
                           + " 页，共 " + Math.Ceiling((double)(cnt / RowsPerPage)).ToString()
                           + " 页";

            e.Graphics.DrawString(PageNum, dgv.Font, Brushes.Black,
                e.MarginBounds.Left + (e.MarginBounds.Width -
                e.Graphics.MeasureString(PageNum, dgv.Font,
                e.MarginBounds.Width).Width) / 2, e.MarginBounds.Top +
                e.MarginBounds.Height + 31);
        }
    }
}
