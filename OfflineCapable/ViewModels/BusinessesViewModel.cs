using OfflineCapable.Data;
using OfflineCapable.Models;
using PwrPlt=OfflineCapable.Models.PwrPlt;
using System;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using OfflineCapable.Pages;

namespace OfflineCapable.ViewModels
{
    public partial class BusinessesViewModel : BaseViewModel
    {
        public ObservableCollection<Business> Businesses { get; } = new();
        DataverseContext dataverseContext;

        public BusinessesViewModel(DataverseContext context)
        {
            dataverseContext = context;
            Title = "Businesses";

            var businesses = GetBusinessesFromDataverse();

            foreach (PwrPlt.Business business in businesses.Businesses)
            {
                var thisBusiness = new Business()
                {
                    BusinessId = business.BusinessId,
                    BusinessName = business.BusinessName
                };

                Businesses.Add(thisBusiness);
            }
        }

        [ICommand]
        async Task GoToInspections(Business business)
        {
            if (business is null)
                return;

            await Shell.Current.GoToAsync($"{nameof(Inspections)}", true,
                new Dictionary<string, object>
                {
                    { "BusinessId", business }
                });

        }

        private PwrPlt.BusinessesPwrPlt GetBusinessesFromDataverse()
        {
            var businesses = new PwrPlt.BusinessesPwrPlt();

            try
            {
                businesses = dataverseContext.GetBusinesses().Result;
            }
            catch (Exception ex)
            {

            }

            return businesses;

        }
    }
}
