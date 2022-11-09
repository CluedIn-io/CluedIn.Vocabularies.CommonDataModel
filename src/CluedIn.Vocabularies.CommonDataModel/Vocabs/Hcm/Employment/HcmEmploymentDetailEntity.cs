using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmEmploymentDetailEntityVocabulary : SimpleVocabulary
    {
        public HcmEmploymentDetailEntityVocabulary()
        {
            VocabularyName = "Common Data Model HcmEmploymentDetailEntity";
            KeyPrefix = "commonDataModel.hcmemploymentdetailentity";
            KeySeparator = ".";
            Grouping = "/HcmEmploymentDetailEntity";

            AddGroup("Common Data Model HcmEmploymentDetailEntity Details", group =>
            {
                AdjustedWorkerStartDate = group.Add(new VocabularyKey(nameof(AdjustedWorkerStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EmployerNoticeAmount = group.Add(new VocabularyKey(nameof(EmployerNoticeAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EmployerUnitOfNotice = group.Add(new VocabularyKey(nameof(EmployerUnitOfNotice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LastDateWorked = group.Add(new VocabularyKey(nameof(LastDateWorked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransitionDate = group.Add(new VocabularyKey(nameof(TransitionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkerNoticeAmount = group.Add(new VocabularyKey(nameof(WorkerNoticeAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkerStartDate = group.Add(new VocabularyKey(nameof(WorkerStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkerUnitOfNotice = group.Add(new VocabularyKey(nameof(WorkerUnitOfNotice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EmploymentStartDate = group.Add(new VocabularyKey(nameof(EmploymentStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EmploymentEndDate = group.Add(new VocabularyKey(nameof(EmploymentEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReasonCodeId = group.Add(new VocabularyKey(nameof(ReasonCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EmploymentType = group.Add(new VocabularyKey(nameof(EmploymentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AdjustedWorkerStartDate { get; private set; }
public VocabularyKey EmployerNoticeAmount { get; private set; }
public VocabularyKey EmployerUnitOfNotice { get; private set; }
public VocabularyKey LastDateWorked { get; private set; }
public VocabularyKey TransitionDate { get; private set; }
public VocabularyKey ValidFrom { get; private set; }
public VocabularyKey ValidTo { get; private set; }
public VocabularyKey WorkerNoticeAmount { get; private set; }
public VocabularyKey WorkerStartDate { get; private set; }
public VocabularyKey WorkerUnitOfNotice { get; private set; }
public VocabularyKey EmploymentStartDate { get; private set; }
public VocabularyKey EmploymentEndDate { get; private set; }
public VocabularyKey LegalEntityId { get; private set; }
public VocabularyKey PersonnelNumber { get; private set; }
public VocabularyKey ReasonCodeId { get; private set; }
public VocabularyKey EmploymentType { get; private set; }


    }
}