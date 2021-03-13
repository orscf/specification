# ORSCF-BillingData Schema Specification
author: ORSCF ("Open Research Study Communication Formats")
license: [Apache-2](https://choosealicense.com/licenses/apache-2.0/)
last update: 13.03.2021
add. info: [orscf.org](https://www.orscf.org)
 
 
# Model:

![chart](./chart.png)



## Type: BillableTask


### Fields

| Name | Type | Required | Fix |
| ---- | ---- | -------- | --- |
| [TaskGuid](#BillableTask.**TaskGuid** (Field)) **(KEY)** | *guid* | YES | YES |
| [VisitGuid](#BillableTask.**VisitGuid** (Field)) (FK) | *guid* | YES | YES |
| [TaskName](#BillableTask.**TaskName** (Field)) | *string* | YES | YES |
| [TaskExecutionTitle](#BillableTask.**TaskExecutionTitle** (Field)) | *string* | YES | YES |
##### BillableTask.**TaskGuid** (Field)
```
a global unique id of a concrete study-task execution which is usually originated at the primary CRF or study management system ('SMS')
```
* this field represents the identity (PK) of the record
* after the record has been created, the value of this field must not be changed any more!
##### BillableTask.**VisitGuid** (Field)
```
a global unique id of a concrete study-visit execution which is usually originated at the primary CRF or study management system ('SMS')
```
* this field is used as foreign key to address the related 'BillableVisit'
* after the record has been created, the value of this field must not be changed any more!
##### BillableTask.**TaskName** (Field)
```
unique invariant name of ths task-procedure as defined in the 'StudyWorkflowDefinition' (originated from the sponsor)
```
* after the record has been created, the value of this field must not be changed any more!
##### BillableTask.**TaskExecutionTitle** (Field)
```
title of the task execution as defined in the 'StudyWorkflowDefinition' (originated from the sponsor)
```
* after the record has been created, the value of this field must not be changed any more!


### Relations

| Name | Role | Target-Type | Target-Multiplicity |
| ---- | ---- | ----------- | ------------------- |
| [BillableVisit](#**BillableVisit** (parent of this BillableTask)) | Parent | [BillableVisit](#Type: BillableVisit) | 0/1 (optional) |

##### **BillableVisit** (parent of this BillableTask)
Target Type: [BillableVisit](#Type: BillableVisit)
Addressed by: [VisitGuid](#BillableTask.VisitGuid (Field)).
```
self describing ...
```




## Type: BillableVisit


### Fields

| Name | Type | Required | Fix |
| ---- | ---- | -------- | --- |
| [VisitGuid](#BillableVisit.**VisitGuid** (Field)) **(KEY)** | *guid* | YES | no |
| [StudyExecutionIdentifier](#BillableVisit.**StudyExecutionIdentifier** (Field)) (FK) | *guid* | YES | no |
| [ParticipantIdentifier](#BillableVisit.**ParticipantIdentifier** (Field)) | *string* (50) | YES | no |
| [VisitProdecureName](#BillableVisit.**VisitProdecureName** (Field)) | *string* | YES | no |
| [VisitExecutionTitle](#BillableVisit.**VisitExecutionTitle** (Field)) | *string* | YES | no |
| [BillingDemandId](#BillableVisit.**BillingDemandId** (Field)) (FK) | *guid* | no | no |
| [InvoiceId](#BillableVisit.**InvoiceId** (Field)) (FK) | *guid* | no | no |
| [ExecutionEndDateUtc](#BillableVisit.**ExecutionEndDateUtc** (Field)) | *datetime* | no | no |
| [SponsorValidationDateUtc](#BillableVisit.**SponsorValidationDateUtc** (Field)) | *datetime* | no | no |
| [ExecutorValidationDateUtc](#BillableVisit.**ExecutorValidationDateUtc** (Field)) | *datetime* | no | no |
##### BillableVisit.**VisitGuid** (Field)
```
a global unique id of a concrete study-visit execution which is usually originated at the primary CRF or study management system ('SMS')
```
* this field represents the identity (PK) of the record
##### BillableVisit.**StudyExecutionIdentifier** (Field)
```
a global unique id of a concrete study execution (dedicated to a concrete institute) which is usually originated at the primary CRF or study management system ('SMS')
```
* this field is used as foreign key to address the related 'StudyExecution'
##### BillableVisit.**ParticipantIdentifier** (Field)
```
identity of the patient which can be a randomization or screening number (the exact semantic is defined per study)
```
* the maximum length of the content within this field is 50 characters.
##### BillableVisit.**VisitProdecureName** (Field)
```
unique invariant name of the visit-procedure as defined in the 'StudyWorkflowDefinition' (originated from the sponsor)
```
##### BillableVisit.**VisitExecutionTitle** (Field)
```
title of the visit execution as defined in the 'StudyWorkflowDefinition' (originated from the sponsor)
```
##### BillableVisit.**BillingDemandId** (Field)
```
self describing ...
```
* this field is optional, so that '*null*' values are supported
* this field is used as foreign key to address the related 'AssignedBillingDemand'
##### BillableVisit.**InvoiceId** (Field)
```
self describing ...
```
* this field is optional, so that '*null*' values are supported
* this field is used as foreign key to address the related 'AssignedInvoice'
##### BillableVisit.**ExecutionEndDateUtc** (Field)
```
self describing ...
```
* this field is optional, so that '*null*' values are supported
##### BillableVisit.**SponsorValidationDateUtc** (Field)
```
indicates, that the visit is ready to get assigned to a 'BillingDemand' (usually this state is managed by the sponsor) This can only be set after there is a valid 'ExecutionEndDateUtc'
```
* this field is optional, so that '*null*' values are supported
##### BillableVisit.**ExecutorValidationDateUtc** (Field)
```
indicates, that the visit is ready to get assigned to a 'Invoice' (usually this state is managed by the executor) This can only be set after either the 'SponsorValidationDateUtc' is set (and there is a Demand) nor the states are only managed by the executor, so that the demand-part is completely skipped.
```
* this field is optional, so that '*null*' values are supported


### Relations

| Name | Role | Target-Type | Target-Multiplicity |
| ---- | ---- | ----------- | ------------------- |
| [BillableTasks](#**BillableTasks** (childs of this BillableVisit)) | Childs | [BillableTask](#Type: BillableTask) | * (multiple) |
| [StudyExecution](#**StudyExecution** (parent of this BillableVisit)) | Parent | [StudyExecutionScope](#Type: StudyExecutionScope) | 0/1 (optional) |
| [AssignedBillingDemand](#**AssignedBillingDemand** (lookup from this BillableVisit)) | Lookup | [BillingDemand](#Type: BillingDemand) | 1 (required) |
| [AssignedInvoice](#**AssignedInvoice** (lookup from this BillableVisit)) | Lookup | [Invoice](#Type: Invoice) | 1 (required) |

##### **BillableTasks** (childs of this BillableVisit)
Target: [BillableTask](#Type: BillableTask)
```
self describing ...
```
##### **StudyExecution** (parent of this BillableVisit)
Target Type: [StudyExecutionScope](#Type: StudyExecutionScope)
Addressed by: [StudyExecutionIdentifier](#BillableVisit.StudyExecutionIdentifier (Field)).
```
self describing ...
```
##### **AssignedBillingDemand** (lookup from this BillableVisit)
Target Type: [BillingDemand](#Type: BillingDemand)
Addressed by: [BillingDemandId](#BillableVisit.BillingDemandId (Field)).
```
self describing ...
```
##### **AssignedInvoice** (lookup from this BillableVisit)
Target Type: [Invoice](#Type: Invoice)
Addressed by: [InvoiceId](#BillableVisit.InvoiceId (Field)).
```
self describing ...
```




## Type: StudyExecutionScope


### Fields

| Name | Type | Required | Fix |
| ---- | ---- | -------- | --- |
| [StudyExecutionIdentifier](#StudyExecutionScope.**StudyExecutionIdentifier** (Field)) **(KEY)** | *guid* | YES | YES |
| [ExecutingInstituteIdentifier](#StudyExecutionScope.**ExecutingInstituteIdentifier** (Field)) | *string* | YES | YES |
| [StudyWorkflowName](#StudyExecutionScope.**StudyWorkflowName** (Field)) | *string* (100) | YES | YES |
| [StudyWorkflowVersion](#StudyExecutionScope.**StudyWorkflowVersion** (Field)) | *string* (20) | YES | YES |
| [ExtendedMetaData](#StudyExecutionScope.**ExtendedMetaData** (Field)) | *string* | no | no |
##### StudyExecutionScope.**StudyExecutionIdentifier** (Field)
```
a global unique id of a concrete study execution (dedicated to a concrete institute) which is usually originated at the primary CRF or study management system ('SMS')
```
* this field represents the identity (PK) of the record
* after the record has been created, the value of this field must not be changed any more!
##### StudyExecutionScope.**ExecutingInstituteIdentifier** (Field)
```
the institute which is executing the study (this should be an invariant technical representation of the company name or a guid)
```
* after the record has been created, the value of this field must not be changed any more!
##### StudyExecutionScope.**StudyWorkflowName** (Field)
```
the official invariant name of the study as given by the sponsor
```
* the maximum length of the content within this field is 100 characters.
* after the record has been created, the value of this field must not be changed any more!
##### StudyExecutionScope.**StudyWorkflowVersion** (Field)
```
version of the workflow
```
* the maximum length of the content within this field is 20 characters.
* after the record has been created, the value of this field must not be changed any more!
##### StudyExecutionScope.**ExtendedMetaData** (Field)
```
optional structure (in JSON-format) containing additional metadata regarding this record, which can be used by 'StudyExecutionSystems' to extend the schema
```
* this field is optional, so that '*null*' values are supported


### Relations

| Name | Role | Target-Type | Target-Multiplicity |
| ---- | ---- | ----------- | ------------------- |
| [BillableVisits](#**BillableVisits** (childs of this StudyExecutionScope)) | Childs | [BillableVisit](#Type: BillableVisit) | * (multiple) |
| [BillingDemands](#**BillingDemands** (childs of this StudyExecutionScope)) | Childs | [BillingDemand](#Type: BillingDemand) | * (multiple) |
| [Invoices](#**Invoices** (childs of this StudyExecutionScope)) | Childs | [Invoice](#Type: Invoice) | * (multiple) |

##### **BillableVisits** (childs of this StudyExecutionScope)
Target: [BillableVisit](#Type: BillableVisit)
```
self describing ...
```
##### **BillingDemands** (childs of this StudyExecutionScope)
Target: [BillingDemand](#Type: BillingDemand)
```
self describing ...
```
##### **Invoices** (childs of this StudyExecutionScope)
Target: [Invoice](#Type: Invoice)
```
self describing ...
```




## Type: BillingDemand

created by the sponsor
### Fields

| Name | Type | Required | Fix |
| ---- | ---- | -------- | --- |
| [Id](#BillingDemand.**Id** (Field)) **(KEY)** | *guid* | YES | no |
| [OfficialNumber](#BillingDemand.**OfficialNumber** (Field)) | *string* | YES | no |
| [StudyExecutionIdentifier](#BillingDemand.**StudyExecutionIdentifier** (Field)) (FK) | *guid* | YES | no |
| [TransmissionDateUtc](#BillingDemand.**TransmissionDateUtc** (Field)) | *datetime* | no | no |
| [CreationDateUtc](#BillingDemand.**CreationDateUtc** (Field)) | *datetime* | YES | no |
| [CreatedByPerson](#BillingDemand.**CreatedByPerson** (Field)) | *string* | YES | no |
##### BillingDemand.**Id** (Field)
```
self describing ...
```
* this field represents the identity (PK) of the record
##### BillingDemand.**OfficialNumber** (Field)
```
self describing ...
```
##### BillingDemand.**StudyExecutionIdentifier** (Field)
```
self describing ...
```
* this field is used as foreign key to address the related 'StudyExecution'
##### BillingDemand.**TransmissionDateUtc** (Field)
```
self describing ...
```
* this field is optional, so that '*null*' values are supported
##### BillingDemand.**CreationDateUtc** (Field)
```
self describing ...
```
##### BillingDemand.**CreatedByPerson** (Field)
```
self describing ...
```


### Relations

| Name | Role | Target-Type | Target-Multiplicity |
| ---- | ---- | ----------- | ------------------- |
| [AssignedVisits](#**AssignedVisits** (refering to this BillingDemand)) | Referers | [BillableVisit](#Type: BillableVisit) | * (multiple) |
| [StudyExecution](#**StudyExecution** (parent of this BillingDemand)) | Parent | [StudyExecutionScope](#Type: StudyExecutionScope) | 0/1 (optional) |

##### **AssignedVisits** (refering to this BillingDemand)
Target: [BillableVisit](#Type: BillableVisit)
```
self describing ...
```
##### **StudyExecution** (parent of this BillingDemand)
Target Type: [StudyExecutionScope](#Type: StudyExecutionScope)
Addressed by: [StudyExecutionIdentifier](#BillingDemand.StudyExecutionIdentifier (Field)).
```
self describing ...
```




## Type: Invoice

created by the executor-company
### Fields

| Name | Type | Required | Fix |
| ---- | ---- | -------- | --- |
| [Id](#Invoice.**Id** (Field)) **(KEY)** | *guid* | YES | YES |
| [OfficialNumber](#Invoice.**OfficialNumber** (Field)) | *string* | YES | YES |
| [StudyExecutionIdentifier](#Invoice.**StudyExecutionIdentifier** (Field)) (FK) | *guid* | YES | YES |
| [OffcialInvoiceDate](#Invoice.**OffcialInvoiceDate** (Field)) | *datetime* | YES | YES |
| [TransmissionDateUtc](#Invoice.**TransmissionDateUtc** (Field)) | *datetime* | no | no |
| [CreationDateUtc](#Invoice.**CreationDateUtc** (Field)) | *datetime* | YES | no |
| [CreatedByPerson](#Invoice.**CreatedByPerson** (Field)) | *string* | YES | no |
| [PaymentSubmittedDateUtc](#Invoice.**PaymentSubmittedDateUtc** (Field)) | *datetime* | no | no |
| [PaymentReceivedDateUtc](#Invoice.**PaymentReceivedDateUtc** (Field)) | *datetime* | no | no |
##### Invoice.**Id** (Field)
```
self describing ...
```
* this field represents the identity (PK) of the record
* after the record has been created, the value of this field must not be changed any more!
##### Invoice.**OfficialNumber** (Field)
```
the invoice number
```
* after the record has been created, the value of this field must not be changed any more!
##### Invoice.**StudyExecutionIdentifier** (Field)
```
self describing ...
```
* this field is used as foreign key to address the related 'StudyExecution'
* after the record has been created, the value of this field must not be changed any more!
##### Invoice.**OffcialInvoiceDate** (Field)
```
self describing ...
```
* after the record has been created, the value of this field must not be changed any more!
##### Invoice.**TransmissionDateUtc** (Field)
```
self describing ...
```
* this field is optional, so that '*null*' values are supported
##### Invoice.**CreationDateUtc** (Field)
```
self describing ...
```
##### Invoice.**CreatedByPerson** (Field)
```
self describing ...
```
##### Invoice.**PaymentSubmittedDateUtc** (Field)
```
self describing ...
```
* this field is optional, so that '*null*' values are supported
##### Invoice.**PaymentReceivedDateUtc** (Field)
```
self describing ...
```
* this field is optional, so that '*null*' values are supported


### Relations

| Name | Role | Target-Type | Target-Multiplicity |
| ---- | ---- | ----------- | ------------------- |
| [AssignedVisits](#**AssignedVisits** (refering to this Invoice)) | Referers | [BillableVisit](#Type: BillableVisit) | * (multiple) |
| [StudyExecution](#**StudyExecution** (parent of this Invoice)) | Parent | [StudyExecutionScope](#Type: StudyExecutionScope) | 0/1 (optional) |

##### **AssignedVisits** (refering to this Invoice)
Target: [BillableVisit](#Type: BillableVisit)
```
self describing ...
```
##### **StudyExecution** (parent of this Invoice)
Target Type: [StudyExecutionScope](#Type: StudyExecutionScope)
Addressed by: [StudyExecutionIdentifier](#Invoice.StudyExecutionIdentifier (Field)).
```
self describing ...
```

