﻿// Copyright (c) Tier 3 Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License. 

using System.Diagnostics.CodeAnalysis;
using ElasticLinq;
using System;
using Xunit;

namespace ElasticLinq.Test
{
    public class ElasticFieldsTests
    {
        [Fact]
        [ExcludeFromCodeCoverage] // Expression isn't "executed"
        public void ScoreThrowsIfAccessed()
        {
            Assert.Throws<InvalidOperationException>(() => ElasticFields.Score);
        }
    }
}