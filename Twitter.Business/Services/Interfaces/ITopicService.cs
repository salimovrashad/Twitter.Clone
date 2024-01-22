﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.Business.DTOs.TopicDTOs;
using Twitter.Core.Entities;

namespace Twitter.Business.Services.Interfaces
{
    public interface ITopicService
    {
        public IQueryable<TopicListItemDTO> GetAll();
        public Task<TopicDetailItemDTO> GetByIdAsync(int id);
        public Task CreateAsync(TopicCreateItemDTO dto);
    }
}
