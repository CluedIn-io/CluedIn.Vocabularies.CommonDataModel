using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TrvRequisitionTableEntityVocabulary : SimpleVocabulary
    {
        public TrvRequisitionTableEntityVocabulary()
        {
            VocabularyName = "Common Data Model TrvRequisitionTableEntity";
            KeyPrefix = "commonDataModel.trvrequisitiontableentity";
            KeySeparator = ".";
            Grouping = "/TrvRequisitionTableEntity";

            AddGroup("Common Data Model TrvRequisitionTableEntity Details", group =>
            {
                ApprovalStatus = group.Add(new VocabularyKey(nameof(ApprovalStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Employee = group.Add(new VocabularyKey(nameof(Employee), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Dimension = group.Add(new VocabularyKey(nameof(Dimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TravelDescription = group.Add(new VocabularyKey(nameof(TravelDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Destination = group.Add(new VocabularyKey(nameof(Destination), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LegalEntity = group.Add(new VocabularyKey(nameof(LegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReconciliationStatus = group.Add(new VocabularyKey(nameof(ReconciliationStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Date = group.Add(new VocabularyKey(nameof(Date), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TravelRequisitionNumber = group.Add(new VocabularyKey(nameof(TravelRequisitionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SourceDocumentHeader = group.Add(new VocabularyKey(nameof(SourceDocumentHeader), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SourceDocumentLine = group.Add(new VocabularyKey(nameof(SourceDocumentLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BusinessPurpose = group.Add(new VocabularyKey(nameof(BusinessPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkerPersonnelNumber = group.Add(new VocabularyKey(nameof(WorkerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DimensionDisplayValue = group.Add(new VocabularyKey(nameof(DimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ApprovalStatus { get; private set; }
public VocabularyKey Employee { get; private set; }
public VocabularyKey Dimension { get; private set; }
public VocabularyKey TravelDescription { get; private set; }
public VocabularyKey Destination { get; private set; }
public VocabularyKey LegalEntity { get; private set; }
public VocabularyKey ReconciliationStatus { get; private set; }
public VocabularyKey Company { get; private set; }
public VocabularyKey Date { get; private set; }
public VocabularyKey TravelRequisitionNumber { get; private set; }
public VocabularyKey SourceDocumentHeader { get; private set; }
public VocabularyKey SourceDocumentLine { get; private set; }
public VocabularyKey BusinessPurpose { get; private set; }
public VocabularyKey WorkerPersonnelNumber { get; private set; }
public VocabularyKey DimensionDisplayValue { get; private set; }


    }
}