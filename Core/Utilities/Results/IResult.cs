using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IResult
    {
        //Temel voidler icin baslangıc
        bool Success { get; } //sadece okunabilir
        string Message { get; }
    }
}
