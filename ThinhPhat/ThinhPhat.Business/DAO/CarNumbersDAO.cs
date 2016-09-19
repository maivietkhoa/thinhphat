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
    /// Đối tượng xe
    /// </summary>
    public class CarNumbersDAO
    {

        #region Methods
        ///<summary>
        /// Kiểm tra xem đối tượng có dữ liệu hay không
        ///</summary>
        /// <returns>true ? Có : False ? Không</returns>
        public bool LoadByPrimaryKeys(CarNumbersBO objBO)
        {

            IData objData = Data.CreateData();
            bool bolOK = false;
            try
            {
                objData.Connect();
                objData.CreateNewStoredProcedure("Sys_SoXe_Select");
                objData.AddParameter("@CarNumberID", objBO.CarNumberID);
                IDataReader reader = objData.ExecStoreToDataReader();
                if (reader.Read())
                {
                    if (!this.IsDBNull(reader["CarNumberID"])) objBO.CarNumberID = Convert.ToInt32(reader["CarNumberID"]);
                    if (!this.IsDBNull(reader["CarNumber"])) objBO.CarNumber = Convert.ToString(reader["CarNumber"]);
                    if (!this.IsDBNull(reader["NumberOfSeat"])) objBO.NumberOfSeat = Convert.ToString(reader["NumberOfSeat"]);
                    if (!this.IsDBNull(reader["Type"])) objBO.Type = Convert.ToString(reader["Type"]);
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
        /// Insert : Sys_SoXe
        /// Them moi du lieu
        ///</summary>
        public object Insert(CarNumbersBO objBO)
        {
            IData objData = Data.CreateData();
            object objTemp = null;
            try
            {
                objData.Connect();
                objData.CreateNewStoredProcedure("Sys_SoXe_Insert");
                if (objBO.CarNumberID != int.MinValue) objData.AddParameter("@CarNumberID", objBO.CarNumberID);
                objData.AddParameter("@CarNumber", objBO.CarNumber);
                objData.AddParameter("@NumberOfSeat", objBO.NumberOfSeat);
                objData.AddParameter("@Type", objBO.Type);
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
        /// Update : Sys_SoXe
        /// Cap nhap thong tin
        ///</summary>
        public object Update(CarNumbersBO objBO)
        {
            IData objData = Data.CreateData();
            object objTemp = null;
            try
            {
                objData.Connect();
                objData.CreateNewStoredProcedure("Sys_SoXe_Update");
                if (objBO.CarNumberID != int.MinValue) objData.AddParameter("@CarNumberID", objBO.CarNumberID);
                else objData.AddParameter("@CarNumberID", DBNull.Value);
                objData.AddParameter("@CarNumber", objBO.CarNumber);
                objData.AddParameter("@NumberOfSeat", objBO.NumberOfSeat);
                objData.AddParameter("@Type", objBO.Type);
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
        /// Delete : Sys_SoXe
        ///
        ///</summary>
        public int Delete(CarNumbersBO objBO)
        {

            IData objData = Data.CreateData();
            int intTemp = 0;
            try
            {
                objData.Connect();
                objData.CreateNewStoredProcedure("Sys_SoXe_Delete");
                objData.AddParameter("@CarNumberID", objBO.CarNumberID);
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
        /// Get all : Sys_SoXe
        ///
        ///</summary>
        public DataTable GetAll()
        {

            IData objData = Data.CreateData() ;
            try
            {
                objData.Connect();
                objData.CreateNewStoredProcedure("Sys_SoXe_SelectAll");
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
