﻿using BKI_QLTTQuocAnh.DS;
using BKI_QLTTQuocAnh.DS.CDBNames;
using BKI_QLTTQuocAnh.RPT;
using BKI_QLTTQuocAnh.US;
using DAL;
using DevExpress.XtraGrid;
using DevExpress.XtraReports.UI;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Models.DTO;

namespace BKI_QLTTQuocAnh.BaoCao
{
    public partial class f417_diem_danh : Form
    {
        private readonly ClassRepository _classRepository;
        private readonly AttendanceRepository _attendanceRepository;

        public f417_diem_danh()
        {
            _attendanceRepository = new AttendanceRepository();
            _classRepository = new ClassRepository();

            InitializeComponent();

            format_controls();
            load_data_to_sle_lop();
        }

        public void displayFromF380_DiemDanh(long classId, int session)
        {
            m_txt_buoi.EditValue = session;
            m_sle_lop.EditValue = classId;

            ShowDialog();
        }
        public void displayFromF380_ViewHistory(long classId, int session)
        {
            m_txt_buoi.EditValue = session;
            m_sle_lop.EditValue = classId;
            m_cmd_diem_danh.Enabled = false;

            ShowDialog();
        }
        public void display_from_f410(decimal ip_id_lop_mon)
        {
            m_sle_lop.EditValue = ip_id_lop_mon;
            this.ShowDialog();
        }
        ///Members
        ///

