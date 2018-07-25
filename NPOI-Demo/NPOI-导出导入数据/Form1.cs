using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NPOI.HSSF.Model;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System.IO;

///最近一直是作那个餐饮项目的增删改查
///一些基础的配置都忘记了
///在这里首先是新建了配置文件App.config---注意配置文件的写法
///我们链接的数据库是Cater
///接着要添加应用->在.Net中-选则Configuration
///复制了一个SqlHelper.cs文件，方便快速的书写sql语句



namespace NPOI_Demo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //查询数据显示在DataGridView 
        //为了便于后续的使用数据，我们把数据放到一个集合中(其实就是在项目中的Dal层操作的)
        List<DishInfo> list = new List<DishInfo>();
        private void btnShow_Click(object sender, EventArgs e)
        {
            string sql = "select * from DishInfo";
            DataTable dt = CaterDal.SqlHelper.ExecuteDataTable(sql);


            foreach (DataRow row in dt.Rows)
            {
                list.Add(new DishInfo()
                {
                    DId = Convert.ToInt32(row["DId"]),
                    DTitle = row["DTitle"].ToString(),
                    DPrice = Convert.ToDecimal(row["DPrice"]),
                    DChar = row["DChar"].ToString(),
                    DTypeId = Convert.ToInt32(row["DTypeId"])
                });
            }

            dgvListImport.DataSource = list;//其实DataGridView 数据源可以直接使用table
        }

        //将数据导出到excel表格中
        private void btnExport_Click(object sender, EventArgs e)
        {

            //进行excel创建擦操作
            //创建一个工作薄workbook
            HSSFWorkbook workbook = new HSSFWorkbook();
            //创建一个工作表Sheet
            ISheet sheet1 = workbook.CreateSheet("菜单");


            #region 建立第一行（标题行)
            //创建行row
            IRow row0 = sheet1.CreateRow(0);//注意虽然excel表中的数据显示是从1开始的，但是我们建表建单元格都是从0开始
            //创建单元格cell
            ICell cell0 = row0.CreateCell(0);
            //给单元格输入内容
            cell0.SetCellValue("菜单列表");

            #region 设置标题行单元格的格式
            //创建格式对象
            ICellStyle style = workbook.CreateCellStyle();
            //设置对齐方式--居中
            style.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
            //创建字体对象
            IFont font = workbook.CreateFont();
            font.FontHeight = 20 * 20;
            style.SetFont(font);

            //设置单元格格式
            cell0.CellStyle = style;
            #endregion


            //合并单元格(从第0行第0列那个单元格到第0行第5列那个单元格）
            sheet1.AddMergedRegion(new NPOI.SS.Util.CellRangeAddress(0, 0, 0, 4));
            #endregion

            #region 建立第二行（列名行）
            IRow rowCTItle = sheet1.CreateRow(1);
            ICell cellCTitle0 = rowCTItle.CreateCell(0);
            cellCTitle0.SetCellValue("ID");
            ICell cellCTitle1 = rowCTItle.CreateCell(1);
            cellCTitle1.SetCellValue("菜名");
            ICell cellCTitle2 = rowCTItle.CreateCell(2);
            cellCTitle2.SetCellValue("菜系");
            ICell cellCTitle3 = rowCTItle.CreateCell(3);
            cellCTitle3.SetCellValue("价格");
            ICell cellCTitle4 = rowCTItle.CreateCell(4);
            cellCTitle4.SetCellValue("拼音");
            #endregion

            #region  遍历表格，创建正文数据
            int rowIndex = 2;//excel第一行为标题，第二行为列名，第三行开始正式放数据
            foreach (var item in list)
            {
                IRow rowData = sheet1.CreateRow(rowIndex++);

                ICell cellDId = rowData.CreateCell(0);
                cellDId.SetCellValue(item.DId);

                ICell cellDTitle = rowData.CreateCell(1);
                cellDTitle.SetCellValue(item.DTitle);

                ICell cellDTypeID = rowData.CreateCell(2);
                cellDTypeID.SetCellValue(item.DTypeId);

                ICell cellDPrice = rowData.CreateCell(3);
                cellDPrice.SetCellValue(Convert.ToString(item.DPrice));

                ICell cellDChar = rowData.CreateCell(4);
                cellDChar.SetCellValue(item.DChar);
            }
            #endregion




            //新建表格，将workbook写入
            FileStream stream = new FileStream(@"C:\Users\shanzm\Desktop\test.xls", FileMode.OpenOrCreate, FileAccess.Write);
            workbook.Write(stream);
            stream.Close();
            stream.Dispose();
            MessageBox.Show("输出成功！");
        }



        //将excel数据导入到DataGridView 
        private void btnImport_Click(object sender, EventArgs e)
        {
            //读取excel中数据存储在list
            List<DishInfo> list = new List<DishInfo>();
            //读取文件
            using (FileStream fsRead = new FileStream(@"导入的数据表格\test.xls", FileMode.OpenOrCreate, FileAccess.Read))
            {
                HSSFWorkbook workbook = new HSSFWorkbook(fsRead);
                //获取相应的表
                ISheet sheet = workbook.GetSheetAt(0);
                //读取正文数据，因为前两行是标题
                int rowIndex = 2;
                IRow row = sheet.GetRow(rowIndex++);//为嘛这里还要++呢，因为你是要在row!=null中作判断，要是下一行为null就不循环了

                while (row!=null)
                {
                    DishInfo di = new DishInfo();

                    di.DId = (int)row.GetCell(0).NumericCellValue;
                    di.DTitle = row.GetCell(1).StringCellValue;
                    di.DTypeId  = (int)row.GetCell(2).NumericCellValue;
                    di.DPrice = Convert.ToDecimal(row.GetCell(3).StringCellValue);
                    di.DChar = row.GetCell(4).StringCellValue;

                    list.Add(di);

                    row = sheet.GetRow(rowIndex++);
                }
            }
            dgvListExport.DataSource = list;
        }


    }
}
