﻿// RequestR.Extensions.Ninject
// Copyright (C) 2021 Dust in the Wind
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;

namespace DustInTheWind.RequestR.Extensions.Ninject
{
    internal class RequestHandlerFactory : IRequestHandlerFactory
    {
        private readonly IServiceProvider serviceProvider;

        public RequestHandlerFactory(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
        }

        public T Create<T>()
        {
            return (T)serviceProvider.GetService(typeof(T));
        }

        public object Create(Type type)
        {
            return serviceProvider.GetService(type);
        }
    }
}