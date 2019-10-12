using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace Jerry.BookStore.Web.Views
{
    public abstract class BookStoreRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected BookStoreRazorPage()
        {
            LocalizationSourceName = BookStoreConsts.LocalizationSourceName;
        }
    }
}
