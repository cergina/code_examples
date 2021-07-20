/* ---------------------------------------------- 
        2020_MarosCerget:github:cergina
----------------------------------------------- */
using System;

namespace Singleton_Example
{
    // Class to simulate singleton DP
    public class Singleton
    {
        #region Variables
        private static Singleton instance = null;
        public string id { get; private set; } = null;
        #endregion

        #region Constructor
        private Singleton()
        {
            Console.WriteLine("     Creating instance of object.");
            id = GenerateId();
        }
        #endregion

        #region Public Methods
        public static Singleton GetInstance
        {
            get
            {
                Console.WriteLine("     Getting instance of object.");
                if (instance == null)
                    instance = new Singleton();

                Console.WriteLine("     Returning instance of object.");
                return instance;
            }
        }
        #endregion

        #region Private Methods
        private static string GenerateId()
        {
            DateTime date = DateTime.Now;
            int number = (new Random()).Next(10000);

            string str_1 = date.ToString("yyyy-MM-dd__HH:mm");
            string str_2 = String.Format("{0:00000}", number);

            return str_1 + "_" + str_2;
        }
        #endregion
    }
}
