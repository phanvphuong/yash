﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using yash.Data.Entities;
using yash.Utilities.Constants;
using yash.ViewModels.Catalog.Categories;

namespace yash.AdminApp.Controllers
{
    public class CategoriesController : Controller
    {
        private string uri = UriConstants.URI_HOST_PORT_NUMBER_OF_API + "api/Categories/";
        public IActionResult Index()
        {
            HttpClient httpclient = new HttpClient();
            var listCategories = JsonConvert.DeserializeObject<List<Category>>(httpclient.GetStringAsync(uri).Result);
            return View(listCategories);
        }
        [HttpGet]
        public IActionResult Details(int Id)
        {
            HttpClient httpclient = new HttpClient();
            var category = JsonConvert.DeserializeObject<Category>(httpclient.GetStringAsync(uri + Id).Result);
            return View(category);
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            HttpClient httpclient = new HttpClient();
            var category = JsonConvert.DeserializeObject<Category>(httpclient.GetStringAsync(uri + Id).Result);
            return View(category);
        }
        [HttpPost]
        public IActionResult Edit(CategoryUpdateRequest request)
        {
            HttpClient httpclient = new HttpClient();
            var result = httpclient.PutAsJsonAsync(uri, request).Result;
            return RedirectToAction("Edit", new { categoryId = request.Id });

        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CategoryCreateRequest request)
        {
            HttpClient httpclient = new HttpClient();
            var result = httpclient.PostAsJsonAsync(uri, request).Result;
            return RedirectToAction("Index");

        }

        public IActionResult Delete(int Id)
        {
            HttpClient httpclient = new HttpClient();
            var result = httpclient.DeleteAsync(uri + Id).Result;
            return RedirectToAction("Index");

        }



    }
}
