using Microsoft.AspNetCore.Mvc;
using OnatrixUmbraco.Services;
using OnatrixUmbraco.ViewModels;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Common.PublishedModels;
using Umbraco.Cms.Web.Website.Controllers;

namespace OnatrixUmbraco.Controllers;

public class FormController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider, FormSubmissionService formSubmissions) : SurfaceController(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
{
    private readonly FormSubmissionService _formSubmissions = formSubmissions;

    public IActionResult HandleCallbackForm(CallbackFormViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return CurrentUmbracoPage();
        }

        var result = _formSubmissions.SaveCallbackRequest(model);
        if (!result)
        {
            TempData["FormError"] = "Something went wrong while submitting your request. Please try again later.";
            return RedirectToCurrentUmbracoPage();
        }
        TempData["FormSuccess"] = "Thank you! Your request has been received and we will get back to you soon.";

        return RedirectToCurrentUmbracoPage();
    }

    public IActionResult HandleServiceDetailForm(ServiceDetailFormViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return CurrentUmbracoPage();
        }

        var result = _formSubmissions.SaveServiceDetailRequest(model);
        if (!result)
        {
            TempData["FormError"] = "Something went wrong while submitting your question. Please try again later.";
            return RedirectToCurrentUmbracoPage();
        }
        TempData["FormSuccess"] = "Thank you! Your question has been received and we will get back to you soon.";

        return RedirectToCurrentUmbracoPage();
    }
}
