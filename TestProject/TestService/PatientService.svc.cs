using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using TestService.Data;

namespace TestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class PatientService : IPatientService
    {
        TestDBContext context = new TestDBContext();

        public Task<PatientDataModel> GetPatientAsync(int id)
        {
            var patient = context.Patients.FindAsync(id).Result;

            return Task.FromResult(MappingModelData(patient));
        }

        public Task<IQueryable<PatientDataModel>> GetPatientsAsync(string idOrName)
        {
            var patientList = new List<PatientDataModel>();
            IQueryable<Patient> patients;

            if (string.IsNullOrEmpty(idOrName) || string.IsNullOrWhiteSpace(idOrName))
            {
                return Task.FromResult(patientList.AsQueryable());
            }
            else
            {
                patients = context.Patients.Where(p => p.IdentityNo.Contains(idOrName) || p.Name.Contains(idOrName));
            }

            if (patients != null && patients.Any())
            {
                foreach (var item in patients)
                {
                    patientList.Add(MappingModelData(item));
                }
            }

            return Task.FromResult(patientList.AsQueryable());
        }

        private PatientDataModel MappingModelData(Patient entity)
        {
            var model = new PatientDataModel();
            if (entity != null)
            {
                var genderString = "male";

                if (entity.Gender.HasValue)
                {
                    // If gender value is 1/true then set the string to male, or set to female
                    genderString = entity.Gender.Value ? "male" : "female";
                }

                model.PatientId = entity.PatientId;
                model.Name = entity.Name;
                model.IdentityNo = entity.IdentityNo;
                model.Gender = entity.Gender;
                model.GenderString = genderString;
                model.CardNo = entity.CardNo;
                model.Birth = entity.Birth;
            }

            return model;
        }
    }
}
