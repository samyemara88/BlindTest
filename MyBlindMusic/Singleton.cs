using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlindMusic
{
  
        public class Singleton
        {
            private static Singleton instance;

            private Singleton() { }

            public static Singleton Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }

                
                    return instance;
                }
            }

        public string Pseudo
        {
            get
            {
                return m_pseudo;
            }

            set
            {
                m_pseudo = value;
            }
        }

        private string m_pseudo;

        public int Score
        {
            get
            {
                return m_score;
            }

            set
            {
                m_score = value;
            }
        }


        private int m_score;

        public int Max_score
        {
            get
            {
                return m_max_score;
            }

            set
            {
                m_max_score = value;
            }
        }
        private int m_max_score;



        public int Actual_score
        {
            get
            {
                return actual_score;
            }

            set
            {
                actual_score = value;
            }
        }

       


        private int actual_score;

        }

   

    
}
