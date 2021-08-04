using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using H7 = Hl7.Fhir.Model;
using MedicalResearch.IdentityManagement.Model;

namespace MedicalResearch.IdentityManagement.Model {

  public class IdentityDetails {
    public string FirstName { get; set; } = null;
    public string LastName { get; set; } = null;
    public string Email { get; set; } = null;
    public string Phone { get; set; } = null;
    public string Street { get; set; } = null;
    public string HouseNumber { get; set; } = null;
    public string PostCode { get; set; } = null;
    public string City { get; set; } = null;
    public string State { get; set; } = null;
    /// <summary> two letter ISO code </summary>
    public string Country { get; set; } = null;
    public DateTime? DateOfBirth { get; set; } = null;
    public DateTime? DateOfDeath { get; set; } = null;
  }

}
