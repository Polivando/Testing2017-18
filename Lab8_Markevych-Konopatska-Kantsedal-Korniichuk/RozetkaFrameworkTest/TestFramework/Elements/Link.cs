﻿using TestFramework.Extensions;
using OpenQA.Selenium;

namespace TestFramework.Elements
{
    public class Link : Element
    {
        public Link(IWebElement nativeElement) : base(nativeElement) { }

        public string GetText()
        {
            var result = Text;
            if (result.IsNullOrEmpty())
                result = GetAttribute("value");
            return Text?.Trim();
        }
    }
}