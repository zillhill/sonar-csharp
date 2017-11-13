﻿/*
 * SonarAnalyzer for .NET
 * Copyright (C) 2015-2017 SonarSource SA
 * mailto: contact AT sonarsource DOT com
 *
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 3 of the License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public License
 * along with this program; if not, write to the Free Software Foundation,
 * Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SonarAnalyzer.UnitTest.Rules
{
    [TestClass]
    public class ClassNameTest
    {
        [TestMethod]
        [TestCategory("Rule")]
        public void ClassName_CSharp()
        {
            Verifier.VerifyAnalyzer(
                new[]
                {
                    @"TestCases\ClassName.cs",
                    @"TestCases\ClassName.Partial.cs",
                }, new SonarAnalyzer.Rules.CSharp.ClassAndMethodName());
        }

        [TestMethod]
        [TestCategory("Rule")]
        public void ClassName_VB()
        {
            Verifier.VerifyAnalyzer(@"TestCases\ClassName.vb", new SonarAnalyzer.Rules.VisualBasic.ClassName());
        }

        [TestMethod]
        [TestCategory("Rule")]
        public void MethodName()
        {
            Verifier.VerifyAnalyzer(
                new[]
                {
                    @"TestCases\MethodName.cs",
                    @"TestCases\MethodName.Partial.cs",
                },
                new SonarAnalyzer.Rules.CSharp.ClassAndMethodName());
        }
    }
}
