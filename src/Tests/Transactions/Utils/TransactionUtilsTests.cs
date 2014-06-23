﻿/*
 *   CoiniumServ - crypto currency pool software - https://github.com/CoiniumServ/CoiniumServ
 *   Copyright (C) 2013 - 2014, Coinium Project - http://www.coinium.org
 *
 *   This program is free software: you can redistribute it and/or modify
 *   it under the terms of the GNU General Public License as published by
 *   the Free Software Foundation, either version 3 of the License, or
 *   (at your option) any later version.
 *
 *   This program is distributed in the hope that it will be useful,
 *   but WITHOUT ANY WARRANTY; without even the implied warranty of
 *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *   GNU General Public License for more details.
 *
 *   You should have received a copy of the GNU General Public License
 *   along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using Coinium.Common.Extensions;
using Coinium.Transactions.Utils;
using Should.Fluent;
using Xunit;

namespace Tests.Transactions.Utils
{
    public class TransactionUtilsTests
    {
        const long UnixDateTime = 1402265775319;
        const long FinalUnixDateTime = UnixDateTime / 1000 | 0;

        /// <summary>
        /// -> date: 1402265775319 final:1402265775 serialized: 04afe09453
        /// </summary>
        [Fact]
        public void SerializedUnixDateTimeTest()
        {
            FinalUnixDateTime.Should().Equal((Int64)1402265775);

            var serializedUnixTime = TransactionUtils.GetSerializedUnixDateTime(UnixDateTime);
            serializedUnixTime.ToHexString().Should().Equal("04afe09453");
        }
    }
}
