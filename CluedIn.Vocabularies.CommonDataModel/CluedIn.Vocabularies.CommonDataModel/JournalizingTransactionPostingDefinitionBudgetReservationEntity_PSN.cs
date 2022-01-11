using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JournalizingTransactionPostingDefinitionBudgetReservationEntity_PSNVocabulary : SimpleVocabulary
    {
        public JournalizingTransactionPostingDefinitionBudgetReservationEntity_PSNVocabulary()
        {
            VocabularyName = "Common Data Model JournalizingTransactionPostingDefinitionBudgetReservationEntity_PSN";
            KeyPrefix = "commonDataModel.journalizingtransactionpostingdefinitionbudgetreservationentity_psn";
            KeySeparator = ".";
            Grouping = "/JournalizingTransactionPostingDefinitionBudgetReservationEntity_PSN";

            AddGroup("Common Data Model JournalizingTransactionPostingDefinitionBudgetReservationEntity_PSN Details", group =>
            {
                BudgetReservationJournalizingType = group.Add(new VocabularyKey(nameof(BudgetReservationJournalizingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetReservationTypeCode = group.Add(new VocabularyKey(nameof(BudgetReservationTypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetReservationType = group.Add(new VocabularyKey(nameof(BudgetReservationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PostingDefinitionRecId = group.Add(new VocabularyKey(nameof(PostingDefinitionRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PostingDefinition = group.Add(new VocabularyKey(nameof(PostingDefinition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetReservationTypeName = group.Add(new VocabularyKey(nameof(BudgetReservationTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey BudgetReservationJournalizingType { get; private set; }
public VocabularyKey BudgetReservationTypeCode { get; private set; }
public VocabularyKey BudgetReservationType { get; private set; }
public VocabularyKey PostingDefinitionRecId { get; private set; }
public VocabularyKey PostingDefinition { get; private set; }
public VocabularyKey BudgetReservationTypeName { get; private set; }


    }
}