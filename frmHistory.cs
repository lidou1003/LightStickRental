using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LightStickRental
{
    public partial class frmHistory : Form
    {
        public frmHistory()
        {
            InitializeComponent();
        }

        private void frmHistory_Load(object sender, EventArgs e)
        {
            // 1. 自動抓取執行檔 (.exe) 所在的資料夾路徑
            string folderPath = Application.StartupPath;

            // 2. 組合出檔案的完整路徑 (必須跟當初 frmMain 存檔時的檔名完全一模一樣)
            string filePath = Path.Combine(folderPath, "rental_history.txt");

            // 3. 檢查檔案存不存在 (防呆：如果粉絲第一次開啟，還沒任何租借紀錄，檔案就不會存在)
            if (!File.Exists(filePath))
            {
                MessageBox.Show("目前還沒有任何租借紀錄喔！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // 結束執行，不往下跑讀取邏輯
            }

            // 4. 設定表格的「標題欄位」 (總共 7 欄)
            dgvHistory.ColumnCount = 7;
            dgvHistory.Columns[0].Name = "姓名";
            dgvHistory.Columns[1].Name = "手燈款式";
            dgvHistory.Columns[2].Name = "日期";
            dgvHistory.Columns[3].Name = "天數";
            dgvHistory.Columns[4].Name = "押金";
            dgvHistory.Columns[5].Name = "租金";
            dgvHistory.Columns[6].Name = "總金額";

            // 5. 讀取 txt 檔裡面的每一行資料
            string[] lines = File.ReadAllLines(filePath);

            // 6. 使用迴圈，把每一行資料切開並塞進表格裡
            foreach (string line in lines)
            {
                // 確保這行不是空白的，避免讀到檔案結尾的空行而報錯
                if (!string.IsNullOrWhiteSpace(line))
                {
                    // 用逗號把字串切成字串陣列 (rowData[0]是名字、rowData[1]是手燈...)
                    string[] rowData = line.Split(',');

                    // 把切好的資料像蓋大樓一樣，一層一層新增到表格中
                    dgvHistory.Rows.Add(rowData);
                }
            }
        }
    }
}
