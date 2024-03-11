﻿namespace Business.Responses.Applications
{
    public class GetAllApplicationResponse
    {
        public int Id { get; set; }
        public string ApplicantFirstName { get; set; }
        public string ApplicantLastName { get; set; }
        public string ApplicantEmail { get; set; }
        public string BootcampName { get; set; }
        public string ApplicationStateName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
