using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjCDSContractLineImportEntityVocabulary : SimpleVocabulary
    {
        public ProjCDSContractLineImportEntityVocabulary()
        {
            VocabularyName = "Proj CDS Contract Line Import Entity";
            KeyPrefix = "commonDataModel.projcdscontractlineimportentity";
            KeySeparator = ".";
            Grouping = "/ProjCDSContractLineImportEntity";

            AddGroup("ProjCDSContractLineImportEntity Details", group =>
            {
                TransactionId = group.Add(new VocabularyKey(nameof(TransactionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContractId = group.Add(new VocabularyKey(nameof(ContractId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContractLine = group.Add(new VocabularyKey(nameof(ContractLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForecastInvoiceFrequency = group.Add(new VocabularyKey(nameof(ForecastInvoiceFrequency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey TransactionId { get; private set; }
        public VocabularyKey ContractId { get; private set; }
        public VocabularyKey ContractLine { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ProjectId { get; private set; }
        public VocabularyKey ForecastInvoiceFrequency { get; private set; }
    }
}