﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.Business.DTOs.TopicDTOs;
using Twitter.Business.Repositories.Interfaces;
using Twitter.Business.Services.Interfaces;
using Twitter.Core.Entities;

namespace Twitter.Business.Services.Implements
{
    public class TopicService : ITopicService
    {
        ITopicRepository _repo { get; }

        public TopicService(ITopicRepository repo)
        {
            _repo = repo;
        }

        public Task CreateAsync(TopicCreateItemDTO dto)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TopicListItemDTO> GetAll()
        {
            return _repo.GetAll().Select(t => new TopicListItemDTO
            {
                Id = t.Id,
                Name = t.Name,
            });
        }

        public Task<TopicDetailItemDTO> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
