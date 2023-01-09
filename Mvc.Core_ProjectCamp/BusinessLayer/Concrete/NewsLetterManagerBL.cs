using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NewsLetterManagerBL:INewsLetterServiceBL
    {
        INewsLetterDAL _newsletterDAL;

        public NewsLetterManagerBL(INewsLetterDAL newsletterDAL)
        {
            _newsletterDAL = newsletterDAL;
        }

        public void AddNewsLetterBL(NewsLetter newsLetter)
        {
            _newsletterDAL.InsertDAL(newsLetter);
        }
    }
}
