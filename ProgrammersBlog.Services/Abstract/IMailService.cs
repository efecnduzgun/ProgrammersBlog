using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgrammersBlog.Entities.Dtos;
using ProgrammersBlog.Shared.Utilities.Result.Abstract;

namespace ProgrammersBlog.Services.Abstract
{
    public interface IMailService
    {
        IResult Send(EmailSendDto emailSendDto); // efecn@duzgun.dev
        IResult SendContactEmail(EmailSendDto emailSendDto); // efecn@duzgun.dev info@programmersblog.com iletisim@programmersblog.com
    }
}
