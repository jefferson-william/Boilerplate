namespace WebApplication1.Controllers
{
    using System.Net;
    using System.Web.Mvc;
    using Constants;

    [RoutePrefix("error")]
    public sealed class ErrorController : Controller
    {
        #region Public Methods

        [OutputCache(CacheProfile = CacheProfileName.BadRequest)]
        [Route("badrequest", Name = ErrorControllerRoute.GetBadRequest)]
        public ActionResult BadRequest()
        {
            return this.GetErrorView(HttpStatusCode.BadRequest, ErrorControllerAction.BadRequest);
        }

        [OutputCache(CacheProfile = CacheProfileName.Forbidden)]
        [Route("forbidden", Name = ErrorControllerRoute.GetForbidden)]
        public ActionResult Forbidden()
        {
            return this.GetErrorView(HttpStatusCode.Forbidden, ErrorControllerAction.Forbidden);
        }

        [OutputCache(CacheProfile = CacheProfileName.InternalServerError)]
        [Route("internalservererror", Name = ErrorControllerRoute.GetInternalServerError)]
        public ActionResult InternalServerError()
        {
            return this.GetErrorView(HttpStatusCode.InternalServerError, ErrorControllerAction.InternalServerError);
        }

        [OutputCache(CacheProfile = CacheProfileName.MethodNotAllowed)]
        [Route("methodnotallowed", Name = ErrorControllerRoute.GetMethodNotAllowed)]
        public ActionResult MethodNotAllowed()
        {
            return this.GetErrorView(HttpStatusCode.MethodNotAllowed, ErrorControllerAction.MethodNotAllowed);
        }

        [OutputCache(CacheProfile = CacheProfileName.NotFound)]
        [Route("notfound", Name = ErrorControllerRoute.GetNotFound)]
        public ActionResult NotFound()
        {
            return this.GetErrorView(HttpStatusCode.NotFound, ErrorControllerAction.NotFound);
        }

        [OutputCache(CacheProfile = CacheProfileName.Unauthorized)]
        [Route("unauthorized", Name = ErrorControllerRoute.GetUnauthorized)]
        public ActionResult Unauthorized()
        {
            return this.GetErrorView(HttpStatusCode.Unauthorized, ErrorControllerAction.Unauthorized);
        } 

        #endregion

        #region Private Methods

        private ActionResult GetErrorView(HttpStatusCode statusCode, string viewName)
        {
            this.Response.StatusCode = (int)statusCode;

            // Don't show IIS custom errors.
            this.Response.TrySkipIisCustomErrors = true;

            ActionResult result;
            if (this.Request.IsAjaxRequest())
            {
                // This allows us to show errors even in partial views.
                result = this.PartialView(viewName);
            }
            else
            {
                result = this.View(viewName);
            }

            return result;
        }

        #endregion
    }
}