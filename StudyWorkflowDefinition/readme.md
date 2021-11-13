# ORSCF-Specification for the 'WorkflowDefinitionRepository' API

![](logo.jpg) 

|          | Info                                                         |
| -------- | ------------------------------------------------------------ |
| author:  | [ORSCF](https://www.orscf.org) ("Open Research Study Communication Formats") |
| license: | [Apache-2](https://choosealicense.com/licenses/apache-2.0/)  |



### Contents:

| File                                                       | Description                                                  |
| ---------------------------------------------------------- | ------------------------------------------------------------ |
| [WDR-Models](./BdrModels.md)                               | Markdown-**Documentation of the domain model** which is defined for this API |
| [Schema.json](./ORSCF-StudyWorkflowDefinition.Schema.json) | a json-based representation of the domain model which can be used to generate entities |
| [WDR-Services](./WdrServices.md)                           | Markdown-**Documentation of the services** (interface-contracts) which are defined for this API |
| [Swagger-Definition](./swagger.json)                       | a json-based [OpenAPI](https://en.wikipedia.org/wiki/OpenAPI_Specification) definition, which can be used to generate client oder server code for REST-APIs |
| [Placeholders](./Placeholders.md)                           | Markdown-**Documentation of the available Placeholders** when defining ExecutionNames for Visits/Tasks |


### see also:

|Specification|Description|Content|
|----|-----------|----|
|[SMS-API](../StudyManagement/readme.md)|Spec. for the 'StudyManagementSystem' API|studies & sites|
|[SDR-API](../SubjectData/readme.md)|Spec. for the 'SubjectDataRepository' API|subjects (operative data)|
|[VDR-API](../VisitData/readme.md)|Spec. for the 'VisitDataRepository' API|research data|
|[BDR-API](../BillingData/readme.md)|Spec. for the 'BillingDataRepository' API|billing data|
|[IMS-API](../IdentityManagement/readme.md)|Spec. for the 'IdentityManagementSystem' API|protected patient identities|
