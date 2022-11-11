using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchPurchaseRequisitionMaintainDelegationEntityVocabulary : SimpleVocabulary
    {
        public PurchPurchaseRequisitionMaintainDelegationEntityVocabulary()
        {
            VocabularyName = "PurchPurchaseRequisitionMaintainDelegationEntity";
            KeyPrefix = "commonDataModel.purchpurchaserequisitionmaintaindelegationentity";
            KeySeparator = ".";
            Grouping = "/PurchPurchaseRequisitionMaintainDelegationEntity";

            AddGroup("PurchPurchaseRequisitionMaintainDelegationEntity Details", group =>
            {
                Originator = group.Add(new VocabularyKey(nameof(Originator), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Requisitioner = group.Add(new VocabularyKey(nameof(Requisitioner), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PreparerPersonnelNumber = group.Add(new VocabularyKey(nameof(PreparerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequisitionerPersonnelNumber = group.Add(new VocabularyKey(nameof(RequisitionerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AuthorizationLevel = group.Add(new VocabularyKey(nameof(AuthorizationLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HasAdministratorGrantedPermission = group.Add(new VocabularyKey(nameof(HasAdministratorGrantedPermission), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Originator { get; private set; }
        public VocabularyKey Requisitioner { get; private set; }
        public VocabularyKey PreparerPersonnelNumber { get; private set; }
        public VocabularyKey RequisitionerPersonnelNumber { get; private set; }
        public VocabularyKey AuthorizationLevel { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey HasAdministratorGrantedPermission { get; private set; }


    }
}