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
    /// Đối tượng 
    /// </summary>	
    public class DriverDAO
    {
        #region Methods
        ///<summary>
        /// Kiểm tra xem đối tượng có dữ liệu hay không
        ///</summary>
        /// <returns>true ? Có : False ? Không</returns>
        public bool LoadByPrimaryKeys(DriverBO objBO)
        {
            IData objData = Data.CreateData();
            bool bolOK = false;
            try
            {
                objData.Connect();
                objData.CreateNewStoredProcedure("Sys_TaiXe_Select");
                objData.AddParameter("@DriverID", objBO.DriverID);
                IDataReader reader = objData.ExecStoreToDataReader();
                if (reader.Read())
                {
                    if (!this.IsDBNull(reader["DriverID"])) objBO.DriverID = Convert.ToInt32(reader["DriverID"]);
                    if (!this.IsDBNull(reader["Name"])) objBO.Name = Convert.ToString(reader["Name"]);
                    if (!this.IsDBNull(reader["Mobile"])) objBO.Mobile = Convert.ToString(reader["Mobile"]);
                    if (!this.IsDBNull(reader["Address"])) objBO.Address = Convert.ToString(reader["Address"]);
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
        /// Insert : Sys_TaiXe
        /// Them moi du lieu
        ///</summary>
        public object Insert(DriverBO objBO)
        {
            IData objData = Data.CreateData();
            object objTemp = null;
            try
            {
                objData.Connect();
                objData.CreateNewStoredProcedure("Sys_TaiXe_Insert");
                if (objBO.DriverID != int.MinValue) objData.AddParameter("@DriverID", objBO.DriverID);
                objData.AddParameter("@Name", objBO.Name);
                objData.AddParameter("@Mobile", objBO.Mobile);
                objData.AddParameter("@Address", objBO.Address);
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
        /// Update : Sys_TaiXe
        /// Cap nhap thong tin
        ///</summary>
        public object Update(DriverBO objBO)
        {
            IData objData = Data.CreateData();
            object objTemp = null;
            try
            {
                objData.Connect();
                objData.CreateNewStoredProcedure("Sys_TaiXe_Update");
                if (objBO.DriverID != int.MinValue) objData.AddParameter("@DriverID", objBO.DriverID);
                else objData.AddParameter("@DriverID", DBNull.Value);
                objData.AddParameter("@Name", objBO.Name);
                objData.AddParameter("@Mobile", objBO.Mobile);
                objData.AddParameter("@Address", objBO.Address);
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
        /// Delete : Sys_TaiXe
        ///
        ///</summary>
        public int Delete(DriverBO objBO)
        {

            IData objData = Data.CreateData();
            int intTemp = 0;
            try
            {
                objData.Connect();
                objData.CreateNewStoredProcedure("Sys_TaiXe_Delete");
                objData.AddParameter("@DriverID", objBO.DriverID);
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
        /// Get all : Sys_TaiXe
        ///
        ///</summary>
        public DataTable GetAll()
        {

            IData objData = Data.CreateData();
            try
            {
                objData.Connect();
                objData.CreateNewStoredProcedure("Sys_TaiXe_SelectAll");
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
