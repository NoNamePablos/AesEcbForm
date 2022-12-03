using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AesEncryption.Core
{
    public class myDecoder
    {
        private string _utf8Message;
        private string _ansiMessage;
        public myDecoder() {
            _utf8Message = "";
            _ansiMessage = "";
        }
        public myDecoder(string ut8,string ansi)
        {
            _utf8Message = ut8;
            _ansiMessage = ansi;
        }
        public string Utf8Message { 
            get { return _utf8Message; }
            set { _utf8Message = value; }
        }
        public string AnsiMessage {

            get { return _ansiMessage; }
            set { _ansiMessage = value; }
        }
        
    }
}
