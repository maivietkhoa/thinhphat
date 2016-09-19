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
    /// Đối tượng hàng hóa
    /// </summary>	
    public class ProductDAO
    {
        #region Methods

        ///<summary>
        /// Kiểm tra xem đối tượng có dữ liệu hay không
        ///</summary>
        /// <returns>true ? Có : False ? Không</returns>
        public bool LoadByPrimaryKeys(ProductBO objBO)
        {

            IData objData = Data.CreateData();
            bool bolOK = false;
            try
            {
                objData.Connect();
                objData.CreateNewStoredProcedure("HangHoa_Select");
                objData.AddParameter("@ID", objBO.ID);
                IDataReader reader = objData.ExecStoreToDataReader();
                if (reader.Read())
                {
                    if (!this.IsDBNull(reader["ID"])) objBO.ID = Convert.ToInt32(reader["ID"]);
                    if (!this.IsDBNull(reader["ProductID"])) objBO.ProductID = Convert.ToInt32(reader["ProductID"]);
                    if (!this.IsDBNull(reader["ProductName"])) objBO.ProductName = Convert.ToString(reader["ProductName"]);
                    if (!this.IsDBNull(reader["FromName"])) objBO.FromName = Convert.ToString(reader["FromName"]);
                    if (!this.IsDBNull(reader["FromMobile"])) objBO.FromMobile = Convert.ToString(reader["FromMobile"]);
                    if (!this.IsDBNull(reader["ToName"])) objBO.ToName = Convert.ToString(reader["ToName"]);
                    if (!this.IsDBNull(reader["ToMobile"])) objBO.ToMobile = Convert.ToString(reader["ToMobile"]);
                    if (!this.IsDBNull(reader["Cost"])) objBO.Cost = Convert.ToInt32(reader["Cost"]);
                    if (!this.IsDBNull(reader["IsPaid"])) objBO.IsPaid = Convert.ToBoolean(reader["IsPaid"]);
                    if (!this.IsDBNull(reader["IsReturn"])) objBO.IsReturn = Convert.ToBoolean(reader["IsReturn"]);
                    if (!this.IsDBNull(reader["Note"])) objBO.Note = Convert.ToString(reader["Note"]);
                    if (!this.IsDBNull(reader["Driver"])) objBO.Driver = Convert.ToString(reader["Driver"]);
                    if (!this.IsDBNull(reader["CarNumber"])) objBO.CarNumber = Convert.ToString(reader["CarNumber"]);
                    if (!this.IsDBNull(reader["TimeReceive"])) objBO.TimeReceive = Convert.ToDateTime(reader["TimeReceive"]);
                    if (!this.IsDBNull(reader["TimeReturn"])) objBO.TimeReturn = Convert.ToDateTime(reader["TimeReturn"]);
                    if (!this.IsDBNull(reader["TimeGo"])) objBO.TimeGo = Convert.ToString(reader["TimeGo"]);
                    if (!this.IsDBNull(reader["GoFrom"])) objBO.GoFrom = Convert.ToString(reader["GoFrom"]);
                    if (!this.IsDBNull(reader["TimeStop"])) objBO.TimeStop = Convert.ToDateTime(reader["TimeStop"]);
                    if (!this.IsDBNull(reader["GoTo"])) objBO.GoTo = Convert.ToString(reader["GoTo"]);
                    if (!this.IsDBNull(reader["IsDeleted"])) objBO.IsDeleted = Convert.ToBoolean(reader["IsDeleted"]);
                    if (!this.IsDBNull(reader["DeletedUser"])) objBO.DeletedUser = Convert.ToString(reader["DeletedUser"]);
                    if (!this.IsDBNull(reader["DeletedDate"])) objBO.DeletedDate = Convert.ToDateTime(reader["DeletedDate"]);
                    if (!this.IsDBNull(reader["UpdatedUser"])) objBO.UpdatedUser = Convert.ToString(reader["UpdatedUser"]);
                    if (!this.IsDBNull(reader["UpdatedDate"])) objBO.UpdatedDate = Convert.ToDateTime(reader["UpdatedDate"]);
                    if (!this.IsDBNull(reader["CreatedUser"])) objBO.CreatedUser = Convert.ToString(reader["CreatedUser"]);
                    if (!this.IsDBNull(reader["CreatedDate"])) objBO.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
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
        /// Insert : HangHoa
        /// Them moi du lieu
        ///</summary>
        public object Insert(ProductBO objBO)
        {
            IData objData = Data.CreateData();
            object objTemp = null;
            try
            {
                objData.Connect();
                objData.CreateNewStoredProcedure("HangHoa_Insert");
                if (objBO.ID != int.MinValue) objData.AddParameter("@ID", objBO.ID);
                if (objBO.ProductID != int.MinValue) objData.AddParameter("@ProductID", objBO.ProductID);
                objData.AddParameter("@ProductName", objBO.ProductName);
                objData.AddParameter("@FromName", objBO.FromName);
                objData.AddParameter("@FromMobile", objBO.FromMobile);
                objData.AddParameter("@ToName", objBO.ToName);
                objData.AddParameter("@ToMobile", objBO.ToMobile);
                if (objBO.Cost != int.MinValue) objData.AddParameter("@Cost", objBO.Cost);
                objData.AddParameter("@IsPaid", objBO.IsPaid);
                objData.AddParameter("@IsReturn", objBO.IsReturn);
                objData.AddParameter("@Note", objBO.Note);
                objData.AddParameter("@Driver", objBO.Driver);
                objData.AddParameter("@CarNumber", objBO.CarNumber);
                if (objBO.TimeReceive != DateTime.MinValue) objData.AddParameter("@TimeReceive", objBO.TimeReceive);
                if (objBO.TimeReturn != DateTime.MinValue) objData.AddParameter("@TimeReturn", objBO.TimeReturn);
                objData.AddParameter("@TimeGo", objBO.TimeGo);
                objData.AddParameter("@GoFrom", objBO.GoFrom);
                if (objBO.TimeStop != DateTime.MinValue) objData.AddParameter("@TimeStop", objBO.TimeStop);
                objData.AddParameter("@GoTo", objBO.GoTo);
                objData.AddParameter("@CreatedUser", objBO.CreatedUser);
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
        /// Update : HangHoa
        /// Cap nhap thong tin
        ///</summary>
        public object Update(ProductBO objBO)
        {
            IData objData = Data.CreateData();
            object objTemp = null;
            try
            {
                objData.Connect();
                objData.CreateNewStoredProcedure("HangHoa_Update");
                if (objBO.ID != int.MinValue) objData.AddParameter("@ID", objBO.ID);
                else objData.AddParameter("@ID", DBNull.Value);
                if (objBO.ProductID != int.MinValue) objData.AddParameter("@ProductID", objBO.ProductID);
                else objData.AddParameter("@ProductID", DBNull.Value);
                objData.AddParameter("@ProductName", objBO.ProductName);
                objData.AddParameter("@FromName", objBO.FromName);
                objData.AddParameter("@FromMobile", objBO.FromMobile);
                objData.AddParameter("@ToName", objBO.ToName);
                objData.AddParameter("@ToMobile", objBO.ToMobile);
                if (objBO.Cost != int.MinValue) objData.AddParameter("@Cost", objBO.Cost);
                else objData.AddParameter("@Cost", DBNull.Value);
                objData.AddParameter("@IsPaid", objBO.IsPaid);
                objData.AddParameter("@IsReturn", objBO.IsReturn);
                objData.AddParameter("@Note", objBO.Note);
                objData.AddParameter("@Driver", objBO.Driver);
                objData.AddParameter("@CarNumber", objBO.CarNumber);
                if (objBO.TimeReceive != DateTime.MinValue) objData.AddParameter("@TimeReceive", objBO.TimeReceive);
                else objData.AddParameter("@TimeReceive", DBNull.Value);
                if (objBO.TimeReturn != DateTime.MinValue) objData.AddParameter("@TimeReturn", objBO.TimeReturn);
                else objData.AddParameter("@TimeReturn", DBNull.Value);
                objData.AddParameter("@TimeGo", objBO.TimeGo);
                objData.AddParameter("@GoFrom", objBO.GoFrom);
                if (objBO.TimeStop != DateTime.MinValue) objData.AddParameter("@TimeStop", objBO.TimeStop);
                else objData.AddParameter("@TimeStop", DBNull.Value);
                objData.AddParameter("@GoTo", objBO.GoTo);
                objData.AddParameter("@UpdatedUser", objBO.UpdatedUser);
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
        /// Delete : HangHoa
        ///
        ///</summary>
        public int Delete(ProductBO objBO)
        {

            IData objData = Data.CreateData();
            int intTemp = 0;
            try
            {
                objData.Connect();
                objData.CreateNewStoredProcedure("HangHoa_Delete");
                objData.AddParameter("@ID", objBO.ID);
                objData.AddParameter("@DeletedUser", objBO.DeletedUser);
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
        /// Get all : HangHoa
        ///
        ///</summary>
        public DataTable GetAll()
        {

            IData objData = Data.CreateData();
            try
            {
                objData.Connect();
                objData.CreateNewStoredProcedure("HangHoa_SelectAll");
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
