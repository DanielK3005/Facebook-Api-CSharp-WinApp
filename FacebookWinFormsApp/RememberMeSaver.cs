using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BasicFacebookFeatures
{
    public class RememberMeSaver
    {
        private static string s_FilePath;
        private const string k_DefaultFilePath = @"\RememberMe.xml";
        private const bool k_RememberUser = false;
        private bool m_IsRememberUser;
        private string m_LastAccessToken;

        public RememberMeSaver()
        {
            m_IsRememberUser = k_RememberUser;
            m_LastAccessToken = null;
            s_FilePath = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        }

        public bool IsRememberUser
        {
            get
            {
                return m_IsRememberUser;
            }

            set
            {
                m_IsRememberUser = value;
            }
        }

        public string LastAccessToken
        {
            get
            {
                return m_LastAccessToken;
            }

            set
            {
                m_LastAccessToken = value;
            }
        }

        public void SaveToFile()
        {
            using (Stream stream = new FileStream(s_FilePath + k_DefaultFilePath, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());

                serializer.Serialize(stream, this);
            }
        }

        public static RememberMeSaver LoadFromFile()
        {
            RememberMeSaver remember = new RememberMeSaver();

            if (File.Exists(s_FilePath + k_DefaultFilePath))
            {
                using (Stream stream = new FileStream(s_FilePath + k_DefaultFilePath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(RememberMeSaver));

                    remember = serializer.Deserialize(stream) as RememberMeSaver;
                }
            }
            return remember;
        }
    }
}