///************************************************
/// Generated by: Haihd
/// Date: 13/05/2015 04:19:17
/// Goal: Create Form for V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU
///************************************************


using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;
using IP.Core.IPSystemAdmin;

using BKI_QLTTQuocAnh.US;
using BKI_QLTTQuocAnh.DS;
using BKI_QLTTQuocAnh.DS.CDBNames;

using C1.Win.C1FlexGrid;

namespace BKI_QLTTQuocAnh
{



    public class f430_bao_cao_danh_sach_phai_thu_thuc_thu_Anh_Thay : System.Windows.Forms.Form
    {
        #region Temp
        internal System.Windows.Forms.ImageList ImageList;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
        internal SIS.Controls.Button.SiSButton m_cmd_delete;
        internal SIS.Controls.Button.SiSButton m_cmd_update;
        internal SIS.Controls.Button.SiSButton m_cmd_insert;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        internal SIS.Controls.Button.SiSButton m_cmd_view;
        private Panel panel2;
        private ComboBox m_cbo_loai_phieu;
        private Label label1;
        private Label m_lbl_goi_y;
        internal SIS.Controls.Button.SiSButton m_cmd_search;
        private Label m_lbl_search;
        private TextBox m_txt_tim_kien;
        private ComboBox m_cbo_nhan_vien_thu;
        private Label m_lbl_nhan_vien_thu;
        private Label m_lbl_header;
        private DateTimePicker m_dat_tu_ngay;
        private Label m_lbl_tu_ngay;
        private Label m_lbl_den_ngay;
        private DateTimePicker m_dat_den_ngay;
        private ComboBox m_cbo_lop_mon;
        private Label m_lbl_lop_mon;
        private System.ComponentModel.IContainer components;
        #endregion

