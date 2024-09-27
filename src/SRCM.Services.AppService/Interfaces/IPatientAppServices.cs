using SRCM.Domain.Entities;
using SRCM.Services.AppService.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SRCM.Services.AppService.Interfaces
{
    public interface IPatientAppServices
    {
        PatientViewModel GetById(Guid id);
        IEnumerable<PatientViewModel> Search(Expression<Func<Patient, bool>> expression);
        IEnumerable<PatientViewModel> Search(Expression<Func<Patient, bool>> expression, int pageNumber, int pageSize);
        AppointmentViewModel Add(PatientViewModel viewModel);
        AppointmentViewModel Update(PatientViewModel viewModel);
        void Remove(Guid id);
        void Remove(Expression<Func<Patient, bool>> expression);
    }
}
