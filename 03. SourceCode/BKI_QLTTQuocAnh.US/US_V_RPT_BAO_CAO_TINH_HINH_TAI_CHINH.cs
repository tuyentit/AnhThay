///************************************************
/// Generated by: tuyennt
/// Date: 18/01/2015 10:12:20
/// Goal: Create User Service Class for V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH
///************************************************
/// <summary>
/// Create User Service Class for V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH
/// </summary>

using System;
using BKI_QLTTQuocAnh.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_QLTTQuocAnh.US
{

    public class US_V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH : US_Object
    {
        private const string c_TableName = "V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH";
        #region "Public Properties"
        public decimal dcID
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID"] = value;
            }
        }

        public bool IsIDNull()
        {
            return pm_objDR.IsNull("ID");
        }

        public void SetIDNull()
        {
            pm_objDR["ID"] = System.Convert.DBNull;
        }

        public string strMA_DOI_TUONG
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MA_DOI_TUONG", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MA_DOI_TUONG"] = value;
            }
        }

        public bool IsMA_DOI_TUONGNull()
        {
            return pm_objDR.IsNull("MA_DOI_TUONG");
        }

        public void SetMA_DOI_TUONGNull()
        {
            pm_objDR["MA_DOI_TUONG"] = System.Convert.DBNull;
        }

        public string strHO_TEN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "HO_TEN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["HO_TEN"] = value;
            }
        }

        public bool IsHO_TENNull()
        {
            return pm_objDR.IsNull("HO_TEN");
        }

        public void SetHO_TENNull()
        {
            pm_objDR["HO_TEN"] = System.Convert.DBNull;
        }

        public string strHO_TEN_PH
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "HO_TEN_PH", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["HO_TEN_PH"] = value;
            }
        }

        public bool IsHO_TEN_PHNull()
        {
            return pm_objDR.IsNull("HO_TEN_PH");
        }

        public void SetHO_TEN_PHNull()
        {
            pm_objDR["HO_TEN_PH"] = System.Convert.DBNull;
        }

        public string strSDT_HS
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "SDT_HS", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["SDT_HS"] = value;
            }
        }

        public bool IsSDT_HSNull()
        {
            return pm_objDR.IsNull("SDT_HS");
        }

        public void SetSDT_HSNull()
        {
            pm_objDR["SDT_HS"] = System.Convert.DBNull;
        }

        public string strSDT_PH
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "SDT_PH", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["SDT_PH"] = value;
            }
        }

        public bool IsSDT_PHNull()
        {
            return pm_objDR.IsNull("SDT_PH");
        }

        public void SetSDT_PHNull()
        {
            pm_objDR["SDT_PH"] = System.Convert.DBNull;
        }

        public string strEMAIL_HS
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "EMAIL_HS", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["EMAIL_HS"] = value;
            }
        }

        public bool IsEMAIL_HSNull()
        {
            return pm_objDR.IsNull("EMAIL_HS");
        }

        public void SetEMAIL_HSNull()
        {
            pm_objDR["EMAIL_HS"] = System.Convert.DBNull;
        }

        public string strEMAIL_PH
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "EMAIL_PH", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["EMAIL_PH"] = value;
            }
        }

        public bool IsEMAIL_PHNull()
        {
            return pm_objDR.IsNull("EMAIL_PH");
        }

        public void SetEMAIL_PHNull()
        {
            pm_objDR["EMAIL_PH"] = System.Convert.DBNull;
        }

        public decimal dcID_LOP_MON
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_LOP_MON", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_LOP_MON"] = value;
            }
        }

        public bool IsID_LOP_MONNull()
        {
            return pm_objDR.IsNull("ID_LOP_MON");
        }

        public void SetID_LOP_MONNull()
        {
            pm_objDR["ID_LOP_MON"] = System.Convert.DBNull;
        }

        public decimal dcTONG_PHAI_THU
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "TONG_PHAI_THU", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["TONG_PHAI_THU"] = value;
            }
        }

        public bool IsTONG_PHAI_THUNull()
        {
            return pm_objDR.IsNull("TONG_PHAI_THU");
        }

        public void SetTONG_PHAI_THUNull()
        {
            pm_objDR["TONG_PHAI_THU"] = System.Convert.DBNull;
        }

        public decimal dcTONG_GIAM_TRU
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "TONG_GIAM_TRU", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["TONG_GIAM_TRU"] = value;
            }
        }

        public bool IsTONG_GIAM_TRUNull()
        {
            return pm_objDR.IsNull("TONG_GIAM_TRU");
        }

        public void SetTONG_GIAM_TRUNull()
        {
            pm_objDR["TONG_GIAM_TRU"] = System.Convert.DBNull;
        }

        public decimal dcTONG_THUC_THU
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "TONG_THUC_THU", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["TONG_THUC_THU"] = value;
            }
        }

        public bool IsTONG_THUC_THUNull()
        {
            return pm_objDR.IsNull("TONG_THUC_THU");
        }

        public void SetTONG_THUC_THUNull()
        {
            pm_objDR["TONG_THUC_THU"] = System.Convert.DBNull;
        }

        public decimal dcTONG_CON_NO
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "TONG_CON_NO", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["TONG_CON_NO"] = value;
            }
        }

        public bool IsTONG_CON_NONull()
        {
            return pm_objDR.IsNull("TONG_CON_NO");
        }

        public void SetTONG_CON_NONull()
        {
            pm_objDR["TONG_CON_NO"] = System.Convert.DBNull;
        }

        #endregion
        #region "Init Functions"
        public US_V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH()
        {
            pm_objDS = new DS_V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH(decimal i_dbID)
        {
            pm_objDS = new DS_V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }
        #endregion
        #region Addtional

        public void FillDataset(
            DS_V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH op_rpt
            , DateTime ip_dat_from_date
            , DateTime ip_dat_to_date
            , string ip_str_search)
        {
            CStoredProc v_obj_pr = new CStoredProc("f470_bao_cao_tien_phai_thu_theo_hoc_sinh");
            v_obj_pr.addDatetimeInputParam("@ip_dat_tu_ngay", ip_dat_from_date);
            v_obj_pr.addDatetimeInputParam("@ip_dat_den_ngay", ip_dat_to_date);
            v_obj_pr.addNVarcharInputParam("@ip_str_search", ip_str_search);
            v_obj_pr.fillDataSetByCommand(this, op_rpt);
        }
        #endregion
    }
}
