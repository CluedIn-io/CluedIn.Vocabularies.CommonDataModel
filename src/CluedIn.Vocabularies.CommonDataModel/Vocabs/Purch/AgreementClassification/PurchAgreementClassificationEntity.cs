using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchAgreementClassificationEntityVocabulary : SimpleVocabulary
    {
        public PurchAgreementClassificationEntityVocabulary()
        {
            VocabularyName = "Common Data Model PurchAgreementClassificationEntity";
            KeyPrefix = "commonDataModel.purchagreementclassificationentity";
            KeySeparator = ".";
            Grouping = "/PurchAgreementClassificationEntity";

            AddGroup("Common Data Model PurchAgreementClassificationEntity Details", group =>
            {
                ArePurchaseAgreementActitivitesEnabled = group.Add(new VocabularyKey(nameof(ArePurchaseAgreementActitivitesEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ArePurchaseAgreementCertificationsEnabled = group.Add(new VocabularyKey(nameof(ArePurchaseAgreementCertificationsEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClassificationDescription = group.Add(new VocabularyKey(nameof(ClassificationDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDirectInvoicingRequired = group.Add(new VocabularyKey(nameof(IsDirectInvoicingRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClassificationName = group.Add(new VocabularyKey(nameof(ClassificationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ArePurchaseAgreementSubcontractorsEnabled = group.Add(new VocabularyKey(nameof(ArePurchaseAgreementSubcontractorsEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryResponsibleWorkerName = group.Add(new VocabularyKey(nameof(PrimaryResponsibleWorkerName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecondaryResponsibleWorkerName = group.Add(new VocabularyKey(nameof(SecondaryResponsibleWorkerName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryResponsibleWorkerRecId = group.Add(new VocabularyKey(nameof(PrimaryResponsibleWorkerRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecondaryResponsibleWorkerRecId = group.Add(new VocabularyKey(nameof(SecondaryResponsibleWorkerRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MatchingPolicy = group.Add(new VocabularyKey(nameof(MatchingPolicy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ArePurchaseAgreementActitivitesEnabled { get; private set; }
        public VocabularyKey ArePurchaseAgreementCertificationsEnabled { get; private set; }
        public VocabularyKey ClassificationDescription { get; private set; }
        public VocabularyKey IsDirectInvoicingRequired { get; private set; }
        public VocabularyKey ClassificationName { get; private set; }
        public VocabularyKey ArePurchaseAgreementSubcontractorsEnabled { get; private set; }
        public VocabularyKey PrimaryResponsibleWorkerName { get; private set; }
        public VocabularyKey SecondaryResponsibleWorkerName { get; private set; }
        public VocabularyKey PrimaryResponsibleWorkerRecId { get; private set; }
        public VocabularyKey SecondaryResponsibleWorkerRecId { get; private set; }
        public VocabularyKey MatchingPolicy { get; private set; }


    }
}