using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JmgPlannedTimeAndAttendanceAbsenceRegistrationEntityVocabulary : SimpleVocabulary
    {
        public JmgPlannedTimeAndAttendanceAbsenceRegistrationEntityVocabulary()
        {
            VocabularyName = "Common Data Model JmgPlannedTimeAndAttendanceAbsenceRegistrationEntity";
            KeyPrefix = "commonDataModel.jmgplannedtimeandattendanceabsenceregistrationentity";
            KeySeparator = ".";
            Grouping = "/JmgPlannedTimeAndAttendanceAbsenceRegistrationEntity";

            AddGroup("Common Data Model JmgPlannedTimeAndAttendanceAbsenceRegistrationEntity Details", group =>
            {
                IsTimeAndAttendanceActivityRegistration = group.Add(new VocabularyKey(nameof(IsTimeAndAttendanceActivityRegistration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsPlannedAbsenceInterruptionAllowed = group.Add(new VocabularyKey(nameof(IsPlannedAbsenceInterruptionAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsPlannedAbsenceInterrupted = group.Add(new VocabularyKey(nameof(IsPlannedAbsenceInterrupted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StartDateTime = group.Add(new VocabularyKey(nameof(StartDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TimeAndAttendanceJobId = group.Add(new VocabularyKey(nameof(TimeAndAttendanceJobId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CalculatedTimeSeconds = group.Add(new VocabularyKey(nameof(CalculatedTimeSeconds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EndDateTime = group.Add(new VocabularyKey(nameof(EndDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkerPersonnelNumber = group.Add(new VocabularyKey(nameof(WorkerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PlannedAbsenceRegistrationEntryNumber = group.Add(new VocabularyKey(nameof(PlannedAbsenceRegistrationEntryNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey IsTimeAndAttendanceActivityRegistration { get; private set; }
public VocabularyKey IsPlannedAbsenceInterruptionAllowed { get; private set; }
public VocabularyKey IsPlannedAbsenceInterrupted { get; private set; }
public VocabularyKey StartDateTime { get; private set; }
public VocabularyKey TimeAndAttendanceJobId { get; private set; }
public VocabularyKey CalculatedTimeSeconds { get; private set; }
public VocabularyKey EndDateTime { get; private set; }
public VocabularyKey WorkerPersonnelNumber { get; private set; }
public VocabularyKey PlannedAbsenceRegistrationEntryNumber { get; private set; }


    }
}