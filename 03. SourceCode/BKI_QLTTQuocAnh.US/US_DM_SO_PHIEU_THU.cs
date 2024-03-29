///************************************************
/// Generated by: TuyenNT
/// Date: 12/05/2015 09:15:48
/// Goal: Create User Service Class for DM_SO_PHIEU_THU
///************************************************
/// <summary>
/// Create User Service Class for DM_SO_PHIEU_THU
/// </summary>

using System;
using BKI_QLTTQuocAnh.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_QLTTQuocAnh.US
{

    public class US_DM_SO_PHIEU_THU : US_Object
    {
        private const string c_TableName = "DM_SO_PHIEU_THU";
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

        public decimal dcMA_SO_QUYEN
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "MA_SO_QUYEN", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["MA_SO_QUYEN"] = value;
            }
        }

        public bool IsMA_SO_QUYENNull()
        {
            return pm_objDR.IsNull("MA_SO_QUYEN");
        }

        public void SetMA_SO_QUYENNull()
        {
            pm_objDR["MA_SO_QUYEN"] = System.Convert.DBNull;
        }

        public string strTEN_SO
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN_SO", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN_SO"] = value;
            }
        }

        public bool IsTEN_SONull()
        {
            return pm_objDR.IsNull("TEN_SO");
        }

        public void SetTEN_SONull()
        {
            pm_objDR["TEN_SO"] = System.Convert.DBNull;
        }

        public decimal dcTU_SO
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "TU_SO", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["TU_SO"] = value;
            }
        }

        public bool IsTU_SONull()
        {
            return pm_objDR.IsNull("TU_SO");
        }

        public void SetTU_SONull()
        {
            pm_objDR["TU_SO"] = System.Convert.DBNull;
        }

        public decimal dcDEN_SO
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "DEN_SO", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["DEN_SO"] = value;
            }
        }

        public bool IsDEN_SONull()
        {
            return pm_objDR.IsNull("DEN_SO");
        }

        public void SetDEN_SONull()
        {
            pm_objDR["DEN_SO"] = System.Convert.DBNull;
        }

        public DateTime datTHOI_GIAN_BAT_DAU_SU_DUNG
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "THOI_GIAN_BAT_DAU_SU_DUNG", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["THOI_GIAN_BAT_DAU_SU_DUNG"] = value;
            }
        }

        public bool IsTHOI_GIAN_BAT_DAU_SU_DUNGNull()
        {
            return pm_objDR.IsNull("THOI_GIAN_BAT_DAU_SU_DUNG");
        }

        public void SetTHOI_GIAN_BAT_DAU_SU_DUNGNull()
        {
            pm_objDR["THOI_GIAN_BAT_DAU_SU_DUNG"] = System.Convert.DBNull;
        }

        public DateTime datTHOI_GIAN_KET_THUC_SD
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "THOI_GIAN_KET_THUC_SD", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["THOI_GIAN_KET_THUC_SD"] = value;
            }
        }

        public bool IsTHOI_GIAN_KET_THUC_SDNull()
        {
            return pm_objDR.IsNull("THOI_GIAN_KET_THUC_SD");
        }

        public void SetTHOI_GIAN_KET_THUC_SDNull()
        {
            pm_objDR["THOI_GIAN_KET_THUC_SD"] = System.Convert.DBNull;
        }

        public string strIS_DELETED
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "IS_DELETED", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["IS_DELETED"] = value;
            }
        }

        public bool IsIS_DELETEDNull()
        {
            return pm_objDR.IsNull("IS_DELETED");
        }

        public void SetIS_DELETEDNull()
        {
            pm_objDR["IS_DELETED"] = System.Convert.DBNull;
        }

        public string strIS_ACTIVE
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "IS_ACTIVE", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["IS_ACTIVE"] = value;
            }
        }

        public bool IsIS_ACTIVENull()
        {
            return pm_objDR.IsNull("IS_ACTIVE");
        }

        public void SetIS_ACTIVENull()
        {
            pm_objDR["IS_ACTIVE"] = System.Convert.DBNull;
        }

        public string strMO_TA
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MO_TA", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MO_TA"] = value;
            }
        }

        public bool IsMO_TANull()
        {
            return pm_objDR.IsNull("MO_TA");
        }

        public void SetMO_TANull()
        {
            pm_objDR["MO_TA"] = System.Convert.DBNull;
        }

        public string strGHI_CHU
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "GHI_CHU", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["GHI_CHU"] = value;
            }
        }

        public bool IsGHI_CHUNull()
        {
            return pm_objDR.IsNull("GHI_CHU");
        }

        public void SetGHI_CHUNull()
        {
            pm_objDR["GHI_CHU"] = System.Convert.DBNull;
        }

        #endregion
        #region "Init Functions"
        public US_DM_SO_PHIEU_THU()
        {
            pm_objDS = new DS_DM_SO_PHIEU_THU();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_DM_SO_PHIEU_THU(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_DM_SO_PHIEU_THU(decimal i_dbID)
        {
            pm_objDS = new DS_DM_SO_PHIEU_THU();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }
        #endregion
    }
}
