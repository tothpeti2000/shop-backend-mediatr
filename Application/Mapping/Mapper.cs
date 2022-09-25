﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapping
{
    public class Mapper<T>
    {
        private readonly IMapper mapper;

        public Mapper()
        {
            var config = new MapperConfiguration(config =>
            {
                config.AddProfile(typeof(T));
            });

            mapper = config.CreateMapper();
        }

        public V Map<U, V>(U from)
        {
            return mapper.Map<U, V>(from);
        }
    }
}
