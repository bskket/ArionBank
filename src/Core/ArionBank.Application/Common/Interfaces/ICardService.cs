﻿using ArionBank.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArionBank.Application.Common.Interfaces
{
    public interface ICardService
    {
        Task GetAll();
        Task GetCardById(string id);
        Task CreateCard(CardCreateModel model);
    }
}
