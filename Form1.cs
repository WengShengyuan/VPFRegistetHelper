using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.Odbc;
using CommonUtils;

namespace VFPInprt
{
    public partial class Form1 : Form
    {
        OpenFileDialog openDbFile = new OpenFileDialog();
        DataSetHelper dsHelper  = new DataSetHelper();
        ODBCDB db;
        string dbFilePath = "";
        string excelFilePath = "";
        string workFileName = "";
        string workFolderPath = "";
        string connStr = "";
        OdbcConnection conn;
        DataTable oriDatadt;
        System.Collections.ArrayList allList;
        System.Collections.ArrayList outputList;
        System.Collections.ArrayList checkList;
        bool checkUnique;
        bool importBlank;
        string selectedColumns;
        string unselectedColumns;

        public Form1()
        {
            InitializeComponent();
        }



        /// <summary>
        /// 载入数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bn_loadDatabase_Click(object sender, EventArgs e)
        {

            try
            {
                this.openDbFile.Filter = "数据库文件(*.dbf)|*.dbf|所有文件(*.*)|*.*";
                if (this.openDbFile.ShowDialog() == DialogResult.OK)
                {
                    dbFilePath = this.openDbFile.FileName;
                    string[] tempstrs = dbFilePath.Split('\\');
                    workFolderPath = dbFilePath.Replace(tempstrs[tempstrs.Length - 1], "");
                    workFileName = tempstrs[tempstrs.Length - 1].Split('.')[0];
                    excelFilePath = workFolderPath + "\\" + workFileName + ".xls";
                    connStr = "Provider=vfpoledb.1;Data Source=" + dbFilePath +";";

                    // 备份数据库源文件
                    string backupdbFilePath = workFolderPath+"\\"+workFileName+"-backup.dbf";
                    if (File.Exists(backupdbFilePath))
                    {
                        File.Delete(backupdbFilePath);
                    } 
                    File.Copy(dbFilePath, backupdbFilePath);

                    db = new ODBCDB(connStr);
                    // 原始数据
                    oriDatadt = db.Query("select * from " + dbFilePath).Tables[0];

                    // 在界面上现实查询结果
                    string testresult = "载入完成！共 " + oriDatadt.Rows.Count.ToString() +" 条数据。";

                    checkLabel.Text = testresult;
                    tb_databasePath.Text = dbFilePath;
                    
                    lb_outportColumn.Items.Clear();
                    foreach (var v in oriDatadt.Columns)
                    {
                        lb_outportColumn.Items.Add(v.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bn_outportFile_Click(object sender, EventArgs e)
        {
            //导出EXCEL
            ListBox.SelectedObjectCollection selectedColumns = lb_outportColumn.SelectedItems;
            if (selectedColumns.Count <= 0)
            {
                MessageBox.Show("选择列不能为空");
                return;
            }

            try
            {
                if (File.Exists(excelFilePath))
                    File.Delete(excelFilePath);
                ExcelHelper.OutputToExcel(oriDatadt, getList(oriDatadt.Columns, selectedColumns), excelFilePath);

                // 在界面中添加列名
                lb_checkColumn.Items.Clear();
                foreach (var v in selectedColumns)
                {
                    lb_checkColumn.Items.Add(v.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bn_writeBack_Click(object sender, EventArgs e)
        {
            //写回数据库
            selectedColumns = "";
            unselectedColumns = "";

            checkUnique = cb_unique.Checked;
            importBlank = cb_import.Checked;

            ListBox.SelectedObjectCollection alterColumns = lb_checkColumn.SelectedItems;
            if(alterColumns.Count < 1)
            {
                MessageBox.Show("选择字段不能为空");
                return;
            }
                
            if (checkIdentifiable(oriDatadt))
            {
                System.Collections.ArrayList sqlList = new System.Collections.ArrayList();
                DataTable newDt = ExcelHelper.InputFromExcel(excelFilePath, "ds");
                selectedColumns = selectedColumns.Substring(0, selectedColumns.Length - 1);
                if (!importBlank)
                {
                    if (unselectedColumns.Length < 1)
                    {
                        MessageBox.Show("非导入空表模式不允许全选写回字段。");
                        return;
                    }
                    unselectedColumns = unselectedColumns.Substring(0, unselectedColumns.Length - 1);
                    // 如果不是重新写入空表，则使用update
                    foreach (DataRow dr in newDt.Rows)
                    {
                        string[] selecteds = selectedColumns.Split(',');
                        string[] unselecteds = unselectedColumns.Split(',');
                        string sqlstr = "update " + dbFilePath + " set ";
                        foreach (string updateValue in selecteds)
                        {
                            if (isDecimal(updateValue))
                            {
                                sqlstr += updateValue + " = " + dr[updateValue] + ", ";
                            }
                            else
                            {
                                sqlstr += updateValue + " = '" + dr[updateValue] + "', ";
                            }
                        }
                        sqlstr = sqlstr.Substring(0, sqlstr.Length - 2) + " where ";
                        foreach (string conditionValue in unselecteds)
                        {
                            sqlstr += conditionValue + " ='" + dr[conditionValue] + "' and ";
                        }
                        sqlstr = sqlstr.Substring(0, sqlstr.Length - 5);
                        sqlList.Add(sqlstr);
                    }
                    try
                    {
                        int finishedRow = db.ExecuteSqlTran(sqlList);
                        MessageBox.Show("成功更新数据。");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("数据更新失败：" + ex.ToString());
                    }
                }
                else
                {
                    // 如果是重新写入空表，则使用insert
                    foreach (DataRow dr in newDt.Rows)
                    {
                        string[] selecteds = selectedColumns.Split(',');
                        
                        string sqlstr = "insert into " + dbFilePath+ " ( ";
                        foreach (string updateValue in selecteds)
                        {
                            sqlstr += updateValue + " ,";
                        }
                        sqlstr = sqlstr.Substring(0, sqlstr.Length - 1)+") values (";
                        foreach (string updateValue in selecteds)
                        {
                            if (isDecimal(updateValue))
                            {
                                sqlstr +=  dr[updateValue] + " ,";
                            }
                            else
                            {
                                sqlstr += " '" + dr[updateValue] + "' ,";
                            }
                        }
                        sqlstr = sqlstr.Substring(0, sqlstr.Length - 1) + ")";
                        sqlList.Add(sqlstr);
                    }
                    try
                    {
                        int finishedRow = db.ExecuteSqlTran(sqlList);
                        MessageBox.Show("成功更新数据。");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("数据更新失败：" + ex.ToString());
                    }
                }

            }
            else
            {
                MessageBox.Show("所选条件不能唯一确定一条记录。");
            }
        }

        private bool isDecimal(String updateValue)
        {
            foreach (DataColumn c in oriDatadt.Columns)
            {
                String typeStr = c.DataType.ToString();
                String columnName = c.ColumnName;
                if (columnName.Equals(updateValue))
                {
                    if (typeStr.ToLower().Contains("string"))
                        return false;
                    else
                        return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 检查所选择的列是否有唯一性
        /// </summary>
        /// <param name="indt"></param>
        /// <returns></returns>
        private bool checkIdentifiable(DataTable indt)
        {
            System.Collections.ArrayList nonselectedList = new System.Collections.ArrayList();
            bool checkSuccess = false;
            string fields = "";

            for (int i = 0; i < lb_checkColumn.Items.Count; i++)
            {
                if (!lb_checkColumn.GetSelected(i))
                {
                    nonselectedList.Add(lb_checkColumn.Items[i]);
                    unselectedColumns += lb_checkColumn.Items[i].ToString() + ",";
                }
                else
                {
                    selectedColumns += lb_checkColumn.Items[i].ToString() + ",";
                }
            }

            if (!checkUnique)
            {
                return true;
            }

            foreach (var vv in nonselectedList)
            {
                fields += vv.ToString().Trim() + ", ";
            }
            fields = fields.Substring(0,fields.Length-2);
            string[] fieldss = fields.Split(',');
            DataTable idendt = dsHelper.SelectDistinct("idendt", indt, fieldss);
            if (idendt.Rows.Count == indt.Rows.Count)
                checkSuccess = true;

            return checkSuccess;
        }

        /// <summary>
        /// 把列表选中的列添加到ArrayList中
        /// </summary>
        /// <param name="dc"></param>
        /// <param name="objc"></param>
        /// <returns>DataColumn的List</returns>
        private System.Collections.ArrayList getList(DataColumnCollection dc, ListBox.SelectedObjectCollection objc)
        {
            System.Collections.ArrayList list = new System.Collections.ArrayList();
            foreach (DataColumn d in dc)
            {
                bool isin = false;
                foreach (var obj in objc)
                {
                    if (d.ToString().Trim() == obj.ToString().Trim())
                    {
                        isin = true;
                        break;
                    }
                }
                if (isin)
                {
                    list.Add(d);
                }
            }
            return list;
        }

        private void cb_checkAll_CheckedChanged(object sender, EventArgs e)
        {
            
            //全选或者全不选
            for (int i = 0; i < lb_outportColumn.Items.Count; i++)  
            {
                lb_outportColumn.SetSelected(i, cb_checkAll.Checked);  
            } 
        }

        private void cb_checkAllExport_CheckedChanged(object sender, EventArgs e)
        {
            //全选或者全不选
            for (int i = 0; i < lb_checkColumn.Items.Count; i++)
            {
                lb_checkColumn.SetSelected(i, cb_checkAllExport.Checked);
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 程序退出
            System.Environment.Exit(0);
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 关于窗口
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void 说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 说明窗口
            Tutorial tu = new Tutorial();
            tu.Show();
        }
    }
}
