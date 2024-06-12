
using LoanManagementSystem_V2_WebApi.Model;
using LoanManagementSystem_V2_WebApi.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace LoanManagementSystem_V2_WebApi.Repository
{
    public interface IOfficerRepository
    {

        // this is the interface for Officer Repository 


        #region Get Details of All Assigned Varification 

        Task<ActionResult<IEnumerable<vw_VerificationDetails>>> GetDetailsToVerify(int staff_id);

        #endregion


        #region Submit a Verification Report 

        // this method is responsible to Submit the verification form 
        Task<ActionResult<int>> SubmitVerificationReport(vw_Dropdown report);


        #endregion


        #region Get Details of all Documents Uploaded by a Customer 

        Task<ActionResult<IEnumerable<vw_Documents>>> GetDocumentOfCustomer(int customer_id);

        #endregion
    }
}
