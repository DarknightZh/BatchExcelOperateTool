using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using TextBox = System.Windows.Forms.TextBox;
using System.CodeDom.Compiler;

namespace BatchExcelOpetateTool
{
	public partial class MainForm : Form
    {
		private List<String> SourceFiles = new List<String>();
		string SheetName = "";
		string RowName = "";
		string ColName = "";
		string ModifyValue = "";

        public MainForm()
        {
            InitializeComponent();

			SourceFileGridView.Columns.Add("FileName", "File Name");
			SourceFileGridView.Columns.Add("FilePath", "File Path");
		}

		private void SourceFileGridView_Click(object sender, EventArgs e)
		{
			
		}
		private void SourceFileGridView_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.All;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private void SourceFileGridView_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

				foreach (string file in files)
				{
					string FileName = System.IO.Path.GetFileName(file);
					string FilePath = file;

					if (SourceFiles.Contains(FilePath) || !IsExcelFile(FilePath))
					{
						return;
					}

					SourceFiles.Add(FilePath);
					// 添加文件信息到DataGridView
					SourceFileGridView.Rows.Add(FileName, FilePath);
				}
			}
		}

		static bool IsExcelFile(string filePath)
		{
			string extension = Path.GetExtension(filePath).ToLower();
			return extension == ".xls" || extension == ".xlsx";
		}

		void ModifyExcelFile(string FilePath, string SheetName, string RowName, string ColName, string Value)
		{
			Excel.Application ExcelApp = new Excel.Application();
			Excel.Workbook WorkBook = ExcelApp.Workbooks.Open(FilePath);

			Excel.Worksheet WorkSheet = null;
			bool SheetExists = false;
			foreach (Excel.Worksheet Sheet in WorkBook.Sheets)
			{
				if (Sheet.Name == SheetName)
				{
					SheetExists = true;
					WorkSheet = Sheet;
					break;
				}
			}

			if (!SheetExists)
			{
				WorkSheet = WorkBook.Sheets.Add();
				WorkSheet.Name = SheetName;
			}

			// 查找第一列中的RowIndex
			int RowIndex = -1;
			for (int row = 1; row <= WorkSheet.UsedRange.Rows.Count; row++)
			{
				Excel.Range cell = WorkSheet.Cells[row, 1] as Excel.Range;
				if (cell.Value != null && cell.Value.ToString().Replace("\n", "") == RowName)
				{
					RowIndex = row;
					break;
				}
			}
			if (RowIndex == -1)
			{
				RowIndex = WorkSheet.UsedRange.Rows.Count + 1;
				WorkSheet.Cells[RowIndex, 1] = RowName;
			}

			// 查找第一行中的ColIndex
			int ColIndex = -1;
			for (int col = 1; col <= WorkSheet.UsedRange.Columns.Count; col++)
			{
				Excel.Range cell = WorkSheet.Cells[1, col] as Excel.Range;
				if (cell.Value != null && cell.Value.ToString().Replace("\n", "") == ColName)
				{
					ColIndex = col;
					break;
				}
			}
			if (ColIndex == -1)
			{
				ColIndex = WorkSheet.UsedRange.Columns.Count + 1;
				WorkSheet.Cells[1, ColIndex] = ColName;
			}

			// 修改交会处的值
			if (RowIndex != -1 && ColIndex != -1)
			{
				Excel.Range targetCell = WorkSheet.Cells[RowIndex, ColIndex] as Excel.Range;
				targetCell.Value = Value;
			}
	
			if (WorkBook.ReadOnly)
			{
				string FileName = System.IO.Path.GetFileName(FilePath);
				MessageBox.Show("The " + FileName + " is read-only. It will not be saved");
			}
			else
			{
				WorkBook.Save();
			}

			WorkBook.Close(false);
			ExcelApp.Quit();
			System.Runtime.InteropServices.Marshal.ReleaseComObject(WorkSheet);
			System.Runtime.InteropServices.Marshal.ReleaseComObject(WorkBook);
			System.Runtime.InteropServices.Marshal.ReleaseComObject(ExcelApp);
		}

		private void SheetTextBox_TextChanged(object sender, EventArgs e)
		{
			TextBox textBox = sender as TextBox;
			if (textBox != null)
			{
				SheetName = textBox.Text;
			}
		}

		private void RowKeyTextBox_TextChanged(object sender, EventArgs e)
		{
			TextBox textBox = sender as TextBox;
			if (textBox != null)
			{
				RowName = textBox.Text;
			}
		}

		private void ColKeyTextBox_TextChanged(object sender, EventArgs e)
		{
			TextBox textBox = sender as TextBox;
			if (textBox != null)
			{
				ColName = textBox.Text;
			}
		}

		private void ModifyValueTextBox_TextChanged(object sender, EventArgs e)
		{
			TextBox textBox = sender as TextBox;
			if (textBox != null)
			{
				ModifyValue = textBox.Text;
			}
		}

		private void ModifyButton_Click(object sender, EventArgs e)
		{
			foreach(string File in SourceFiles)
			{
				ModifyExcelFile(File, SheetName, RowName, ColName, ModifyValue);
			}
			MessageBox.Show("Execution ends");
		}

		private void SourceFileGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.RowIndex < ((DataGridView)sender).Rows.Count)
			{	
				SourceFileGridView.Rows.RemoveAt(e.RowIndex);
				SourceFiles.RemoveAt(e.RowIndex);
			}
		}

		private void panel2_Resize(object sender, EventArgs e)
		{
			panel2.Top = panel1.Bottom;
			panel2.Height = 250;
		}
	}
}
