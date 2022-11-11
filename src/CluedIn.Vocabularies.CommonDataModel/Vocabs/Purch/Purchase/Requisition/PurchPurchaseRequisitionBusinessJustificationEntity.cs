using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchPurchaseRequisitionBusinessJustificationEntityVocabulary : SimpleVocabulary
    {
        public PurchPurchaseRequisitionBusinessJustificationEntityVocabulary()
        {
            VocabularyName = "PurchPurchaseRequisitionBusinessJustificationEntity";
            KeyPrefix = "commonDataModel.purchpurchaserequisitionbusinessjustificationentity";
            KeySeparator = ".";
            Grouping = "/PurchPurchaseRequisitionBusinessJustificationEntity";

            AddGroup("PurchPurchaseRequisitionBusinessJustificationEntity Details", group =>
            {
                PurchaseRequisitionBusinessJustificationCode = group.Add(new VocabularyKey(nameof(PurchaseRequisitionBusinessJustificationCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JustificationDescription = group.Add(new VocabularyKey(nameof(JustificationDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PurchaseRequisitionBusinessJustificationCode { get; private set; }
        public VocabularyKey JustificationDescription { get; private set; }


    }
}