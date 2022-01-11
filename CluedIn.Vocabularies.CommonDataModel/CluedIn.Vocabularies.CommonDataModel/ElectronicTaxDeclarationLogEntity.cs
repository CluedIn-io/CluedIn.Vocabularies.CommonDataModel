using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ElectronicTaxDeclarationLogEntityVocabulary : SimpleVocabulary
    {
        public ElectronicTaxDeclarationLogEntityVocabulary()
        {
            VocabularyName = "Common Data Model ElectronicTaxDeclarationLogEntity";
            KeyPrefix = "commonDataModel.electronictaxdeclarationlogentity";
            KeySeparator = ".";
            Grouping = "/ElectronicTaxDeclarationLogEntity";

            AddGroup("Common Data Model ElectronicTaxDeclarationLogEntity Details", group =>
            {
                CorrectedDeclaration = group.Add(new VocabularyKey(nameof(CorrectedDeclaration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExecutionDate = group.Add(new VocabularyKey(nameof(ExecutionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocumentsSubmittedSeparately = group.Add(new VocabularyKey(nameof(DocumentsSubmittedSeparately), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Date = group.Add(new VocabularyKey(nameof(Date), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Inactive = group.Add(new VocabularyKey(nameof(Inactive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Sent = group.Add(new VocabularyKey(nameof(Sent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ElectronicTaxDocument = group.Add(new VocabularyKey(nameof(ElectronicTaxDocument), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SettlementPeriod = group.Add(new VocabularyKey(nameof(SettlementPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PeriodValue = group.Add(new VocabularyKey(nameof(PeriodValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PeriodYear = group.Add(new VocabularyKey(nameof(PeriodYear), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CorrectedDeclaration { get; private set; }
public VocabularyKey ExecutionDate { get; private set; }
public VocabularyKey DocumentsSubmittedSeparately { get; private set; }
public VocabularyKey Date { get; private set; }
public VocabularyKey Inactive { get; private set; }
public VocabularyKey Sent { get; private set; }
public VocabularyKey ElectronicTaxDocument { get; private set; }
public VocabularyKey SettlementPeriod { get; private set; }
public VocabularyKey PeriodValue { get; private set; }
public VocabularyKey PeriodYear { get; private set; }
public VocabularyKey Company { get; private set; }


    }
}