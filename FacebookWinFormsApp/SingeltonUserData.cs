using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using BasicFacebookFeatures;

namespace Logic
{
    public sealed class SingeltonUserData
    {
        private static readonly object sr_LockOfCreateSingelton = new object();
        private static SingeltonUserData s_StaticInstance;
        private User m_LoggedInUser;

        private SingeltonUserData()
        {
        }

        public static SingeltonUserData StaticInstance
        {
            get
            {
                if (s_StaticInstance == null)
                {
                    lock (sr_LockOfCreateSingelton)
                    {
                        if (s_StaticInstance == null)
                        {
                            s_StaticInstance = new SingeltonUserData();
                        }
                    }
                }

                return s_StaticInstance;
            }
        }

        public User LoggedInUser
        {
            get
            {
                return m_LoggedInUser;
            }

            set
            {
                m_LoggedInUser = value;
            }
        }

        public string AccessToken
        {
            get;
            set;
        }

        public RememberMeSaver RememberMe
        {
            get;
            set;
        }
    }
}
