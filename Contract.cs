using System;
namespace LabAI
{
	public class Contract
	{


        //private attributes
        private string _contractNumber;
        private string _signature;

        //public proprietes
        public string ContractNumber { set;  get; }
        public string Signature { set;  get; }



        public Contract()
        {

        }

 

        //public methods
        public void SetContractDetails(Contract contract, string contractNumber, string signature)
        {
            contract.ContractNumber = contractNumber;
            contract.Signature = signature;
        }

        public void SetMasterSignature(string masterSignature)
        {
            _signature = masterSignature;
            _contractNumber = "Director";


            //hehe
        }
    }
}

