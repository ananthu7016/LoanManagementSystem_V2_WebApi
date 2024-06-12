
using LoanManagementSystem_V2_WebApi.Model;
using LoanManagementSystem_V2_WebApi.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace LoanManagementSystem_V2_WebApi.Repository
{
    public interface IAdminRepository
    {
        // this is the Interface for the IAdmin Repository 



        #region Add a New Staff 

        Task<ActionResult<int>> RegisterNewStaff(vw_Staff staff);

        #endregion



        #region Get all Log Details 

        Task<ActionResult<IEnumerable<vw_LogDetails>>> GetAllLogDetails();

        #endregion
    }
}
