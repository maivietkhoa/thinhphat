using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TGDD.Library.Data;
using ThinhPhat.Business.BO;

namespace ThinhPhat.Business.DAO
{
    /// <summary>
    /// Created by 		: Bình Trần Công 
    /// Created date 	: 9/18/2016 
    /// Đối tượng Thời gian chạy
    /// </summary>	
    public class RunTimeDAO
    {
        #region Methods
        ///<summary>
        /// Kiểm tra xem đối tượng có dữ liệu hay không
        ///</summary>
        /// <returns>true ? Có : False ? Không</returns>
        public bool LoadByPrimaryKeys(RunTimeBO objBO)
        {

            IData objData = Data.CreateData();
            bool bolOK = false;
            try
            {
                objData.Connect();
                objData.CreateNewStoredProcedure("Sys_GioChay_Select");
                objData.AddParameter("@TimeGoID", objBO.TimeGoID);
                IDataReader reader = objData.ExecStoreToDataReader();
                if (reader.Read())
                {
                    if (!this.IsDBNull(reader["TimeGoID"])) objBO.TimeGoID = Convert.ToInt32(reader["TimeGoID"]);
                    if (!this.IsDBNull(reader["TimeGo"])) objBO.TimeGo = Convert.ToString(reader["TimeGo"]);
                    if (!this.IsDBNull(reader["Note"])) objBO.Note = Convert.ToString(reader["Note"]);
                    bolOK = true;
                }
                reader.Close();
            }
            catch (Exception objEx)
            {
                throw new Exception("LoadByPrimaryKeys() Error   " + objEx.Message.ToString());
            }
            finally
            {
                objData.Disconnect();
            }
            return bolOK;
        }

        ///<summary>
        /// Insert : Sys_GioChay
        /// Them moi du lieu
        ///</summary>
        public object Insert(RunTimeBO objBO)
        {
            IData objData = Data.CreateData();
            object objTemp = null;
            try
            {
                objData.Connect();
                objData.CreateNewStoredProcedure("Sys_GioChay_Insert");
                if (objBO.TimeGoID != int.MinValue) objData.AddParameter("@TimeGoID", objBO.TimeGoID);
                objData.AddParameter("@TimeGo", objBO.TimeGo);
                objData.AddParameter("@Note", objBO.Note);
                objTemp = objData.ExecStoreToString();
            }
            catch (Exception objEx)
            {
                throw new Exception("Insert() Error   " + objEx.Message.ToString());
            }
            finally
            {
                objData.Disconnect();
            }
            return objTemp;
        }


        ///<summary>
        /// Update : Sys_GioChay
        /// Cap nhap thong tin
        ///</summary>
        public object Update(RunTimeBO objBO)
        {
            IData objData = Data.CreateData();
            object objTemp = null;
            try
            {
                objData.Connect();
                objData.CreateNewStoredProcedure("Sys_GioChay_Update");
                if (objBO.TimeGoID != int.MinValue) objData.AddParameter("@TimeGoID", objBO.TimeGoID);
                else objData.AddParameter("@TimeGoID", DBNull.Value);
                objData.AddParameter("@TimeGo", objBO.TimeGo);
                objData.AddParameter("@Note", objBO.Note);
                objTemp = objData.ExecNonQuery();
            }
            catch (Exception objEx)
            {
                throw new Exception("Update() Error   " + objEx.Message.ToString());
            }
            finally
            {
                objData.Disconnect();
            }
            return objTemp;
        }


        ///<summary>
        /// Delete : Sys_GioChay
        ///
        ///</summary>
        public int Delete(RunTimeBO objBO)
        {

            IData objData = Data.CreateData();
            int intTemp = 0;
            try
            {
                objData.Connect();
                objData.CreateNewStoredProcedure("Sys_GioChay_Delete");
                objData.AddParameter("@TimeGoID", objBO.TimeGoID);
                intTemp = objData.ExecNonQuery();
            }
            catch (Exception objEx)
            {
                throw new Exception("Delete() Error   " + objEx.Message.ToString());
            }
            finally
            {
                objData.Disconnect();
            }
            return intTemp;
        }


        ///<summary>
        /// Get all : Sys_GioChay
        ///
        ///</summary>
        public DataTable GetAll()
        {

            IData objData = Data.CreateData();
            try
            {
                objData.Connect();
                objData.CreateNewStoredProcedure("Sys_GioChay_SelectAll");
                return objData.ExecStoreToDataTable();
            }
            catch (Exception objEx)
            {
                throw new Exception("GetAll() Error   " + objEx.Message.ToString());
            }
            finally
            {
                objData.Disconnect();
            }
        }
        #endregion


        /// <summary>
        /// Check Data IsDBNull 
        /// </summary>
        /// <param name="objObject"> Object Value</param>
        /// <returns>Null : true ? false </returns>
        private bool IsDBNull(object objObject)
        {
            return Convert.IsDBNull(objObject);
        }
    }
}
