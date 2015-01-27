using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace TestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IPatientService
    {
        [OperationContract]
        Task<PatientDataModel> GetPatientAsync(int id);
        
        [OperationContract]
        Task<IQueryable<PatientDataModel>> GetPatientsAsync(string idOrName);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class PatientDataModel
    {
        [DataMember]
        public int PatientId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string CardNo { get; set; }

        [DataMember]
        public string IdentityNo { get; set; }

        [DataMember]
        public bool? Gender { get; set; }

        [DataMember]
        public string GenderString { get; set; }

        [DataMember]
        public DateTime? Birth { get; set; }
    }
}
