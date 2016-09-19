using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThinhPhat.Business.BO
{
    /// <summary>
    /// Created by 		: Bình Trần Công 
    /// Created date 	: 9/18/2016 
    /// Đối tượng hàng hóa
    /// </summary>	
    public class ProductBO
    {
        #region Member Variables

        private int intID = int.MinValue;
        private int intProductID = int.MinValue;
        private string strProductName = string.Empty;
        private string strFromName = string.Empty;
        private string strFromMobile = string.Empty;
        private string strToName = string.Empty;
        private string strToMobile = string.Empty;
        private int intCost = int.MinValue;
        private bool bolIsPaid;
        private bool bolIsReturn;
        private string strNote = string.Empty;
        private string strDriver = string.Empty;
        private string strCarNumber = string.Empty;
        private DateTime dtmTimeReceive = DateTime.MinValue;
        private DateTime dtmTimeReturn = DateTime.MinValue;
        private string strTimeGo = string.Empty;
        private string strGoFrom = string.Empty;
        private DateTime dtmTimeStop = DateTime.MinValue;
        private string strGoTo = string.Empty;
        private bool bolIsDeleted;
        private string strDeletedUser = string.Empty;
        private DateTime dtmDeletedDate = DateTime.MinValue;
        private string strUpdatedUser = string.Empty;
        private DateTime dtmUpdatedDate = DateTime.MinValue;
        private string strCreatedUser = string.Empty;
        private DateTime dtmCreatedDate = DateTime.MinValue;
        #endregion

        #region Properties 

		public static string CacheKey
		{
  			get { return  "HangHoa_GetAll";}
		}

		/// <summary>
		/// ID
		/// 
		/// </summary>
		public int ID
		{
			get { return  intID; }
			set { intID = value; }
		}

		/// <summary>
		/// ProductID
		/// 
		/// </summary>
		public int ProductID
		{
			get { return  intProductID; }
			set { intProductID = value; }
		}

		/// <summary>
		/// ProductName
		/// 
		/// </summary>
		public string ProductName
		{
			get { return  strProductName; }
			set { strProductName = value; }
		}

		/// <summary>
		/// FromName
		/// 
		/// </summary>
		public string FromName
		{
			get { return  strFromName; }
			set { strFromName = value; }
		}

		/// <summary>
		/// FromMobile
		/// 
		/// </summary>
		public string FromMobile
		{
			get { return  strFromMobile; }
			set { strFromMobile = value; }
		}

		/// <summary>
		/// ToName
		/// 
		/// </summary>
		public string ToName
		{
			get { return  strToName; }
			set { strToName = value; }
		}

		/// <summary>
		/// ToMobile
		/// 
		/// </summary>
		public string ToMobile
		{
			get { return  strToMobile; }
			set { strToMobile = value; }
		}

		/// <summary>
		/// Cost
		/// 
		/// </summary>
		public int Cost
		{
			get { return  intCost; }
			set { intCost = value; }
		}

		/// <summary>
		/// IsPaid
		/// 
		/// </summary>
		public bool IsPaid
		{
			get { return  bolIsPaid; }
			set { bolIsPaid = value; }
		}

		/// <summary>
		/// IsReturn
		/// 
		/// </summary>
		public bool IsReturn
		{
			get { return  bolIsReturn; }
			set { bolIsReturn = value; }
		}

		/// <summary>
		/// Note
		/// 
		/// </summary>
		public string Note
		{
			get { return  strNote; }
			set { strNote = value; }
		}

		/// <summary>
		/// Driver
		/// 
		/// </summary>
		public string Driver
		{
			get { return  strDriver; }
			set { strDriver = value; }
		}

		/// <summary>
		/// CarNumber
		/// 
		/// </summary>
		public string CarNumber
		{
			get { return  strCarNumber; }
			set { strCarNumber = value; }
		}

		/// <summary>
		/// TimeReceive
		/// 
		/// </summary>
		public DateTime TimeReceive
		{
			get { return  dtmTimeReceive; }
			set { dtmTimeReceive = value; }
		}

		/// <summary>
		/// TimeReturn
		/// 
		/// </summary>
		public DateTime TimeReturn
		{
			get { return  dtmTimeReturn; }
			set { dtmTimeReturn = value; }
		}

		/// <summary>
		/// TimeGo
		/// 
		/// </summary>
		public string TimeGo
		{
			get { return  strTimeGo; }
			set { strTimeGo = value; }
		}

		/// <summary>
		/// GoFrom
		/// 1: Ben Tre; 2: HCM; 3: Tieng Giang; 4: Nga 4 huyen
		/// </summary>
		public string GoFrom
		{
			get { return  strGoFrom; }
			set { strGoFrom = value; }
		}

		/// <summary>
		/// TimeStop
		/// 
		/// </summary>
		public DateTime TimeStop
		{
			get { return  dtmTimeStop; }
			set { dtmTimeStop = value; }
		}

		/// <summary>
		/// GoTo
		/// 1: Ben Tre; 2: HCM; 3: Tieng Giang; 4: Nga 4 huyen
		/// </summary>
		public string GoTo
		{
			get { return  strGoTo; }
			set { strGoTo = value; }
		}

		/// <summary>
		/// IsDeleted
		/// 
		/// </summary>
		public bool IsDeleted
		{
			get { return  bolIsDeleted; }
			set { bolIsDeleted = value; }
		}

		/// <summary>
		/// DeletedUser
		/// 
		/// </summary>
		public string DeletedUser
		{
			get { return  strDeletedUser; }
			set { strDeletedUser = value; }
		}

		/// <summary>
		/// DeletedDate
		/// 
		/// </summary>
		public DateTime DeletedDate
		{
			get { return  dtmDeletedDate; }
			set { dtmDeletedDate = value; }
		}

		/// <summary>
		/// UpdatedUser
		/// 
		/// </summary>
		public string UpdatedUser
		{
			get { return  strUpdatedUser; }
			set { strUpdatedUser = value; }
		}

		/// <summary>
		/// UpdatedDate
		/// 
		/// </summary>
		public DateTime UpdatedDate
		{
			get { return  dtmUpdatedDate; }
			set { dtmUpdatedDate = value; }
		}

		/// <summary>
		/// CreatedUser
		/// 
		/// </summary>
		public string CreatedUser
		{
			get { return  strCreatedUser; }
			set { strCreatedUser = value; }
		}

		/// <summary>
		/// CreatedDate
		/// 
		/// </summary>
		public DateTime CreatedDate
		{
			get { return  dtmCreatedDate; }
			set { dtmCreatedDate = value; }
		}


		#endregion		
		
		
		#region Constructor

		public ProductBO()
		{
		}
		private static ProductBO _current;
        static ProductBO()
		{
            _current = new ProductBO();
		}
        public static ProductBO Current
		{
			get
			{
		      return _current;
			}
		}
		#endregion
    }
}
