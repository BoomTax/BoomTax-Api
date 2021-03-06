﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace BoomTax.Api.SampleProject.Models
{
    public partial class ErrorDetail
    {
        private string _errorCode;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }
        
        private string _errorMessage;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }
        
        private int? _formId;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int? FormId
        {
            get { return this._formId; }
            set { this._formId = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ErrorDetail class.
        /// </summary>
        public ErrorDetail()
        {
        }
        
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                JToken errorCodeValue = inputObject["ErrorCode"];
                if (errorCodeValue != null && errorCodeValue.Type != JTokenType.Null)
                {
                    this.ErrorCode = ((string)errorCodeValue);
                }
                JToken errorMessageValue = inputObject["ErrorMessage"];
                if (errorMessageValue != null && errorMessageValue.Type != JTokenType.Null)
                {
                    this.ErrorMessage = ((string)errorMessageValue);
                }
                JToken formIdValue = inputObject["FormId"];
                if (formIdValue != null && formIdValue.Type != JTokenType.Null)
                {
                    this.FormId = ((int)formIdValue);
                }
            }
        }
    }
}
