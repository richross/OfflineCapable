using Microsoft.Extensions.Configuration;
using OfflineCapable.Data;
using models = OfflineCapable.Models;
using OfflineCapable.Models.PwrPlt;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfflineCapable.ViewModels
{
    //[QueryProperty(nameof(models.Business), "Business")]
    public partial class InspectionsViewModel : BaseViewModel
    {
        public ObservableCollection<InspectionPwrPlt> Inspections { get; } = new ();

        [ObservableProperty]
        models.Business SelectedBusiness;

        DataverseContext dataverseContext;

        public InspectionsViewModel(DataverseContext _dataContext)
        {
            Title = "Worklist";

            //get the inspections from Dataverse
            this.dataverseContext = _dataContext;
            var inspectionCollection = GetInspectionsFromDataverse();

            

            //clear any existing list of items in the inspections.
            if (Inspections.Count != 0) Inspections.Clear();

            //loops through the dataverse results and add them to the OC.
            foreach (var inspection in inspectionCollection.Inspections.Where(i => i.BusinessFkId == SelectedBusiness.BusinessId))
            {
                Inspections.Add(inspection);
            }
        }

        private InspectionsPwrPlt GetInspectionsFromDataverse()
        {
            return dataverseContext.GetInspections().Result;
        }
    }
}
