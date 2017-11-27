
using log4net;
using Soti.CaseStudy.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Soti.CaseStudy.API
{
    [ApiExceptionFilter]
    public class BaseApiController : ApiController
    {
        public static readonly ILog Log =   LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    }


}
