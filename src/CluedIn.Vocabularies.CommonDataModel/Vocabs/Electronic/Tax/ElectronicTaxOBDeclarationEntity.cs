using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ElectronicTaxOBDeclarationEntityVocabulary : SimpleVocabulary
    {
        public ElectronicTaxOBDeclarationEntityVocabulary()
        {
            VocabularyName = "ElectronicTaxOBDeclarationEntity";
            KeyPrefix = "commonDataModel.electronictaxobdeclarationentity";
            KeySeparator = ".";
            Grouping = "/ElectronicTaxOBDeclarationEntity";

            AddGroup("ElectronicTaxOBDeclarationEntity Details", group =>
            {
                ID = group.Add(new VocabularyKey(nameof(ID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndDate = group.Add(new VocabularyKey(nameof(EndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MessageID = group.Add(new VocabularyKey(nameof(MessageID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestId = group.Add(new VocabularyKey(nameof(RequestId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxExemptNumber = group.Add(new VocabularyKey(nameof(TaxExemptNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalGroup = group.Add(new VocabularyKey(nameof(FiscalGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactID = group.Add(new VocabularyKey(nameof(ContactID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactName = group.Add(new VocabularyKey(nameof(ContactName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactInitials = group.Add(new VocabularyKey(nameof(ContactInitials), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactPhone = group.Add(new VocabularyKey(nameof(ContactPhone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactType = group.Add(new VocabularyKey(nameof(ContactType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxTurnOverTable_NL = group.Add(new VocabularyKey(nameof(TaxTurnOverTable_NL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineAmount = group.Add(new VocabularyKey(nameof(LineAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxReportCollection = group.Add(new VocabularyKey(nameof(TaxReportCollection), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CollectionName = group.Add(new VocabularyKey(nameof(CollectionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CollectionDescription = group.Add(new VocabularyKey(nameof(CollectionDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CollectionTaxReportField = group.Add(new VocabularyKey(nameof(CollectionTaxReportField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CollectionTaxReportLayout = group.Add(new VocabularyKey(nameof(CollectionTaxReportLayout), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ID { get; private set; }
        public VocabularyKey Company { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey Currency { get; private set; }
        public VocabularyKey MessageID { get; private set; }
        public VocabularyKey RequestId { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey TaxExemptNumber { get; private set; }
        public VocabularyKey FiscalGroup { get; private set; }
        public VocabularyKey ContactID { get; private set; }
        public VocabularyKey ContactName { get; private set; }
        public VocabularyKey ContactInitials { get; private set; }
        public VocabularyKey ContactPhone { get; private set; }
        public VocabularyKey ContactType { get; private set; }
        public VocabularyKey TaxTurnOverTable_NL { get; private set; }
        public VocabularyKey LineAmount { get; private set; }
        public VocabularyKey TaxReportCollection { get; private set; }
        public VocabularyKey CollectionName { get; private set; }
        public VocabularyKey CollectionDescription { get; private set; }
        public VocabularyKey CollectionTaxReportField { get; private set; }
        public VocabularyKey CollectionTaxReportLayout { get; private set; }


    }
}