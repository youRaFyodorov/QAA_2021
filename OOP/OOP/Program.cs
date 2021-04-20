using System;

namespace OOP
{
    class Program
    {
        class Credentials
        {
            private string loginName;
            private string password;
            private string secretQuestion;

            public Credentials(string ln, string psw, string sq)
            {
                loginName = ln;
                password = psw;
                secretQuestion = sq;
            }
            public bool IsEquals(Credentials creds)
            {
                return (loginName == creds.loginName && password == creds.password && secretQuestion == creds.secretQuestion);
            }
        }
        static void Main(string[] args)
        {
            Credentials cred = new Credentials("name2", "password2", "question2");

            if (CheckAuthentification(cred) == true)
            {
                Login();
            }
            else
            {
                throw new Exception("Can't authentificate!");
            }
        }

        static bool CheckAuthentification(Credentials creds)
        {
            //DataBase
            Credentials[] dbCredentials = GetCredentialsFromDB();
            foreach (Credentials credData in dbCredentials)
            {
                if (credData.IsEquals(creds))
                {
                    return true;
                }
            }
            return false;
        }
        static void Login()
        {
            // login
        }

        static Credentials[] GetCredentialsFromDB()
        {
            //Data Base
            Credentials[] dataBaseCreds = new Credentials[3];

            dataBaseCreds[0] = new Credentials("name1", "password1", "question1");
            dataBaseCreds[1] = new Credentials("name2", "password2", "question2");
            dataBaseCreds[2] = new Credentials("name3", "password3", "question3");

            return dataBaseCreds;
        }
    }
}
