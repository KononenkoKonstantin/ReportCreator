﻿using ReportCreator.BLL.DTOs;
using System.Collections.Generic;

namespace ReportCreator.BLL.Interfaces
{
    public interface ICategoryService
    {
        void Add(CategoryDto categoryDto);
        void Remove(CategoryDto categoryDto);
        void Update(CategoryDto categoryDto);
        CategoryDto GetById(int id);
        IEnumerable<CategoryDto> GetAll();
        bool IsUnique(string name);
    }
}
