using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class DBResult
    {
        public bool COMPLETED { get; set; }
        public string FICHENO { get; set; }
        public int FICHEREF { get; set; }
        public int ID { get; set; }
        public string TYPE { get; set; }
        public string RESULT { get; set; }
        public string DBERROR { get; set; }
        public string FILENAME { get; set; }
        public Object REQUEST { get; set; }
        public Object RESPONSE { get; set; }
        public bool INSERT { get; set; }
        public DBResult ResultSub { get; set; }
        public DBResult ResultSub2 { get; set; }
    }
}
