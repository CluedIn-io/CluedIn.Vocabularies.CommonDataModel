using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchCommitmentLineEntityVocabulary : SimpleVocabulary
    {
        public PurchCommitmentLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model PurchCommitmentLineEntity";
            KeyPrefix = "commonDataModel.purchcommitmentlineentity";
            KeySeparator = ".";
            Grouping = "/PurchCommitmentLineEntity";

            AddGroup("Common Data Model PurchCommitmentLineEntity Details", group =>
            {
                AgreementLine = group.Add(new VocabularyKey(nameof(AgreementLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Comment = group.Add(new VocabularyKey(nameof(Comment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LedgerDimension = group.Add(new VocabularyKey(nameof(LedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineAmount = group.Add(new VocabularyKey(nameof(LineAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineDate = group.Add(new VocabularyKey(nameof(LineDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OriginalAmount = group.Add(new VocabularyKey(nameof(OriginalAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PurchCommitmentHeader_PSN = group.Add(new VocabularyKey(nameof(PurchCommitmentHeader_PSN), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CommitmentNumber = group.Add(new VocabularyKey(nameof(CommitmentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultDate = group.Add(new VocabularyKey(nameof(DefaultDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalYear = group.Add(new VocabularyKey(nameof(FiscalYear), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Preparer = group.Add(new VocabularyKey(nameof(Preparer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CommitmentName = group.Add(new VocabularyKey(nameof(CommitmentName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReasonComment = group.Add(new VocabularyKey(nameof(ReasonComment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VendorAccount = group.Add(new VocabularyKey(nameof(VendorAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalCalendarYear_FiscalCalendar = group.Add(new VocabularyKey(nameof(FiscalCalendarYear_FiscalCalendar), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalCalendarYear_Name = group.Add(new VocabularyKey(nameof(FiscalCalendarYear_Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalCalendar_CalendarId = group.Add(new VocabularyKey(nameof(FiscalCalendar_CalendarId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(LedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AgreementLineNumber = group.Add(new VocabularyKey(nameof(AgreementLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AgreementNumber = group.Add(new VocabularyKey(nameof(AgreementNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AgreementLine { get; private set; }
public VocabularyKey Comment { get; private set; }
public VocabularyKey LedgerDimension { get; private set; }
public VocabularyKey LineAmount { get; private set; }
public VocabularyKey LineDate { get; private set; }
public VocabularyKey LineNumber { get; private set; }
public VocabularyKey OriginalAmount { get; private set; }
public VocabularyKey PurchCommitmentHeader_PSN { get; private set; }
public VocabularyKey CommitmentNumber { get; private set; }
public VocabularyKey Currency { get; private set; }
public VocabularyKey DefaultDate { get; private set; }
public VocabularyKey FiscalYear { get; private set; }
public VocabularyKey Preparer { get; private set; }
public VocabularyKey CommitmentName { get; private set; }
public VocabularyKey ReasonComment { get; private set; }
public VocabularyKey VendorAccount { get; private set; }
public VocabularyKey FiscalCalendarYear_FiscalCalendar { get; private set; }
public VocabularyKey FiscalCalendarYear_Name { get; private set; }
public VocabularyKey FiscalCalendar_CalendarId { get; private set; }
public VocabularyKey PersonnelNumber { get; private set; }
public VocabularyKey LedgerDimensionDisplayValue { get; private set; }
public VocabularyKey AgreementLineNumber { get; private set; }
public VocabularyKey AgreementNumber { get; private set; }


    }
}