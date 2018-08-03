namespace PushViewer
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sqlConnection = new System.Data.SqlClient.SqlConnection();
            this.IshidaDesk = new System.Windows.Forms.TextBox();
            this.KoikeDesk = new System.Windows.Forms.TextBox();
            this.UemuraDesk = new System.Windows.Forms.TextBox();
            this.FukanoDesk = new System.Windows.Forms.TextBox();
            this.NoName = new System.Windows.Forms.TextBox();
            this.HamasakiDesk = new System.Windows.Forms.TextBox();
            this.IsobeDesk = new System.Windows.Forms.TextBox();
            this.SaitoDesk = new System.Windows.Forms.TextBox();
            this.IbarakiDesk = new System.Windows.Forms.TextBox();
            this.Microwave = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.MicrowaveBlue = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.MicrowaveGreen = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.MicrowaveRed = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.KoikeBlue = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.KoikeGreen = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.KoikeRed = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.HamasakiBlue = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.HamasakiGreen = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.HamasakiRed = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.IsobeBlue = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.IsobeGreen = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.IsobeRed = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.IbarakiBlue = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.IbarakiGreen = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.IbarakiRed = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.SaitoBlue = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.SaitoGreen = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.SaitoRed = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.UemuraBlue = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.UemuraGreen = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.UemuraRed = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.FukanoBlue = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.FukanoGreen = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.FukanoRed = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.IshidaRed = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.IshidaBlue = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.IshidaGreen = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.StartButton = new System.Windows.Forms.Button();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.Red = new System.Windows.Forms.ComboBox();
            this.Green = new System.Windows.Forms.ComboBox();
            this.Blue = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StopButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sqlConnection
            // 
            this.sqlConnection.ConnectionString = "Data Source=vader;Initial Catalog=SEEConDB_R3;Integrated Security=True";
            this.sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // IshidaDesk
            // 
            this.IshidaDesk.BackColor = System.Drawing.Color.White;
            this.IshidaDesk.Font = new System.Drawing.Font("MS UI Gothic", 55F);
            this.IshidaDesk.ForeColor = System.Drawing.Color.Black;
            this.IshidaDesk.Location = new System.Drawing.Point(24, 400);
            this.IshidaDesk.Name = "IshidaDesk";
            this.IshidaDesk.ReadOnly = true;
            this.IshidaDesk.Size = new System.Drawing.Size(197, 81);
            this.IshidaDesk.TabIndex = 11;
            this.IshidaDesk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KoikeDesk
            // 
            this.KoikeDesk.BackColor = System.Drawing.Color.White;
            this.KoikeDesk.Font = new System.Drawing.Font("MS UI Gothic", 55F);
            this.KoikeDesk.ForeColor = System.Drawing.Color.Black;
            this.KoikeDesk.Location = new System.Drawing.Point(227, 400);
            this.KoikeDesk.Name = "KoikeDesk";
            this.KoikeDesk.ReadOnly = true;
            this.KoikeDesk.Size = new System.Drawing.Size(197, 81);
            this.KoikeDesk.TabIndex = 12;
            this.KoikeDesk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UemuraDesk
            // 
            this.UemuraDesk.BackColor = System.Drawing.Color.White;
            this.UemuraDesk.Font = new System.Drawing.Font("MS UI Gothic", 55F);
            this.UemuraDesk.ForeColor = System.Drawing.Color.Black;
            this.UemuraDesk.Location = new System.Drawing.Point(227, 493);
            this.UemuraDesk.Name = "UemuraDesk";
            this.UemuraDesk.ReadOnly = true;
            this.UemuraDesk.Size = new System.Drawing.Size(197, 81);
            this.UemuraDesk.TabIndex = 13;
            this.UemuraDesk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FukanoDesk
            // 
            this.FukanoDesk.BackColor = System.Drawing.Color.White;
            this.FukanoDesk.Font = new System.Drawing.Font("MS UI Gothic", 55F);
            this.FukanoDesk.ForeColor = System.Drawing.Color.Black;
            this.FukanoDesk.Location = new System.Drawing.Point(465, 400);
            this.FukanoDesk.Name = "FukanoDesk";
            this.FukanoDesk.ReadOnly = true;
            this.FukanoDesk.Size = new System.Drawing.Size(197, 81);
            this.FukanoDesk.TabIndex = 14;
            this.FukanoDesk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NoName
            // 
            this.NoName.BackColor = System.Drawing.Color.White;
            this.NoName.Font = new System.Drawing.Font("MS UI Gothic", 55F);
            this.NoName.ForeColor = System.Drawing.Color.Black;
            this.NoName.Location = new System.Drawing.Point(668, 400);
            this.NoName.Name = "NoName";
            this.NoName.ReadOnly = true;
            this.NoName.Size = new System.Drawing.Size(197, 81);
            this.NoName.TabIndex = 20;
            this.NoName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HamasakiDesk
            // 
            this.HamasakiDesk.BackColor = System.Drawing.Color.White;
            this.HamasakiDesk.Font = new System.Drawing.Font("MS UI Gothic", 55F);
            this.HamasakiDesk.ForeColor = System.Drawing.Color.Black;
            this.HamasakiDesk.Location = new System.Drawing.Point(871, 400);
            this.HamasakiDesk.Name = "HamasakiDesk";
            this.HamasakiDesk.ReadOnly = true;
            this.HamasakiDesk.Size = new System.Drawing.Size(197, 81);
            this.HamasakiDesk.TabIndex = 21;
            this.HamasakiDesk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IsobeDesk
            // 
            this.IsobeDesk.BackColor = System.Drawing.Color.White;
            this.IsobeDesk.Font = new System.Drawing.Font("MS UI Gothic", 55F);
            this.IsobeDesk.ForeColor = System.Drawing.Color.Black;
            this.IsobeDesk.Location = new System.Drawing.Point(668, 493);
            this.IsobeDesk.Name = "IsobeDesk";
            this.IsobeDesk.ReadOnly = true;
            this.IsobeDesk.Size = new System.Drawing.Size(197, 81);
            this.IsobeDesk.TabIndex = 22;
            this.IsobeDesk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SaitoDesk
            // 
            this.SaitoDesk.BackColor = System.Drawing.Color.White;
            this.SaitoDesk.Font = new System.Drawing.Font("MS UI Gothic", 55F);
            this.SaitoDesk.ForeColor = System.Drawing.Color.Black;
            this.SaitoDesk.Location = new System.Drawing.Point(465, 493);
            this.SaitoDesk.Name = "SaitoDesk";
            this.SaitoDesk.ReadOnly = true;
            this.SaitoDesk.Size = new System.Drawing.Size(197, 81);
            this.SaitoDesk.TabIndex = 23;
            this.SaitoDesk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IbarakiDesk
            // 
            this.IbarakiDesk.BackColor = System.Drawing.Color.White;
            this.IbarakiDesk.Font = new System.Drawing.Font("MS UI Gothic", 55F);
            this.IbarakiDesk.ForeColor = System.Drawing.Color.Black;
            this.IbarakiDesk.Location = new System.Drawing.Point(871, 493);
            this.IbarakiDesk.Name = "IbarakiDesk";
            this.IbarakiDesk.ReadOnly = true;
            this.IbarakiDesk.Size = new System.Drawing.Size(197, 81);
            this.IbarakiDesk.TabIndex = 24;
            this.IbarakiDesk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Microwave
            // 
            this.Microwave.BackColor = System.Drawing.Color.White;
            this.Microwave.Font = new System.Drawing.Font("MS UI Gothic", 40F);
            this.Microwave.ForeColor = System.Drawing.Color.Black;
            this.Microwave.Location = new System.Drawing.Point(923, 17);
            this.Microwave.Name = "Microwave";
            this.Microwave.ReadOnly = true;
            this.Microwave.Size = new System.Drawing.Size(145, 61);
            this.Microwave.TabIndex = 25;
            this.Microwave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.UemuraDesk);
            this.panel1.Controls.Add(this.FukanoDesk);
            this.panel1.Controls.Add(this.IshidaDesk);
            this.panel1.Controls.Add(this.KoikeDesk);
            this.panel1.Controls.Add(this.SaitoDesk);
            this.panel1.Controls.Add(this.IbarakiDesk);
            this.panel1.Controls.Add(this.NoName);
            this.panel1.Controls.Add(this.IsobeDesk);
            this.panel1.Controls.Add(this.Microwave);
            this.panel1.Controls.Add(this.HamasakiDesk);
            this.panel1.Controls.Add(this.shapeContainer2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 666);
            this.panel1.TabIndex = 26;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.MicrowaveBlue,
            this.MicrowaveGreen,
            this.MicrowaveRed,
            this.KoikeBlue,
            this.KoikeGreen,
            this.KoikeRed,
            this.HamasakiBlue,
            this.HamasakiGreen,
            this.HamasakiRed,
            this.IsobeBlue,
            this.IsobeGreen,
            this.IsobeRed,
            this.IbarakiBlue,
            this.IbarakiGreen,
            this.IbarakiRed,
            this.SaitoBlue,
            this.SaitoGreen,
            this.SaitoRed,
            this.UemuraBlue,
            this.UemuraGreen,
            this.UemuraRed,
            this.FukanoBlue,
            this.FukanoGreen,
            this.FukanoRed,
            this.IshidaRed,
            this.IshidaBlue,
            this.IshidaGreen});
            this.shapeContainer2.Size = new System.Drawing.Size(1094, 662);
            this.shapeContainer2.TabIndex = 26;
            this.shapeContainer2.TabStop = false;
            // 
            // MicrowaveBlue
            // 
            this.MicrowaveBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MicrowaveBlue.BackColor = System.Drawing.SystemColors.Control;
            this.MicrowaveBlue.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.MicrowaveBlue.FillColor = System.Drawing.Color.Blue;
            this.MicrowaveBlue.FillGradientColor = System.Drawing.SystemColors.Control;
            this.MicrowaveBlue.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.MicrowaveBlue.Location = new System.Drawing.Point(1026, 85);
            this.MicrowaveBlue.Name = "MicrowaveBlue";
            this.MicrowaveBlue.Size = new System.Drawing.Size(50, 50);
            this.MicrowaveBlue.Visible = false;
            // 
            // MicrowaveGreen
            // 
            this.MicrowaveGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MicrowaveGreen.BackColor = System.Drawing.SystemColors.Control;
            this.MicrowaveGreen.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.MicrowaveGreen.FillColor = System.Drawing.Color.Green;
            this.MicrowaveGreen.FillGradientColor = System.Drawing.SystemColors.Control;
            this.MicrowaveGreen.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.MicrowaveGreen.Location = new System.Drawing.Point(971, 85);
            this.MicrowaveGreen.Name = "MicrowaveGreen";
            this.MicrowaveGreen.Size = new System.Drawing.Size(50, 50);
            this.MicrowaveGreen.Visible = false;
            // 
            // MicrowaveRed
            // 
            this.MicrowaveRed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MicrowaveRed.BackColor = System.Drawing.SystemColors.Control;
            this.MicrowaveRed.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.MicrowaveRed.FillColor = System.Drawing.Color.Red;
            this.MicrowaveRed.FillGradientColor = System.Drawing.SystemColors.Control;
            this.MicrowaveRed.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.MicrowaveRed.Location = new System.Drawing.Point(916, 85);
            this.MicrowaveRed.Name = "MicrowaveRed";
            this.MicrowaveRed.Size = new System.Drawing.Size(50, 50);
            this.MicrowaveRed.Visible = false;
            // 
            // KoikeBlue
            // 
            this.KoikeBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KoikeBlue.BackColor = System.Drawing.SystemColors.Control;
            this.KoikeBlue.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.KoikeBlue.FillColor = System.Drawing.Color.Blue;
            this.KoikeBlue.FillGradientColor = System.Drawing.SystemColors.Control;
            this.KoikeBlue.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.KoikeBlue.Location = new System.Drawing.Point(354, 340);
            this.KoikeBlue.Name = "KoikeBlue";
            this.KoikeBlue.Size = new System.Drawing.Size(50, 50);
            this.KoikeBlue.Visible = false;
            // 
            // KoikeGreen
            // 
            this.KoikeGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KoikeGreen.BackColor = System.Drawing.SystemColors.Control;
            this.KoikeGreen.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.KoikeGreen.FillColor = System.Drawing.Color.Green;
            this.KoikeGreen.FillGradientColor = System.Drawing.SystemColors.Control;
            this.KoikeGreen.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.KoikeGreen.Location = new System.Drawing.Point(299, 340);
            this.KoikeGreen.Name = "KoikeGreen";
            this.KoikeGreen.Size = new System.Drawing.Size(50, 50);
            this.KoikeGreen.Visible = false;
            // 
            // KoikeRed
            // 
            this.KoikeRed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KoikeRed.BackColor = System.Drawing.SystemColors.Control;
            this.KoikeRed.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.KoikeRed.FillColor = System.Drawing.Color.Red;
            this.KoikeRed.FillGradientColor = System.Drawing.SystemColors.Control;
            this.KoikeRed.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.KoikeRed.Location = new System.Drawing.Point(244, 340);
            this.KoikeRed.Name = "KoikeRed";
            this.KoikeRed.Size = new System.Drawing.Size(50, 50);
            this.KoikeRed.Visible = false;
            // 
            // HamasakiBlue
            // 
            this.HamasakiBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HamasakiBlue.BackColor = System.Drawing.SystemColors.Control;
            this.HamasakiBlue.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.HamasakiBlue.FillColor = System.Drawing.Color.Blue;
            this.HamasakiBlue.FillGradientColor = System.Drawing.SystemColors.Control;
            this.HamasakiBlue.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.HamasakiBlue.Location = new System.Drawing.Point(998, 340);
            this.HamasakiBlue.Name = "HamasakiBlue";
            this.HamasakiBlue.Size = new System.Drawing.Size(50, 50);
            this.HamasakiBlue.Visible = false;
            // 
            // HamasakiGreen
            // 
            this.HamasakiGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HamasakiGreen.BackColor = System.Drawing.SystemColors.Control;
            this.HamasakiGreen.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.HamasakiGreen.FillColor = System.Drawing.Color.Green;
            this.HamasakiGreen.FillGradientColor = System.Drawing.SystemColors.Control;
            this.HamasakiGreen.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.HamasakiGreen.Location = new System.Drawing.Point(943, 340);
            this.HamasakiGreen.Name = "HamasakiGreen";
            this.HamasakiGreen.Size = new System.Drawing.Size(50, 50);
            this.HamasakiGreen.Visible = false;
            // 
            // HamasakiRed
            // 
            this.HamasakiRed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HamasakiRed.BackColor = System.Drawing.SystemColors.Control;
            this.HamasakiRed.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.HamasakiRed.FillColor = System.Drawing.Color.Red;
            this.HamasakiRed.FillGradientColor = System.Drawing.SystemColors.Control;
            this.HamasakiRed.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.HamasakiRed.Location = new System.Drawing.Point(888, 340);
            this.HamasakiRed.Name = "HamasakiRed";
            this.HamasakiRed.Size = new System.Drawing.Size(50, 50);
            this.HamasakiRed.Visible = false;
            // 
            // IsobeBlue
            // 
            this.IsobeBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IsobeBlue.BackColor = System.Drawing.SystemColors.Control;
            this.IsobeBlue.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.IsobeBlue.FillColor = System.Drawing.Color.Blue;
            this.IsobeBlue.FillGradientColor = System.Drawing.SystemColors.Control;
            this.IsobeBlue.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.IsobeBlue.Location = new System.Drawing.Point(797, 585);
            this.IsobeBlue.Name = "IsobeBlue";
            this.IsobeBlue.Size = new System.Drawing.Size(50, 50);
            this.IsobeBlue.Visible = false;
            // 
            // IsobeGreen
            // 
            this.IsobeGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IsobeGreen.BackColor = System.Drawing.SystemColors.Control;
            this.IsobeGreen.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.IsobeGreen.FillColor = System.Drawing.Color.Green;
            this.IsobeGreen.FillGradientColor = System.Drawing.SystemColors.Control;
            this.IsobeGreen.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.IsobeGreen.Location = new System.Drawing.Point(742, 585);
            this.IsobeGreen.Name = "IsobeGreen";
            this.IsobeGreen.Size = new System.Drawing.Size(50, 50);
            this.IsobeGreen.Visible = false;
            // 
            // IsobeRed
            // 
            this.IsobeRed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IsobeRed.BackColor = System.Drawing.SystemColors.Control;
            this.IsobeRed.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.IsobeRed.FillColor = System.Drawing.Color.Red;
            this.IsobeRed.FillGradientColor = System.Drawing.SystemColors.Control;
            this.IsobeRed.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.IsobeRed.Location = new System.Drawing.Point(687, 585);
            this.IsobeRed.Name = "IsobeRed";
            this.IsobeRed.Size = new System.Drawing.Size(50, 50);
            this.IsobeRed.Visible = false;
            // 
            // IbarakiBlue
            // 
            this.IbarakiBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IbarakiBlue.BackColor = System.Drawing.SystemColors.Control;
            this.IbarakiBlue.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.IbarakiBlue.FillColor = System.Drawing.Color.Blue;
            this.IbarakiBlue.FillGradientColor = System.Drawing.SystemColors.Control;
            this.IbarakiBlue.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.IbarakiBlue.Location = new System.Drawing.Point(997, 585);
            this.IbarakiBlue.Name = "IbarakiBlue";
            this.IbarakiBlue.Size = new System.Drawing.Size(50, 50);
            this.IbarakiBlue.Visible = false;
            // 
            // IbarakiGreen
            // 
            this.IbarakiGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IbarakiGreen.BackColor = System.Drawing.SystemColors.Control;
            this.IbarakiGreen.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.IbarakiGreen.FillColor = System.Drawing.Color.Green;
            this.IbarakiGreen.FillGradientColor = System.Drawing.SystemColors.Control;
            this.IbarakiGreen.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.IbarakiGreen.Location = new System.Drawing.Point(942, 585);
            this.IbarakiGreen.Name = "IbarakiGreen";
            this.IbarakiGreen.Size = new System.Drawing.Size(50, 50);
            this.IbarakiGreen.Visible = false;
            // 
            // IbarakiRed
            // 
            this.IbarakiRed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IbarakiRed.BackColor = System.Drawing.SystemColors.Control;
            this.IbarakiRed.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.IbarakiRed.FillColor = System.Drawing.Color.Red;
            this.IbarakiRed.FillGradientColor = System.Drawing.SystemColors.Control;
            this.IbarakiRed.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.IbarakiRed.Location = new System.Drawing.Point(887, 585);
            this.IbarakiRed.Name = "IbarakiRed";
            this.IbarakiRed.Size = new System.Drawing.Size(50, 50);
            this.IbarakiRed.Visible = false;
            // 
            // SaitoBlue
            // 
            this.SaitoBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaitoBlue.BackColor = System.Drawing.SystemColors.Control;
            this.SaitoBlue.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.SaitoBlue.FillColor = System.Drawing.Color.Blue;
            this.SaitoBlue.FillGradientColor = System.Drawing.SystemColors.Control;
            this.SaitoBlue.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.SaitoBlue.Location = new System.Drawing.Point(594, 585);
            this.SaitoBlue.Name = "SaitoBlue";
            this.SaitoBlue.Size = new System.Drawing.Size(50, 50);
            this.SaitoBlue.Visible = false;
            // 
            // SaitoGreen
            // 
            this.SaitoGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaitoGreen.BackColor = System.Drawing.SystemColors.Control;
            this.SaitoGreen.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.SaitoGreen.FillColor = System.Drawing.Color.Green;
            this.SaitoGreen.FillGradientColor = System.Drawing.SystemColors.Control;
            this.SaitoGreen.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.SaitoGreen.Location = new System.Drawing.Point(539, 585);
            this.SaitoGreen.Name = "SaitoGreen";
            this.SaitoGreen.Size = new System.Drawing.Size(50, 50);
            this.SaitoGreen.Visible = false;
            // 
            // SaitoRed
            // 
            this.SaitoRed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaitoRed.BackColor = System.Drawing.SystemColors.Control;
            this.SaitoRed.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.SaitoRed.FillColor = System.Drawing.Color.Red;
            this.SaitoRed.FillGradientColor = System.Drawing.SystemColors.Control;
            this.SaitoRed.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.SaitoRed.Location = new System.Drawing.Point(484, 585);
            this.SaitoRed.Name = "SaitoRed";
            this.SaitoRed.Size = new System.Drawing.Size(50, 50);
            this.SaitoRed.Visible = false;
            // 
            // UemuraBlue
            // 
            this.UemuraBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UemuraBlue.BackColor = System.Drawing.SystemColors.Control;
            this.UemuraBlue.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.UemuraBlue.FillColor = System.Drawing.Color.Blue;
            this.UemuraBlue.FillGradientColor = System.Drawing.SystemColors.Control;
            this.UemuraBlue.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.UemuraBlue.Location = new System.Drawing.Point(355, 585);
            this.UemuraBlue.Name = "UemuraBlue";
            this.UemuraBlue.Size = new System.Drawing.Size(50, 50);
            this.UemuraBlue.Visible = false;
            // 
            // UemuraGreen
            // 
            this.UemuraGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UemuraGreen.BackColor = System.Drawing.SystemColors.Control;
            this.UemuraGreen.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.UemuraGreen.FillColor = System.Drawing.Color.Green;
            this.UemuraGreen.FillGradientColor = System.Drawing.SystemColors.Control;
            this.UemuraGreen.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.UemuraGreen.Location = new System.Drawing.Point(300, 585);
            this.UemuraGreen.Name = "UemuraGreen";
            this.UemuraGreen.Size = new System.Drawing.Size(50, 50);
            this.UemuraGreen.Visible = false;
            // 
            // UemuraRed
            // 
            this.UemuraRed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UemuraRed.BackColor = System.Drawing.SystemColors.Control;
            this.UemuraRed.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.UemuraRed.FillColor = System.Drawing.Color.Red;
            this.UemuraRed.FillGradientColor = System.Drawing.SystemColors.Control;
            this.UemuraRed.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.UemuraRed.Location = new System.Drawing.Point(245, 585);
            this.UemuraRed.Name = "UemuraRed";
            this.UemuraRed.Size = new System.Drawing.Size(50, 50);
            this.UemuraRed.Visible = false;
            // 
            // FukanoBlue
            // 
            this.FukanoBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FukanoBlue.BackColor = System.Drawing.SystemColors.Control;
            this.FukanoBlue.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.FukanoBlue.FillColor = System.Drawing.Color.Blue;
            this.FukanoBlue.FillGradientColor = System.Drawing.SystemColors.Control;
            this.FukanoBlue.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.FukanoBlue.Location = new System.Drawing.Point(594, 340);
            this.FukanoBlue.Name = "FukanoBlue";
            this.FukanoBlue.Size = new System.Drawing.Size(50, 50);
            this.FukanoBlue.Visible = false;
            // 
            // FukanoGreen
            // 
            this.FukanoGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FukanoGreen.BackColor = System.Drawing.SystemColors.Control;
            this.FukanoGreen.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.FukanoGreen.FillColor = System.Drawing.Color.Green;
            this.FukanoGreen.FillGradientColor = System.Drawing.SystemColors.Control;
            this.FukanoGreen.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.FukanoGreen.Location = new System.Drawing.Point(539, 340);
            this.FukanoGreen.Name = "FukanoGreen";
            this.FukanoGreen.Size = new System.Drawing.Size(50, 50);
            this.FukanoGreen.Visible = false;
            // 
            // FukanoRed
            // 
            this.FukanoRed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FukanoRed.BackColor = System.Drawing.SystemColors.Control;
            this.FukanoRed.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.FukanoRed.FillColor = System.Drawing.Color.Red;
            this.FukanoRed.FillGradientColor = System.Drawing.SystemColors.Control;
            this.FukanoRed.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.FukanoRed.Location = new System.Drawing.Point(484, 340);
            this.FukanoRed.Name = "FukanoRed";
            this.FukanoRed.Size = new System.Drawing.Size(50, 50);
            this.FukanoRed.Visible = false;
            // 
            // IshidaRed
            // 
            this.IshidaRed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IshidaRed.BackColor = System.Drawing.SystemColors.Control;
            this.IshidaRed.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.IshidaRed.FillColor = System.Drawing.Color.Red;
            this.IshidaRed.FillGradientColor = System.Drawing.SystemColors.Control;
            this.IshidaRed.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.IshidaRed.Location = new System.Drawing.Point(43, 340);
            this.IshidaRed.Name = "IshidaRed";
            this.IshidaRed.Size = new System.Drawing.Size(50, 50);
            this.IshidaRed.Visible = false;
            // 
            // IshidaBlue
            // 
            this.IshidaBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IshidaBlue.BackColor = System.Drawing.SystemColors.Control;
            this.IshidaBlue.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.IshidaBlue.FillColor = System.Drawing.Color.Blue;
            this.IshidaBlue.FillGradientColor = System.Drawing.SystemColors.Control;
            this.IshidaBlue.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.IshidaBlue.Location = new System.Drawing.Point(153, 340);
            this.IshidaBlue.Name = "IshidaBlue";
            this.IshidaBlue.Size = new System.Drawing.Size(50, 50);
            this.IshidaBlue.Visible = false;
            // 
            // IshidaGreen
            // 
            this.IshidaGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IshidaGreen.BackColor = System.Drawing.SystemColors.Control;
            this.IshidaGreen.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.IshidaGreen.FillColor = System.Drawing.Color.Green;
            this.IshidaGreen.FillGradientColor = System.Drawing.SystemColors.Control;
            this.IshidaGreen.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.IshidaGreen.Location = new System.Drawing.Point(98, 340);
            this.IshidaGreen.Name = "IshidaGreen";
            this.IshidaGreen.Size = new System.Drawing.Size(50, 50);
            this.IshidaGreen.Visible = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StartButton.Location = new System.Drawing.Point(1129, 248);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(121, 45);
            this.StartButton.TabIndex = 27;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // checkedListBox
            // 
            this.checkedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Items.AddRange(new object[] {
            "消費電力",
            "Beacon"});
            this.checkedListBox.Location = new System.Drawing.Point(1129, 12);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(120, 52);
            this.checkedListBox.TabIndex = 28;
            // 
            // Red
            // 
            this.Red.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Red.ForeColor = System.Drawing.Color.Red;
            this.Red.FormattingEnabled = true;
            this.Red.Location = new System.Drawing.Point(1188, 99);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(61, 32);
            this.Red.TabIndex = 29;
            this.Red.TextChanged += new System.EventHandler(this.Red_TextChanged);
            // 
            // Green
            // 
            this.Green.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Green.ForeColor = System.Drawing.Color.Green;
            this.Green.FormattingEnabled = true;
            this.Green.Location = new System.Drawing.Point(1188, 137);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(61, 32);
            this.Green.TabIndex = 30;
            this.Green.TextChanged += new System.EventHandler(this.Green_TextChanged);
            // 
            // Blue
            // 
            this.Blue.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Blue.ForeColor = System.Drawing.Color.Blue;
            this.Blue.FormattingEnabled = true;
            this.Blue.Location = new System.Drawing.Point(1188, 175);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(61, 32);
            this.Blue.TabIndex = 31;
            this.Blue.TextChanged += new System.EventHandler(this.Blue_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(1132, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "ID : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(1131, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 33;
            this.label2.Text = "ID : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(1131, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 24);
            this.label3.TabIndex = 34;
            this.label3.Text = "ID : ";
            // 
            // StopButton
            // 
            this.StopButton.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StopButton.Location = new System.Drawing.Point(1128, 299);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(121, 45);
            this.StopButton.TabIndex = 35;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(317, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(476, 28);
            this.textBox1.TabIndex = 27;
            this.textBox1.Text = "スクリーン";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1270, 697);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PushViewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConnection;
        private System.Windows.Forms.TextBox IshidaDesk;
        private System.Windows.Forms.TextBox KoikeDesk;
        private System.Windows.Forms.TextBox UemuraDesk;
        private System.Windows.Forms.TextBox FukanoDesk;
        private System.Windows.Forms.TextBox NoName;
        private System.Windows.Forms.TextBox HamasakiDesk;
        private System.Windows.Forms.TextBox IsobeDesk;
        private System.Windows.Forms.TextBox SaitoDesk;
        private System.Windows.Forms.TextBox IbarakiDesk;
        private System.Windows.Forms.TextBox Microwave;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.OvalShape IshidaGreen;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button StartButton;
        private Microsoft.VisualBasic.PowerPacks.OvalShape IshidaRed;
        private Microsoft.VisualBasic.PowerPacks.OvalShape IshidaBlue;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.ComboBox Red;
        private System.Windows.Forms.ComboBox Green;
        private System.Windows.Forms.ComboBox Blue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button StopButton;
        private Microsoft.VisualBasic.PowerPacks.OvalShape MicrowaveBlue;
        private Microsoft.VisualBasic.PowerPacks.OvalShape MicrowaveGreen;
        private Microsoft.VisualBasic.PowerPacks.OvalShape MicrowaveRed;
        private Microsoft.VisualBasic.PowerPacks.OvalShape KoikeBlue;
        private Microsoft.VisualBasic.PowerPacks.OvalShape KoikeGreen;
        private Microsoft.VisualBasic.PowerPacks.OvalShape KoikeRed;
        private Microsoft.VisualBasic.PowerPacks.OvalShape HamasakiBlue;
        private Microsoft.VisualBasic.PowerPacks.OvalShape HamasakiGreen;
        private Microsoft.VisualBasic.PowerPacks.OvalShape HamasakiRed;
        private Microsoft.VisualBasic.PowerPacks.OvalShape IsobeBlue;
        private Microsoft.VisualBasic.PowerPacks.OvalShape IsobeGreen;
        private Microsoft.VisualBasic.PowerPacks.OvalShape IsobeRed;
        private Microsoft.VisualBasic.PowerPacks.OvalShape IbarakiBlue;
        private Microsoft.VisualBasic.PowerPacks.OvalShape IbarakiGreen;
        private Microsoft.VisualBasic.PowerPacks.OvalShape IbarakiRed;
        private Microsoft.VisualBasic.PowerPacks.OvalShape SaitoBlue;
        private Microsoft.VisualBasic.PowerPacks.OvalShape SaitoGreen;
        private Microsoft.VisualBasic.PowerPacks.OvalShape SaitoRed;
        private Microsoft.VisualBasic.PowerPacks.OvalShape UemuraBlue;
        private Microsoft.VisualBasic.PowerPacks.OvalShape UemuraGreen;
        private Microsoft.VisualBasic.PowerPacks.OvalShape UemuraRed;
        private Microsoft.VisualBasic.PowerPacks.OvalShape FukanoBlue;
        private Microsoft.VisualBasic.PowerPacks.OvalShape FukanoGreen;
        private Microsoft.VisualBasic.PowerPacks.OvalShape FukanoRed;
        private System.Windows.Forms.TextBox textBox1;
    }
}

