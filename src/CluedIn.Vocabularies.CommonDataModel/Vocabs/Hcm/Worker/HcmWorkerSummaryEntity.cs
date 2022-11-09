using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmWorkerSummaryEntityVocabulary : SimpleVocabulary
    {
        public HcmWorkerSummaryEntityVocabulary()
        {
            VocabularyName = "Common Data Model HcmWorkerSummaryEntity";
            KeyPrefix = "commonDataModel.hcmworkersummaryentity";
            KeySeparator = ".";
            Grouping = "/HcmWorkerSummaryEntity";

            AddGroup("Common Data Model HcmWorkerSummaryEntity Details", group =>
            {
                BuildingAddress = group.Add(new VocabularyKey(nameof(BuildingAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OfficeLocation = group.Add(new VocabularyKey(nameof(OfficeLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OriginalHireDateTime = group.Add(new VocabularyKey(nameof(OriginalHireDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SeniorityDate = group.Add(new VocabularyKey(nameof(SeniorityDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AnniversaryDateTime = group.Add(new VocabularyKey(nameof(AnniversaryDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Title = group.Add(new VocabularyKey(nameof(Title), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TitleId = group.Add(new VocabularyKey(nameof(TitleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BuildingAddressId = group.Add(new VocabularyKey(nameof(BuildingAddressId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorksFromHome = group.Add(new VocabularyKey(nameof(WorksFromHome), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey BuildingAddress { get; private set; }
public VocabularyKey OfficeLocation { get; private set; }
public VocabularyKey OriginalHireDateTime { get; private set; }
public VocabularyKey SeniorityDate { get; private set; }
public VocabularyKey AnniversaryDateTime { get; private set; }
public VocabularyKey Title { get; private set; }
public VocabularyKey ValidFrom { get; private set; }
public VocabularyKey ValidTo { get; private set; }
public VocabularyKey TitleId { get; private set; }
public VocabularyKey PersonnelNumber { get; private set; }
public VocabularyKey BuildingAddressId { get; private set; }
public VocabularyKey WorksFromHome { get; private set; }


    }
}