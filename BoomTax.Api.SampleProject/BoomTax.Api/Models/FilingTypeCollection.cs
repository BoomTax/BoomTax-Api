﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using BoomTax.Api.SampleProject.Models;
using Newtonsoft.Json.Linq;

namespace BoomTax.Api.SampleProject.Models
{
    public static partial class FilingTypeCollection
    {
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public static IList<FilingType> DeserializeJson(JToken inputObject)
        {
            IList<FilingType> deserializedObject = new List<FilingType>();
            foreach (JToken iListValue in ((JArray)inputObject))
            {
                FilingType filingType = new FilingType();
                filingType.DeserializeJson(iListValue);
                deserializedObject.Add(filingType);
            }
            return deserializedObject;
        }
    }
}
