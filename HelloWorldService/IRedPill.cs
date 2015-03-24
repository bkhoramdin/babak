using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.InteropServices;
using System.ServiceModel.Web;
using System.Runtime.Serialization;



namespace MyWCFServices
{
  
    [DataContract(Name="Triangle")]

    public enum TriangleType
    {
        [EnumMember]
        Equilateral,
        [EnumMember]
        Isosceles,
       [EnumMember]
        Scalene,
        [EnumMember]

        Error
    }
     [ServiceContract(Namespace= "http://KnockKnock.readify.net")]
    public interface IRedPill
    {
         
        [OperationContract]
     
        System.Guid WhatIsYourToken( );


         [OperationContract]

        TriangleType WhatShapeIsThis(int a, int b, int c);

          [OperationContract]
          [FaultContract(typeof(ArgumentOutOfRangeException))]
         long FibonacciNumber(long n);
          
         
         
         [OperationContract]
         [FaultContract(typeof(ArgumentNullException))]
          string ReverseWords(string s);

        

    }
}