        public f430_bao_cao_danh_sach_phai_thu_thuc_thu_Anh_Thay()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            format_controls();
            CCommon.load_data_2_cbo_nhan_vien(
               CAppContext_201.getCurrentUserID()
               , m_cbo_nhan_vien_thu);
            CCommon.load_data_2_cbo_loai_phieu_thu(
                CONST_LOAI_TU_DIEN.LOAI_PHIEU_THU,
                m_cbo_loai_phieu);
            CCommon.load_data_2_cbo_lop_mon(-1, m_cbo_lop_mon);
            m_dat_tu_ngay.Value = DateTime.Now.Date.AddDays(-DateTime.Now.Date.Day + 1);
            m_dat_den_ngay.Value = DateTime.Now.Date;
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f430_bao_cao_danh_sach_phai_thu_thuc_thu_Anh_Thay));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_view = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_cbo_lop_mon = new System.Windows.Forms.ComboBox();
            this.m_lbl_lop_mon = new System.Windows.Forms.Label();
            this.m_cbo_loai_phieu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_lbl_goi_y = new System.Windows.Forms.Label();
            this.m_cmd_search = new SIS.Controls.Button.SiSButton();
            this.m_lbl_search = new System.Windows.Forms.Label();
            this.m_txt_tim_kien = new System.Windows.Forms.TextBox();
            this.m_cbo_nhan_vien_thu = new System.Windows.Forms.ComboBox();
            this.m_lbl_nhan_vien_thu = new System.Windows.Forms.Label();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.m_dat_tu_ngay = new System.Windows.Forms.DateTimePicker();
            this.m_lbl_tu_ngay = new System.Windows.Forms.Label();
            this.m_lbl_den_ngay = new System.Windows.Forms.Label();
            this.m_dat_den_ngay = new System.Windows.Forms.DateTimePicker();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "");
            this.ImageList.Images.SetKeyName(1, "");
            this.ImageList.Images.SetKeyName(2, "");
            this.ImageList.Images.SetKeyName(3, "");
            this.ImageList.Images.SetKeyName(4, "");
            this.ImageList.Images.SetKeyName(5, "");
            this.ImageList.Images.SetKeyName(6, "");
            this.ImageList.Images.SetKeyName(7, "");
            this.ImageList.Images.SetKeyName(8, "");
            this.ImageList.Images.SetKeyName(9, "");
            this.ImageList.Images.SetKeyName(10, "");
            this.ImageList.Images.SetKeyName(11, "");
            this.ImageList.Images.SetKeyName(12, "");
            this.ImageList.Images.SetKeyName(13, "");
            this.ImageList.Images.SetKeyName(14, "");
            this.ImageList.Images.SetKeyName(15, "");
            this.ImageList.Images.SetKeyName(16, "");
            this.ImageList.Images.SetKeyName(17, "");
            this.ImageList.Images.SetKeyName(18, "");
            this.ImageList.Images.SetKeyName(19, "");
            this.ImageList.Images.SetKeyName(20, "");
            this.ImageList.Images.SetKeyName(21, "");
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_insert);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_update);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_view);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_delete);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 427);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(945, 36);
            this.m_pnl_out_place_dm.TabIndex = 19;
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_insert.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_insert.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_insert.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_insert.ImageIndex = 2;
            this.m_cmd_insert.ImageList = this.ImageList;
            this.m_cmd_insert.Location = new System.Drawing.Point(677, 4);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_insert.TabIndex = 12;
            this.m_cmd_insert.Text = "&Thêm";
            // 
            // m_cmd_update
            // 
            this.m_cmd_update.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_update.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_update.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_update.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_update.ImageIndex = 3;
            this.m_cmd_update.ImageList = this.ImageList;
            this.m_cmd_update.Location = new System.Drawing.Point(4, 4);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_update.TabIndex = 13;
            this.m_cmd_update.Text = "&Sửa";
            // 
            // m_cmd_view
            // 
            this.m_cmd_view.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_view.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_view.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_view.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_view.ImageIndex = 18;
            this.m_cmd_view.ImageList = this.ImageList;
            this.m_cmd_view.Location = new System.Drawing.Point(765, 4);
            this.m_cmd_view.Name = "m_cmd_view";
            this.m_cmd_view.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_view.TabIndex = 21;
            this.m_cmd_view.Text = "Xem";
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_delete.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_delete.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_delete.ImageIndex = 4;
            this.m_cmd_delete.ImageList = this.ImageList;
            this.m_cmd_delete.Location = new System.Drawing.Point(92, 4);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_delete.TabIndex = 14;
            this.m_cmd_delete.Text = "&Xoá";
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_exit.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_exit.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_exit.ImageIndex = 12;
            this.m_cmd_exit.ImageList = this.ImageList;
            this.m_cmd_exit.Location = new System.Drawing.Point(853, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg.Location = new System.Drawing.Point(0, 197);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(945, 230);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_cbo_lop_mon);
            this.panel2.Controls.Add(this.m_lbl_lop_mon);
            this.panel2.Controls.Add(this.m_cbo_loai_phieu);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.m_lbl_goi_y);
            this.panel2.Controls.Add(this.m_cmd_search);
            this.panel2.Controls.Add(this.m_lbl_search);
            this.panel2.Controls.Add(this.m_txt_tim_kien);
            this.panel2.Controls.Add(this.m_cbo_nhan_vien_thu);
            this.panel2.Controls.Add(this.m_lbl_nhan_vien_thu);
            this.panel2.Controls.Add(this.m_lbl_header);
            this.panel2.Controls.Add(this.m_dat_tu_ngay);
            this.panel2.Controls.Add(this.m_lbl_tu_ngay);
            this.panel2.Controls.Add(this.m_lbl_den_ngay);
            this.panel2.Controls.Add(this.m_dat_den_ngay);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 197);
            this.panel2.TabIndex = 21;
            // 
            // m_cbo_lop_mon
            // 
            this.m_cbo_lop_mon.FormattingEnabled = true;
            this.m_cbo_lop_mon.Location = new System.Drawing.Point(93, 136);
            this.m_cbo_lop_mon.Name = "m_cbo_lop_mon";
            this.m_cbo_lop_mon.Size = new System.Drawing.Size(222, 21);
            this.m_cbo_lop_mon.TabIndex = 14;
            // 
            // m_lbl_lop_mon
            // 
            this.m_lbl_lop_mon.AutoSize = true;
            this.m_lbl_lop_mon.Location = new System.Drawing.Point(36, 139);
            this.m_lbl_lop_mon.Name = "m_lbl_lop_mon";
            this.m_lbl_lop_mon.Size = new System.Drawing.Size(48, 13);
            this.m_lbl_lop_mon.TabIndex = 13;
            this.m_lbl_lop_mon.Text = "Lớp môn";
            // 
            // m_cbo_loai_phieu
            // 
            this.m_cbo_loai_phieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_loai_phieu.FormattingEnabled = true;
            this.m_cbo_loai_phieu.Location = new System.Drawing.Point(94, 108);
            this.m_cbo_loai_phieu.Name = "m_cbo_loai_phieu";
            this.m_cbo_loai_phieu.Size = new System.Drawing.Size(222, 21);
            this.m_cbo_loai_phieu.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Loại phiếu thu";
            // 
            // m_lbl_goi_y
            // 
            this.m_lbl_goi_y.AutoSize = true;
            this.m_lbl_goi_y.Location = new System.Drawing.Point(735, 175);
            this.m_lbl_goi_y.Name = "m_lbl_goi_y";
            this.m_lbl_goi_y.Size = new System.Drawing.Size(198, 13);
            this.m_lbl_goi_y.TabIndex = 12;
            this.m_lbl_goi_y.Text = "Nhấp đúp chuột vào hàng để sửa phiếu";
            this.m_lbl_goi_y.Visible = false;
            // 
            // m_cmd_search
            // 
            this.m_cmd_search.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_search.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_search.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_search.ImageIndex = 5;
            this.m_cmd_search.ImageList = this.ImageList;
            this.m_cmd_search.Location = new System.Drawing.Point(326, 160);
            this.m_cmd_search.Name = "m_cmd_search";
            this.m_cmd_search.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_search.TabIndex = 11;
            this.m_cmd_search.Text = "Lọc dữ liệu";
            // 
            // m_lbl_search
            // 
            this.m_lbl_search.AutoSize = true;
            this.m_lbl_search.Location = new System.Drawing.Point(17, 168);
            this.m_lbl_search.Name = "m_lbl_search";
            this.m_lbl_search.Size = new System.Drawing.Size(67, 13);
            this.m_lbl_search.TabIndex = 9;
            this.m_lbl_search.Text = "Lọc theo HS";
            // 
            // m_txt_tim_kien
            // 
            this.m_txt_tim_kien.Location = new System.Drawing.Point(92, 165);
            this.m_txt_tim_kien.Name = "m_txt_tim_kien";
            this.m_txt_tim_kien.Size = new System.Drawing.Size(222, 20);
            this.m_txt_tim_kien.TabIndex = 10;
            // 
            // m_cbo_nhan_vien_thu
            // 
            this.m_cbo_nhan_vien_thu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_nhan_vien_thu.FormattingEnabled = true;
            this.m_cbo_nhan_vien_thu.Location = new System.Drawing.Point(94, 81);
            this.m_cbo_nhan_vien_thu.Name = "m_cbo_nhan_vien_thu";
            this.m_cbo_nhan_vien_thu.Size = new System.Drawing.Size(222, 21);
            this.m_cbo_nhan_vien_thu.TabIndex = 6;
            // 
            // m_lbl_nhan_vien_thu
            // 
            this.m_lbl_nhan_vien_thu.AutoSize = true;
            this.m_lbl_nhan_vien_thu.Location = new System.Drawing.Point(10, 84);
            this.m_lbl_nhan_vien_thu.Name = "m_lbl_nhan_vien_thu";
            this.m_lbl_nhan_vien_thu.Size = new System.Drawing.Size(74, 13);
            this.m_lbl_nhan_vien_thu.TabIndex = 5;
            this.m_lbl_nhan_vien_thu.Text = "Nhân viên thu";
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(945, 44);
            this.m_lbl_header.TabIndex = 0;
            this.m_lbl_header.Text = "BÁO CÁO DANH SÁCH PHIẾU THU";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_dat_tu_ngay
            // 
            this.m_dat_tu_ngay.CustomFormat = "dd/MM/yyyy";
            this.m_dat_tu_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_tu_ngay.Location = new System.Drawing.Point(69, 46);
            this.m_dat_tu_ngay.Name = "m_dat_tu_ngay";
            this.m_dat_tu_ngay.Size = new System.Drawing.Size(82, 20);
            this.m_dat_tu_ngay.TabIndex = 2;
            // 
            // m_lbl_tu_ngay
            // 
            this.m_lbl_tu_ngay.AutoSize = true;
            this.m_lbl_tu_ngay.Location = new System.Drawing.Point(14, 50);
            this.m_lbl_tu_ngay.Name = "m_lbl_tu_ngay";
            this.m_lbl_tu_ngay.Size = new System.Drawing.Size(46, 13);
            this.m_lbl_tu_ngay.TabIndex = 1;
            this.m_lbl_tu_ngay.Text = "Từ ngày";
            // 
            // m_lbl_den_ngay
            // 
            this.m_lbl_den_ngay.AutoSize = true;
            this.m_lbl_den_ngay.Location = new System.Drawing.Point(170, 50);
            this.m_lbl_den_ngay.Name = "m_lbl_den_ngay";
            this.m_lbl_den_ngay.Size = new System.Drawing.Size(53, 13);
            this.m_lbl_den_ngay.TabIndex = 3;
            this.m_lbl_den_ngay.Text = "Đến ngày";
            // 
            // m_dat_den_ngay
            // 
            this.m_dat_den_ngay.CustomFormat = "dd/MM/yyyy";
            this.m_dat_den_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_den_ngay.Location = new System.Drawing.Point(232, 46);
            this.m_dat_den_ngay.Name = "m_dat_den_ngay";
            this.m_dat_den_ngay.Size = new System.Drawing.Size(84, 20);
            this.m_dat_den_ngay.TabIndex = 4;
            // 
            // f430_bao_cao_danh_sach_phai_thu_thuc_thu_Anh_Thay
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(945, 463);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f430_bao_cao_danh_sach_phai_thu_thuc_thu_Anh_Thay";
            this.Text = "F430 - Báo cáo danh sách phải thu, thực thu";
            this.Load += new System.EventHandler(this.F430_bao_cao_danh_sach_phai_thu_thuc_thu_Anh_Thay_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }
        #endregion

        #region Data Structure
        private enum e_col_Number
        {
            HO_TEN_PH = 7
,
            SO_PHIEU = 3
                ,
            NGAY_THU = 1
                ,
            TEN_LOAI_PHIEU_THU = 2
                ,
            TIEN_THUC_THU = 11
                ,
            TIEN_GIAM_TRU = 10
                ,
            MA_HOC_SINH = 5
                ,
            NOI_DUNG = 4
                ,
            TIEN_CON_PHAI_THU = 12
                ,
            TEN_NGUOI_THU = 8
                ,
            TIEN_PHAI_THU = 9
                , HO_TEN_HS = 6

        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU m_ds = new DS_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU();
        US_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU m_us = new US_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU();
        US_V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH m_us_bc_tinh_hinh_tc = new US_V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH();
        decimal m_trang_thai_hien_thi = 0; //0 neu bam tren menu va 1 neu la form detail
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            m_fg.AllowResizing = AllowResizingEnum.Both;

            set_define_events();
            this.KeyPreview = true;
        }
        private void set_initial_form_load()
        {
            m_obj_trans = get_trans_object(m_fg);
            load_data_2_grid();
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.HO_TEN_PH, e_col_Number.HO_TEN_PH);
            v_htb.Add(V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.SO_PHIEU, e_col_Number.SO_PHIEU);
            v_htb.Add(V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.NGAY_THU, e_col_Number.NGAY_THU);
            v_htb.Add(V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.TEN_LOAI_PHIEU_THU, e_col_Number.TEN_LOAI_PHIEU_THU);
            v_htb.Add(V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.TIEN_THUC_THU, e_col_Number.TIEN_THUC_THU);
            v_htb.Add(V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.TIEN_GIAM_TRU, e_col_Number.TIEN_GIAM_TRU);
            v_htb.Add(V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.MA_HOC_SINH, e_col_Number.MA_HOC_SINH);
            v_htb.Add(V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.NOI_DUNG, e_col_Number.NOI_DUNG);
            v_htb.Add(V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.TIEN_CON_PHAI_THU, e_col_Number.TIEN_CON_PHAI_THU);
            v_htb.Add(V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.TEN_NGUOI_THU, e_col_Number.TEN_NGUOI_THU);
            v_htb.Add(V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.TIEN_PHAI_THU, e_col_Number.TIEN_PHAI_THU);
            v_htb.Add(V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.HO_TEN_HS, e_col_Number.HO_TEN_HS);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.NewRow());
            return v_obj_trans;
        }

        private void wrap_text_cell()
        {
            m_fg.Styles[CellStyleEnum.Normal].WordWrap = true;
            m_fg.AllowResizing = AllowResizingEnum.Rows;
            m_fg.AutoSizeRows();
        }

        private void create_tree_2grid()
        {
            m_fg.Subtotal(AggregateEnum.Sum
                , 0
                , -1
                , (int)e_col_Number.TIEN_PHAI_THU
                , "Tổng cộng");
            m_fg.Subtotal(AggregateEnum.Sum
                , 0
                , -1
                , (int)e_col_Number.TIEN_GIAM_TRU
                , "Tổng cộng");
            m_fg.Subtotal(AggregateEnum.Sum
                , 0
                , -1
                , (int)e_col_Number.TIEN_THUC_THU
                , "Tổng cộng");
            m_fg.Subtotal(AggregateEnum.Sum
             , 0
             , -1
             , (int)e_col_Number.TIEN_CON_PHAI_THU
             , "Tổng cộng");

            m_fg.Redraw = true;
        }

        private void load_data_2_grid()
        {
            //m_ds = new DS_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU();
            //m_us.FillDataset(m_ds);
            //m_fg.Redraw = false;
            //CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            //m_fg.Redraw = true;

            DS_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU v_ds = new DS_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU();
            v_ds.Clear();
            v_ds.EnforceConstraints = false;
            //m_us.FillDataset(v_ds);
            m_us.FillDataset_by_condition(
                     v_ds
                //, m_us_bc_tinh_hinh_tc.dcID
                     , CIPConvert.ToDecimal(m_cbo_lop_mon.SelectedValue)
                     , m_dat_tu_ngay.Value.Date
                     , m_dat_den_ngay.Value.Date
                     , CIPConvert.ToDecimal(m_cbo_nhan_vien_thu.SelectedValue)
                     , CIPConvert.ToDecimal(m_cbo_loai_phieu.SelectedValue)
                     , m_txt_tim_kien.Text.Trim());
            CGridUtils.Dataset2C1Grid(v_ds, m_fg, m_obj_trans);
            m_fg.Redraw = true;
            create_tree_2grid();
            wrap_text_cell();

            CGridUtils.MakeSoTT(0, m_fg);

        }
        private void grid2us_object(US_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }


        private void insert_v_rpt_bao_cao_danh_sach_phieu_thu()
        {
            //	F430_bao_cao_danh_sach_phai_thu_thuc_thu_Anh_Thay_DE v_fDE = new  F430_bao_cao_danh_sach_phai_thu_thuc_thu_Anh_Thay_DE();								
            //	v_fDE.display();
            load_data_2_grid();
        }

        private void update_v_rpt_bao_cao_danh_sach_phieu_thu()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            //	F430_bao_cao_danh_sach_phai_thu_thuc_thu_Anh_Thay_DE v_fDE = new F430_bao_cao_danh_sach_phai_thu_thuc_thu_Anh_Thay_DE();
            //	v_fDE.display(m_us);
            load_data_2_grid();
        }

        private void delete_v_rpt_bao_cao_danh_sach_phieu_thu()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            US_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU v_us = new US_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU();
            grid2us_object(v_us, m_fg.Row);
            try
            {
                v_us.BeginTransaction();
                v_us.Delete();
                v_us.CommitTransaction();
                m_fg.Rows.Remove(m_fg.Row);
            }
            catch (Exception v_e)
            {
                v_us.Rollback();
                CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
                    new CDBClientDBExceptionInterpret());
                v_objErrHandler.showErrorMessage();
            }
        }

        private void view_v_rpt_bao_cao_danh_sach_phieu_thu()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            //	F430_bao_cao_danh_sach_phai_thu_thuc_thu_Anh_Thay_DE v_fDE = new F430_bao_cao_danh_sach_phai_thu_thuc_thu_Anh_Thay_DE();			
            //	v_fDE.display(m_us);
        }

        #endregion

        //
        //
        //		EVENT HANLDERS
        //
        //
        private void F430_bao_cao_danh_sach_phai_thu_thuc_thu_Anh_Thay_Load(object sender, System.EventArgs e)
        {
            try
            {
                set_initial_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
            m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
            m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
            m_cmd_view.Click += new EventHandler(m_cmd_view_Click);
            this.KeyDown += f430_bao_cao_danh_sach_phai_thu_thuc_thu_Anh_Thay_KeyDown;
            m_cmd_search.Click += m_cmd_search_Click;
        }

        void m_cmd_search_Click(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f430_bao_cao_danh_sach_phai_thu_thuc_thu_Anh_Thay_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if ((e.KeyCode == Keys.Escape) && (m_trang_thai_hien_thi == 1))
                {
                    this.Close();
                }
                else
                    if (e.KeyCode == Keys.Enter)
                    {
                        load_data_2_grid();
                    }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {
                insert_v_rpt_bao_cao_danh_sach_phieu_thu();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_update_Click(object sender, EventArgs e)
        {
            try
            {
                update_v_rpt_bao_cao_danh_sach_phieu_thu();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                delete_v_rpt_bao_cao_danh_sach_phieu_thu();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_view_Click(object sender, EventArgs e)
        {
            try
            {
                view_v_rpt_bao_cao_danh_sach_phieu_thu();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

    }
}

