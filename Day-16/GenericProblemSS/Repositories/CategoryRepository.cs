﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericProblemSS.Data;
using GenericProblemSS.Entities;

namespace GenericProblemSS.Repositories
{
    internal class CategoryRepository
    {
        public GenericResponse<List<Category>> GetAllCategories()
        {
            var categories = DataStore.Categories;
            return new GenericResponse<List<Category>>
            {
                Success = true,
                Data = categories,
            };
        }

        public GenericResponse<Category> GetCategoryById(int id)
        {
            var categpry = DataStore.Categories.FirstOrDefault(x => x.Id == id);
            if (categpry == null)
            {
                return new GenericResponse<Category>
                {
                    Success = false,
                    Message = "Category not found",
                };
            }

            return new GenericResponse<Category>
            {
                Success = true,
                Data = categpry,
            };
        }
    }
}
