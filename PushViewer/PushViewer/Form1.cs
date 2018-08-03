using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PushViewer
{
    public partial class Form1 : Form
    {
        private Boolean power_consumption = false, beacon = false;
        private string minor_red, minor_green, minor_blue;
        private Boolean red = false, green = false, blue = false;

        SqlQuery sq;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sq = new SqlQuery();

            #region CheckedListBox
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedListBox.SetItemChecked(i, true);
            }
            #endregion

            #region ComboBox
            try
            {
                string query = sq.GetMinorList();
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int minor = reader.GetInt32(0);
                    Red.Items.Add(minor);
                    Green.Items.Add(minor);
                    Blue.Items.Add(minor);
                }
            }
            catch (SqlException)
            {
            }
            finally
            {
                sqlConnection.Close();
            }
            #endregion

            #region timer
            timer.Interval = 2500; // 2.5秒ごとに更新
            timer.Enabled = false;
            #endregion
        }

        private void Red_TextChanged(object sender, EventArgs e)
        {
            minor_red = Red.Text;
            red = true;
        }

        private void Green_TextChanged(object sender, EventArgs e)
        {
            minor_green = Green.Text;
            green = true;
        }

        private void Blue_TextChanged(object sender, EventArgs e)
        {
            minor_blue = Blue.Text;
            blue = true;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            #region 機能選択
            power_consumption = false;
            beacon = false;
            foreach (string item in checkedListBox.CheckedItems)
            {
                switch (item)
                {
                    case "消費電力":
                        power_consumption = true;
                        break;
                    case "Beacon":
                        beacon = true;
                        break;
                }
            }
            #endregion

            if (power_consumption)
            {
                UpdatePowerConsumption();
            } else
            {
                changeText(" ");
            }
            changeOvalVisible(beacon);
            if (beacon)
            {               
                UpdateBeacon();
            }
            timer.Enabled = true;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            changeText(" ");
            changeOvalVisible(false);
        }

        private void changeText(string text)
        {
            Microwave.Text = text;
            IshidaDesk.Text = text;
            KoikeDesk.Text = text;
            UemuraDesk.Text = text;
            FukanoDesk.Text = text;
            HamasakiDesk.Text = text;
            SaitoDesk.Text = text;
            IsobeDesk.Text = text;
            IbarakiDesk.Text = text;
        }

        private void changeOvalVisible(Boolean oval_visible)
        {
            if (red)
            {
                MicrowaveRed.Visible = oval_visible;
                IshidaRed.Visible = oval_visible;
                KoikeRed.Visible = oval_visible;
                UemuraRed.Visible = oval_visible;
                FukanoRed.Visible = oval_visible;
                HamasakiRed.Visible = oval_visible;
                SaitoRed.Visible = oval_visible;
                IsobeRed.Visible = oval_visible;
                IbarakiRed.Visible = oval_visible;
            }

            if (green)
            {
                MicrowaveGreen.Visible = oval_visible;
                IshidaGreen.Visible = oval_visible;
                KoikeGreen.Visible = oval_visible;
                UemuraGreen.Visible = oval_visible;
                FukanoGreen.Visible = oval_visible;
                HamasakiGreen.Visible = oval_visible;
                SaitoGreen.Visible = oval_visible;
                IsobeGreen.Visible = oval_visible;
                IbarakiGreen.Visible = oval_visible;
            }
            
            if (blue)
            {
                MicrowaveBlue.Visible = oval_visible;
                IshidaBlue.Visible = oval_visible;
                KoikeBlue.Visible = oval_visible;
                UemuraBlue.Visible = oval_visible;
                FukanoBlue.Visible = oval_visible;
                HamasakiBlue.Visible = oval_visible;
                SaitoBlue.Visible = oval_visible;
                IsobeBlue.Visible = oval_visible;
                IbarakiBlue.Visible = oval_visible;
            } 
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (power_consumption)
            {
                UpdatePowerConsumption();
            }
            if (beacon)
            {
                UpdateBeacon();
            }
        }

        private void UpdatePowerConsumption()
        {
            #region 電子レンジの消費電力
            const string Microwave_ApplianceID = "147";
            Microwave.Text = ExecutePowerConsumpQuery(Microwave_ApplianceID) + "W";
            #endregion

            #region 石田デスクの消費電力
            const string IshidaDesk_ApplianceID = "1227";
            IshidaDesk.Text = ExecutePowerConsumpQuery(IshidaDesk_ApplianceID) + "W";
            #endregion

            #region 小池デスクの消費電力
            const string KoikeDesk_ApplianceID = "1230";
            KoikeDesk.Text = ExecutePowerConsumpQuery(KoikeDesk_ApplianceID) + "W";
            #endregion

            #region 植村デスクの消費電力
            const string UemuraDesk_ApplianceID = "1218";
            UemuraDesk.Text = ExecutePowerConsumpQuery(UemuraDesk_ApplianceID) + "W";
            #endregion

            #region 深野デスクの消費電力
            const string FukanoDesk_ApplianceID = "1231";
            FukanoDesk.Text = ExecutePowerConsumpQuery(FukanoDesk_ApplianceID) + "W";
            #endregion

            #region 濱崎デスクの消費電力
            const string HamasakiDesk_ApplianceID = "1226";
            HamasakiDesk.Text = ExecutePowerConsumpQuery(HamasakiDesk_ApplianceID) + "W";
            #endregion

            #region 齊藤デスクの消費電力
            const string SaitoDesk_ApplianceID = "1224";
            SaitoDesk.Text = ExecutePowerConsumpQuery(SaitoDesk_ApplianceID) + "W";
            #endregion

            #region 磯部デスクの消費電力
            const string IsobeDesk_ApplianceID = "1222";
            IsobeDesk.Text = ExecutePowerConsumpQuery(IsobeDesk_ApplianceID) + "W";
            #endregion

            #region 茨木デスクの消費電力
            const string IbarakiDesk_ApplianceID = "1223";
            IbarakiDesk.Text = ExecutePowerConsumpQuery(IbarakiDesk_ApplianceID) + "W";
            #endregion
        }

        private string ExecutePowerConsumpQuery(string ApplianceID)
        {
            string PC = "-";
            try
            {
                string query = sq.GetEnergy(ApplianceID);
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                PC = reader.GetDouble(0).ToString();
            }
            catch (SqlException)
            {
            }
            catch (InvalidOperationException)
            {
            }
            finally
            {
                sqlConnection.Close();
            }
            return PC;
        }

        private void UpdateBeacon()
        {
            int diameter = 0;
            #region 電子レンジのBeacon受信回数
            string Microwave_address = "B8:27:EB:60:43:1D"; // ラズパイ4
            if (red)
            {
                diameter = ExecuteBeaconQuery(minor_red, Microwave_address) / 3 * 5;
                MicrowaveRed.Size = new System.Drawing.Size(diameter, diameter);
            }
            if (green)
            {
                diameter = ExecuteBeaconQuery(minor_green, Microwave_address) / 3 * 5;
                MicrowaveGreen.Size = new System.Drawing.Size(diameter, diameter);
            }
            if (blue)
            {
                diameter = ExecuteBeaconQuery(minor_blue, Microwave_address) / 3 * 5;
                MicrowaveBlue.Size = new System.Drawing.Size(diameter, diameter);
            }
            #endregion

            #region 石田デスクのBeacon受信回数
            string IshidaDesk_address = "00:1B:DC:05:06:76";
            if (red)
            {
                diameter = ExecuteBeaconQuery(minor_red, IshidaDesk_address) / 3 * 5;
                IshidaRed.Size = new System.Drawing.Size(diameter, diameter);
            }
            if (green)
            {
                diameter = ExecuteBeaconQuery(minor_green, IshidaDesk_address) / 3 * 5;
                IshidaGreen.Size = new System.Drawing.Size(diameter, diameter);
            }
            if (blue)
            {
                diameter = ExecuteBeaconQuery(minor_blue, IshidaDesk_address) / 3 * 5;
                IshidaBlue.Size = new System.Drawing.Size(diameter, diameter);
            }
            #endregion

            #region 小池デスクのBeacon受信回数
            string KoikeDesk_address = "00:1B:DC:05:06:34";
            if (red)
            {
                diameter = ExecuteBeaconQuery(minor_red, KoikeDesk_address) / 3 * 5;
                KoikeRed.Size = new System.Drawing.Size(diameter, diameter);
            }
            if (green)
            {
                diameter = ExecuteBeaconQuery(minor_green, KoikeDesk_address) / 3 * 5;
                KoikeGreen.Size = new System.Drawing.Size(diameter, diameter);
            }
            if (blue)
            {
                diameter = ExecuteBeaconQuery(minor_blue, KoikeDesk_address) / 3 * 5;
                KoikeBlue.Size = new System.Drawing.Size(diameter, diameter);
            }
            #endregion

            #region 植村デスクのBeacon受信回数
            string UemuraDesk_address = "B8:27:EB:CC:8B:57"; // ラズパイ9
            if (red)
            {
                diameter = ExecuteBeaconQuery(minor_red, UemuraDesk_address) / 3 * 5;
                UemuraRed.Size = new System.Drawing.Size(diameter, diameter);
            }
            if (green)
            {
                diameter = ExecuteBeaconQuery(minor_green, UemuraDesk_address) / 3 * 5;
                UemuraGreen.Size = new System.Drawing.Size(diameter, diameter);
            }
            if (blue)
            {
                diameter = ExecuteBeaconQuery(minor_blue, UemuraDesk_address) / 3 * 5;
                UemuraBlue.Size = new System.Drawing.Size(diameter, diameter);
            }
            #endregion

            #region 深野デスクのBeacon受信回数
            string FukanoDesk_address = "B8:27:EB:8C:6B:4B"; // ラズパイ8
            if (red)
            {
                diameter = ExecuteBeaconQuery(minor_red, FukanoDesk_address) / 3 * 5;
                FukanoRed.Size = new System.Drawing.Size(diameter, diameter);
            }
            if (green)
            {
                diameter = ExecuteBeaconQuery(minor_green, FukanoDesk_address) / 3 * 5;
                FukanoGreen.Size = new System.Drawing.Size(diameter, diameter);
            }
            if (blue)
            {
                diameter = ExecuteBeaconQuery(minor_blue, FukanoDesk_address) / 3 * 5;
                FukanoBlue.Size = new System.Drawing.Size(diameter, diameter);
            }
            #endregion

            #region 濱崎デスクのBeacon受信回数
            string HamasakiDesk_address = "00:1B:DC:05:06:32";
            if (red)
            {
                diameter = ExecuteBeaconQuery(minor_red, HamasakiDesk_address) / 3 * 5;
                HamasakiRed.Size = new System.Drawing.Size(diameter, diameter);
            }
            if (green)
            {
                diameter = ExecuteBeaconQuery(minor_green, HamasakiDesk_address) / 3 * 5;
                HamasakiGreen.Size = new System.Drawing.Size(diameter, diameter);
            }
            if (blue)
            {
                diameter = ExecuteBeaconQuery(minor_blue, HamasakiDesk_address) / 3 * 5;
                HamasakiBlue.Size = new System.Drawing.Size(diameter, diameter);
            }
            #endregion

            #region 齊藤デスクのBeacon受信回数
            string SaitoDesk_address = "B8:27:EB:53:9E:1B"; // ラズパイ2
            if (red)
            {
                diameter = ExecuteBeaconQuery(minor_red, SaitoDesk_address) / 3 * 5;
                SaitoRed.Size = new System.Drawing.Size(diameter, diameter);
            }
            if (green)
            {
                diameter = ExecuteBeaconQuery(minor_green, SaitoDesk_address) / 3 * 5;
                SaitoGreen.Size = new System.Drawing.Size(diameter, diameter);
            }
            if (blue)
            {
                diameter = ExecuteBeaconQuery(minor_blue, SaitoDesk_address) / 3 * 5;
                SaitoBlue.Size = new System.Drawing.Size(diameter, diameter);
            }
            #endregion

            #region 磯部デスクのBeacon受信回数
            string IsobeDesk_address = "B8:27:EB:3F:E9:BA"; // ラズパイ10
            if (red)
            {
                diameter = ExecuteBeaconQuery(minor_red, IsobeDesk_address) / 3 * 5;
                IsobeRed.Size = new System.Drawing.Size(diameter, diameter);
            }
            if (green)
            {
                diameter = ExecuteBeaconQuery(minor_green, IsobeDesk_address) / 3 * 5;
                IsobeGreen.Size = new System.Drawing.Size(diameter, diameter);
            }
            if (blue)
            {
                diameter = ExecuteBeaconQuery(minor_blue, IsobeDesk_address) / 3 * 5;
                IsobeBlue.Size = new System.Drawing.Size(diameter, diameter);
            }
            #endregion

            #region 茨木デスクのBeacon受信回数
            string IbarakiDesk_address = "00:1B:DC:05:06:33";
            if (red)
            {
                diameter = ExecuteBeaconQuery(minor_red, IbarakiDesk_address) / 3 * 5;
                IbarakiRed.Size = new System.Drawing.Size(diameter, diameter);
            }
            if (green)
            {
                diameter = ExecuteBeaconQuery(minor_green, IbarakiDesk_address) / 3 * 5;
                IbarakiGreen.Size = new System.Drawing.Size(diameter, diameter);
            }
            if (blue)
            {
                diameter = ExecuteBeaconQuery(minor_blue, IbarakiDesk_address) / 3 * 5;
                IbarakiBlue.Size = new System.Drawing.Size(diameter, diameter);
            }
            #endregion            
        }

        private int ExecuteBeaconQuery(string minor, string address)
        {
            int count = 0;
            try
            {
                string query = sq.GetCount(minor, address);
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                count = reader.GetInt32(0);
            }
            catch (SqlException)
            {
            }
            catch (InvalidOperationException)
            {
            }
            finally
            {
                sqlConnection.Close();
            }
            return count;
        }
    }
}
