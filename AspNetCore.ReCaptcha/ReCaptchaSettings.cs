﻿using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Localization;

namespace AspNetCore.ReCaptcha
{
    [ExcludeFromCodeCoverage]
    public class ReCaptchaSettings
    {
        internal static readonly Uri GoogleReCaptchaBaseUrl = new Uri("https://www.google.com/recaptcha/");
        internal static readonly Uri RecaptchaNetBaseUrl = new Uri("https://www.recaptcha.net/recaptcha/");

        public string SiteKey { get; set; }
        public string SecretKey { get; set; }
        public ReCaptchaVersion Version { get; set; }
        public bool UseRecaptchaNet { get; set; }
        public double ScoreThreshold { get; set; } = 0.5;
        public Func<Type, IStringLocalizerFactory, IStringLocalizer> LocalizerProvider { get; set; }
        public Uri RecaptchaBaseUrl { get; set; } = GoogleReCaptchaBaseUrl;
    }
}
