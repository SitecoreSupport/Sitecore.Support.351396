namespace Sitecore.Support.XA.Foundation.Multisite.Services
{
    using Sitecore.Data.Comparers;
    using Sitecore.Data.Items;
    using Sitecore.XA.Foundation.Multisite.Services;
    using System.Collections.Generic;
    using System.Linq;

    public class PushCloneService : Sitecore.XA.Foundation.Multisite.Services.PushCloneService
    {

        public PushCloneService(IPushCloneCoordinatorService pushCloneCoordinatorService) : base(pushCloneCoordinatorService)
        { }

        protected override IEnumerable<Item> GetCloneItem(Item item)
        {
            return item.GetClones().Distinct(new ItemIdComparer());
        }
    }
}