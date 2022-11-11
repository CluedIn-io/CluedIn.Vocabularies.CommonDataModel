using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PlSADDocumentPurchaseOrderEntityVocabulary : SimpleVocabulary
    {
        public PlSADDocumentPurchaseOrderEntityVocabulary()
        {
            VocabularyName = "Common Data Model PlSADDocumentPurchaseOrderEntity";
            KeyPrefix = "commonDataModel.plsaddocumentpurchaseorderentity";
            KeySeparator = ".";
            Grouping = "/PlSADDocumentPurchaseOrderEntity";

            AddGroup("Common Data Model PlSADDocumentPurchaseOrderEntity Details", group =>
            {
                Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Dimension = group.Add(new VocabularyKey(nameof(Dimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SADDate = group.Add(new VocabularyKey(nameof(SADDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DutyGovernment = group.Add(new VocabularyKey(nameof(DutyGovernment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MiscPayments = group.Add(new VocabularyKey(nameof(MiscPayments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SAD = group.Add(new VocabularyKey(nameof(SAD), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentCode = group.Add(new VocabularyKey(nameof(DocumentCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Transport = group.Add(new VocabularyKey(nameof(Transport), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Date = group.Add(new VocabularyKey(nameof(Date), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateOfVATRegister = group.Add(new VocabularyKey(nameof(DateOfVATRegister), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionDisplayValue = group.Add(new VocabularyKey(nameof(DimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Posted = group.Add(new VocabularyKey(nameof(Posted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Currency { get; private set; }
        public VocabularyKey Dimension { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey SADDate { get; private set; }
        public VocabularyKey DutyGovernment { get; private set; }
        public VocabularyKey MiscPayments { get; private set; }
        public VocabularyKey SAD { get; private set; }
        public VocabularyKey DocumentCode { get; private set; }
        public VocabularyKey Transport { get; private set; }
        public VocabularyKey Date { get; private set; }
        public VocabularyKey DateOfVATRegister { get; private set; }
        public VocabularyKey DimensionDisplayValue { get; private set; }
        public VocabularyKey Posted { get; private set; }


    }
}