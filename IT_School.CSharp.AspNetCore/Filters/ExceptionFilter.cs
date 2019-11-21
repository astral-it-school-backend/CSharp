using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;

namespace IT_School.CSharp.AspNetCore.Filters
{
    public class ExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (context.Exception is InvalidOperationException)
            {
                context.HttpContext.Response.WriteAsync($"Некорректная операция. {context.Exception.Message}");
            }
            else if(context.Exception is UnauthorizedAccessException)
            {
                context.HttpContext.Response.WriteAsync($"Ошибка авторизации. {context.Exception.Message}");
            }
            else
            {
                context.HttpContext.Response.WriteAsync("Извините пожалуйста, у нас произошла ошибка");
            }
        }
    }
}