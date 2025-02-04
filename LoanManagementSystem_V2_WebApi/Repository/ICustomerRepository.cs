﻿
using LoanManagementSystem_V2_WebApi.Model;
using LoanManagementSystem_V2_WebApi.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LoanManagementSystem_V2_WebApi.Repository
{
    public interface ICustomerRepository
    {

        // This is the Interface of Customer Repository here we neeed to declare the methods that are to be implemented in the 
        //child class 


        #region Register a New Customer 

        Task<ActionResult<int>> RegisterNewCustomer(Customer customer);
        // the declaration of this method is responsible to add details of a new customer.

        #endregion



        #region Get Details Of All Loans Taken By a Customer

        Task<ActionResult<IEnumerable<vw_LoanDetailsOfCustomer>>> GetAllLoansOfCustomer(int custId);

        #endregion


        #region Get Details of All Available Loans

        Task<ActionResult<IEnumerable<Loan>>> GetDetailsOfAllLoans();

        #endregion


        #region Get Details of Logged in Customer 
        
        Task<ActionResult<Customer>> GetCustomerDetails(int custId);

        #endregion


        #region Apply for a Loan 

        Task<ActionResult<int>> ApplyForLoan(LoanRequest loan);

        #endregion



        #region Check Loan Eligibility for a Loan 

        Task<ActionResult<IEnumerable<Loan>>> GetEligibleLoans(vw_CheckEligibility condition);

        #endregion


        #region Upload a Document for Verification 
        Task<ActionResult<int>> UploadADocument(UploadedDocument document);

        #endregion

    }
}
