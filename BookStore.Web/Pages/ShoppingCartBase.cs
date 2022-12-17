﻿using System;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

//using ShopOnline.Models.Dtos;
//using ShopOnline.Web.Services.Contracts;

namespace BookStore.Web.Pages
{
    public class ShoppingCartBase : ComponentBase
    {
       

        [Inject]
        public IShoppingCartService ShoppingCartService { get; set; }

        public IEnumerable<BooksDto> ShoppingCartService { get; set; }

        public string ErrorMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                ShoppingCartItems = await ShoppingCartService.GetItems(HardCoded.UserID);

            }
            catch (Exception ex)
            {

                ErrorMessage = ex.Message;
            }
        }