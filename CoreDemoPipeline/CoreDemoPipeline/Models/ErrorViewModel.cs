using System;

namespace CoreDemoPipeline.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        sandeep
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}