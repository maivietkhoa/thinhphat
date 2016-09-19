using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThinhPhat.Business.BO
{
    /// <summary>
    /// Created by 		: Bình Trần Công 
    /// Created date 	: 9/18/2016 
    /// Đối tượng thời gian chạy
    /// </summary>	
    public class RunTimeBO
    {
        #region Member Variables

		private int intTimeGoID = int.MinValue;
		private string strTimeGo = string.Empty;
		private string strNote = string.Empty;
		#endregion


		#region Properties 

		public static string CacheKey
		{
  			get { return  "SysGioChay_GetAll";}
		}

		/// <summary>
		/// TimeGoID
		/// 
		/// </summary>
		public int TimeGoID
		{
			get { return  intTimeGoID; }
			set { intTimeGoID = value; }
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

		public RunTimeBO()
		{
		}
		private static RunTimeBO _current;
        static RunTimeBO()
		{
            _current = new RunTimeBO();
		}
        public static RunTimeBO Current
		{
			get
			{
		      return _current;
			}
		}
		#endregion
    }
}
