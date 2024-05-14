using System;

namespace Common
{
    [Serializable]
    public class Request
    {
        public Operation Operation { get; set; }
        public object RequestObject { get; set; }   //posto je object apsolutna nadklasa svih klasa ovim obuhvatamo i listu objekata,
                                                    //dakle nije List<object> vec je object isto to zapravo
    }
}
