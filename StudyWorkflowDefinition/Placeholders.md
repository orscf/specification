 

#  Placeholders & Counters

 

| **Placeholder**            | **Description**                                              | **Usable for Title of ProcedureSchdeule**   **= PSE bzw. PPSE** | Usable for ExecutionTitle of Vists    =PE** | TaskSchedule  | TaskExecution           =TE |
| -------------------------- | ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------- | ------------- | --------------------------- |
| **{D} / {d}**              | Total   days since the StudyParticipation (=root Schedule) has been started     Always   based on estimated begin of the cusomer - nerver on a recorded!!!!    Sample usage:   *"Visit [Y{Y}-]X" will render   "Visit X", "Visit Y2-X", …* |                                                              |                                             |               |                             |
| **{FW} / {fw}**            | Full weeks since the StudyParticipation (=root Schedule) has been started (will   increment in a 7-day interval relative to entry date)   Always   based on estimated begin of the cusomer - nerver on a recorded!!!! |                                                              |                                             |               |                             |
| **{W} / {w}**              | WeekNumber   (will increment on each Sunnday)   Always   based on estimated begin of the cusomer - nerver on a recorded!!!! |                                                              |                                             |               |                             |
| {M} / {m}                  | Month-number  since the StudyParticipation (=root   Schedule) has been started    (monath-changes are in sync with the regular month = relative to the   1. of every monath)   Always   based on estimated begin of the cusomer - nerver on a recorded!!!! | yes                                                          | yes                                         |               |                             |
| {Y} / {y}                  | Year-number   since the StudyParticipation (=root Schedule) has been started   (year-changes are in sync with the regluar   motnhs = relative to the 1. of every monath)   Always   based on estimated begin of the cusomer - nerver on a recorded!!!! | yes                                                          | yes                                         |               |                             |
| {SBD}                      | Begin of study (only date)                                   |                                                              |                                             |               |                             |
| {#X} / {#x}                | CUSTOM "on demand"  on usage!!!!!!!!!   Can be scoped using @  :            {#x@SEN+CY}                will   count each use scoped to  schedule   execution & cycle | yes                                                          | yes                                         |               |                             |
| **{ARM}**                  | ArmName                                                      | yes                                                          | yes                                         |               |                             |
| {SUB}                      | Sub-Study   Name (if the current Execution Tree is running under context of a sub-study) |                                                              |                                             |               |                             |
| {EN}                       | Name of   the Event which induced the current Execution (if it was triggered by an   event) |                                                              |                                             |               |                             |
| {ET}                       | Date   and Time  of the Event which induced   the current Execution (if it was triggered by an event) |                                                              |                                             |               |                             |
| {PPSE}                     | Parent  PrcedureSchedule uniqueExecutionName (if   exists)   | yes                                                          |                                             | yes           | no                          |
| {PPSW}                     | parent   PrcedureScheduleDefinitionUid (if   exists)         | yes                                                          | Yes                                         | yes           | yes                         |
| {PPSC} / {ppsc}            | The   current cycle of the parentschedule (not inheritd)     | yes                                                          |                                             |               |                             |
| **{PSE}**                  | PrcedureSchedule   uniqueExecutionName                       | <<<   DEFINES                                                |                                             |               |                             |
| **{PSW}**                  | PrcedureSchedule   workflowname                              |                                                              | Yes                                         |               |                             |
| **{PSC} / {psc}**          | The   current cycle of the current schedule (not inheritd)   |                                                              | yes                                         |               |                             |
| PSED                       | Prcedureschedulebegindate  (always estemeted - recoding ignored) |                                                              |                                             |               |                             |
| PSCD                       | Procedureschedule   clycle begn date (always estimated!!! - recoding ignored) |                                                              |                                             |               |                             |
| {#}                        | VisitNumber!!!!  Based on the Counter-model within the   workflow |                                                              |                                             |               |                             |
| **{V} /   {v}       =v@s** | Schulude-übergreifend (=alle sisits   eines participants)    |                                                              | Yes                                         |               |                             |
| {V@pSD} / {vsd}            | Innerhalb einen schedule definition   (abarbeitungs und cycle-übergeifned) |                                                              | Yes                                         |               |                             |
| {v@pse}                    | "Visits-@Current-ProcedureScheduleExecution"         Innerhalb einer einzigen schdeule abarbeitung (aber cycle   übergreifend) |                                                              | Yes                                         |               |                             |
| {v@psc}         {VSC}      | Innerhalb einers einzigen clycles einer   konkreten schdeule abarbeitung |                                                              | Yes                                         |               |                             |
| v@M                        | Viisits    innerhalb eines monats (sieh m)                   |                                                              |                                             |               |                             |
| v@Y                        | Viisits innerhalb eines jahres (siehe Y)                     |                                                              |                                             |               |                             |
| {v@pd}                     | Viisits ein und des selbsen   prcedure-definition            |                                                              | Yes                                         |               |                             |
| **{PD}**                   | VisitProcedure   -> InvariantDefinitionName                  |                                                              | Yes                                         |               |                             |
| **{PED}**                  | Visit   procedure execution date  ESTIMATED!!!!              |                                                              |                                             |               |                             |
| {PEDR}                     | Visit   procedure execution REAL date can change when data is recorded! *NOT   RECCOKMENDED |                                                              |                                             |               |                             |
| **{PE}**                   | VisitProcedure  -> UniqueExecutionName                       |                                                              | <<<   DEFINES                               |               |                             |
| {PTSE}                     | Parent  PrcedureSchedule uniqueExecutionName (if   exists)   |                                                              |                                             |               |                             |
| {PTSW}                     | parent   PrcedureScheduleDefinitionUid (if   exists)         |                                                              |                                             |               |                             |
| {PTSC}                     | The   current cycle of the parentschedule (not inheritd)     |                                                              |                                             |               |                             |
| **{TSE}**                  | TaskSchedule   uniqueExecutionName                           |                                                              | -                                           | <<<   DEFINES |                             |
| **{TSW}**                  | TaskScheduleDefinition   workflowname                        |                                                              |                                             |               |                             |
| **{TSC}**                  | The   current cycle of the current schedule (not inheritd)   |                                                              |                                             |               |                             |
| TSET                       | Schedule   executionbegintime  (always estemeted -   recoding ignored) |                                                              |                                             |               |                             |
| TSCT                       | clycle begn time (always estimated!!! -   recoding ignored)  |                                                              |                                             |               |                             |
| {!}                        | TaskNumber                                                   |                                                              |                                             |               |                             |
| {T@S} / {t@s}              | Task of Study (scoped to the current   substudyORarm) (komplett übergreifen für alle vists des patienten |                                                              |                                             |               | yes                         |
| **{T} /   {t}       =t@P** | Schedule-übergreifend (=alle tasks eines   procedurte ausführung) |                                                              |                                             |               | yes                         |
| {t@tsd}                    | Innerhalb einen schedule definition   (abarbeitungs und cycle-übergeifned) |                                                              |                                             |               |                             |
| {t@tse}                    | Innerhalb einer einzigen schedule   abarbeitung (aber cycle übergreifend) |                                                              |                                             |               |                             |
| {t@tsc}                    | Innerhalb einers einzigen clycles einer   konkreten schdeule abarbeitung |                                                              |                                             |               |                             |
| {t@td}                     | Tasks ein und des selbsen   task-definitioon                 |                                                              |                                             |               |                             |
| **{TD}**                   | taskdefinitionname                                           |                                                              |                                             |               |                             |
| **{TET}**                  | Task   executionbegintime (and date)       ESTIMATED!!!!!!!  |                                                              |                                             |               |                             |
| **{TE}**                   | taskexectuonname                                             |                                                              |                                             |               | <<<   DEFINES               |

**When cycling is enabled then the UniqueExecutionNamePattern needs to contain the {cy} or {CY}! If not, an automatic fall back will append  "@{CY}" before resolving!!!!**

 

## Formatting Numeric Placeholders:

 

### Zero based counters vs starting at 1 

| Sample           | Results                                                      |
| ---------------- | ------------------------------------------------------------ |
| {psc}            | Counter name in lower casing indicates start at 0:      (0, 1, 2, 3, …) |
| {PSC} /   {Psc}* | Counter name in upper casing indicates start at 1:      (1, 2, 3, 4, …) |

*For a Counter name in mixed casing there will only the casing first Letter be evaluated! 

Important: the casing is just something like formatting, which means that we have only one counter instead of two!

Ignoring the fact, that ist wont make much sense to use the lower case placeholders {vp} in combination with the upper case placeholders, the counter will increase synchronously!

 

### Formatting: leading zeros 

Can be applied by specifying the minimum count of digits 

| Sample | Results                                 |
| ------ | --------------------------------------- |
| {D}    | 1, 2, 3, …                              |
| {d}    | 0, 1, 2, … , 10, 11, …                  |
| {d:2}  | 00, 01,   02, … , 99, 100, 101, …       |
| {d:3}  | 000,   001, 002, … , 999, 1000, 1001, … |

 

### Formatting:  to be Alphanumeric   

0=""; 

| Sample | Results                                  |
| ------ | ---------------------------------------- |
| {t:a}  | "", a, b, …     *("House-Number" style)* |
| {t:A}  | "",   A, B, …                            |
| {T:a}  | a, b, c, …                               |
| {T:A}  | A, B, C, …                               |

Overflow "like Excel":      A,B,…,X,Y,Z,AA,AB,AC,…,AY,AZ,BA,BB,BC,…



## Formatting: Date/Time Placeholders

 

As usual

Details for Date-based variables   yyyy-MM-dd 

Default for time-based variables (on task-level) is HH:mm:ss   (without a date information)

IS DEFAULT, if there is no date part

 

## Optional Blocks based on Placeholders

  

Using [ ] around a placeholder defines, that the placeholder should only be inserted from the second value of a counter.

This means, that only the first occurrence will not contain a value for this placeholder. In addition to that, a custom sequence of characters can be applied between the outer and inner brackets which also be suppressed when the placeholder is suppressed. Block can also be used for other placeholders which have in a DEFAULT value, .

 

For numeric values (as counters/cycles) is it the First Number is the "DEFAULT"

For text-based placeholders is it the empty string "" - for example the current sub study name "{SUB}"

For special datetime values which can be null (for example the time of a trigger-event "{ET}"), the null is used as "DEFAULT"



| Sample                | Results                                           |
| --------------------- | ------------------------------------------------- |
| [{V}]                 | "",   "2", "3", …                                 |
| [{v}]                 | "",   "1", "2", …                                 |
| TaskX[-{T:a}]         | "TaskX",   "TaskX-b", "TaskX-c", …                |
| TaskX[-{t:a}]         | "TaskX",   "TaskX-a", "TaskX-b", …                |
| V0[-{v}]              | "V0",   "V0-1", "V0-2"                            |
| [C.{PSC:2}-]Screening | "Screening",   "C.02-Screening", "C.03-Screening" |