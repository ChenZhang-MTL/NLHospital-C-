using System;

namespace NLHospitalLibrary
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	public class CurrentUser
	{
		private string user;

		public string UserID
		{
			get
			{
				return user;
			}
			set
			{
				user = value;
			}
		}
		public string UserType;
		public string Ref;
        public string UserName;

        public CurrentUser()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public CurrentUser(string userID)
		{
			UserID = userID;
		}
	}
}
