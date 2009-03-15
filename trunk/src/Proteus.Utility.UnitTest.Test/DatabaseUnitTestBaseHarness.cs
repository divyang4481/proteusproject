﻿/*
 *
 * Proteus
 * Copyright (C) 2008, 2009
 * Stephen A. Bohlen
 * http://www.unhandled-exceptions.com
 *
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 3.0 of the License, or (at your option) any later version.
 *
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public
 * License along with this library; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 *
 */

using System;
using System.Collections.Generic;
using System.Text;
using MbUnit.Framework;
using Proteus.Utility.UnitTest;

namespace UnitTestTest
{
    [TestFixture]
    [Category(UnitTestType.DatabaseDependent)]
    public class DatabaseUnitTestBaseHarness : DatabaseUnitTestBase
    {
        [FixtureSetUp]
        public void FixtureSetUp()
        {
            DatabaseFixtureSetUp();
            System.Diagnostics.Trace.WriteLine("DERIVED: FixtureSetUp");
        }

        [FixtureTearDown]
        public void FixtureTearDown()
        {
            //other stuff you also need to do goes here!
            DatabaseFixtureTearDown();
            System.Diagnostics.Trace.WriteLine("DERIVED: FixtureTearDown");
        }

        [Test]
        public void ImATest2()
        {
            System.Diagnostics.Trace.WriteLine("DERIVED: Test2");
        }

        [Test]
        public void ImATest()
        {

            System.Diagnostics.Trace.WriteLine("DERIVED: Test1");
        }

        [SetUp]
        public void SetUp()
        {
            DatabaseSetUp();
            System.Diagnostics.Trace.WriteLine("DERIVED: TestSetUp");
        }

        [TearDown]
        public void TearDown()
        {
            DatabaseTearDown();
            System.Diagnostics.Trace.WriteLine("DERIVED: TestTearDown");
        }

    }
}
