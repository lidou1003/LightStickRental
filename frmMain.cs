using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Microsoft.VisualBasic;

namespace LightStickRental
{
    public partial class frmMain : Form
    {
        // 🌟 新增這行全域變數：預設每日租金為 400 元
        int dailyRentPrice = 400;

        public bool isAdmin = false;
        private int newPrice;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            grpRentalInfo.Visible = false;
            listView1.Focus();

            // 如果 isAdmin 是 false (代表是一般粉絲)，就把更改租金的按鈕反灰停用
            if (isAdmin == false)
            {
                menuChangeRent.Visible = false;
            }

            string folderPath = Application.StartupPath;
            string priceFilePath = Path.Combine(folderPath, "price.txt");

            // 2. 檢查之前有沒有存過價格
            if (File.Exists(priceFilePath))
            {
                // 如果有，就把裡面的文字讀出來，並轉換成數字存進變數裡
                string savedPrice = File.ReadAllText(priceFilePath);
                if (int.TryParse(savedPrice, out int parsedPrice))
                {
                    dailyRentPrice = parsedPrice; // 成功讀取最新租金！
                }
            }
            else
            {
                // 如果是第一次執行 (還沒有這個檔案)，就建立一個並寫入預設的 400
                File.WriteAllText(priceFilePath, "400");
                dailyRentPrice = 400;
            }
        }

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            string renterName = txtRenterName.Text;
            string rentalDate = txtDate.Text;
            string daysInput = txtDays.Text;

            // 【新增】防呆機制：確保粉絲有在左邊選擇手燈
            // 💡注意：請確認你的 ListView 元件名稱是不是 listView1，如果有改名請替換
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("請先選擇手燈喔！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string selectedStick = listView1.SelectedItems[0].Text;

            // 防呆機制：檢查有沒有漏填資料
            if (string.IsNullOrWhiteSpace(renterName) || string.IsNullOrWhiteSpace(rentalDate) || string.IsNullOrWhiteSpace(daysInput))
            {
                MessageBox.Show("請確認所有欄位都已經填寫完畢！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 防呆機制：確保天數輸入的是「數字」
            int totalDays;
            if (!int.TryParse(daysInput, out totalDays))
            {
                MessageBox.Show("租借天數必須輸入數字喔！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 計算費用 (押金固定 1000，租金一天 400)
            int deposit = 1000;
            int rentFee = totalDays * dailyRentPrice;

            // 計算總金額
            int totalAmount = deposit + rentFee;

            // 將資料組合成 CSV 格式 (用逗號隔開)
            string historyLine = $"{renterName},{selectedStick},{rentalDate},{totalDays},{deposit},{rentFee},{totalAmount}";

            // 寫入 txt 檔 (Environment.NewLine 代表換行)
            File.AppendAllText("rental_history.txt", historyLine + Environment.NewLine);


            // 【新增】彈出包含「手燈款式」與「總金額」的成功視窗
            string successMessage = $"租借成功！\n\n" +
                                    $"租借者：{renterName}\n" +
                                    $"手燈款式：{selectedStick}\n" +
                                    $"總天數：{totalDays} 天\n" +
                                    $"押金：{deposit} 元\n" +
                                    $"租金：{rentFee} 元\n" +
                                    $"總金額：{totalAmount} 元\n\n" +
                                    $"資料已儲存";

            MessageBox.Show(successMessage, "成功");

            // 租借成功後，清空輸入框與狀態，方便下一筆輸入
            txtRenterName.Clear();
            txtDate.Clear();
            txtDays.Clear();

            listView1.SelectedItems.Clear();

            grpRentalInfo.Visible = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) // 如果 ListView 不叫 listView1，請替換
            {
                MessageBox.Show("請先點選一支手燈的圖片喔！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 顯示右邊的填寫資料區塊
            grpRentalInfo.Visible = true;
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // 實體化並開啟歷史紀錄視窗 (請確保你已經新增了 frmHistory 這個表單)
            frmHistory historyForm = new frmHistory();
            historyForm.ShowDialog();
        }

        private void menuChangeRent_Click(object sender, EventArgs e)
        {
            // 1. 跳出輸入框，並帶入目前的租金價格
            string input = Microsoft.VisualBasic.Interaction.InputBox("請輸入新的每日租金金額：", "變更實時租金", dailyRentPrice.ToString());

            // 2. 防呆機制 A：如果使用者按了「取消」或「什麼都沒填」就按確定，直接結束，不要往下跑
            if (string.IsNullOrWhiteSpace(input))
            {
                return;
            }

            // 3. 防呆機制 B：檢查輸入的是不是純數字
            if (int.TryParse(input, out int newPrice))
            {
                // 如果真的是數字，就更新全域變數
                dailyRentPrice = newPrice;

                // 4. 將新價格寫入 price.txt 檔案中，讓程式永久記住！
                string folderPath = Application.StartupPath;
                string priceFilePath = Path.Combine(folderPath, "price.txt");
                File.WriteAllText(priceFilePath, dailyRentPrice.ToString());

                // 5. 顯示更新成功訊息
                MessageBox.Show($"每日租金已成功更新為：{dailyRentPrice} 元\n(系統已記住此價格，下次登入將繼續套用！)", "設定成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // 如果輸入了 ABC 或特殊符號，跳出警告
                MessageBox.Show("請輸入正確的數字金額！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tsmLogout_Click(object sender, EventArgs e)
        {
            // 1. 跳出視窗，跟使用者再次確認是否真的要登出
            DialogResult result = MessageBox.Show("確定要登出系統並返回登入畫面嗎？", "登出確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // 2. 如果使用者點擊「是 (Yes)」
            if (result == DialogResult.Yes)
            {
                // 執行這行指令，整個程式就會乾淨地重新啟動，直接回到登入畫面！
                Application.Restart();
            }
        }
    }
}
