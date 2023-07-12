using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICRUDService" in both code and config file together.
    [ServiceContract]
    public interface ICRUDService
    {
        [OperationContract]
        string  InsertExam(exam ee);


        [OperationContract]
        string UpdateExam(exam ee);

        [OperationContract]
        exam  SearchExam(int eid);


        [OperationContract]
        string  DeleteExam(int eid);

        [OperationContract]
        List<exam> showallexam();


        [OperationContract]
        string InsertStud(stud ss);


        [OperationContract]
        string UpdateStud(stud ss);

        [OperationContract]
        stud  SearchStud(int sid);


        [OperationContract]
        string DeleteStud(int sid);

        [OperationContract]
       List<stud>showallstud();
    }
}
