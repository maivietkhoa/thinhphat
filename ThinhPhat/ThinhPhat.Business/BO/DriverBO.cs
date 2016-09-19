using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThinhPhat.Business.BO
{
    /// <summary>
    /// Created by 		: Bình Trần Công 
    /// Created date 	: 9/18/2016 
    /// Đối tượng 
    /// </summary>	
    public class DriverBO
    {
        #region Member Variables

		private int intDriverID = int.MinValue;
		private string strName = string.Empty;
		private string strMobile = string.Empty;
		private string strAddress = string.Empty;
		private string strNote = string.Empty;

		#endregion


		#region Properties 

		public static string CacheKey
		{
  			get { return  "SysTaiXe_GetAll";}
		}

		/// <summary>
		/// DriverID
		/// 
		/// </summary>
		public int DriverID
		{
			get { return  intDriverID; }
			set { intDriverID = value; }
		}

		/// <summary>
		/// Name
		/// 
		/// </summary>
		public string Name
		{
			get { return  strName; }
			set { strName = value; }
		}

		/// <summary>
		/// Mobile
		/// 
		/// </summary>
		public string Mobile
		{
			get { return  strMobile; }
			set { strMobile = value; }
		}

		/// <summary>
		/// Address
		/// 
		/// </summary>
		public string Address
		{
			get { return  strAddress; }
			set { strAddress = value; }
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


		#endregion		
		
		
		#region Constructor

		public DriverBO()
		{
		}
		private static DriverBO _current;
        static DriverBO()
		{
            _current = new DriverBO();
		}
        public static DriverBO Current
		{
			get
			{
		      return _current;
			}
		}
		#endregion
    }
}
