using MedicalResearch.StudyManagement.Model;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;

namespace MedicalResearch.StudyManagement.StoreAccess {

/// <summary> Provides CRUD access to stored Institutes (based on schema version '1.0.0') </summary>
public partial interface IInstitutes {

  //// <summary> Returns an info object, which specifies the possible operations (accessor specific permissions) regarding Institutes.</summary>
  //AccessSpecs GetAccessSpecs();

  /// <summary> Loads a specific Institute addressed by the given primary identifier. Returns null on failure, or if no record exists with the given identity.</summary>
  /// <param name="instituteUid"> Represents the primary identity of a Institute </param>
  Institute GetInstituteByInstituteUid(Guid instituteUid);

  /// <summary> Loads Institutes. </summary>
  /// <param name="page">Number of the page, which should be returned </param>
  /// <param name="pageSize">Max count of Institutes which should be returned </param>
  Institute[] GetInstitutes(int page = 1, int pageSize = 20);

  /// <summary> Loads Institutes where values matching to the given filterExpression</summary>
    /// <param name="filterExpression">a filter expression like '((FieldName1 == "ABC" &amp;&amp; FieldName2 &gt; 12) || FieldName2 != "")'</param>
  /// <param name="sortingExpression">one or more property names which are used as sort order (before pagination)</param>
  /// <param name="page">Number of the page, which should be returned</param>
  /// <param name="pageSize">Max count of Institutes which should be returned</param>
  Institute[] SearchInstitutes(String filterExpression, String sortingExpression = null, int page = 1, int pageSize = 20);

  /// <summary> Adds a new Institute and returns its primary identifier (or null on failure). </summary>
  /// <param name="institute"> Institute containing the new values </param>
  bool AddNewInstitute(Institute institute);

  /// <summary> Updates all values (which are not "FixedAfterCreation") of the given Institute addressed by the primary identifier fields within the given Institute. Returns false on failure or if no target record was found, otherwise true.</summary>
  /// <param name="institute"> Institute containing the new values (the primary identifier fields within the given Institute will be used to address the target record) </param>
  bool UpdateInstitute(Institute institute);

  /// <summary> Updates all values (which are not "FixedAfterCreation") of the given Institute addressed by the supplementary given primary identifier. Returns false on failure or if no target record was found, otherwise true.</summary>
  /// <param name="instituteUid"> Represents the primary identity of a Institute </param>
  /// <param name="institute"> Institute containing the new values (the primary identifier fields within the given Institute will be ignored) </param>
  bool UpdateInstituteByInstituteUid(Guid instituteUid, Institute institute);

  /// <summary> Deletes a specific Institute addressed by the given primary identifier. Returns false on failure or if no target record was found, otherwise true.</summary>
  /// <param name="instituteUid"> Represents the primary identity of a Institute </param>
  bool ArchiveInstituteByInstituteUid(Guid instituteUid);

}

/// <summary> Provides CRUD access to stored ResearchStudies (based on schema version '1.0.0') </summary>
public partial interface IResearchStudies {

  //// <summary> Returns an info object, which specifies the possible operations (accessor specific permissions) regarding ResearchStudies.</summary>
  //AccessSpecs GetAccessSpecs();

  /// <summary> Loads a specific ResearchStudy addressed by the given primary identifier. Returns null on failure, or if no record exists with the given identity.</summary>
  /// <param name="studyIdentifier"> Represents the primary identity of a ResearchStudy </param>
  ResearchStudy GetResearchStudyByStudyIdentifier(String studyIdentifier);

  /// <summary> Loads ResearchStudies. </summary>
  /// <param name="page">Number of the page, which should be returned </param>
  /// <param name="pageSize">Max count of ResearchStudies which should be returned </param>
  ResearchStudy[] GetResearchStudies(int page = 1, int pageSize = 20);

  /// <summary> Loads ResearchStudies where values matching to the given filterExpression</summary>
    /// <param name="filterExpression">a filter expression like '((FieldName1 == "ABC" &amp;&amp; FieldName2 &gt; 12) || FieldName2 != "")'</param>
  /// <param name="sortingExpression">one or more property names which are used as sort order (before pagination)</param>
  /// <param name="page">Number of the page, which should be returned</param>
  /// <param name="pageSize">Max count of ResearchStudies which should be returned</param>
  ResearchStudy[] SearchResearchStudies(String filterExpression, String sortingExpression = null, int page = 1, int pageSize = 20);

  /// <summary> Adds a new ResearchStudy and returns its primary identifier (or null on failure). </summary>
  /// <param name="researchStudy"> ResearchStudy containing the new values </param>
  bool AddNewResearchStudy(ResearchStudy researchStudy);

  /// <summary> Updates all values (which are not "FixedAfterCreation") of the given ResearchStudy addressed by the primary identifier fields within the given ResearchStudy. Returns false on failure or if no target record was found, otherwise true.</summary>
  /// <param name="researchStudy"> ResearchStudy containing the new values (the primary identifier fields within the given ResearchStudy will be used to address the target record) </param>
  bool UpdateResearchStudy(ResearchStudy researchStudy);

  /// <summary> Updates all values (which are not "FixedAfterCreation") of the given ResearchStudy addressed by the supplementary given primary identifier. Returns false on failure or if no target record was found, otherwise true.</summary>
  /// <param name="studyIdentifier"> Represents the primary identity of a ResearchStudy </param>
  /// <param name="researchStudy"> ResearchStudy containing the new values (the primary identifier fields within the given ResearchStudy will be ignored) </param>
  bool UpdateResearchStudyByStudyIdentifier(String studyIdentifier, ResearchStudy researchStudy);

  /// <summary> Deletes a specific ResearchStudy addressed by the given primary identifier. Returns false on failure or if no target record was found, otherwise true.</summary>
  /// <param name="studyIdentifier"> Represents the primary identity of a ResearchStudy </param>
  bool ArchiveResearchStudyByStudyIdentifier(String studyIdentifier);

}

}
