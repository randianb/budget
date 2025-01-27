//============================================================
// Producnt name:		Auto Generate
// Version: 			1.0
// Coded by:			Wu Di (wd_kk@qq.com)
// Auto generated at: 	2014-08-21 11:50:03
//============================================================

using System;
using System.Collections.Generic;
using System.Text;

namespace FinaAnaly.Model
{
	
	[Serializable()]
	public class FA_User
	{
	
		private int userID; 
		private string userName = String.Empty;
		private string userNum = String.Empty;
		private string userIDNum = String.Empty;
		private string userPwd = String.Empty;
		private int userLim;
		private int userSta;
		private int depID;
		private string userRem = String.Empty;
		private string userPurStr = String.Empty;

		
		public FA_User() { }
		
		
		public int UserID
		{
			get { return this.userID; }
			set { this.userID = value; }
		}
		
        
		
		
		
		public string UserName
		{
			get { return this.userName; }
			set { this.userName = value; }
		}		
		
		
		public string UserNum
		{
			get { return this.userNum; }
			set { this.userNum = value; }
		}		
		
		
		public string UserIDNum
		{
			get { return this.userIDNum; }
			set { this.userIDNum = value; }
		}		
		
		
		public string UserPwd
		{
			get { return this.userPwd; }
			set { this.userPwd = value; }
		}		
		
		
		public int UserLim
		{
			get { return this.userLim; }
			set { this.userLim = value; }
		}		
		
		
		public int UserSta
		{
			get { return this.userSta; }
			set { this.userSta = value; }
		}		
		
		
		public int DepID
		{
			get { return this.depID; }
			set { this.depID = value; }
		}		
		
		
		public string UserRem
		{
			get { return this.userRem; }
			set { this.userRem = value; }
		}		
		
		
		public string UserPurStr
		{
			get { return this.userPurStr; }
			set { this.userPurStr = value; }
		}		
		
	}
}
