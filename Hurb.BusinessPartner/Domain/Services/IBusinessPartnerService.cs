namespace Hurb.BusinessPartner.Domain.Services
{
    interface IBusinessPartnerService
    {
        void Add();
        
        //void AsyncAdd();
       
        void GetById(int id);
    }
}
