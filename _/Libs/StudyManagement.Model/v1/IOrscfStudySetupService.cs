using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using H7 = Hl7.Fhir.Model;

namespace MedicalResearch.StudyManagement {

  /// <summary> Provides an workflow-level API for interating with a 'StudyManagementSystem' (SMS) </summary>
  public partial interface IOrscfStudySetupService {

    /// <summary>
    /// returns the Version of the API itself, which can be used to 
    /// backward compatibility within inhomogeneous infrastructures
    /// </summary>
    string GetApiVersion();


    bool HasAccess();
  }

}
