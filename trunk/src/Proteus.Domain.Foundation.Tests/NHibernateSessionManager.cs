/*
 *
 * Proteus
 * Copyright (C) 2008, 2009, 2010
 * Stephen A. Bohlen
 * http://www.unhandled-exceptions.com
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 */ 



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Cfg;
using NHibernate;
using NHibernate.Criterion;

namespace DataAccessLayer
{
    public class NHibernateSessionManager
    {

        private ISessionFactory _sessionFactory;

        /// <summary>
        /// Initializes a new instance of the NHibernateSessionManager class.
        /// </summary>
        public NHibernateSessionManager()
        {
            _sessionFactory = GetSessionFactory();

        }



        public ISession GetSession()
        {
            return _sessionFactory.OpenSession();
        }

        private ISessionFactory GetSessionFactory()
        {
            return (new Configuration()).Configure().BuildSessionFactory();

        }

    }
}
