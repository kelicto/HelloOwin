using System.Collections.Generic;
using System.Web.Http;

namespace KeLi.HelloOwin.App
{
    public abstract class BaseController<T> : ApiController
    {
        public abstract void Post([FromBody]string value);

        public abstract void Delete(int id);

        public abstract void Put(int id, [FromBody] string value);

        public abstract T Get(int id);

        public abstract List<T> Get();
    }
}