using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchPurchaseRequisitionExpenditureReviewerConfigurationEntityVocabulary : SimpleVocabulary
    {
        public PurchPurchaseRequisitionExpenditureReviewerConfigurationEntityVocabulary()
        {
            VocabularyName = "Common Data Model PurchPurchaseRequisitionExpenditureReviewerConfigurationEntity";
            KeyPrefix = "commonDataModel.purchpurchaserequisitionexpenditurereviewerconfigurationentity";
            KeySeparator = ".";
            Grouping = "/PurchPurchaseRequisitionExpenditureReviewerConfigurationEntity";

            AddGroup("Common Data Model PurchPurchaseRequisitionExpenditureReviewerConfigurationEntity Details", group =>
            {
                ConfigurationName = group.Add(new VocabularyKey(nameof(ConfigurationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExpenditureDocumentType = group.Add(new VocabularyKey(nameof(ExpenditureDocumentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ConfigurationName { get; private set; }
public VocabularyKey ExpenditureDocumentType { get; private set; }


    }
}