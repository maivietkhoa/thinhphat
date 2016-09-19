using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThinhPhat.Business.BO
{
    /// <summary>
    /// Created by 		: Bình Trần Công 
    /// Created date 	: 9/18/2016 
    /// Đối tượng xe
    /// </summary>
    public class CarNumbersBO
    {
        #region Member Variables

        private int intCarNumberID = int.MinValue;
        private string strCarNumber = string.Empty;
        private string strNumberOfSeat = string.Empty;
        private string strType = string.Empty;
        private string strNote = string.Empty;
        #endregion


        #region Properties

        public static string CacheKey
        {
            get { return "SysSoXe_GetAll"; }
        }
        /// <summary>
        /// CarNumberID
        /// 
        /// </summary>
        public int CarNumberID
        {
            get { return intCarNumberID; }
            set { intCarNumberID = value; }
        }

        /// <summary>
        /// CarNumber
        /// 
        /// </summary>
        public string CarNumber
        {
            get { return strCarNumber; }
            set { strCarNumber = value; }
        }

        /// <summary>
        /// NumberOfSeat
        /// 
        /// </summary>
        public string NumberOfSeat
        {
            get { return strNumberOfSeat; }
            set { strNumberOfSeat = value; }
        }

        /// <summary>
        /// Type
        /// 
        /// </summary>
        public string Type
        {
            get { return strType; }
            set { strType = value; }
        }

        /// <summary>
        /// Note
        /// 
        /// </summary>
        public string Note
        {
            get { return strNote; }
            set { strNote = value; }
        }


        #endregion


        #region Constructor

        public CarNumbersBO()
        {
        }
        private static CarNumbersBO _current;
        static CarNumbersBO()
        {
            _current = new CarNumbersBO();
        }
        public static CarNumbersBO Current
        {
            get
            {
                return _current;
            }
        }
        #endregion
    }
}
