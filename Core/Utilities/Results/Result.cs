using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //getterları(success, message) constructorda set ettik
        public Result(bool success, string message):this(success)  //Result ın tek parametreli olan constructorına successi yolla(Success = success kod satırını tekrar etmemek icin) 
        {
            Message = message;
        }
        //mesaj döndürmek istemiyorsak
        public Result(bool success) //constructor overloading
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