        ///Private Methods
        ///
        private void format_controls()
        {
            //CControlFormat.setFormStyle(this, new CAppContext_201());
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163))); this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163))); this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;

            set_define_events();
        }

        private DS_DM_LOP_MON load_data_2_ds_dm_lop()
        {
            DS_DM_LOP_MON v_ds = new DS_DM_LOP_MON();
            US_DM_LOP_MON v_us = new US_DM_LOP_MON();
            string v_str_filter = "where TRANG_THAI_LOP_MON = " + CONST_TRANG_THAI_LOP_MON.DANG_HOAT_DONG;
            v_ds.Clear();
            v_ds.EnforceConstraints = false;
            v_us.FillDataset(v_ds, v_str_filter);

            return v_ds;
        }

        private void load_data_to_sle_lop()
        {


            //Chinh hien thi nguoi dung
            m_sle_lop.Properties.DataSource = load_data_2_ds_dm_lop().DM_LOP_MON;
            m_sle_lop.Properties.DisplayMember = DM_LOP_MON.MO_TA;
            m_sle_lop.Properties.ValueMember = DM_LOP_MON.ID;

            m_sle_lop.Properties.PopulateViewColumns();
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.ID].Visible = false;
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.ID_LOP].Visible = false;
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.ID_MON].Visible = false;
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.TRANG_THAI_LOP_MON].Visible = false;
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.DON_GIA_BUOI_HOC].Visible = false;
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.TONG_TIEN_KHOA_HOC].Visible = false;
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.TONG_SO_BUOI_HOC].Visible = false;
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.THOI_GIAN_HOC_TO_DATE].Visible = false;
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.THOI_GIAN_HOC_FROM_DATE].Visible = false;
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.GHI_CHU].Visible = false;
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.ID_TRO_GIANG].Visible = false;

            m_sle_lop.Properties.View.Columns[DM_LOP_MON.MO_TA].Width = 300;
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.MA_LOP_MON].Width = 150;

            m_sle_lop.Properties.View.Columns[DM_LOP_MON.MA_LOP_MON].Caption = "Mã lớp";
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.MO_TA].Caption = "Chọn tên lớp";

            m_sle_lop.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_lop.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private void set_init_form_load()
        {
            load_data_2_grid();
        }

        private void load_data_2_grid()
        {
            if (m_sle_lop.EditValue == null || m_sle_lop.Text == "")
            {
                return;
            }

            make_stt();

            var data = _attendanceRepository.getAttendances(Convert.ToInt32(m_sle_lop.EditValue),
                Convert.ToInt32(m_txt_buoi.EditValue));

            gridControlDiemDanh.DataSource = data;
            
        }

        private void make_stt()
        {
            var col = gridViewDiemDanh.Columns.Add();
            col.FieldName = "STT";
            col.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            gridViewDiemDanh.CustomUnboundColumnData += gridView2_CustomUnboundColumnData;
        }

        private void gridView2_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.IsGetData)
                e.Value = e.ListSourceRowIndex + 1;
        }

        private void diemDanh()
        {
            var classId = Convert.ToInt32(m_sle_lop.EditValue);
            var session = Convert.ToInt32(m_txt_buoi.EditValue);

            var isExistAttendance = _attendanceRepository.isExistAttendance(classId, session);

            if (isExistAttendance)
            {
                var dlg = MessageBox.Show(
                    "Đã tồn tại dữ liệu điểm danh buổi học này! Bạn có muốn xóa dữ liệu này đi để cập nhật dữ liệu mới thay thế không?",
                    "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if(dlg == DialogResult.Cancel)
                {
                    return; 
                }
                _attendanceRepository.deleteExistAttendance(classId, session);
            }
            //Save session history
            _attendanceRepository.saveSessionHistory(classId, session);


            //Save attendances
            for(var index = 0; index < gridViewDiemDanh.RowCount; index++)
            {
                var attendance = (AttendanceDTO)gridViewDiemDanh.GetRow(index);

                var studentId = attendance.StudentId;
                var shortcut = attendance.ShortcutKey;

                _classRepository.DiemDanh(studentId, shortcut, classId, session);
            }
            XtraMessageBox.Show("Điểm danh thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        ///Events
        ///
        private void set_define_events()
        {
            this.Load += frm_bao_cao_so_giao_dich_theo_lop_Load;
            m_cmd_search.Click += m_cmd_search_Click;
            //m_sle_lop.EditValueChanged += m_sle_lop_EditValueChanged;

            m_cmd_diem_danh.Click += M_cmd_diem_danh_Click;
        }

        private void M_cmd_diem_danh_Click(object sender, EventArgs e)
        {
            try
            {
               diemDanh();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_sle_lop_EditValueChanged(object sender, EventArgs e)
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

        void m_cmd_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_sle_lop.EditValue == null || m_sle_lop.Text == "")
                {
                    MessageBox.Show("Bạn phải chọn lớp trước!!!");
                    return;
                }

                load_data_2_grid();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void frm_bao_cao_so_giao_dich_theo_lop_Load(object sender, EventArgs e)
        {
            try
            {
                set_init_form_load();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //if (m_sle_lop.EditValue == null || m_sle_lop.Text == "")
                //{
                //    return;
                //}
                //Decimal v_id_hoc_sinh = CIPConvert.ToDecimal(gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ID_HOC_SINH"));
                //hien_thi_danh_sach_phieu(CIPConvert.ToDecimal(m_sle_lop.EditValue), v_id_hoc_sinh);
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_xuat_excel_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog dlg = new FolderBrowserDialog();
                string path = "";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    path = dlg.SelectedPath;
                }
                path = path + "giaodichtheolop" + DateTime.Now.Hour + DateTime.Now.Minute + ".xlsx";

                gridViewDiemDanh.ExportToXlsx(path);
            }
            catch (Exception v_e)
            {

                throw v_e;
            }
        }

        public WinControlContainer CopyGridControl(GridControl grid)
        {
            WinControlContainer winContainer = new WinControlContainer();

            winContainer.Location = new Point(0, 0);
            winContainer.Size = new Size(200, 100);

            winContainer.WinControl = grid;
            return winContainer;
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                var r = new rpt_lop();
                //gridView2.BestFitColumns();
                r.Bands[BandKind.Detail].Controls.Add(CopyGridControl(gridControlDiemDanh));
                r.xrLabel2.Text = m_sle_lop.Text;
                r.PaperKind = System.Drawing.Printing.PaperKind.A4;
                r.Landscape = true;
                r.ShowPreview();
            }
            catch (Exception v_e)
            {

                throw v_e;
            }
        }



    }
}