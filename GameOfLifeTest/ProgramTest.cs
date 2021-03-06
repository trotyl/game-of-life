﻿using NUnit.Framework;
using GameOfLife;
using System;

namespace GameOfLifeTest
{
    [TestFixture]
    public class ProgramTest
    {
        [Test]
        public void should_get_result_result()
        {
            var input = @"4 8
........
....*...
...**...
........";
            var expected = @"4 8
........
...**...
...**...
........";

            var actual = Program.Run(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
