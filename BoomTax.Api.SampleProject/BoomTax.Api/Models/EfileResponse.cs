﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using BoomTax.Api.SampleProject.Models;
using Microsoft.Rest;
using Newtonsoft.Json.Linq;

namespace BoomTax.Api.SampleProject.Models
{
    public partial class EfileResponse
    {
        private int? _efileRequestId;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int? EfileRequestId
        {
            get { return this._efileRequestId; }
            set { this._efileRequestId = value; }
        }
        
        private IList<ErrorDetail> _errors;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IList<ErrorDetail> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }
        
        private int? _id;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int? Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private bool? _isError;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public bool? IsError
        {
            get { return this._isError; }
            set { this._isError = value; }
        }
        
        private string _receiptId;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string ReceiptId
        {
            get { return this._receiptId; }
            set { this._receiptId = value; }
        }
        
        private DateTimeOffset? _receivedOn;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public DateTimeOffset? ReceivedOn
        {
            get { return this._receivedOn; }
            set { this._receivedOn = value; }
        }
        
        private string _status;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        private string _submissionProof;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string SubmissionProof
        {
            get { return this._submissionProof; }
            set { this._submissionProof = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the EfileResponse class.
        /// </summary>
        public EfileResponse()
        {
            this.Errors = new LazyList<ErrorDetail>();
        }
        
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                JToken efileRequestIdValue = inputObject["EfileRequestId"];
                if (efileRequestIdValue != null && efileRequestIdValue.Type != JTokenType.Null)
                {
                    this.EfileRequestId = ((int)efileRequestIdValue);
                }
                JToken errorsSequence = ((JToken)inputObject["Errors"]);
                if (errorsSequence != null && errorsSequence.Type != JTokenType.Null)
                {
                    foreach (JToken errorsValue in ((JArray)errorsSequence))
                    {
                        ErrorDetail errorDetail = new ErrorDetail();
                        errorDetail.DeserializeJson(errorsValue);
                        this.Errors.Add(errorDetail);
                    }
                }
                JToken idValue = inputObject["Id"];
                if (idValue != null && idValue.Type != JTokenType.Null)
                {
                    this.Id = ((int)idValue);
                }
                JToken isErrorValue = inputObject["IsError"];
                if (isErrorValue != null && isErrorValue.Type != JTokenType.Null)
                {
                    this.IsError = ((bool)isErrorValue);
                }
                JToken receiptIdValue = inputObject["ReceiptId"];
                if (receiptIdValue != null && receiptIdValue.Type != JTokenType.Null)
                {
                    this.ReceiptId = ((string)receiptIdValue);
                }
                JToken receivedOnValue = inputObject["ReceivedOn"];
                if (receivedOnValue != null && receivedOnValue.Type != JTokenType.Null)
                {
                    this.ReceivedOn = ((DateTimeOffset)receivedOnValue);
                }
                JToken statusValue = inputObject["Status"];
                if (statusValue != null && statusValue.Type != JTokenType.Null)
                {
                    this.Status = ((string)statusValue);
                }
                JToken submissionProofValue = inputObject["SubmissionProof"];
                if (submissionProofValue != null && submissionProofValue.Type != JTokenType.Null)
                {
                    this.SubmissionProof = ((string)submissionProofValue);
                }
            }
        }
    }
}
