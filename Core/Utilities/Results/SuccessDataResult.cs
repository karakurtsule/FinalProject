using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data, string message) : base(data, true, message)
        {
        }

        public SuccessDataResult(T data) : base(data, true)  //mesaj döndürmek istemiyorsak
        {
        }
        public SuccessDataResult(string message) : base(default, true, message)  //datayı default haliyle döndürdük. Sadece mesaj döndürücek
        {
        }
        public SuccessDataResult() : base(default, true)
        {
        }
    }
}
