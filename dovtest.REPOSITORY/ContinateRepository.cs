using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using dovtest.MODAL;
using dovtest.DATA;
using System.Net.Http;

using System.Net.Http.Headers; 
using Newtonsoft.Json;

namespace dovtest.REPOSITORY
{
    public class ContinateRepository:IContinateRepository
    {
      
          //   private readonly DataContext _context;
      
  

         public  async Task<object> GetContinate(){
         
            object text = System.IO.File.ReadAllText(@"..\dovtest.DATA\\conitnate.txt");

            await Task.Delay(1000);
    
          //  Continate path=System.Web.HttpContext.Current.Request.MapPath("~\\conitnate.txt");
            return  text;
         }
         
    }
}