using OfflineCapable.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfflineCapable.Models
{
    public interface IInspectionsRepository
    {
        List<Inspection> GetInspections();
        void Save();
    }

    public class InspectionsRepository : IInspectionsRepository
    {
        private InspectionsContext _context;

        public InspectionsRepository(InspectionsContext context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public List<Inspection> GetInspections()
        {
            return _context.Inspections.ToList<Inspection>();
        }
    }
}
