﻿using NUnit.Framework;

namespace iTextSharp.Test {
    [LogListener]
    public abstract class ExtendedITextTest : ITextTest {
        [SetUp]
        public virtual void BeforeTestMethodAction() {
        }

        [TearDown]
        public virtual void AfterTestMethodAction() {
        }
    }
}