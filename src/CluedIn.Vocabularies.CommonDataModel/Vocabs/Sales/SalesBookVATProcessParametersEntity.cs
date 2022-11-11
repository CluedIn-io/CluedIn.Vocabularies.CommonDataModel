using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesBookVATProcessParametersEntityVocabulary : SimpleVocabulary
    {
        public SalesBookVATProcessParametersEntityVocabulary()
        {
            VocabularyName = "Common Data Model SalesBookVATProcessParametersEntity";
            KeyPrefix = "commonDataModel.salesbookvatprocessparametersentity";
            KeySeparator = ".";
            Grouping = "/SalesBookVATProcessParametersEntity";

            AddGroup("Common Data Model SalesBookVATProcessParametersEntity Details", group =>
            {
                Dimension = group.Add(new VocabularyKey(nameof(Dimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimensionEnabled = group.Add(new VocabularyKey(nameof(DefaultDimensionEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IncludeInBook = group.Add(new VocabularyKey(nameof(IncludeInBook), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDefault = group.Add(new VocabularyKey(nameof(IsDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VATOperationCode = group.Add(new VocabularyKey(nameof(VATOperationCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationType = group.Add(new VocabularyKey(nameof(OperationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RestorationType = group.Add(new VocabularyKey(nameof(RestorationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FactureOperationTypeCode = group.Add(new VocabularyKey(nameof(FactureOperationTypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Dimension { get; private set; }
        public VocabularyKey DefaultDimensionEnabled { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey IncludeInBook { get; private set; }
        public VocabularyKey IsDefault { get; private set; }
        public VocabularyKey VATOperationCode { get; private set; }
        public VocabularyKey OperationType { get; private set; }
        public VocabularyKey RestorationType { get; private set; }
        public VocabularyKey FactureOperationTypeCode { get; private set; }


    }
}