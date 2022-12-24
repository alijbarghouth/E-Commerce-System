﻿using E_Commerce_System.DTO.CustomerDto;
using E_Commerce_System.Model;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_System.Service.CustomerService
{
    public interface ICustomerService
    {
        Task<AuthModel> RegisterUser(RegisterUser user);


        Task<AuthModel> LoginUser(LoginUser user);

        Task<IEnumerable<Customer>> GetAllCustomer();

        Task<Customer> GetCustomerById(int id);

        Task<Customer> LogOut(int id);
    }
}