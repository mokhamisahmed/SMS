using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Core.Bases
{
    public static class RequestHandler<T>
    {

        public async static Task<RESPONSE<T>> Success(T Data,String Message) { 
        
        return await Task.FromResult( new RESPONSE<T> { Data = Data, Message = Message,isSuccessful=true });
        
        }

        public async static Task<RESPONSE<T>> BadRequest(T Data, String Message, List<ValidationFailure> Errors)
        {

            return await  Task.FromResult(new RESPONSE<T> { Data = Data, Message = Message, isSuccessful = false,Errors=Errors });

        }

        public async static Task<RESPONSE<T>> BadRequest(T Data, String Message)
        {

            return await Task.FromResult(new RESPONSE<T> { Data = Data, Message = Message, isSuccessful = false });

        }

        public async static Task<RESPONSE<T>> Error(T Data,string Message, Exception ex = null)
        {
            return await Task.FromResult(new RESPONSE<T>
            {
                Data = Data,
                Message = Message,
                isSuccessful = false,
                Errors = ex != null
                    ? new List<ValidationFailure>
                    {
                    new ValidationFailure
                    {
                        PropertyName = "Exception",
                        ErrorMessage = ex.Message
                    }
                    }
                    : null
            });
        }



    }
}
